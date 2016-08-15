namespace Lab8_multiform_richTextBox
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFile_button = new System.Windows.Forms.ToolStripButton();
            this.showTask_button = new System.Windows.Forms.ToolStripButton();
            this.exit_button = new System.Windows.Forms.ToolStripButton();
            this.text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.symbolsCount_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchStringSize_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vocabLength_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.includesCount_label = new System.Windows.Forms.Label();
            this.openVocab_button = new System.Windows.Forms.Button();
            this.selectedWords_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile_button,
            this.showTask_button,
            this.exit_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFile_button
            // 
            this.openFile_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFile_button.Image = ((System.Drawing.Image)(resources.GetObject("openFile_button.Image")));
            this.openFile_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFile_button.Name = "openFile_button";
            this.openFile_button.Size = new System.Drawing.Size(96, 22);
            this.openFile_button.Text = "Открыть файл..";
            this.openFile_button.Click += new System.EventHandler(this.openFile_button_Click);
            // 
            // showTask_button
            // 
            this.showTask_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showTask_button.Image = ((System.Drawing.Image)(resources.GetObject("showTask_button.Image")));
            this.showTask_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showTask_button.Name = "showTask_button";
            this.showTask_button.Size = new System.Drawing.Size(56, 22);
            this.showTask_button.Text = "Задание";
            // 
            // exit_button
            // 
            this.exit_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(46, 22);
            this.exit_button.Text = "Выйти";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(15, 55);
            this.text.Name = "text";
            this.text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.text.Size = new System.Drawing.Size(450, 371);
            this.text.TabIndex = 1;
            this.text.Text = "";
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(483, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество символов в тексте:";
            // 
            // symbolsCount_label
            // 
            this.symbolsCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolsCount_label.Location = new System.Drawing.Point(694, 55);
            this.symbolsCount_label.Name = "symbolsCount_label";
            this.symbolsCount_label.Size = new System.Drawing.Size(52, 23);
            this.symbolsCount_label.TabIndex = 4;
            this.symbolsCount_label.Text = "0";
            this.symbolsCount_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(483, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите строку для поиска:";
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textbox.Location = new System.Drawing.Point(486, 122);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(263, 22);
            this.search_textbox.TabIndex = 6;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(483, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Число символов в строке:";
            // 
            // searchStringSize_label
            // 
            this.searchStringSize_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchStringSize_label.Location = new System.Drawing.Point(697, 147);
            this.searchStringSize_label.Name = "searchStringSize_label";
            this.searchStringSize_label.Size = new System.Drawing.Size(49, 23);
            this.searchStringSize_label.TabIndex = 8;
            this.searchStringSize_label.Text = "0";
            this.searchStringSize_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_button.Location = new System.Drawing.Point(486, 171);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(263, 36);
            this.search_button.TabIndex = 9;
            this.search_button.Text = "Найти число вхождений";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(483, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Число слов в словаре:";
            // 
            // vocabLength_label
            // 
            this.vocabLength_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vocabLength_label.Location = new System.Drawing.Point(697, 270);
            this.vocabLength_label.Name = "vocabLength_label";
            this.vocabLength_label.Size = new System.Drawing.Size(52, 23);
            this.vocabLength_label.TabIndex = 11;
            this.vocabLength_label.Text = "0";
            this.vocabLength_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(485, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 2);
            this.label9.TabIndex = 12;
            this.label9.Text = "label9";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(485, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 2);
            this.label11.TabIndex = 14;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(483, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Число вхождений:";
            // 
            // includesCount_label
            // 
            this.includesCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.includesCount_label.Location = new System.Drawing.Point(700, 212);
            this.includesCount_label.Name = "includesCount_label";
            this.includesCount_label.Size = new System.Drawing.Size(49, 16);
            this.includesCount_label.TabIndex = 16;
            this.includesCount_label.Text = "0";
            this.includesCount_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openVocab_button
            // 
            this.openVocab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openVocab_button.Location = new System.Drawing.Point(485, 300);
            this.openVocab_button.Name = "openVocab_button";
            this.openVocab_button.Size = new System.Drawing.Size(263, 39);
            this.openVocab_button.TabIndex = 17;
            this.openVocab_button.Text = "Открыть словарь";
            this.openVocab_button.UseVisualStyleBackColor = true;
            this.openVocab_button.Click += new System.EventHandler(this.openVocab_button_Click);
            // 
            // selectedWords_label
            // 
            this.selectedWords_label.AutoSize = true;
            this.selectedWords_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedWords_label.Location = new System.Drawing.Point(483, 372);
            this.selectedWords_label.MaximumSize = new System.Drawing.Size(260, 0);
            this.selectedWords_label.Name = "selectedWords_label";
            this.selectedWords_label.Size = new System.Drawing.Size(0, 16);
            this.selectedWords_label.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(483, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Выбранные слова для поиска:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 444);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.selectedWords_label);
            this.Controls.Add(this.openVocab_button);
            this.Controls.Add(this.includesCount_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vocabLength_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.searchStringSize_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.symbolsCount_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Lab8 - Multiform & richTextBox";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openFile_button;
        private System.Windows.Forms.ToolStripButton showTask_button;
        private System.Windows.Forms.ToolStripButton exit_button;
        public System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label symbolsCount_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label searchStringSize_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label vocabLength_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label includesCount_label;
        private System.Windows.Forms.Button openVocab_button;
        public System.Windows.Forms.Label selectedWords_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

