namespace Lab8_multiform_richTextBox
{
    partial class VocabForm
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
            this.vocab_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vocab_checkList = new System.Windows.Forms.CheckedListBox();
            this.colorize_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vocab_text
            // 
            this.vocab_text.Location = new System.Drawing.Point(12, 41);
            this.vocab_text.Multiline = true;
            this.vocab_text.Name = "vocab_text";
            this.vocab_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.vocab_text.Size = new System.Drawing.Size(193, 331);
            this.vocab_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Словарь:";
            // 
            // vocab_checkList
            // 
            this.vocab_checkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vocab_checkList.FormattingEnabled = true;
            this.vocab_checkList.Location = new System.Drawing.Point(225, 41);
            this.vocab_checkList.Name = "vocab_checkList";
            this.vocab_checkList.Size = new System.Drawing.Size(313, 276);
            this.vocab_checkList.TabIndex = 2;
            this.vocab_checkList.SelectedIndexChanged += new System.EventHandler(this.vocab_checkList_SelectedIndexChanged);
            // 
            // colorize_button
            // 
            this.colorize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorize_button.Location = new System.Drawing.Point(225, 324);
            this.colorize_button.Name = "colorize_button";
            this.colorize_button.Size = new System.Drawing.Size(313, 48);
            this.colorize_button.TabIndex = 3;
            this.colorize_button.Text = "Выделить цветом..";
            this.colorize_button.UseVisualStyleBackColor = true;
            this.colorize_button.Click += new System.EventHandler(this.colorize_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_button.Location = new System.Drawing.Point(451, 13);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(87, 23);
            this.refresh_button.TabIndex = 4;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = true;
            // 
            // VocabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 384);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.colorize_button);
            this.Controls.Add(this.vocab_checkList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vocab_text);
            this.Name = "VocabForm";
            this.Text = "VocabForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vocab_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox vocab_checkList;
        private System.Windows.Forms.Button colorize_button;
        private System.Windows.Forms.Button refresh_button;

    }
}