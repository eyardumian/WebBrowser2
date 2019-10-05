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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }
        private void HistoryManager_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();

            foreach (var item in items)
            {
                HistoryListBox.Items.Add(string.Format("{0} ({1}) [{2}]", item.Title, item.URL, item.Date));
                //MessageBox.Show(item.ToString());

            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HistoryListBox.Items.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var chosen = HistoryListBox.SelectedIndex;
            HistoryListBox.Items.RemoveAt(chosen);
        }
    }
}
