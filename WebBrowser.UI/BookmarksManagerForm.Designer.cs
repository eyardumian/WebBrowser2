namespace WebBrowser.UI
{
    partial class BookmarksManagerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookmarksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BookmarksListBox
            // 
            this.BookmarksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookmarksListBox.FormattingEnabled = true;
            this.BookmarksListBox.Location = new System.Drawing.Point(0, 0);
            this.BookmarksListBox.Name = "BookmarksListBox";
            this.BookmarksListBox.Size = new System.Drawing.Size(800, 450);
            this.BookmarksListBox.TabIndex = 0;
            // 
            // BookmarksManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookmarksListBox);
            this.Name = "BookmarksManager";
            this.Text = "BookmarksManager";
            this.Load += new System.EventHandler(this.BookmarksManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox BookmarksListBox;
    }
}