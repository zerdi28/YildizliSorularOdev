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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        /*
     FOREACH
     1) Kesinlikle index mantigi yoktur!
     2) Tip bagimli dongulerdir...
     3) Cogu zaman elimizdeki bir koleksiyonun her bir elemanini tek tek ele almak icin kullanilir...
 */

        string[] sehirler = {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce" };

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirler.Length; i++)
            {
                string sehir = sehirler[i];

                listBox1.Items.Add(sehir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 0;
            while (i < sehirler.Length)
            {
                string sehir = sehirler[i];
                listBox1.Items.Add(sehir);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //İkiye bolunenleri listbox1'e bolunemeyenleri listbox2 ye atın... Hem ikiye hem uce bolunenlerin kac tane oldugunu da messagebox'la gosterin...
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };

            int tamBolunen = 0;
            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    tamBolunen++;
                }
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }

            }
            MessageBox.Show(tamBolunen.ToString());
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Listbox1'deki secili tum elemanlari (birden fazla secim sansi olmali!) listbox2'ye ekleyelim...
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Remove(item);
            }

        }
        Random
            rnd
            =
            new Random();
        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //Form uzerindeki tum butonlarin arkaplanlari ve yazi renklerini degistiriniz...
            foreach (Control item in Controls)
            {
                if(item is Button)
                {
                    item.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }
    }
}
