﻿namespace WebBrowser.UI
{
    partial class MainForm
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
            this.webBrowserControl1 = new WebBrowser.UI.WebBrowserControl();
            this.SuspendLayout();
            // 
            // webBrowserControl1
            // 
            this.webBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserControl1.Location = new System.Drawing.Point(0, 0);
            this.webBrowserControl1.Name = "webBrowserControl1";
            this.webBrowserControl1.Size = new System.Drawing.Size(800, 450);
            this.webBrowserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WebBrowserControl webBrowserControl1;
    }
}

