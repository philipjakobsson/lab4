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
    public partial class AddNewList : Form
    {
        public AddNewList()
        {
            InitializeComponent();
           
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            tbListName.Text = tbListName.Text.Trim();

            if (!string.IsNullOrEmpty(tbListName.Text))
            {
                if (tbLanguages.Lines.Length > 1)
                {
                    if (!string.IsNullOrEmpty(tbLanguages.Lines[0]) &&
                        !string.IsNullOrEmpty(tbLanguages.Lines[1]))
                    {
                        string[] language = tbLanguages.Lines;

                        for (int i = 0; i < language.Length; i++)
                        {
                            language[i] = language[i].Trim();
                        }

                        new WordList(tbListName.Text, language).Save();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Enter at least two languages.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Enter at least two languages.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Enter a list name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
