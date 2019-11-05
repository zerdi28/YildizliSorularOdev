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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        /*
           DOWHILE
           While'ın isleyis prensibi olarak tam tersi mantıkla calisir...
           Oncelikle isleminizi sarta bakmaksizin en az bir defa calistirir, daha sonraki tum islemlerine sarta bagimli olarak gerceklestirir. Bu sebeple, DİKKATLİ KULLANMAKTA FAYDA VAR!
           Cok sık tercih edilen bir dongu tipi degildir...
         */
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i < 100);
        }
    }
}
/*
 
            string username = "";
            int index = 1;
            do
            {
                Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz : ");
                username = Console.ReadLine();
                index++;

            } while (username != "admin");


            Console.WriteLine("Kullanıcı adınızı tam {0} kere denedikten sonra girebildiniz afferin", index);
            Console.ReadLine();

*/
