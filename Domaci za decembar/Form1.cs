using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domaci_za_decembar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void izlazBtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spisakStdBtt_Click(object sender, EventArgs e)
        {
            SpisakStdForm f = new SpisakStdForm();
            f.Show();
            
        }

        private void spisakFxBtt_Click(object sender, EventArgs e)
        {
            SpisakFaxForm f = new SpisakFaxForm();
            f.Show();
        }
    }
}
