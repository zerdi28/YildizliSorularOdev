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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };
            for (int i = 0; i < takimlar.Length; i++)
            {
                listBox1.Items.Add(takimlar[i]);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };

            int enBuyukEleman = 0;

            for (int i = 0; i < sayisal.Length; i++)
            {
                if (enBuyukEleman < sayisal[i])
                {
                    enBuyukEleman = sayisal[i];
                }
            }
            MessageBox.Show("dizi içerisinde yer alan en büyük eleman " + enBuyukEleman);
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
            int tekSayi = 0, ciftSayi = 0;
            for (int i = 0; i < sayisal.Length; i++)
            {
                if (sayisal[i] % 2 == 0) { ciftSayi++; }
                else { tekSayi++; }
            }
            MessageBox.Show($"dizi içerisinde toplamda yer alan çift sayı adedi : {ciftSayi}\ndizi içerisinde toplamda yer alan tek sayı adedi : {tekSayi}");
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //asagidaki "adim" degiskeninde yer alan metni tersten isterseniz formun tepesine, isterseniz MessageBox'la yazdiriniz...

            //NOT => STRING'LER BİRER CHAR DİZİSİDİR...
            string adim = "bilgeadam";
            string yeniAd = "";
            for (int i = adim.Length - 1; i >= 0; i--)
            {
                yeniAd += adim[i];
            }
            MessageBox.Show(yeniAd);
        }
        Random rnd = new Random();
        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(100));
            }
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button)
                {
                    Controls[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...
            int toplam = 0;
            for (int i = 0; i < txtGirisAlani.Text.Length; i++)
            {
                toplam += Convert.ToInt32(txtGirisAlani.Text[i].ToString());
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
