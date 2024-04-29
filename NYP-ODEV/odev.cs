using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_ODEV
{
    public partial class odev : Form
    {
        public odev()
        {
            InitializeComponent();
        }

        private int adetHesapla()
        {
            int metin = richTextBox1.Text.IndexOf(txt2AnaEkran.Text);
            int adet = 0;
            while(metin != -1) {
                metin = richTextBox1.Text.IndexOf(txt2AnaEkran.Text, metin + 1);
                adet++;
                }
            return adet;
        }

        private string ilkIndex()
        {
            string gecenIndex;
            int IlkIndex = richTextBox1.Text.IndexOf(txt2AnaEkran.Text);

            bool AraIfade = richTextBox1.Text.Contains(txt2AnaEkran.Text);

            if (AraIfade == true)
            {
                gecenIndex = IlkIndex.ToString();
            } else
            {
                gecenIndex = "";
            }

            return gecenIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txt1AnaEkran_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn2AnaEkran_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void txtAnalizSonuçları_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt2AnaEkran_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1Analiz_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

        }

        private void btn2Analiz_Click(object sender, EventArgs e)
        {
            txtAnalizSonuclari.Text = " ";

        }

        private void btn3Analiz_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn1AnaEkran_Click(object sender, EventArgs e)
        {

              if (kontrol() == true)
              {
                  int uzunluk = metinUzunluk();
                  int ifadeninUzunlugu = arananIfadeUzunluk();
                  string ilkIndexD = ilkIndex();
             
             
             
                  string textteYazdir = "Arama yapılacak metin: " + richTextBox1.Text + Environment.NewLine + "Aranacak ifade: " + txt2AnaEkran.Text + Environment.NewLine + "Metnin Uzunlugu: " + uzunluk + Environment.NewLine +
                      "Aranacak ifade uzunlugu: " + ifadeninUzunlugu + Environment.NewLine + "Aranan ifadenin gectigi ilk yer: " + ilkIndexD + Environment.NewLine + "Metin aranan ifadeden " + adetHesapla() + " tane içeriyor." +
                      Environment.NewLine + Environment.NewLine;
             
                  txtAnalizSonuclari.Text += textteYazdir;
             
                  string KaydetLog = "Aranan ifade " + txt2AnaEkran.Text + " , metinde " + adetHesapla() + " kez geçmiştir. Metin " + uzunluk + " uzunluğundadır.";
                  listLoglama.Items.Add(KaydetLog);
             
              }
              else
              {
                txtAnalizSonuclari.Text += "Aranan değer bulunamadı.";
              }

        }

        private void btn1Loglama_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn2Loglama_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn3Loglama_Click(object sender, EventArgs e)
        {
            listLoglama.Clear();

        }

        private bool kontrol()
        {
            int KontrolSayi;
            char KontrolKarakter;

            bool K = int.TryParse(txt2AnaEkran.Text, out KontrolSayi);
            bool M = char.TryParse(txt2AnaEkran.Text, out KontrolKarakter);


            //1.checkBox seçildiğinde olacaklar
            if (checkBox1.Checked)
            {
                if (K == true || M == true)
                {
                    MessageBox.Show("Aranan ifade metin değil.");
                    return false;
                }
            }
            //2.checkBox seçildiğinde olacaklar
            else if (checkBox2.Checked) 
            {
                if (!(int.TryParse(txt2AnaEkran.Text, out KontrolSayi)))
                {
                    MessageBox.Show("Aranan ifade sayı değil.");
                    return false;

                }
            }
            //3.checkBox seçildiğinde olacaklar
            else if (checkBox3.Checked)
            {
                if (!(char.TryParse(txt2AnaEkran.Text, out KontrolKarakter)))
                {
                    MessageBox.Show("Aranan ifade karakter değil.");
                    return false;

                }
            }
            //checkBox seçilmediğinde olacaklar
            else
            {
                MessageBox.Show("Bir  check box seçmelisiniz.");
            }
            return true;

        }

        //Metnin uzunluğunu bulan fonksiyon
        private int metinUzunluk()
        {
            return richTextBox1.Text.Length;
        }

        //Aranan ifadenenin uzunluğunu bulan fonksiyon
        private int arananIfadeUzunluk()
        {
            return txt2AnaEkran.Text.Length;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listAnaliz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listLoglama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void odev_Load(object sender, EventArgs e)
        {
            Bildirim.ShowBalloonTip(1, "Programa Hoş Geldiniz!", "Nesne Yönelimli Programlama Odev1", ToolTipIcon.Info);
        }
    }
}
