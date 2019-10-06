using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarksManagerForm : Form
    {
        public BookmarksManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarksManager_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();

            foreach (var item in items)
            {
                BookmarksListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                MessageBox.Show(item.ToString());
            }
            MessageBox.Show("hello");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var chosen = BookmarksListBox.SelectedIndex;
            BookmarksListBox.Items.RemoveAt(chosen);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            BookmarksListBox.SelectedItems.Clear();
            for (int i = BookmarksListBox.Items.Count - 1; i >= 0; i-- )
            {
                if (BookmarksListBox.Items[i].ToString().Contains(BookmarkSearchTextBox.Text))
                {
                    BookmarksListBox.SetSelected(i,true);
                }
            }
            int index = BookmarksListBox.FindString(BookmarksListBox.Text);
            if (index < 0)
            {
                MessageBox.Show("Item not found.");
                BookmarkSearchTextBox.Text = String.Empty;
            }
            else
            {
                BookmarksListBox.SelectedIndex = index;
                StatusLabel.Text = BookmarksListBox.SelectedItems.Count.ToString() + " items found";
            }
        }

        private void BookmarkSearchTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BookmarksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
