using System;
using System.Drawing;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            // Sonsuz döngü
            //while (true)
            //{
            //    listBox1.Items.Add("A");
            //}

            //for (; ; )
            //{
            //    listBox1.Items.Add("A");
            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            int i = 1;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }
        Random rnd = new Random();
        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // form üzerinde yer alan, butonları renklendirin :)

            //for (int i = 0; i < Controls.Count; i++)
            //{
            //    if (Controls[i] is Button)
            //    {
            //        Controls[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //    }
            //}

            int i = 0;
            while (i < Controls.Count)
            {
                if (Controls[i] is Button)
                {
                    Controls[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
                i++;
            }

        }
    }
}
