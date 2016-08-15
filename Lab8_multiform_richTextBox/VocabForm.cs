using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_multiform_richTextBox
{
    public partial class VocabForm : Form
    {
        MainForm mainForm;

        public VocabForm(MainForm m)
        {
            InitializeComponent();
            mainForm = m;

            rebuildForm(this, null);
            mainForm.selectedWords_label.Text = "";
            refresh_button.Click += new EventHandler(rebuildForm);
        }

        public void rebuildForm(object sender, EventArgs e) {
            string[] words = mainForm.vocab.getString().Split(new Char [] {' '});
            string s = "";

            vocab_checkList.Items.Clear();

            foreach (string word in words) {
                s += word + " ";
                vocab_checkList.Items.Add(word, false);
            }

            vocab_text.Text = s;
            mainForm.selectedWords_label.Text = "";

            // Clear formating..
            s = mainForm.text.Text;
            mainForm.text.Clear();
            mainForm.text.Text = s;
        }

        private void vocab_checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.selectedWords_label.Text = "";
            foreach (object item in vocab_checkList.CheckedItems) {
                mainForm.selectedWords_label.Text += item.ToString() + " ";
            }
        }

        private void colorize_button_Click(object sender, EventArgs e)
        {
            // Clear formating..
            string s = mainForm.text.Text;
            mainForm.text.Clear();
            mainForm.text.Text = s;

            foreach (object item in vocab_checkList.CheckedItems) {
                int start = 0;
                int cur = 0;
                cur = mainForm.text.Find(item.ToString(), start, RichTextBoxFinds.MatchCase);
                while (cur >= 0 && start < mainForm.text.TextLength) {
                    mainForm.text.Select(cur, item.ToString().Length);
                    mainForm.text.SelectionColor = Color.Red;
                    start = cur + item.ToString().Length;
                    cur = mainForm.text.Find(item.ToString(), start, RichTextBoxFinds.None);
                }
            }

        }


    }
}
