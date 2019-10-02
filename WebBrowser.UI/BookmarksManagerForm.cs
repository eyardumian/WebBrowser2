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
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var chosen = BookmarksListBox.SelectedIndex;
            BookmarksListBox.Items.RemoveAt(chosen);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          
            var searchTerm = BookmarkSearchTextBox.Text;
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                if (item.Equals(searchTerm))
                {
                    BookmarksListBox.Items.Add(item);
                }
            }
        }
    }
}
