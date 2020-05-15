using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobalagi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MODUL2
            if (JenisBBM.Text == "Dexlite")
            {
                Hargaperliter.Text = "7000";
            }
            else if (JenisBBM.Text == "Premium")
            {
                Hargaperliter.Text = "7500";
            }
            else if (JenisBBM.Text == "Pertalite")
            {
                Hargaperliter.Text = "8020";
            }
            else if (JenisBBM.Text == "Pertamax")
            {
                Hargaperliter.Text = "9310";
            }
            else if (JenisBBM.Text == "Solar")
            {
                Hargaperliter.Text = "8700";
            }
            //MODUL1
            int Harga = Int32.Parse(Hargaperliter.Text);
            int Liter = Int32.Parse(Literx.Text);
            int Total = 0;
            //modul3
            for (int i = 0; i <= 1; i++)
            {
                Total = Harga * Liter;
            }
            Totalx.Text = Total.ToString();
            Reportx.Text = "SPBU 191.3.0047" + Environment.NewLine
            + ("---") + Environment.NewLine
            + ("Transaksi " + Nonota.Text + " dengan jenis BBM " + JenisBBM.Text + " sebanyak " + Literx.Text + " liter telah berhasil ditransfer menggunakan selang " + PilihSelang.Text) + Environment.NewLine
            + ("Terima kasih atas kepercayaan anda ") + Environment.NewLine
            + ("Salam PASTIPAS");
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JenisBBM.Text = String.Empty;
            Nonota.Text = String.Empty;
            PilihSelang.Text = String.Empty;
            Literx.Text = String.Empty;
            Hargaperliter.Text = String.Empty;
            Totalx.Text = String.Empty;
            Reportx.Text = String.Empty;
        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            if(f.ShowDialog() == DialogResult.OK)
            {
                PilihSelang.Text = f.MyVal;
            }
        }

        private void Reportx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Literx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Literx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}