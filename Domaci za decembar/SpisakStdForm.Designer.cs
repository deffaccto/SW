namespace Domaci_za_decembar
{
    partial class SpisakStdForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.promeniBtt = new System.Windows.Forms.Button();
            this.dodajBtt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imeTxt = new System.Windows.Forms.TextBox();
            this.prezimeTxt = new System.Windows.Forms.TextBox();
            this.indexTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.obirsiStdBtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENTI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FAKULTET";
            // 
            // promeniBtt
            // 
            this.promeniBtt.Location = new System.Drawing.Point(250, 195);
            this.promeniBtt.Name = "promeniBtt";
            this.promeniBtt.Size = new System.Drawing.Size(97, 46);
            this.promeniBtt.TabIndex = 5;
            this.promeniBtt.Text = "PROMENI PODATKE\r\n";
            this.promeniBtt.UseVisualStyleBackColor = true;
            this.promeniBtt.Click += new System.EventHandler(this.promeniBtt_Click);
            // 
            // dodajBtt
            // 
            this.dodajBtt.Location = new System.Drawing.Point(250, 84);
            this.dodajBtt.Name = "dodajBtt";
            this.dodajBtt.Size = new System.Drawing.Size(97, 45);
            this.dodajBtt.TabIndex = 6;
            this.dodajBtt.Text = "DODAJ STUDENTA";
            this.dodajBtt.UseVisualStyleBackColor = true;
            this.dodajBtt.Click += new System.EventHandler(this.dodajBtt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imeTxt
            // 
            this.imeTxt.Location = new System.Drawing.Point(33, 281);
            this.imeTxt.Name = "imeTxt";
            this.imeTxt.Size = new System.Drawing.Size(100, 20);
            this.imeTxt.TabIndex = 8;
            // 
            // prezimeTxt
            // 
            this.prezimeTxt.Location = new System.Drawing.Point(154, 281);
            this.prezimeTxt.Name = "prezimeTxt";
            this.prezimeTxt.Size = new System.Drawing.Size(100, 20);
            this.prezimeTxt.TabIndex = 9;
            // 
            // indexTxt
            // 
            this.indexTxt.Location = new System.Drawing.Point(271, 281);
            this.indexTxt.Name = "indexTxt";
            this.indexTxt.Size = new System.Drawing.Size(100, 20);
            this.indexTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Broj indexa";
            // 
            // obirsiStdBtt
            // 
            this.obirsiStdBtt.Location = new System.Drawing.Point(250, 135);
            this.obirsiStdBtt.Name = "obirsiStdBtt";
            this.obirsiStdBtt.Size = new System.Drawing.Size(97, 54);
            this.obirsiStdBtt.TabIndex = 14;
            this.obirsiStdBtt.Text = "OBRISI STUDENTA";
            this.obirsiStdBtt.UseVisualStyleBackColor = true;
            // 
            // SpisakStdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 331);
            this.Controls.Add(this.obirsiStdBtt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.indexTxt);
            this.Controls.Add(this.prezimeTxt);
            this.Controls.Add(this.imeTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dodajBtt);
            this.Controls.Add(this.promeniBtt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "SpisakStdForm";
            this.Text = "Spisak Studenata";
            this.Load += new System.EventHandler(this.SpisakStdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button promeniBtt;
        private System.Windows.Forms.Button dodajBtt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox imeTxt;
        private System.Windows.Forms.TextBox prezimeTxt;
        private System.Windows.Forms.TextBox indexTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button obirsiStdBtt;
    }
}