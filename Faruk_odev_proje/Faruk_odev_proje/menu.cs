using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Faruk_odev_proje
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        public void parola(string p)
        {
            if (p == "32")
            {
                yonetici yonetici2 = new yonetici();
                this.Hide();
                yonetici2.ShowDialog();
            }
            else
            {
                MessageBox.Show("yanlış parola", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("çıkış yapılsınmı", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void yonetici_Click(object sender, EventArgs e)
        {
            string p = Interaction.InputBox("parola giriniz:");
            parola(p);
        }

        private void kullanıcı_Click(object sender, EventArgs e)
        {
            marka form = new marka();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
