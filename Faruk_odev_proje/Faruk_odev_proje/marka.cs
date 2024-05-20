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
    public partial class marka : Form
    {
        public marka()
        {
            InitializeComponent();
        }
        arabalar arabalari = new arabalar();
        private void button3_Click(object sender, EventArgs e)
        {
            arabalari.comboBox1.Items.Add("R30");
            arabalari.comboBox1.Items.Add("R31");
            arabalari.comboBox1.Items.Add("R32");
            arabalari.comboBox1.Items.Add("R33");
            arabalari.comboBox1.Items.Add("R34");
            arabalari.pictureBox1.ImageLocation = "E:\\proje resim\\arabaseçin.png";
            this.Hide();
            arabalari.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arabalari.comboBox1.Items.Add("E28");
            arabalari.comboBox1.Items.Add("E34");
            arabalari.comboBox1.Items.Add("E39");
            arabalari.comboBox1.Items.Add("E60");
            arabalari.comboBox1.Items.Add("F10");
            arabalari.pictureBox1.ImageLocation = "E:\\proje resim\\arabaseçin.png";
            this.Hide();
            arabalari.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arabalari.comboBox1.Items.Add("C 180");
            arabalari.comboBox1.Items.Add("C 200d");
            arabalari.comboBox1.Items.Add("C 200");
            arabalari.comboBox1.Items.Add("C 250");
            arabalari.pictureBox1.ImageLocation = "E:\\proje resim\\arabaseçin.png";
            this.Hide();
            arabalari.ShowDialog();
        }

        private void marka_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu frm1 = new menu();
            this.Hide();
            frm1.ShowDialog();
        }
    }
}
