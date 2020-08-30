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
    public partial class disleksi : Form
    {
        public disleksi()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int puan = 0;

        private void disleksi_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 21, 21);
            label1.Text = "Teste Başlamaya Hazır Mısın ? :)";


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            sayac++;
            btnbaslat.Text = "Sonraki";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            btnbaslat.Enabled = false;
            label5.Text = "Test İlerlemeniz " + sayac + "/18";




            if (sayac == 1)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Sağ ve sol ayrımı yapmakta \nzorlanıyor musunuz ?";

            }

            btnbaslat.Text = "Sonraki";

            if (sayac == 2)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Harita takibinde veya yol  \nbulmakta zorlanıyor musun ?";
            }

            if (sayac == 3)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Yüksek sesle okumaktan rahatsızlık \nduyuyor musun ?";
            }

            if (sayac == 4)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Bir sayfayı okumanız normalden \ndaha fazla süre mi alıyor ?";
            }

            if (sayac == 5)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Okumakta olduğunuz konuyu takip \netmekte zorlanıyor musunuz ?";
            }

            if (sayac == 6)
            {

                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Uzun kitapları okumaktan \nsıkılır mısınız ?";

            }

            if (sayac == 7)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Yazınız ve imlanız zayıf mı ? ";     
            }


            if (sayac == 8)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "El yazınız Okunaksız mı ?";
            }


            if (sayac == 9)
            {
                label2.Text = "EVET";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Kalabalık karşısında rahat \nkonuşabiliyor musunuz ?";
            }


            if (sayac == 10)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Telefonda başkaları için not alıp gerekli \nkişilere iletmekte zorlanıyor musunuz ?";
            }

            if (sayac == 11)
            {
                label2.Text = "EVET";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Uzunca bir kelimeyi rahatlıkla \nsöyleyebiliyor musunuz ?";
            }


            if (sayac == 12)
            {
                label2.Text = "EVET";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Kafanızdan rahatlıkla hesap \nyapabiliyor musunuz ?";
                }

            if (sayac == 13)
            {
                label2.Text = "EVET";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Ayları peş peşe zorlanmadan \nsöyleyebiliyor musunuz ?";
             }



            if (sayac == 14)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Ayları sondan başlayıp geri sıralamakta \nzorluk çekiyor musunuz ?";
            }


            if (sayac == 15)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Hiç tarihleri karıştırıp randevularınızı \nkaçırdığınız oluyor mu ?";
            }


            if (sayac == 16)
            {
                label2.Text = "HAYIR";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Form doldururken zorluk \nçekiyor musunuz ?";
            }

            if (sayac == 17)
            {
                label2.Text = "4";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Örneğin görme bozukluğunuz \nolmamasına rağmen  59 ile 95 gibi \notobüs numaralarını \n karıştırıyor musunuz ?";
            }

            if (sayac == 18)
            {
                btnbaslat.Enabled = false;
                label2.Text = "8";
                label1.Text = "Doğru sonuç için soruları kendi \nyaşamınıza göre cevaplayınız.";
                labelsoru.Text = "Öğrenciyken çarpım tablosunu \nezberlemekte sıkıntı yaşamış mıydınız ?";
            }
            if (sayac == 19)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
               
                btnbaslat.Enabled = false;

                labelsoru.Text = "";
                label1.Text = "";
                label5.Text = "Test Bitti";
                label7.Text= "Test sonuçlarının tıbbi kesin bir bilgi vermediğini \ntekrar hatırlatmak isteriz.Bu testler kendinizle " +
                                "ilgili \nfarkındalığınızı artırmak içindir,tek başına \ntanı koydurmaz. Doğru tanı ve tedavi için bir " +
                               "uzmana \nbaşvurmanızı tavsiye ederiz. Sağlıklı günler dileriz.";
                pictureBox2.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images/unnamed.png";



                if (puan >= 9)
                {
                    label6.Text = "Testte 9 puandan daha fazla puan aldınız. \nTestin toplamında 9 ve daha fazla puan almak \ndisleksi tipi bir zorluk olmadığını gösterir.";

                }


                else
                {
                    label6.Text = "Testte 9 puandan daha az puan aldınız. \nTestin toplamında 9 puandan daha az \npuan almak disleksi tipi bir zorluk \nyaşandığının göstergesidir.";

                }


            }
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
        }
    }
}
