namespace WinFormsAppStrings
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.textin = new System.Windows.Forms.TextBox();
            this.delword = new System.Windows.Forms.TextBox();
            this.maxword = new System.Windows.Forms.Button();
            this.DeleteWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outmaxword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textin
            // 
            this.textin.Location = new System.Drawing.Point(12, 103);
            this.textin.Multiline = true;
            this.textin.Name = "textin";
            this.textin.Size = new System.Drawing.Size(222, 210);
            this.textin.TabIndex = 0;
            // 
            // delword
            // 
            this.delword.Location = new System.Drawing.Point(344, 222);
            this.delword.Multiline = true;
            this.delword.Name = "delword";
            this.delword.Size = new System.Drawing.Size(216, 91);
            this.delword.TabIndex = 1;
            // 
            // maxword
            // 
            this.maxword.Location = new System.Drawing.Point(247, 103);
            this.maxword.Name = "maxword";
            this.maxword.Size = new System.Drawing.Size(85, 93);
            this.maxword.TabIndex = 2;
            this.maxword.Text = "Самое длинное слово";
            this.maxword.UseVisualStyleBackColor = true;
            this.maxword.Click += new System.EventHandler(this.maxword_Click);
            // 
            // DeleteWord
            // 
            this.DeleteWord.Location = new System.Drawing.Point(247, 222);
            this.DeleteWord.Name = "DeleteWord";
            this.DeleteWord.Size = new System.Drawing.Size(85, 91);
            this.DeleteWord.TabIndex = 3;
            this.DeleteWord.Text = "Удалить все предыдущие вхождения последней буквы\r\n";
            this.DeleteWord.UseVisualStyleBackColor = true;
            this.DeleteWord.Click += new System.EventHandler(this.DeleteWord_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите текст";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(385, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Преобразованый текст";
            // 
            // outmaxword
            // 
            this.outmaxword.Location = new System.Drawing.Point(344, 103);
            this.outmaxword.Multiline = true;
            this.outmaxword.Name = "outmaxword";
            this.outmaxword.Size = new System.Drawing.Size(215, 93);
            this.outmaxword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(373, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Самое длинное слово и сколько раз оно встречалось";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(223, 355);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(131, 36);
            this.reset.TabIndex = 8;
            this.reset.Text = "Очистить\r\n";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outmaxword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteWord);
            this.Controls.Add(this.maxword);
            this.Controls.Add(this.delword);
            this.Controls.Add(this.textin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button reset;

        private System.Windows.Forms.TextBox delword;
        private System.Windows.Forms.TextBox outmaxword;
        private System.Windows.Forms.TextBox textin;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button DeleteWord;

        private System.Windows.Forms.Button maxword;

        #endregion
    }
}