using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renkkorlugu
{
    public partial class Sekiller : Form
    {
        public Sekiller()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int puan = 0;


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Sekiller_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 21, 21);
            label1.Text = "Teste Başlamaya Hazır Mısın ? :)";


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            sayac++;
            btnbaslat.Text = "Sonraki";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            label2.Enabled = false;
            label5.Text = "Test İlerlemeniz " + sayac + "/18";


            if (sayac == 1)
            {
                label2.Text = "DAİRE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/daire1.png";
            }

            btnbaslat.Text = "Sonraki";
            if (sayac == 2)
            {
                label2.Text = "DAİRE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/daire2.png";
            }

            if (sayac == 3)
            {
                label2.Text = "DAİRE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/daire3.png";
            }

            if (sayac == 4)
            {
                label2.Text = "KARE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/kare4.png";
            }

            if (sayac == 5)
            {
                label2.Text = "ÜÇGEN";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/ucgen5.png";
            }

            if (sayac == 6)
            {
                label2.Text = "ÜÇGEN";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/ucgen6.png";
            }

            if (sayac == 7)
            {
                label2.Text = "KARE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/kare7.png";
            }


            if (sayac == 8)
            {
                label2.Text = "DAİRE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/daire8.png";
            }


            if (sayac == 9)
            {
                label2.Text = "KARE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/kare9.png";
            }


            if (sayac == 10)
            {
                label2.Text = "DAİRE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/daire10.png";
            }

            if (sayac == 11)
            {
                label2.Text = "ÜÇGEN";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/ucgen11.png";
            }


            if (sayac == 12)
            {
                label2.Text = "KARE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/kare12.png";
            }

            if (sayac == 13)
            {
                label2.Text = "KARE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/kare13.png";
            }


            if (sayac == 14)
            {
                label2.Text = "ÜÇGEN";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/ucgen14.png";
            }


            if (sayac == 15)
            {
                label2.Text = "KARE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/kare15.png";
            }


            if (sayac == 16)
            {
                label2.Text = "KARE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/kare16.png";
            }

            if (sayac == 17)
            {
                label2.Text = "DAİRE";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/daire17.png";
            }

            if (sayac == 18)
            {
                btnbaslat.Enabled = false;
                label2.Text = "ÜÇGEN";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/ucgen18.png";
            }
            if (sayac == 19)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;         
                btnbaslat.Enabled = false;

                label1.Text = "";
                label5.Text = "Test Bitti";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/son.jpg";
                pictureBox2.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/icon.png";


                if (puan >= 16)
                {
                    label6.Text = "Normal renk görüşünüz var, \n yani bir milyona kadar farklı renk tonu görebilirsiniz!";
                }
                else if (puan >= 13 && puan < 16)
                {
                    label6.Text = "Zayıf Protan tipi renk körlüğünüz var. \n Protan tipi renk körlüğü olan bir kişi, \n özellikle düşük ışıkta yeşillikleri," +
                        " sarıları, portakalları, kırmızıları ve kahveleri \n normalden daha benzer renk tonları olarak görme eğilimindedir";

                }
                else if (puan >= 11 && puan < 13)
                {
                    label6.Text = "Zayıf Deutan tipi renk körlüğünüz var.\n Deutan tipi  renk görme eksikliği olan bir kişi" +
                        " yeşil ve sarı veya mavi ve mor gibi \n renkler arasında karışıklıklar yaşayabilir.";

                }
                else if (puan >= 9 && puan < 11)
                {
                    label6.Text = "Kuvvetli Deutan tipi renk körlüğünüz var.\n Deutan tipi  renk görme eksikliği olan bir kişi" +
                        " yeşil ve sarı veya mavi ve mor gibi \n renkler arasında karışıklıklar yaşayabilir.";

                }
                else if (puan >= 7 && puan < 9)
                {
                    label6.Text = "Kuvvetli protan tipi renk körlüğünüz var.\n Protan tipi  renk körlüğü olan bir kişi,\n özellikle düşük ışıkta yeşillikleri," +
                        " sarıları, portakalları, kırmızıları ve kahveleri \n normalden daha benzer renk tonları olarak görme eğilimindedir";

                }
                else if (puan >= 5 && puan < 7)
                {
                    label6.Text = "kuvvetli  mavi-sarı tipi renk körlüğünüz var ";

                }

                else
                {
                    label6.Text = "LÜTFEN testi tekrar uygulayın...";

                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = button5.Text;

            if (label2.Text == label3.Text)
            {
                puan = puan + 1;
            }
            btnbaslat.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label3.Text = button1.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 1;
            }
            btnbaslat.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            button1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = button2.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 1;
            }
            btnbaslat.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = button3.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 1;
            }
            btnbaslat.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label3.Text = button4.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 1;
            }
            btnbaslat.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

    }
}
