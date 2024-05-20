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
    public partial class baslangic : Form
    {
        public baslangic()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void baslangic_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            await Task.Delay(1000);
            progressBar1.Value += 10;
            menu form1 = new menu();
            this.Hide();
            form1.ShowDialog();

        }
    }
}
