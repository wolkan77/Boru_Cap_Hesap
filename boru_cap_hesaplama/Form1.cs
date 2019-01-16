using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace boru_cap_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;

            Dictionary<int, double> cap_listesi_pn10 = new Dictionary<int, double>() { { 40, 35.2 }, { 50, 44 }, { 63, 55.4 }, { 75, 66 }, { 90, 79.2 }, { 110, 96.8 }, { 125, 110.2 }, { 140, 123.4 }, { 160, 141 }, { 180, 158.6 }, { 200, 176.2 }, { 225, 198.2 }, { 250, 220.4 }, { 280, 246.8 }, { 315, 277.6 }, { 355, 312.8 }, { 400, 352.6 }, { 450, 396.6 }, { 500, 440.6 }, { 560, 493.6 }, { 630, 555.2 }, { 710, 625.8 }, { 800, 705.2 }, { 900, 793.4 }, { 1000, 881.4 }, { 1200, 1058.8 }, { 1400, 1235.2 }, { 1600, 1411.8 } };
            Dictionary<int, double> cap_listesi_pn16 = new Dictionary<int, double>() { { 40, 32.6 }, { 50, 40.8 }, { 63, 51.4 }, { 75, 61.4 }, { 90, 73.6 }, { 110, 90 }, { 125, 102.2 }, { 140, 114.6 }, { 160, 130.8 }, { 180, 147.2 }, { 200, 163.6 }, { 225, 184 }, { 250, 204.6 }, { 280, 229.2 }, { 315, 257.8 }, { 355, 290.6 }, { 400, 327.4 }, { 450, 368.2 }, { 500, 409.2 }, { 560, 458.4 }, { 630, 515.6 }, { 710, 581 }, { 800, 654.6 }, { 900, 736.4 }, { 1000, 818.2 }, { 1200, 981.8 }, { 1400, 1145.4 }, { 1600, 1309 } };
            Dictionary<int, double> cap_listesi_pn20 = new Dictionary<int, double>() { { 40, 31 }, { 50, 38.8 }, { 63, 48.8 }, { 75, 58.2 }, { 90, 69.8 }, { 110, 85.4 }, { 125, 97 }, { 140, 108.6 }, { 160, 124.2 }, { 180, 139.8 }, { 200, 155.2 }, { 225, 174.6 }, { 250, 194.2 }, { 280, 217.4 }, { 315, 244.6 }, { 355, 275.6 }, { 400, 310.6 }, { 450, 349.4 }, { 500, 388.4 }, { 560, 435.6 }, { 630, 490 }, { 710, 552.4 }, { 800, 622.2 }, { 900, 700 }, { 1000, 777.8 }, { 1200, 933.4 }, { 1400, 1089 }, { 1600, 1244.4 } };
            Dictionary<int, double> cap_listesi_pn25 = new Dictionary<int, double>() { { 40, 29 }, { 50, 36.2 }, { 63, 45.8 }, { 75, 54.4 }, { 90, 65.4 }, { 110, 79.8 }, { 125, 90.8 }, { 140, 101.6 }, { 160, 116.2 }, { 180, 130.8 }, { 200, 145.2 }, { 225, 163.4 }, { 250, 181.6 }, { 280, 203.4 }, { 315, 228.8 }, { 355, 258 }, { 400, 290.6 }, { 450, 327 }, { 500, 364.8 }, { 560, 408.6 }, { 630, 459.8 }, { 710, 518.2 }, { 800, 583.8 }, { 900, 656.4 }, { 1000, 729.8 }, { 1200, 875.6 }, { 1400, 1021.6 }, { 1600, 1167.6 } };

            double debi = Convert.ToInt32(textBox1.Text);
            double hiz;

            #region try
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    for (int i = 0; i < cap_listesi_pn10.Count; i++)
                    {
                        hiz = (debi / 1000) / (Math.PI * (Math.Pow((cap_listesi_pn10.ElementAt(i).Value / 1000), 2)) / 4);
                        if (hiz < 3)
                        {
                            label2.Text += cap_listesi_pn10.ElementAt(i).Key.ToString() + " mm" + " " + hiz.ToString("n3") + " m/s" + "\n";
                            if (hiz < 1.2)
                            {
                                label2.Text += "Seçilen Çap: " + cap_listesi_pn10.ElementAt(i).Key.ToString() + " mm" + " " + "\n" + "Hesap Hız: " + hiz.ToString("n3") + " m/s" + "\n";
                                break;
                            }
                        }
                        
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    for (int i = 0; i < cap_listesi_pn16.Count; i++)
                    {
                        hiz = (debi / 1000) / (Math.PI * (Math.Pow((cap_listesi_pn16.ElementAt(i).Value / 1000), 2)) / 4);
                        if (hiz<3)
                        {
                            label2.Text += cap_listesi_pn16.ElementAt(i).Key.ToString() + " mm" + " " + hiz.ToString("n3") + " m/s" + "\n";
                            if (hiz < 1.2)
                            {
                                label2.Text += "Seçilen Çap: " + cap_listesi_pn16.ElementAt(i).Key.ToString() + " mm" + " " + "\n" + "Hesap Hız: " + hiz.ToString("n3") + " m/s" + "\n";
                                break;
                            }
                        }
                       
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    for (int i = 0; i < cap_listesi_pn20.Count; i++)
                    {

                        hiz = (debi / 1000) / (Math.PI * (Math.Pow((cap_listesi_pn20.ElementAt(i).Value / 1000), 2)) / 4);
                        if (hiz < 3)
                        {
                            label2.Text += cap_listesi_pn20.ElementAt(i).Key.ToString() + " mm" + " " + hiz.ToString("n3") + " m/s" + "\n";
                            if (hiz < 1.2)
                            {
                                label2.Text += "Seçilen Çap: " + cap_listesi_pn20.ElementAt(i).Key.ToString() + " mm" + " " + "\n" + "Hesap Hız: " + hiz.ToString("n3") + " m/s";
                                break;
                            }

                        }
                    }
                }
                else
                {
                    for (int i = 0; i < cap_listesi_pn25.Count; i++)
                    {
                        hiz = (debi / 1000) / (Math.PI * (Math.Pow((cap_listesi_pn25.ElementAt(i).Value / 1000), 2)) / 4);
                        if (hiz<3)
                        {
                            label2.Text += cap_listesi_pn25.ElementAt(i).Key.ToString() + " mm" + " " + hiz.ToString("n3") + " m/s" + "\n";
                            if (hiz < 1.2)
                            {
                                label2.Text += "Seçilen Çap: " + cap_listesi_pn25.ElementAt(i).Key.ToString() + " mm" + " " + "\n" + "Hesap Hız: " + hiz.ToString("n3") + " m/s" + "\n";
                                break;
                            }
                        }
                       
                    }
                }
            }
            #endregion

            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }
    }
}
