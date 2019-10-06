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

        //Update staus bar and add items to history table once website loads.
        private void DisplayLabel(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Done";
            toolStripProgressBar1.Value = 0;
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
             
                webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DisplayLabel);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
                toolStripStatusLabel1.Text = "Loading";
                for (int i = 0; i <= 100; i++)
                {
                    toolStripProgressBar1.Value = i;
                }

            var item = new HistoryItem();
            item.URL = toolStripTextBox1.Text;
            item.Title = webBrowser1.DocumentTitle;
            item.Date = DateTime.Now;

            HistoryManager.AddItem(item);

            Navigate(toolStripTextBox1.Text.ToString());       

            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DisplayLabel);                         
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

        //Add items to bookmarks datbase.
        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            var newItem = new BookmarkItem();
            newItem.URL = toolStripTextBox1.Text;
            newItem.Title = webBrowser1.DocumentTitle;

            BookmarkManager.AddItem(newItem);
        }

        //Display History.
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

        //Add a new tab.
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var page = new TabPage("New Tab");
            tabControl1.TabPages.Add(page);
        }

        //Remove a tab.
        private void closeCurentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(current_tab);
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Erika Yardumian" + "\r\n" + "ezy0013@auburn.edu");
        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Navigate("www.google.com");
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Loading";
            for (int i = 0; i <= 100; i++)
            {
                toolStripProgressBar1.Value = i;
            }

            var item = new HistoryItem();
            item.URL = toolStripTextBox2.Text;
            item.Title = webBrowser1.DocumentTitle;
            item.Date = DateTime.Now;

            HistoryManager.AddItem(item);

            Navigate(toolStripTextBox2.Text.ToString());

            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DisplayLabel);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            var newItem = new BookmarkItem();
            newItem.URL = toolStripTextBox2.Text;
            newItem.Title = webBrowser1.DocumentTitle;

            BookmarkManager.AddItem(newItem);
        }
    }
}
