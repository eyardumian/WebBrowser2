using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class WebBrowserControl : UserControl
    {
        public WebBrowserControl()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void DisplayLabel(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Done";
            toolStripProgressBar1.Value = 0;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
                toolStripStatusLabel1.Text = "Loading";
                for (int i = 0; i <= 100; i++)
                {
                    toolStripProgressBar1.Value = i;
                }
            
            Navigate(toolStripTextBox1.Text.ToString());

            var item = new HistoryItem();
            item.URL = toolStripTextBox1.Text;
            item.Title = webBrowser1.DocumentTitle;
            item.Date = DateTime.Now;

            HistoryManager.AddItem(item);

            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DisplayLabel);
                
            
        }
        

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                toolStripStatusLabel1.Text = "Loading";
                for (int i = 0; i <= 100; i++)
                {
                    toolStripProgressBar1.Value = i;
                }

                Navigate(toolStripTextBox1.Text.ToString());

                var item = new HistoryItem();
                item.URL = toolStripTextBox1.Text;
                item.Title = webBrowser1.DocumentTitle;
                item.Date = DateTime.Now;

                HistoryManager.AddItem(item);

                webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DisplayLabel);
            }
        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch(System.UriFormatException)
            {
                return;
            }
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erika Yardumian" + "\r\n" + "ezy0013@auburn.edu");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Navigate("www.google.com");
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyItemsForm = new HistoryManagerForm();
            historyItemsForm.ShowDialog();
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            var newItem = new BookmarkItem();
            newItem.URL = toolStripTextBox1.Text;
            newItem.Title = webBrowser1.DocumentTitle;

            BookmarkManager.AddItem(newItem);
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkItemsForm = new BookmarksManagerForm();
            bookmarkItemsForm.ShowDialog();
        }

        //Allow user to add and delete tabs using keyboard shorcuts.
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.T))
            {
                //var tabContent = new ();
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
