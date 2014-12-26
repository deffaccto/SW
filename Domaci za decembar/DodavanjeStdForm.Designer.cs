namespace Domaci_za_decembar
{
    partial class DodavanjeStdForm
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
            this.imeTxt = new System.Windows.Forms.TextBox();
            this.prezimeTxt = new System.Windows.Forms.TextBox();
            this.indexTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 0;
            // 
            // imeTxt
            // 
            this.imeTxt.Location = new System.Drawing.Point(138, 34);
            this.imeTxt.Name = "imeTxt";
            this.imeTxt.Size = new System.Drawing.Size(100, 20);
            this.imeTxt.TabIndex = 1;
            // 
            // prezimeTxt
            // 
            this.prezimeTxt.Location = new System.Drawing.Point(138, 95);
            this.prezimeTxt.Name = "prezimeTxt";
            this.prezimeTxt.Size = new System.Drawing.Size(100, 20);
            this.prezimeTxt.TabIndex = 2;
            // 
            // indexTxt
            // 
            this.indexTxt.Location = new System.Drawing.Point(138, 159);
            this.indexTxt.Name = "indexTxt";
            this.indexTxt.Size = new System.Drawing.Size(100, 20);
            this.indexTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj Indexa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj Studenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodavanjeStdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexTxt);
            this.Controls.Add(this.prezimeTxt);
            this.Controls.Add(this.imeTxt);
            this.Controls.Add(this.listBox1);
            this.Name = "DodavanjeStdForm";
            this.Text = "DodavanjeStdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox imeTxt;
        private System.Windows.Forms.TextBox prezimeTxt;
        private System.Windows.Forms.TextBox indexTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}