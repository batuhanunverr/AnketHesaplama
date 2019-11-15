using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elkon_Anket_Sonuc_Hesaplama
{
    public partial class inovasyonproje : Form
    {
        int sayac = 1;
        soru soru1 = new soru();
        soru soru2 = new soru();
        soru soru3 = new soru();
        soru soru4 = new soru();
        soru soru5 = new soru();
        soru soru6 = new soru();
        soru soru7 = new soru();
        soru soru8 = new soru();
        soru soru9 = new soru();
        soru soru10 = new soru();
        soru soru11 = new soru();
        soru soru12 = new soru();
        soru soru13 = new soru();
        soru soru14 = new soru();
        soru soru15 = new soru();
        soru soru16 = new soru();
        soru soru17 = new soru();
        soru soru18 = new soru();
        soru soru19 = new soru();
        soru soru20 = new soru();
        soru soru21 = new soru();
        soru soru22 = new soru();
        soru soru23 = new soru();
        soru soru24 = new soru();
        soru soru25 = new soru();
        soru soru26 = new soru();
        soru soru27 = new soru();
        soru soru28 = new soru();
        soru soru29 = new soru();
        soru soru30 = new soru();
        soru soru31 = new soru();
        soru soru32 = new soru();
        soru soru33 = new soru();
        soru soru34 = new soru();
        soru soru35 = new soru();
        soru soru36 = new soru();
        soru soru37 = new soru();
        soru soru38 = new soru();
        soru soru39 = new soru();
        soru soru40 = new soru();
        soru soru41 = new soru();
        soru soru42 = new soru();
        soru soru43 = new soru();
        soru soru44 = new soru();
        soru soru45 = new soru();
        public int bdtstandartsapma, bdtortalama, bdtmedyan;
        public inovasyonproje()
        {
            InitializeComponent();
        }

        private void buttonhesapla_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            soru1.kkatima = Convert.ToInt32(textBox1.Text);
            soru1.katilma = Convert.ToInt32(textBox2.Text);
            soru1.kararsız = Convert.ToInt32(textBox3.Text);
            soru1.katil = Convert.ToInt32(textBox4.Text);
            soru1.kkatil = Convert.ToInt32(textBox5.Text);

            soru2.kkatima = Convert.ToInt32(textBox10.Text);
            soru2.katilma = Convert.ToInt32(textBox9.Text);
            soru2.kararsız = Convert.ToInt32(textBox8.Text);
            soru2.katil = Convert.ToInt32(textBox7.Text);
            soru2.kkatil = Convert.ToInt32(textBox6.Text);


            soru3.kkatima = Convert.ToInt32(textBox15.Text);
            soru3.katilma = Convert.ToInt32(textBox14.Text);
            soru3.kararsız = Convert.ToInt32(textBox13.Text);
            soru3.katil = Convert.ToInt32(textBox12.Text);
            soru3.kkatil = Convert.ToInt32(textBox11.Text);
            
          soru4.kkatima = Convert.ToInt32(textBox20.Text);
          soru4.katilma = Convert.ToInt32(textBox19.Text);
          soru4.kararsız = Convert.ToInt32(textBox18.Text);
          soru4.katil = Convert.ToInt32(textBox17.Text);
          soru4.kkatil = Convert.ToInt32(textBox16.Text);

       soru5.kkatima = Convert.ToInt32(textBox25.Text);
       soru5.katilma = Convert.ToInt32(textBox24.Text);
       soru5.kararsız = Convert.ToInt32(textBox23.Text);
       soru5.katil = Convert.ToInt32(textBox12.Text);
       soru5.kkatil = Convert.ToInt32(textBox11.Text);

       soru6.kkatima = Convert.ToInt32(textBox30.Text);
       soru6.katilma = Convert.ToInt32(textBox29.Text);
       soru6.kararsız = Convert.ToInt32(textBox28.Text);
       soru6.katil = Convert.ToInt32(textBox27.Text);
       soru6.kkatil = Convert.ToInt32(textBox26.Text);

       soru7.kkatima = Convert.ToInt32(textBox35.Text);
       soru7.katilma = Convert.ToInt32(textBox34.Text);
       soru7.kararsız = Convert.ToInt32(textBox33.Text);
       soru7.katil = Convert.ToInt32(textBox32.Text);
       soru7.kkatil = Convert.ToInt32(textBox31.Text);

       soru8.kkatima = Convert.ToInt32(textBox40.Text);
       soru8.katilma = Convert.ToInt32(textBox39.Text);
       soru8.kararsız = Convert.ToInt32(textBox38.Text);
       soru8.katil = Convert.ToInt32(textBox37.Text);
       soru8.kkatil = Convert.ToInt32(textBox36.Text);

       soru9.kkatima = Convert.ToInt32(textBox45.Text);
       soru9.katilma = Convert.ToInt32(textBox44.Text);
       soru9.kararsız = Convert.ToInt32(textBox43.Text);
       soru9.katil = Convert.ToInt32(textBox42.Text);
       soru9.kkatil = Convert.ToInt32(textBox41.Text);

       soru10.kkatima = Convert.ToInt32(textBox50.Text);
       soru10.katilma = Convert.ToInt32(textBox49.Text);
       soru10.kararsız = Convert.ToInt32(textBox48.Text);
       soru10.katil = Convert.ToInt32(textBox47.Text);
       soru10.kkatil = Convert.ToInt32(textBox46.Text);

       soru11.kkatima = Convert.ToInt32(textBox55.Text);
       soru11.katilma = Convert.ToInt32(textBox54.Text);
       soru11.kararsız = Convert.ToInt32(textBox53.Text);
       soru11.katil = Convert.ToInt32(textBox52.Text);
       soru11.kkatil = Convert.ToInt32(textBox51.Text);

       soru12.kkatima = Convert.ToInt32(textBox60.Text);
       soru12.katilma = Convert.ToInt32(textBox59.Text);
       soru12.kararsız = Convert.ToInt32(textBox58.Text);
       soru12.katil = Convert.ToInt32(textBox57.Text);
       soru12.kkatil = Convert.ToInt32(textBox56.Text);

       soru13.kkatima = Convert.ToInt32(textBox65.Text);
       soru13.katilma = Convert.ToInt32(textBox64.Text);
       soru13.kararsız = Convert.ToInt32(textBox63.Text);
       soru13.katil = Convert.ToInt32(textBox62.Text);
       soru13.kkatil = Convert.ToInt32(textBox61.Text);

       soru14.kkatima = Convert.ToInt32(textBox70.Text);
       soru14.katilma = Convert.ToInt32(textBox69.Text);
       soru14.kararsız = Convert.ToInt32(textBox68.Text);
       soru14.katil = Convert.ToInt32(textBox67.Text);
       soru14.kkatil = Convert.ToInt32(textBox66.Text);

       soru15.kkatima = Convert.ToInt32(textBox75.Text);
       soru15.katilma = Convert.ToInt32(textBox74.Text);
       soru15.kararsız = Convert.ToInt32(textBox73.Text);
       soru15.katil = Convert.ToInt32(textBox72.Text);
       soru15.kkatil = Convert.ToInt32(textBox71.Text);

       soru16.kkatima = Convert.ToInt32(textBox80.Text);
       soru16.katilma = Convert.ToInt32(textBox79.Text);
       soru16.kararsız = Convert.ToInt32(textBox78.Text);
       soru16.katil = Convert.ToInt32(textBox77.Text);
       soru16.kkatil = Convert.ToInt32(textBox76.Text);

       soru17.kkatima = Convert.ToInt32(textBox85.Text);
       soru17.katilma = Convert.ToInt32(textBox84.Text);
       soru17.kararsız = Convert.ToInt32(textBox83.Text);
       soru17.katil = Convert.ToInt32(textBox82.Text);
       soru17.kkatil = Convert.ToInt32(textBox81.Text);

       soru18.kkatima = Convert.ToInt32(textBox90.Text);
       soru18.katilma = Convert.ToInt32(textBox89.Text);
       soru18.kararsız = Convert.ToInt32(textBox88.Text);
       soru18.katil = Convert.ToInt32(textBox87.Text);
       soru18.kkatil = Convert.ToInt32(textBox86.Text);

       soru19.kkatima = Convert.ToInt32(textBox95.Text);
       soru19.katilma = Convert.ToInt32(textBox94.Text);
       soru19.kararsız = Convert.ToInt32(textBox93.Text);
       soru19.katil = Convert.ToInt32(textBox92.Text);
       soru19.kkatil = Convert.ToInt32(textBox91.Text);

       soru20.kkatima = Convert.ToInt32(textBox100.Text);
       soru20.katilma = Convert.ToInt32(textBox99.Text);
       soru20.kararsız = Convert.ToInt32(textBox98.Text);
       soru20.katil = Convert.ToInt32(textBox97.Text);
       soru20.kkatil = Convert.ToInt32(textBox96.Text);

       soru21.kkatima = Convert.ToInt32(textBox105.Text);
       soru21.katilma = Convert.ToInt32(textBox104.Text);
       soru21.kararsız = Convert.ToInt32(textBox103.Text);
       soru21.katil = Convert.ToInt32(textBox102.Text);
       soru21.kkatil = Convert.ToInt32(textBox101.Text);

       soru22.kkatima = Convert.ToInt32(textBox110.Text);
       soru22.katilma = Convert.ToInt32(textBox109.Text);
       soru22.kararsız = Convert.ToInt32(textBox108.Text);
       soru22.katil = Convert.ToInt32(textBox107.Text);
       soru22.kkatil = Convert.ToInt32(textBox106.Text);

       soru23.kkatima = Convert.ToInt32(textBox115.Text);
       soru23.katilma = Convert.ToInt32(textBox114.Text);
       soru23.kararsız = Convert.ToInt32(textBox113.Text);
       soru23.katil = Convert.ToInt32(textBox112.Text);
       soru23.kkatil = Convert.ToInt32(textBox111.Text);

       soru24.kkatima = Convert.ToInt32(textBox120.Text);
       soru24.katilma = Convert.ToInt32(textBox119.Text);
       soru24.kararsız = Convert.ToInt32(textBox118.Text);
       soru24.katil = Convert.ToInt32(textBox117.Text);
       soru24.kkatil = Convert.ToInt32(textBox116.Text);

       soru25.kkatima = Convert.ToInt32(textBox125.Text);
       soru25.katilma = Convert.ToInt32(textBox124.Text);
       soru25.kararsız = Convert.ToInt32(textBox123.Text);
       soru25.katil = Convert.ToInt32(textBox122.Text);
       soru25.kkatil = Convert.ToInt32(textBox121.Text);

       soru26.kkatima = Convert.ToInt32(textBox130.Text);
       soru26.katilma = Convert.ToInt32(textBox129.Text);
       soru26.kararsız = Convert.ToInt32(textBox128.Text);
       soru26.katil = Convert.ToInt32(textBox127.Text);
       soru26.kkatil = Convert.ToInt32(textBox126.Text);

       soru27.kkatima = Convert.ToInt32(textBox135.Text);
       soru27.katilma = Convert.ToInt32(textBox134.Text);
       soru27.kararsız = Convert.ToInt32(textBox133.Text);
       soru27.katil = Convert.ToInt32(textBox132.Text);
       soru27.kkatil = Convert.ToInt32(textBox131.Text);

       soru28.kkatima = Convert.ToInt32(textBox140.Text);
       soru28.katilma = Convert.ToInt32(textBox139.Text);
       soru28.kararsız = Convert.ToInt32(textBox138.Text);
       soru28.katil = Convert.ToInt32(textBox137.Text);
       soru28.kkatil = Convert.ToInt32(textBox136.Text);

       soru29.kkatima = Convert.ToInt32(textBox145.Text);
       soru29.katilma = Convert.ToInt32(textBox144.Text);
       soru29.kararsız = Convert.ToInt32(textBox143.Text);
       soru29.katil = Convert.ToInt32(textBox142.Text);
       soru29.kkatil = Convert.ToInt32(textBox141.Text);

       soru30.kkatima = Convert.ToInt32(textBox150.Text);
       soru30.katilma = Convert.ToInt32(textBox149.Text);
       soru30.kararsız = Convert.ToInt32(textBox148.Text);
       soru30.katil = Convert.ToInt32(textBox147.Text);
       soru30.kkatil = Convert.ToInt32(textBox146.Text);

       soru31.kkatima = Convert.ToInt32(textBox155.Text);
       soru31.katilma = Convert.ToInt32(textBox154.Text);
       soru31.kararsız = Convert.ToInt32(textBox153.Text);
       soru31.katil = Convert.ToInt32(textBox152.Text);
       soru31.kkatil = Convert.ToInt32(textBox151.Text);

       soru32.kkatima = Convert.ToInt32(textBox160.Text);
       soru32.katilma = Convert.ToInt32(textBox159.Text);
       soru32.kararsız = Convert.ToInt32(textBox158.Text);
       soru32.katil = Convert.ToInt32(textBox157.Text);
       soru32.kkatil = Convert.ToInt32(textBox156.Text);

       soru33.kkatima = Convert.ToInt32(textBox165.Text);
       soru33.katilma = Convert.ToInt32(textBox164.Text);
       soru33.kararsız = Convert.ToInt32(textBox163.Text);
       soru33.katil = Convert.ToInt32(textBox162.Text);
       soru33.kkatil = Convert.ToInt32(textBox161.Text);

       soru34.kkatima = Convert.ToInt32(textBox170.Text);
       soru34.katilma = Convert.ToInt32(textBox169.Text);
       soru34.kararsız = Convert.ToInt32(textBox168.Text);
       soru34.katil = Convert.ToInt32(textBox167.Text);
       soru34.kkatil = Convert.ToInt32(textBox166.Text);

       soru35.kkatima = Convert.ToInt32(textBox175.Text);
       soru35.katilma = Convert.ToInt32(textBox174.Text);
       soru35.kararsız = Convert.ToInt32(textBox173.Text);
       soru35.katil = Convert.ToInt32(textBox172.Text);
       soru35.kkatil = Convert.ToInt32(textBox171.Text);

       soru36.kkatima = Convert.ToInt32(textBox180.Text);
       soru36.katilma = Convert.ToInt32(textBox179.Text);
       soru36.kararsız = Convert.ToInt32(textBox178.Text);
       soru36.katil = Convert.ToInt32(textBox177.Text);
       soru36.kkatil = Convert.ToInt32(textBox176.Text);

       soru37.kkatima = Convert.ToInt32(textBox185.Text);
       soru37.katilma = Convert.ToInt32(textBox184.Text);
       soru37.kararsız = Convert.ToInt32(textBox183.Text);
       soru37.katil = Convert.ToInt32(textBox182.Text);
       soru37.kkatil = Convert.ToInt32(textBox181.Text);

       soru38.kkatima = Convert.ToInt32(textBox190.Text);
       soru38.katilma = Convert.ToInt32(textBox189.Text);
       soru38.kararsız = Convert.ToInt32(textBox188.Text);
       soru38.katil = Convert.ToInt32(textBox187.Text);
       soru38.kkatil = Convert.ToInt32(textBox186.Text);

       soru39.kkatima = Convert.ToInt32(textBox195.Text);
       soru39.katilma = Convert.ToInt32(textBox194.Text);
       soru39.kararsız = Convert.ToInt32(textBox193.Text);
       soru39.katil = Convert.ToInt32(textBox192.Text);
       soru39.kkatil = Convert.ToInt32(textBox191.Text);

       soru40.kkatima = Convert.ToInt32(textBox200.Text);
       soru40.katilma = Convert.ToInt32(textBox199.Text);
       soru40.kararsız = Convert.ToInt32(textBox198.Text);
       soru40.katil = Convert.ToInt32(textBox197.Text);
       soru40.kkatil = Convert.ToInt32(textBox196.Text);

       soru41.kkatima = Convert.ToInt32(textBox205.Text);
       soru41.katilma = Convert.ToInt32(textBox204.Text);
       soru41.kararsız = Convert.ToInt32(textBox203.Text);
       soru41.katil = Convert.ToInt32(textBox202.Text);
       soru41.kkatil = Convert.ToInt32(textBox201.Text);

       soru42.kkatima = Convert.ToInt32(textBox210.Text);
       soru42.katilma = Convert.ToInt32(textBox209.Text);
       soru42.kararsız = Convert.ToInt32(textBox208.Text);
       soru42.katil = Convert.ToInt32(textBox207.Text);
       soru42.kkatil = Convert.ToInt32(textBox206.Text);

       soru43.kkatima = Convert.ToInt32(textBox215.Text);
       soru43.katilma = Convert.ToInt32(textBox214.Text);
       soru43.kararsız = Convert.ToInt32(textBox213.Text);
       soru43.katil = Convert.ToInt32(textBox212.Text);
       soru43.kkatil = Convert.ToInt32(textBox211.Text);

       soru44.kkatima = Convert.ToInt32(textBox220.Text);
       soru44.katilma = Convert.ToInt32(textBox219.Text);
       soru44.kararsız = Convert.ToInt32(textBox218.Text);
       soru44.katil = Convert.ToInt32(textBox217.Text);
       soru44.kkatil = Convert.ToInt32(textBox216.Text);

       soru45.kkatima = Convert.ToInt32(textBox225.Text);
       soru45.katilma = Convert.ToInt32(textBox224.Text);
       soru45.kararsız = Convert.ToInt32(textBox223.Text);
       soru45.katil = Convert.ToInt32(textBox222.Text);
       soru45.kkatil = Convert.ToInt32(textBox221.Text);


             
            hesaplama(soru1);
            hesaplama(soru2);
            hesaplama(soru3);
              hesaplama(soru4);

                        hesaplama(soru5);
                        hesaplama(soru6);
                        hesaplama(soru7);
                        hesaplama(soru8);
                        hesaplama(soru9);
                       hesaplama(soru10);
                        hesaplama(soru11);
                        hesaplama(soru12);
                        hesaplama(soru13);
                        hesaplama(soru14);
                        hesaplama(soru15);
                        hesaplama(soru16);
                        hesaplama(soru17);
                        hesaplama(soru18);
                        hesaplama(soru19);
            hesaplama(soru20);
            hesaplama(soru21);
                        hesaplama(soru22);
                        hesaplama(soru23);
                        hesaplama(soru24);
                        hesaplama(soru25);
                        hesaplama(soru26);
                        hesaplama(soru27);
                        hesaplama(soru28);
                        hesaplama(soru29);
                        hesaplama(soru30);
                        hesaplama(soru31);
                        hesaplama(soru32);
                        hesaplama(soru33);
                        hesaplama(soru34);
                        hesaplama(soru35);
                        hesaplama(soru36);
                        hesaplama(soru37);
                        hesaplama(soru38);
                        hesaplama(soru39);
                        hesaplama(soru40);
                        hesaplama(soru41);
                        hesaplama(soru42);
                        hesaplama(soru43);
                        hesaplama(soru44);
                        hesaplama(soru45);
                        
        }
        public int hesaplama(soru q)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];




            q.ortalama = (q.kkatima + q.katilma + q.kararsız + q.katil + q.kkatil) / 5;
            q.toplam = q.kkatima + q.katilma + q.kararsız + q.katil + q.kkatil;
            double[] secimler = new double[5];
            secimler[0] = q.kkatima;
            secimler[1] = q.katilma;
            secimler[2] = q.kararsız;
            secimler[3] = q.katil;
            secimler[4] = q.kkatil;

            double ibre = 3.00;

            ibre = ibre + (-((q.kkatima * 2) / q.toplam) - ((q.katilma * 1) / q.toplam) + ((q.katil * 1) / q.toplam) + ((q.kkatil * 2) / q.toplam));


            if (ibre > 1 && ibre < 2)
            {

                MessageBox.Show("Muhasebe Bölümün Bu Sorusu için Ortalama Cevap = 'Kesinlikle Katılmıyorum - Katılmıyorum Arasındadır' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap =  'Kesinlikle Katılmıyorum - Katılmıyorum Arasındadır' ");
            }
            if (ibre > 2 && ibre < 3)
            {
                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Katılmıyorum - Kararsızım Arasındadır' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap = 'Katılmıyorum - Kararsızım' ");
            }
            if (ibre > 3 && ibre < 4)
            {
                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Kararsızım - Katılıyorum Arasındadır' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap = 'Kararsızım - Katılıyorum' ");
            }
            if (ibre > 4 && ibre < 5)
            {
                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Katılıyorum - Kesinlikle Katılıyorum Arasındadır' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap =  'Katılıyorum - Kesinlikle Katılıyorum Arasındadır' ");
            }
            if (ibre == 1)
            {
                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Kesinlikle Katılmıyorum' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap = 'Kesinlikle Katılmıyorum ' ");
            }
            if (ibre == 2)
            {
                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Katılmıyorum' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap = ' Katılmıyorum ' ");
            }
            if (ibre == 3)
            {

                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Kararsızım' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap =  'Kararsızım' ");
            }
            if (ibre == 4)
            {
                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Katılıyorum' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap = 'Katılıyorum' ");
            }
            if (ibre == 5)
            {
                MessageBox.Show("Bu Bölümün Bu Sorusu için Ortalama Cevap = 'Kesinlikle Katılıyorum' ", "soru" + sayac);
                f.ortalamalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Ortalama Cevap = 'Kesinlikle Katılıyorum' ");
            }


            double ort = q.ortalama;
            double toplam = 0.0;
            for (int y = 0; y < secimler.Length; y++)
                toplam += Math.Pow((secimler[y] - ort), 2);
            double x = Math.Sqrt(toplam / (secimler.Length - 1));
            MessageBox.Show("Bu Bölüm İçin Bu Sorunun Standart Sapması = " + x.ToString(), "soru" + sayac);
            f.standartsapmalistbox.Items.Add("İnovasyonProje Bölümün " + sayac + ".inci Sorusu için Standart Sapması = " + x.ToString());

            double[] medyandizi = new double[Convert.ToInt32(q.toplam)];
            double a = 1, b = 2, c = 3, d = 4, e = 5;
            int i = 0;
            for (int r = i; i < Convert.ToInt32(q.kkatima); r++)
            {
                medyandizi[r] = a;
                i++;
            }
            for (int r = i; i < Convert.ToInt32(q.katilma) + Convert.ToInt32(q.kkatima); r++)
            {
                medyandizi[r] = b;
                i++;
            }
            for (int r = i; i < Convert.ToInt32(q.kararsız) + Convert.ToInt32(q.katilma) + Convert.ToInt32(q.kkatima); r++)
            {
                medyandizi[r] = c;
                i++;
            }
            for (int r = i; i < Convert.ToInt32(q.katil) + Convert.ToInt32(q.kararsız) + Convert.ToInt32(q.katilma) + Convert.ToInt32(q.kkatima); r++)
            {
                medyandizi[r] = d;
                i++;
            }
            for (int r = i; i < Convert.ToInt32(q.kkatil) + Convert.ToInt32(q.katil) + Convert.ToInt32(q.kararsız) + Convert.ToInt32(q.katilma) + Convert.ToInt32(q.kkatima); r++)
            {
                medyandizi[r] = e;
                i++;
            }
            double gecici;
            for (i = 0; i < medyandizi.Length - 1; i++)
            {
                for (int j = i; j < medyandizi.Length; j++)
                {
                    // >(büyük) işareti <(küçük ) olarak değiştirilirse büyükten küçüğe sıralanır
                    if (medyandizi[i] > medyandizi[j])
                    {
                        gecici = medyandizi[j];
                        medyandizi[j] = medyandizi[i];
                        medyandizi[i] = gecici;
                    }

                }

            }

            int medyannn = (medyandizi.Length - 1) / 2;
            int medyan = Convert.ToInt32(medyandizi[medyannn]);
            if (medyan == 1)
            {
                MessageBox.Show("Bu Bölüm İçin" + sayac + ". Sorunun Medyanı = Kesinlikle Katılmıyorum");
                f.medyanlistbox.Items.Add("İnovasyonProje Bölüm İçin" + sayac + ". Sorunun Medyanı = Kesinlikle Katılmıyorum");
            }
            if (medyan == 2)
            {
                MessageBox.Show("Bu Bölüm İçin" + sayac + ". Sorunun Medyanı = Katılmıyorum");
                f.medyanlistbox.Items.Add("İnovasyonProje Bölüm İçin" + sayac + ". Sorunun Medyanı = Katılmıyorum");
            }
            if (medyan == 3)
            {
                MessageBox.Show("Bu Bölüm İçin" + sayac + ". Sorunun Medyanı = Kararsızım");
                f.medyanlistbox.Items.Add("İnovasyonProje Bölüm İçin" + sayac + ". Sorunun Medyanı = Kararsızım ");
            }
            if (medyan == 4)
            {
                MessageBox.Show("Bu Bölüm İçin" + sayac + ". Sorunun Medyanı = Katılıyorum");
                f.medyanlistbox.Items.Add("İnovasyonProje Bölüm İçin" + sayac + ". Sorunun Medyanı = Katılıyorum ");
            }
            if (medyan == 5)
            {
                MessageBox.Show("Bu Bölüm İçin" + sayac + ". Sorunun Medyanı = Kesinlikle Katılıyorum");
                f.medyanlistbox.Items.Add("İnovasyonProje Bölüm İçin" + sayac + ". Sorunun Medyanı = Kesinlikle Katılıyorum");
            }

            sayac++;




            //MessageBox.Show("Ortalama" + mak);


            return 0;
        }
    }
    }

