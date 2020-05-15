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
    public partial class Form2 : Form
    {
        private string myVal;

        public string MyVal
        {
            //modul4, modul6
            get { return myVal; }
            set { myVal = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyVal = Selang.Text;
        }
    }
}