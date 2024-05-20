using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faruk_odev_proje
{
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu form1 = new menu();
            this.Hide();
            form1.ShowDialog();
        }
        arabalar arabalar2 = new arabalar();
        private void button2_Click(object sender, EventArgs e)
        {
            marka form2 = new marka();
            this.Hide();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arabalar2.ShowDialog();
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            menu frm1 = new menu();
            this.Hide();
            frm1.ShowDialog();
        }
    }
}
