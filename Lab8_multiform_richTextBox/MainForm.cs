using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Lab8_multiform_richTextBox
{
    public partial class MainForm : Form
    {
        public vocabList vocab = new vocabList();

        VocabForm vocabForm;

        public MainForm()
        {
            InitializeComponent();
        }

        // Изменяется основной текст
        private void text_TextChanged(object sender, EventArgs e)
        {
            symbolsCount_label.Text = text.TextLength.ToString();

            // update vocab
            vocab.update(text.Text);
            vocabLength_label.Text = vocab.getLength().ToString();
        }

        // Изменяется строка поиска
        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            searchStringSize_label.Text = search_textbox.TextLength.ToString();
        }

        // Поиск числа вхождений строки в текст
        private void search_button_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(search_textbox.Text);
            MatchCollection matches = rgx.Matches(text.Text);

            includesCount_label.Text = matches.Count.ToString();
        }

        // Открыть словарь
        private void openVocab_button_Click(object sender, EventArgs e)
        {
            vocabForm = new VocabForm(this);
            vocabForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFile_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                string s;
                text.Text = "";
                while (!sr.EndOfStream) {
                    s = sr.ReadLine();
                    text.Text += s + "\r\n";
                }
            }
        }


    }
}
