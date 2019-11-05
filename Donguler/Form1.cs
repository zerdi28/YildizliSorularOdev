using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DONGULER - LOOPS
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR - FOREACH - WHILE - DOWHILE
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {

            // 1. bölüm başlangıç noktası
            // 2. bölüm karşılaştırma
            // 3. bölüm iterasyon

            for (int i = 1; i <= 1000; i++)
            {
                listBox1.Items.Add(i);
            }

        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // 1000 ile 1 arasındaki sayıları listbox'a ekleyiniz

            for (int i = 1000 - 1; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }

        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            // 0 ile 1000 arasındaki çift sayıları ekrana yazdırınız!
            for (int i = 0; i <= 1000; i += 2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            // A'dan Z'ye alfabeyi listbox'a yazdırınız :)
            for (char i = 'A'; i <= 'Z'; i++)
            {
                listBox1.Items.Add($"{i} - {Convert.ToInt32(i)}");
            }
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki sayilarin toplamini ekrana yazdiriniz..
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
            }
            MessageBox.Show("Toplam : " + toplam);
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, tek sayilarin toplaminin farklari karesi kactir?

            int tekSayilar = 0;
            int ciftSayilar = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftSayilar += i;
                }
                else
                {
                    tekSayilar += i;
                }
            }
            int sonuc = (ciftSayilar - tekSayilar) * (ciftSayilar - tekSayilar);
            MessageBox.Show("İşlem sonucu : " + sonuc);
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar Listbox'a eklensin ancak 1990 ve 1992 yılları eklenmeyecek...
            for (int i = 1945; i <= DateTime.Now.Year; i++)
            {
                if (i != 1990 &&  i != 1992)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}

