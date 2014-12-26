namespace Domaci_za_decembar
{
    partial class Form1
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
            this.spisakStdBtt = new System.Windows.Forms.Button();
            this.spisakFxBtt = new System.Windows.Forms.Button();
            this.dodajBtt = new System.Windows.Forms.Button();
            this.izlazBtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spisakStdBtt
            // 
            this.spisakStdBtt.Location = new System.Drawing.Point(12, 23);
            this.spisakStdBtt.Name = "spisakStdBtt";
            this.spisakStdBtt.Size = new System.Drawing.Size(103, 40);
            this.spisakStdBtt.TabIndex = 0;
            this.spisakStdBtt.Text = "Spisak Studenata";
            this.spisakStdBtt.UseVisualStyleBackColor = true;
            this.spisakStdBtt.Click += new System.EventHandler(this.spisakStdBtt_Click);
            // 
            // spisakFxBtt
            // 
            this.spisakFxBtt.Location = new System.Drawing.Point(12, 80);
            this.spisakFxBtt.Name = "spisakFxBtt";
            this.spisakFxBtt.Size = new System.Drawing.Size(103, 40);
            this.spisakFxBtt.TabIndex = 1;
            this.spisakFxBtt.Text = "Spisak Fakulteta";
            this.spisakFxBtt.UseVisualStyleBackColor = true;
            this.spisakFxBtt.Click += new System.EventHandler(this.spisakFxBtt_Click);
            // 
            // dodajBtt
            // 
            this.dodajBtt.Location = new System.Drawing.Point(12, 140);
            this.dodajBtt.Name = "dodajBtt";
            this.dodajBtt.Size = new System.Drawing.Size(103, 40);
            this.dodajBtt.TabIndex = 2;
            this.dodajBtt.Text = "Dodaj Studenta/Fakultet";
            this.dodajBtt.UseVisualStyleBackColor = true;
            // 
            // izlazBtt
            // 
            this.izlazBtt.Location = new System.Drawing.Point(12, 195);
            this.izlazBtt.Name = "izlazBtt";
            this.izlazBtt.Size = new System.Drawing.Size(103, 40);
            this.izlazBtt.TabIndex = 3;
            this.izlazBtt.Text = "Izlaz";
            this.izlazBtt.UseVisualStyleBackColor = true;
            this.izlazBtt.Click += new System.EventHandler(this.izlazBtt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.izlazBtt);
            this.Controls.Add(this.dodajBtt);
            this.Controls.Add(this.spisakFxBtt);
            this.Controls.Add(this.spisakStdBtt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button spisakStdBtt;
        private System.Windows.Forms.Button spisakFxBtt;
        private System.Windows.Forms.Button dodajBtt;
        private System.Windows.Forms.Button izlazBtt;

    }
}

