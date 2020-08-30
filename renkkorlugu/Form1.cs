using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renkkorlugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int puan = 0;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 21, 21);
            label1.Text = "Teste Başlamaya Hazır Mısın ? :)";


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        


        private void label1_Click(object sender, EventArgs e)
        {

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
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            btnbaslat.Enabled = false;
            label2.Enabled = false;
            label5.Text = "Test İlerlemeniz " + sayac +  "/18";


            if (sayac == 1)
            {
                label2.Text = "1";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/1.png";
            }

            btnbaslat.Text = "Sonraki";
            if (sayac == 2)
            {
                label2.Text = "3";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/33.png";
            }

            if (sayac == 3)
            {
                label2.Text = "7";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/77.png";
            }

            if (sayac == 4)
            {
                label2.Text = "2";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/22.png";
            }

            if (sayac == 5)
            {
                label2.Text = "8";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/88.png";
            }

            if (sayac == 6)
            {
                label2.Text = "6";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/66.png";
            }

            if (sayac == 7)
            {
                label2.Text = "4";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/44.png";
            }


            if (sayac == 8)
            {
                label2.Text = "9";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/99.png";
            }


            if (sayac == 9)
            {
                label2.Text = "5";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/55.png";
            }


            if (sayac == 10)
            {
                label2.Text = "9";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/9.png";
            }

            if (sayac == 11)
            {
                label2.Text = "1";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/11.png";
            }


            if (sayac == 12)
            {
                label2.Text = "5";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/5.png";
            }

            if (sayac == 13)
            {
                label2.Text = "2";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/2.png";
            }


            if (sayac == 14)
            {
                label2.Text = "7";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/7.png";
            }


            if (sayac == 15)
            {
                label2.Text = "3";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/3.png";
            }


            if (sayac == 16)
            {
                label2.Text = "6";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/6.png";
            }

            if (sayac == 17)
            {
                label2.Text = "4";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/4.png";
            }

            if (sayac == 18)
            {
                btnbaslat.Enabled = false;
                label2.Text = "8";
                label1.Text = "Resimde Ne Görüyorsun ?";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/8.png";
            }
            if (sayac == 19)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                btnbaslat.Enabled = false;

                label1.Text = "";
                label5.Text = "Test Bitti";
                pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/son.jpg";
                pictureBox2.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/icon.png";


                if (puan>=16)
                {
                    label6.Text = "Normal renk görüşünüz var, \n yani bir milyona kadar farklı renk tonu görebilirsiniz!";
                }
                else if (puan>=13 && puan<16)
                {
                    label6.Text = "Zayıf Protan tipi renk körlüğünüz var. \n Protan tipi renk körlüğü olan bir kişi, \n özellikle düşük ışıkta yeşillikleri," +
                        " sarıları, portakalları, kırmızıları ve kahveleri \n normalden daha benzer renk tonları olarak görme eğilimindedir";

                }
                else if (puan>=11 && puan<13)
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

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = button11.Text;

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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = button6.Text;
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = button7.Text;
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = button8.Text;
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = button9.Text;
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = button10.Text;
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
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
