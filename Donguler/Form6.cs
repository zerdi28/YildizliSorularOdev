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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            // Yan yana 5 adet X yazdırınız

            string gelen = "X";
            for (int i = 1; i < 5; i++)
            {
                gelen = gelen + "X";
                lblYaziAlani.Text = gelen;
            }



        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // Alt alta 5 adet X yazdırınız
            string gelen = "X";
            for (int i = 1; i < 5; i++)
            {
                gelen = gelen + "\n" + "X";
                lblYaziAlani.Text = gelen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verilen değere göre X ile kare çizdiriniz
            /*
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X 
             */
            string deger = "";
            for (int i = 1; i <= 5; i++)
            {
                deger = deger + "\n";
                lblYaziAlani.Text = deger;
                for (int j = 0; j <= 5; j++)
                {
                    deger = deger + "X";
                    lblYaziAlani.Text = deger;
                }
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            // X iler dik kenar üçgen yazdırınız
            /*
  
 
             X 
             X X
             X X X
             X X X X
             X X X X X
             X X X X X X
             X X X X X X X
             
             
             */
            string gelen = "";
            for (int i = 0; i < 5; i++)
            {
                gelen = "";
                for (int j = 5; j >= 5 - i; j--)
                {
                    gelen += "X";
                    
                }
                lblYaziAlani.Text = lblYaziAlani.Text + gelen + "\n";
            }
           

        }
        
        

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            // Listbox'a çarpım tablosonu ekleyiniz 1 ile 10(dahil) arası

            //    1 X 1  = 1 
            //    1 X 2  = 2 
            //    1 X 3  = 3 
            //    1 X 4  = 4 
            //    1 X 5  = 5 
            //    1 X 6  = 6 
            //    1 X 7  = 7 
            //    1 X 8  = 8 
            //    1 X 9  = 9 
            //    1 X 10 = 10
            //    ----------------------
            //    2 X 1  = 2 
            //    2 X 2  = 4 
            //    2 X 3  = 6 
            //    2 X 4  = 8 
            //    2 X 5  = 10 
            //    2 X 6  = 12
            //    2 X 7  = 14
            //    2 X 8  = 16
            //    2 X 9  = 18
            //    2 X 10 = 20
            //    ----------------------
            for (int i = 1; i < 10; i++)
            {
                for (int x = 1; x < 10; x++)
                {
                    int sonuc = i * x;
                    listBox1.Items.Add(i + "X" + x + "=" + sonuc);
                }
            }

        }
    }
}
