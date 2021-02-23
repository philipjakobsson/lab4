using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordDictionaryLibrary;

namespace WordDisctionary_Lab4
{
    public partial class AddNewWordToList : Form
    {
        public WordsDictionary Parent;
        public AddNewWordToList(WordsDictionary parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void AddNewWordToList_Load(object sender, EventArgs e)
        {
            string selection = Parent.SelectedList;

            dataGridView.TopLeftHeaderCell.Value = "LANGUAGE";
            dataGridView.Columns.Add("WORD", "WORD");

            int gridHeight = 0;
            foreach (var language in Parent.GetLanguages(selection))
            {
                var newRow = new DataGridViewRow();
                newRow.HeaderCell.Value = language.ToUpper();
                dataGridView.Rows.Add(newRow);
                gridHeight += newRow.Height;
            }
            this.Height = gridHeight + 100 + dataGridView.ColumnHeadersHeight;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> Words = new List<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0)
                    {
                        if (!string.IsNullOrEmpty((string)cell.Value))
                        {
                            cell.Value = cell.Value.ToString().Trim();

                            if (string.IsNullOrEmpty((string)cell.Value))
                            {
                                MessageBox.Show(this, "Value Cannot be empty", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Value Cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Words.Add(cell.Value.ToString().ToLower());
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            WordList wordList = WordList.LoadList(Parent.SelectedList);
            wordList.Add(Words.ToArray());
            wordList.Save();
        }
    }
}
