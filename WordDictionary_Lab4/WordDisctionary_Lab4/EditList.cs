using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordDictionaryLibrary;

namespace WordDisctionary_Lab4
{
    public partial class EditList : Form
    {
        public string SelectedList { get { return listBox.GetItemText(listBox.SelectedItem); } }
        public EditList()
        {
            InitializeComponent();
        }

        private void EditList_Load(object sender, EventArgs e)
        {
            LoadLists();
        }
        private void LoadLists()
        {
            if (listBox.Items.Count > 0)
                listBox.Items.Clear();
            var listOfFiles = WordList.GetLists();
            foreach (var list in listOfFiles)
            {
                listBox.Items.Add(list);
            }
        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Delete this List?",
                "Delete list", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var file = listBox.GetItemText(listBox.SelectedItem);
                File.Delete(WordList.LocalAppDirectory + file+".dat");
                LoadLists();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
