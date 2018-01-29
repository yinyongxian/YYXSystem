using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace YYXSystem.Tools
{
    public partial class CleanFolderForm : Form
    {
        public CleanFolderForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var currentDirectory = Environment.CurrentDirectory;
            var parentDirectory = Directory.GetParent(currentDirectory);
            textBoxPath.Text = parentDirectory.FullName;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            buttonClean.Enabled = false;
            toolStripStatusLabel.Text = @"清理中...";

            ThreadPool.QueueUserWorkItem(state =>
            {
                var path = textBoxPath.Text;
                if (!Directory.Exists(path))
                {
                    BeginInvoke((EventHandler)delegate
                    {
                        toolStripStatusLabel.Text = @"文件夹不存在...";
                    });
                    return;
                }

                var parentDirectory = new DirectoryInfo(path);
                var directoryInfos = parentDirectory.GetDirectories("*", SearchOption.AllDirectories);

                var deleteDirectoryNames = new List<string>();
                Invoke((EventHandler)delegate
                {
                    var directoryNames = richTextBox.Text.Split(',').ToList();
                    deleteDirectoryNames.AddRange(directoryNames);
                });

                var deleteDirectoryInfos = directoryInfos.Where(item => deleteDirectoryNames.Contains(item.Name)).ToList();
                try
                {
                    deleteDirectoryInfos.ForEach(item => item.Delete(true));
                }
                catch (IOException ex)
                {
                    BeginInvoke((EventHandler)delegate
                    {
                        toolStripStatusLabel.Text = ex.Message;
                    });
                    return;
                }
                finally
                {
                    BeginInvoke((EventHandler)delegate
                    {
                        buttonClean.Enabled = true;
                    });
                }

                BeginInvoke((EventHandler)delegate
                {
                    buttonClean.Enabled = true;
                    toolStripStatusLabel.Text = @"清理完成...";
                });
            });
        }
    }
}
