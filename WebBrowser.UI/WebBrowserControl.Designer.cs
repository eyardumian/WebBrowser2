namespace WebBrowser.UI
{
    partial class WebBrowserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WebBrowserControl
            // 
            this.Name = "WebBrowserControl";
            this.Size = new System.Drawing.Size(913, 513);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem closeCurentTabToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.ToolStripButton toolStripButton4;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripButton toolStripButton5;
        public System.Windows.Forms.ToolStripButton bookmarkButton;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}
