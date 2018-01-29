namespace YYXSystem.Tools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonClean = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemCleanFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonClean});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonClean
            // 
            this.toolStripDropDownButtonClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonClean.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCleanFolder});
            this.toolStripDropDownButtonClean.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonClean.Image")));
            this.toolStripDropDownButtonClean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonClean.Name = "toolStripDropDownButtonClean";
            this.toolStripDropDownButtonClean.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonClean.Text = "清理";
            // 
            // ToolStripMenuItemCleanFolder
            // 
            this.ToolStripMenuItemCleanFolder.Name = "ToolStripMenuItemCleanFolder";
            this.ToolStripMenuItemCleanFolder.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCleanFolder.Text = "清理文件夹";
            this.ToolStripMenuItemCleanFolder.Click += new System.EventHandler(this.ToolStripMenuItemCleanFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YYX工具";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonClean;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCleanFolder;
    }
}

