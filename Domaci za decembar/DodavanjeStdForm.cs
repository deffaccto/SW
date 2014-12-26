using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Domaci_za_decembar.Klase;

namespace Domaci_za_decembar
{
    public partial class DodavanjeStdForm : Form
    {
        ListaFax f;
        ListaStudent s;

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\deFaccto\Programiranje\StormWind\Domaci za decembar\Domaci za decembar\baza.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public DodavanjeStdForm(ListaStudent s, ListaFax f)
        {
            this.s = new ListaStudent();
            this.f = new ListaFax();

            this.s = s;
            this.f = f;
            InitializeComponent();

            for (int i = 0; i < f.N; i++)
            {
                listBox1.Items.Add(f[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cm.Connection = cn;
                int x = listBox1.SelectedIndex + 1;
                cn.Open();
                cm.CommandText = "insert into Student (Ime,Prezime,Index,Id_faxa) values ('" + imeTxt.Text + "', '" + prezimeTxt.Text + "', '" + indexTxt.Text + "', '" + x + "')";
                cm.ExecuteNonQuery();
                cm.Clone();
                cn.Close();

                s.dodajStudenta((Fax)listBox1.SelectedItem, imeTxt.Text, prezimeTxt.Text, indexTxt.Text);
                MessageBox.Show("Uspesno ste ubacili novog studenta");
            }

            catch
            {
                MessageBox.Show("Greska");
            }

            imeTxt.Text = "";
            prezimeTxt.Text = "";
            indexTxt.Text = "";
            
        }
    }
}
