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
    public partial class arabalar : Form
    {
        public arabalar()
        {
            InitializeComponent();
        }
        class sat
        {
            public DialogResult a;
        }
        sat s=new sat();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "E28")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\e28.jpg";
                s.a = MessageBox.Show("\r\nModel\tMotor\tGüç\tTork\tYakıt tedariki\tYıllar\r\n518\tM10B18\r\n4 silindir\t66 kW (90 PS)\r\nat 5500 rpm\t140 N·m (103 lb·ft)\r\nat 4000 rpm\tPierburg 2BE\r\nkarbüratör\t1981-1984\r\n518i\t77 kW (105 PS)\r\nat 5800 rpm\t145 N·m (107 lb·ft)\r\nat 4500 rpm\tL-Jetronic\t1981–1987\r\n520i\tM20B20\r\n6 silindir\t92 kW (125 PS)\r\nat 5800 rpm\t165 N·m (122 lb·ft)\r\nat 4500 rpm\tK-Jetronic\t1981–1982\r\n170 N·m (125 lb·ft)\r\nat 4000 rpm\tL-Jetronic\t1982-1987\r\n95 kW (129 PS)\r\nat 6000 rpm\t174 N·m (128 lb·ft)\r\nat 4000 rpm\tLE-Jetronic\t1985-1988\r\n164 N·m (121 lb·ft)\r\nat 4300 rpm\tMotronic\t1986-1988\r\n525i\tM30B25\r\n6 silindir\t110 kW (150 PS)\r\nat 5500 rpm\t215 N·m (159 lb·ft)\r\nat 4000 rpm\tL-Jetronic\t1981–1987\r\n  525e /\r\n528e\tM20B27\r\n6 silindir\t92 kW (125 PS; 123 hp)\r\nat 4250 rpm\t240 N·m (177 lb·ft)\r\nat 3250 rpm\tMotronic\t1982–1987\r\n90 kW (122 PS; 121 hp)\r\nat 4250 rpm\t230 N·m (170 lb·ft)\r\nat 3250 rpm\tL-Jetronic,\r\nMotronic\t1982–1987\r\n95 kW (129 PS; 127 hp)\r\nat 4250 rpm\t240 N·m (177 lb·ft)\r\nat 3250 rpm\tMotronic\t1984–1988\r\n525e\t88 kW (120 PS)\r\nat 4250 rpm\t240 N·m (177 lb·ft)\r\nat 3250 rpm\tMotronic\t1985–1987\r\n528i\tM30B28\r\n6 silindir\t135 kW (184 PS)\r\nat 5800 rpm\t240 N·m (177 lb·ft)\r\nat 4200 rpm\tL-Jetronic\t1981–1987\r\n  533i[3]\tM30B32\r\n6 silindir\t135 kW (184 PS)\r\nat 6000 rpm\t265 N·m (195 lb·ft)\r\nat 4000 rpm\tMotronic", "E28", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "E34")
            {
                pictureBox1.ImageLocation = ":\\proje resim\\e34.jpg";
                s.a = MessageBox.Show("\r\nModel\tYıllar\tMotor\tGüç\tTork\r\n518i\t1989-1994\tM40B18\r\nsıralı 4\t83 kW (111 hp) 5.500 rpm'de\t165 N·m (122 lb·ft) 4.250 rpm\r\n1994-1996\tM43B18\r\nsıralı 4\t85 kW (114 hp) 5.500 rpm'de\t168 N·m (124 lb·ft) 3,900 rpm\r\n520i\t1988-1990\tM20B20\r\nsıralı 6\t95 kW (127 hp)\r\n6.000 rpm'de\t174 N·m (128 lb·ft)\r\n4.000 rpm\r\n1989-1992\tM50B20\r\nsıralı 6\t110 kW (148 hp)\r\n6,000 rpm'de\t190 N·m (140 lb·ft)\r\n4.700 rpm\r\n1992-1996\tM50B20TU\r\n6-cyl\t110 kW (148 hp)\r\n5,900 rpm'de\t190 N·m (140 lb·ft)\r\n4.200 rpm\r\n525i\t1988-1991\tM20B25\r\nsıralı 6\t125 kW (168 hp) 5.800 rpm'de\t222 N·m (164 lb·ft) 4.300 rpm\r\n1991-1992\tM50B25\r\nsıralı 6\t141 kW (189 hp) 6.000 rpm'de\t245 N·m (181 lb·ft) 4.700 rpm\r\n1992-1996\tM50B25TU\r\nsıralı 6\t141 kW (189 hp) 5.900 rpm'de\t250 N·m (184 lb·ft) 4.200 rpm\r\n530i\t1988-1991\tM30B30\r\nsıralı 6\t138 kW (185 hp) 5.500 rpm'de\t260 N·m (192 lb·ft) 4.300 rpm\r\n1992-1996\tM60B30\r\nV8\t160 kW (215 hp) 5.800 rpm'de\t290 N·m (214 lb·ft) 4.500 rpm\r\n535i\t1987-1992\tM30B35\r\nsıralı 6\t155 kW (208 hp) 5.700 rpm'de\t305 N·m (225 lb·ft) 4.000 rpm\r\n540i\t1992-1996\tM60B40\r\nV8\t210 kW (282 hp) 5.800 rpm'de\t400 N·m (295 lb·ft) 4.500 rpm\r\nM5\t1988-1992\tS38B36\r\nsıralı 6\t232 kW (311 hp) 6.900 rpm'de\t360 N·m (266 lb·ft) 4,750 rpm\r\n1992-1996\tS38B38\r\nsıralı 6\t250 kW (335 hp) 6.900 rpm'de\t400 N·m (295 lb·ft) 4,750 rpm\r\n", "E34", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "E39") 
            { 
                pictureBox1.ImageLocation = "E:\\proje resim\\e34.jpg";
                s.a = MessageBox.Show("\r\nModel\tYıllar\tMotor\tGüç\tTork\r\n520i\t1995–1998\tM52B20\r\ndüz 6\t110 kW (148 hp) at 5,900 rpm\t190 N·m (140 lb·ft) at 4,200 rpm\r\n1998–2000\t  M52TUB20   \r\ndüz 6\t110 kW (148 hp) at 5,900 rpm\t190 N·m (140 lb·ft) at 3,500 rpm\r\n2000–2003\tM54B22\r\ndüz 6\t125 kW (168 hp)\r\nat 6,100 rpm\t210 N·m (155 lb·ft)\r\nat 3,500 rpm\r\n523i\t1995–1998\tM52B25\r\ndüz 6\t125 kW (168 hp) at 5,500 rpm\t245 N·m (181 lb·ft) at 3,950 rpm\r\n1998–2000\tM52TUB25\r\ndüz 6\t125 kW (168 hp) at 5,500 rpm\t245 N·m (181 lb·ft) at 3,500 rpm\r\n525i\t2000–2003\tM54B25\r\ndüz 6\t141 kW (189 hp) at 6,000 rpm\t245 N·m (181 lb·ft) at 3,500 rpm\r\n528i\t1995–1998\tM52B28\r\ndüz 6\t142 kW (190 hp) at 5,300 rpm\t280 N·m (207 lb·ft) at 3,950 rpm\r\n1998–2001\tM52TUB28\r\ndüz 6\t142 kW (190 hp) at 5,500 rpm\t280 N·m (207 lb·ft) at 3,500 rpm\r\n530i\t2000–2003\tM54B30\r\ndüz 6\t170 kW (228 hp) at 5,900 rpm\t300 N·m (221 lb·ft) at 3,500 rpm\r\n535i\t1996–1998\tM62B35\r\nV8\t173 kW (232 hp) at 5,700 rpm\t320 N·m (236 lb·ft) at 3,300 rpm\r\n1998–2003\tM62TUB35\r\nV8\t180 kW (241 hp) at 5,800 rpm\t345 N·m (254 lb·ft) at 3,800 rpm\r\n540i\t1995–1998\tM62B44\r\nV8\t210 kW (282 hp) at 5,700 rpm\t420 N·m (310 lb·ft) at 3,900 rpm\r\n1998–2003\tM62TUB44\r\nV8\t210 kW (282 hp) at 5,400 rpm\t440 N·m (325 lb·ft) at 3,600 rpm\r\nM5\t1998–2003\tS62B50\r\nV8\t294 kW (394 hp) at 6,600 rpm\t500 N·m (369 lb·ft) at 3,800 rpm", "E39", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "E60")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\e60.jpg";
                s.a = MessageBox.Show("\r\nModel\tYıllar\tMotor\tGüç\tTork\r\n520i\t2003-2005\t2.2 L M54\r\nsıralı-6\t125 kW (168 hp)\r\n6,250 rpm'de\t210 N·m (155 lb·ft)\r\n3,500 rpm'de\r\n2007-2010\t2.0 L N46\r\nsıralı-4\t115 kW (154 hp)\r\n6,400 rpm'de\t200 N·m (148 lb·ft)\r\n3,500 rpm'de\r\n2007-2010\t2.0 L N43\r\nsıralı-4\t125 kW (168 hp)\r\n6,700 rpm'de\t210 N·m (155 lb·ft)\r\n4,250 rpm'de\r\n523i\t2005-2007\t2.5 L N52\r\nsıralı-6\t130 kW (174 hp)\r\n5,800 rpm'de\t230 N·m (170 lb·ft)\r\n3,500 rpm'de\r\n2007-2010\t2.5 L N53\r\nsıralı-6\t140 kW (188 hp)\r\n6,100 rpm'de\t240 N·m (177 lb·ft)\r\n3,500 rpm'de\r\n525i\t2003-2005\t2.5 L M54\r\nsıralı-6\t140 kW (188 hp)\r\n6,000 rpm'de\t237 N·m (175 lb·ft)\r\n3,500 rpm'de\r\n2005-2007\t2.5 L N52\r\nsıralı-6\t160 kW (215 hp)\r\n6,500 rpm'de\t250 N·m (184 lb·ft)\r\n2,750 rpm'de\r\n2007-2010\t3.0 L N53\r\nsıralı-6\t160 kW (215 hp)\r\n6,100 rpm'de\t270 N·m (199 lb·ft)\r\n2,400 rpm'de\r\n528i\t2007-2010\t3.0 L N52\r\nsıralı-6\t172 kW (231 hp)\r\n6,500 rpm'de\t270 N·m (199 lb·ft)\r\n2,750 rpm'de\r\n530i\t2003-2005\t3.0 L M54\r\nsıralı-6\t170 kW (228 hp)\r\n5,900 rpm'de\t300 N·m (221 lb·ft)\r\n3,500 rpm'de\r\n2005-2007\t3.0 L N52\r\nsıralı-6\t190 kW (255 hp)\r\n6,600 rpm'de\t300 N·m (221 lb·ft)\r\n2,500 rpm'de\r\n2007-2010\t3.0 L N53\r\nsıralı-6\t200 kW (268 hp)\r\n6,700 rpm'de", "E60", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "F10")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\f10.jpg";
                s.a = MessageBox.Show("Ağırlık\r\nYüksüz ağırlık (kg) EC\r\n1970\r\nİzin verilen toplam ağırlık (kg)\r\n2440\r\nOtomobilin yük kapasitesi (kg)\r\n545\r\nİzin verilen ön/arka aks yükü (kg)\r\n1215/1260\r\nBagaj Hacmi (lt)\r\n530\r\nMotor\r\nSilindir/Valf\r\n8/4\r\nSilindir hacmi (cm³)\r\n4395\r\nStrok/çap (mm)\r\n88.3/89\r\nGüç (bg)/Güç devir (devir/dak)\r\n600/625 / 6000\r\nTork (Nm)/Tork devir (devir/dak)\r\n750 / 1800 - 5860, 1800 - 5600\r\nKompresyon oranı : 1\r\n10\r\nPerformans\r\nMaksimum hız km/sa\r\n250/305\r\n0-100 km/sa hızlanma\r\n3.3/3.4\r\nYakıt Tüketimi\r\nŞehir içi (lt/100 km)\r\n-\r\nŞehir dışı (lt/100 km)\r\n-\r\nOrtalama (lt/100 km)\r\n-\r\nCO2 emisyonu (gr/km)\r\n38.4/265.2\r\nDepo hacmi (lt)\r\n68\r\nJantlar\r\nÖn lastik\r\n275/35 ZR20 (102Y) XL, 275/40 ZR19 (105Y) XL\r\nArka lastik\r\n285/35 ZR20 (104Y) XL, 285/40 ZR19 (107Y) XL\r\nÖn jant\r\n9,5J x 19, 9,5J x 20\r\nArka jant\r\n10,5J x 20, 10,5J x 19\r\n​\r\nYakıt tüketimi ve CO2 emisyonu.\r\nBMW M5 CS:\r\nYakıt tüketimi (litre/100 km) (ortalama): 11,3\r\nCO2 emisyonu (g/km) (ortalama): 256\r\n\r\nBMW M5 Competition:\r\nYakıt tüketimi (litre/100 km) (ortalama): 11,3-11,1\r\nCO2 emisyonu (g/km) (ortalama): 259-253\r\n\r\nBMW M5", "F10", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "C 180")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\c180.jpg";
                s.a = MessageBox.Show("C 180\t1.6 I4\t115 kW (156 PS; 154 hp)", "  C180", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "C 200d")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\c 200d.jpg";
                s.a = MessageBox.Show("C 200d\t1.6 I4\t118 kW (160 PS; 158 hp)", "", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "C 200")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\c200.jpg";
                s.a = MessageBox.Show("C 200\t2.0 I4\t135 kW (184 PS; 181 hp)", "", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "C 250")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\c250.jpg";
                s.a = MessageBox.Show("C 250	2.0 I4	155 kW (211 PS; 208 hp)", "", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "R30")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\r30.jpg";
                s.a = MessageBox.Show("Production\t1981–1985\r\n406,432 units sold\r\nAssembly\tJapan: Musashimurayama\r\nDesigner\tShinichiro Sakurai\r\nBody and chassis\r\nBody style\t4-door sedan\r\n2-door coupé\r\n5-door Liftback\r\n5-door station wagon\r\nLayout\tFront-engine, rear-wheel-drive\r\nRelated\tNissan Laurel\r\nNissan Leopard\r\nPowertrain\r\nEngine\t\r\nGasoline:\r\n1770 cc Z18S I4\r\n1809 cc CA18E I4\r\n1952 cc Z20E I4\r\n1990 cc FJ20E DOHC I4\r\n1990 cc FJ20ET DOHC turbo I4\r\n1998 cc L20E I6\r\n1998 cc L20ET turbo I6\r\n2393 cc L24 I6\r\n2753 cc L28/L28E I6\r\nDiesel:\r\n1998 cc LD20 I4\r\n2792 cc LD28 diesel I6\r\nTransmission\t3/4-speed automatic or 4/5-speed manual\r\nDimensions\r\nWheelbase\t2,615 mm (103.0 in)\r\nLength\t4,620 mm (181.9 in)\r\nWidth\t1,675 mm (65.9 in)\r\nHeight\t1,385 mm (54.5 in)", "", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "R31")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\r31.jpg";
                s.a = MessageBox.Show("Overview\r\nAlso called\tNissan Pintara (Australian 4-cylinder models).\r\nProduction\t1985–1989 (Japan)\r\n1986–1990 (Australia)\r\n309,716 units sold\r\nAssembly\tMusashimurayama, Japan (Nissan Motor Co.)\r\nClayton, Australia (Nissan Australia)[47]\r\nDesigner\tShinichiro Sakurai\r\nNaganori Ito\r\nBody and chassis\r\nBody style\t4-door sedan\r\n4-door hardtop\r\n2-door coupe\r\n5-door station wagon\r\nLayout\tFront-engine, rear-wheel-drive\r\nRelated\tNissan Laurel\r\nNissan Leopard\r\nNissan Pintara\r\nPowertrain\r\nEngine\tGasoline:\r\n1.8 L CA18I I4\r\n2.0 L CA20E I4\r\n2.0 L RB20E I6\r\n2.0 L RB20ET I6 Turbocharged\r\n2.0 L RB20DE I6\r\n2.0 L RB20DET I6 Turbocharged\r\n2.0 L RB20DET-R I6 Turbocharged\r\n3.0 L RB30E I6\r\n3.0 L RB30DE I6[48]\r\nDiesel:\r\n2.8 L RD28 I6\r\nTransmission\t4-speed automatic, 5-speed manual\r\nDimensions\r\nWheelbase\t2,610 mm (102.8 in)\r\nLength\t4,590 mm (180.7 in) (pre-facelift sedan/wagon)\r\n4,650 mm (183.1 in) (pre-facelift hardtop)\r\n4,660 mm (183.5 in) (coupe/facelift sedan/hardtop/wagon)\r\nWidth\t1,690 mm (66.5 in)\r\nHeight\t1,365 mm (53.7 in) (coupe)","",MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "R32")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\r32.jpg";
                s.a = MessageBox.Show("Overview\r\nProduction\tMay 1989–July 1993 (standard)[50]\r\nAugust 1989–November 1994 (GT-R)[50]\r\nAssembly\tMusashimurayama, Japan\r\nDesigner\tNaganori Ito (1986)\r\nBody and chassis\r\nBody style\t4-door sedan\r\n2-door coupe\r\nLayout\tFront-engine, rear-wheel-drive\r\nFront-engine, four-wheel-drive\r\nRelated\tNissan Laurel\r\nNissan Cefiro\r\nPowertrain\r\nEngine\t\r\nGasoline:\r\n1.8 L CA18i I4\r\n2.0 L RB20E I6\r\n2.0 L RB20DE DOHC I6\r\n2.0 L RB20DET DOHC turbo I6\r\n2.5 L RB25DE DOHC I6\r\n2.6 L RB26DETT DOHC twin-turbo I6\r\nTransmission\t4-speed automatic\r\n5-speed automatic\r\n5-speed manual\r\nDimensions\r\nWheelbase\t2,615 mm (103.0 in)\r\nLength\t4,530 mm (178.3 in) (coupe)\r\n4,545 mm (178.9 in) (GT-R)\r\n4,580 mm (180.3 in) (sedan)\r\nWidth\t1,695 mm (66.7 in)\r\n1,755 mm (69.1 in) (GT-R)\r\nHeight\t1,325–1,345 mm (52.2–53.0 in) (coupe)\r\n1,340–1,355 mm (52.8–53.3 in) (GT-R)\r\n1,340–1,360 mm (52.8–53.5 in) (sedan)\r\nCurb weight\t1,120–1,380 kg (2,469.2–3,042.4 lb) (RWD)\r\n1,390–1,480 kg (3,064.4–3,262.8 lb) (AWD)\r\n1,430–1,500 kg (3,152.6–3,306.9 lb) (GT-R)", "", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "R33")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\r33.jpg";
                s.a = MessageBox.Show("Overview\r\nProduction\t1993–1998\r\n217,133 units sold\r\nAssembly\tMusashimurayama, Japan\r\nDesigner\tKozo Watanabe (1991)\r\nBody and chassis\r\nBody style\t4-door sedan\r\n2-door coupé\r\nLayout\tFront-engine, rear-wheel-drive\r\nFront-engine, four-wheel-drive\r\nRelated\tNissan Laurel\r\nNissan Stagea\r\nPowertrain\r\nEngine\t\r\nGasoline:\r\n2.0 L RB20E SOHC I6 (GTS)\r\n2.5 L RB25DE I6 (GTS-25, GTS-4)\r\n2.5 L RB25DET turbo I6 (GTS-25t)\r\n2.6 L RB26DETT twin-turbo I6 (GT-R)\r\n2.8 L RBX-GT2 twin-turbo I6 (400R)\r\nTransmission\t5-speed manual\r\n5-speed automatic\r\nDimensions\r\nWheelbase\t2,720 mm (107.1 in)\r\nLength\t4,640 mm (182.7 in) (coupé)\r\n4,675 mm (184.1 in) (GT-R)\r\n4,720 mm (185.8 in) (sedan)\r\nWidth\t1,720 mm (67.7 in)\r\n1,780 mm (70.1 in) (GT-R)\r\nHeight\t1,340–1,360 mm (52.8–53.5 in) (coupé)\r\n1,360–1,375 mm (53.5–54.1 in) (sedan)\r\nCurb weight\t1,270–1,410 kg (2,799.9–3,108.5 lb) (RWD)\r\n1,430–1,470 kg (3,152.6–3,240.8 lb) (AWD)\r\n1,530–1,540 kg (3,373.1–3,395.1 lb) (GT-R)", "", MessageBoxButtons.YesNo);
                if(s.a == DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
            if (comboBox1.SelectedItem == "R34")
            {
                pictureBox1.ImageLocation = "E:\\proje resim\\r34.jpg";
                s.a= MessageBox.Show("Overview\r\nProduction\t1998–2001 (up to 2002 for the GT-R and up to 2005 for the NISMO Z-Tune)\r\n64,623 units sold\r\nAssembly\tMusashimurayama, Japan\r\nDesigner\tKozo Watanabe (1996)\r\nBody and chassis\r\nBody style\t4-door sedan\r\n2-door coupe\r\nLayout\tFront-engine, rear-wheel-drive (ER/HR34)\r\nFront-engine, four-wheel-drive (BNR/ENR34)\r\nRelated\tNissan Laurel\r\nNissan Stagea\r\nPowertrain\r\nEngine\t\r\nGasoline:\r\n2.0 L RB20DE I6\r\n2.5 L RB25DE I6\r\n2.5 L RB25DET turbo I6\r\n2.6 L RB26DETT twin-turbo I6\r\nTransmission\t4-speed automatic\r\n5-speed manual\r\n6-speed manual Getrag 233 (GT-R)\r\nDimensions\r\nWheelbase\t2,665 mm (104.9 in)\r\nLength\t4,580 mm (180.3 in) (coupe)\r\n4,600 mm (181.1 in) (GT-R)\r\n4,705 mm (185.2 in) (sedan)\r\nWidth\t1,720 mm (67.7 in) (coupe)\r\n1,725 mm (67.9 in) (sedan)\r\n1,785 mm (70.3 in) (GT-R)\r\nHeight\t1,340–1,350 mm (52.8–53.1 in) (coupe)\r\n1,360 mm (53.5 in) (GT-R)\r\n1,375–1,385 mm (54.1–54.5 in) (sedan)\r\nCurb weight\t1,330–1,460 kg (2,932.1–3,218.7 lb) (coupe)\r\n1,360–1,490 kg (2,998.3–3,284.9 lb) (sedan)\r\n1,540–1,580 kg (3,395.1–3,483.3 lb) (GT-R)\r\nChronology\r\nSuccessor\tNissan GT-R (R35) (for GT-R models)", "", MessageBoxButtons.YesNo);
                if(s.a==DialogResult.Yes)
                {
                    MessageBox.Show("satın aldınız");
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
                
            }
        }

        private void cık_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            marka frm2 = new marka();
            this.Hide();
            frm2.ShowDialog();
        }
    }
}
