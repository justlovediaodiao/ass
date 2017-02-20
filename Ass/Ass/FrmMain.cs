using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Ass
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            cboEncoding.SelectedIndex = 0;
        }

        #region 文件
        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbrSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    AddFiles(fileDialog.FileNames);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "提示");
            }
        }
        /// <summary>
        /// 添加目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbrSelectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == folderDialog.ShowDialog())
                {
                    AddFiles(Directory.GetFiles(folderDialog.SelectedPath, "*.ass"));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "提示");
            }
        }
        /// <summary>
        /// 清空文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbrClearFile_Click(object sender, EventArgs e)
        {
            try
            {
                lvwFiles.Items.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "提示");
            }
        }
        /// <summary>
        /// 添加一个文件
        /// </summary>
        /// <param name="files"></param>
        private void AddFiles(string[] files)
        {
            try
            {
                foreach (var file in files)
                {
                    if (!lvwFiles.Items.Cast<ListViewItem>().Any(item => item.Tag.ToString() == file))
                    {
                        var item = lvwFiles.Items.Add(new ListViewItem(new[] { Path.GetFileName(file), "就绪" }));
                        item.Tag = file;
                        item.Checked = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "提示");
            }
        }
        /// <summary>
        /// 移除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbrRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwFiles.SelectedItems.Count != 0)
                {
                    foreach (ListViewItem item in lvwFiles.SelectedItems)
                    {
                        lvwFiles.Items.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        #endregion

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbrStart_Click(object sender, EventArgs e)
        {
            try
            {
                int millisecond;
                var start = new TimeSpan();
                var end = new TimeSpan();
                if (lvwFiles.CheckedItems.Count == 0)
                    return;
                if (txtTimeOffset.Text.Length == 0)
                {
                    MessageBox.Show("请输入时间轴调整毫秒数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!int.TryParse(txtTimeOffset.Text, out millisecond))
                {
                    MessageBox.Show("请输入整数毫秒数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (chkTimeArea.Checked)
                {
                    if (txtTimeArea.Text.Length == 0)
                    {
                        MessageBox.Show("请输入时间轴区间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!GetTimeArea(txtTimeArea.Text, out start, out end))
                    {
                        MessageBox.Show("时间轴区间输入不正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (DialogResult.Yes == MessageBox.Show("确认执行操作?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var encoding = GetEncoding(cboEncoding.SelectedItem.ToString());
                    foreach (ListViewItem item in lvwFiles.CheckedItems)
                    {
                        try
                        {
                            var ass = new AssSub(item.Tag.ToString(), encoding);
                            ass.Open();
                            ass.ControlTime(millisecond, (int)start.TotalMilliseconds, (int)end.TotalMilliseconds);
                            ass.Save();
                            item.SubItems[1].Text = "完成";
                        }
                        catch (Exception ex)
                        {
                            item.SubItems[1].Text = ex.Message;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "错误");
            }
        }
        /// <summary>
        /// 获取编码
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        private Encoding GetEncoding(string strName)
        {
            switch (strName)
            {
                case "Default":
                    return Encoding.Default;
                case "Unicode":
                    return Encoding.Unicode;
                case "UTF8":
                    return Encoding.UTF8;
                default:
                    return Encoding.Default;
            }
        }
        /// <summary>
        /// 获取时间区域
        /// </summary>
        /// <param name="strText"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private bool GetTimeArea(string strText, out TimeSpan start, out TimeSpan end)
        {
            start = new TimeSpan();
            end = new TimeSpan();
            var index = strText.IndexOf('~');
            if (index == -1)
                return GetTimeSpan(strText, out start);
            else
                return index != 0 && index != strText.Length - 1 && GetTimeSpan(strText.Substring(0, index), out start) && GetTimeSpan(strText.Substring(index + 1), out end);
        }
        /// <summary>
        /// 获取时间段
        /// </summary>
        /// <param name="strText"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        private bool GetTimeSpan(string strText, out TimeSpan time)
        {
            time = new TimeSpan();
            try
            {
                int hour = 0, minute = 0, second = 0, milliSecond = 0;

                var array = strText.Split(':');
                //时分
                if (array.Length > 3)
                {
                    return false;
                }
                else if (array.Length == 3)
                {
                    hour = int.Parse(array[0]);
                    minute = int.Parse(array[1]);
                }
                else if (array.Length == 2)
                {
                    minute = int.Parse(array[0]);
                }

                var seconds = array[array.Length - 1].Split('.');
                //毫秒
                if (seconds.Length > 2)
                    return false;
                else if (seconds.Length == 2)
                    milliSecond = int.Parse(seconds[1]);
                //秒
                second = int.Parse(seconds[0]);

                if (!(hour >= 0 && minute >= 0 && minute < 60 && second >= 0 && second < 60 && milliSecond >= 0 && milliSecond < 1000))
                    return false;
                time = new TimeSpan(0, hour, minute, second, milliSecond);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lvwFiles.Items)
                item.Checked = true;
        }
        /// <summary>
        /// 反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblReserve_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lvwFiles.Items)
                item.Checked = !item.Checked;
        }

        private void lvwFiles_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Link;
                else
                    e.Effect = DragDropEffects.None;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "提示");
            }
        }

        private void lvwFiles_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var strNames = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (strNames != null)
                {
                    foreach (var str in strNames)
                    {
                        if (Directory.Exists(str))
                            AddFiles(Directory.GetFiles(str,"*.ass"));
                        else if (Path.GetExtension(str).ToLower() == "*.ass" && File.Exists(str))
                            AddFiles(new[] { str });
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "提示");
            }
        }
    }
}
