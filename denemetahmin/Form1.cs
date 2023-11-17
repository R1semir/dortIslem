using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemetahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        int puan = 0;
        int sure = 30;


        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            button2.Enabled = true;
            int sayi1, sayi2, islem;
            int a, b;
            int toplam, çıkar, çarp, bol;

            sayi1 = rastgele.Next(0, 51);
            sayi2 = rastgele.Next(0, 51);
            islem = rastgele.Next(1, 5);    // 1= topla   2= çıkar   3=çarp  4=böl

            label1.Text = sayi1.ToString();
            label3.Text = sayi2.ToString();

            a = Convert.ToInt32(label1.Text);
            b = Convert.ToInt32(label3.Text);
 
            if (islem == 1)
            {
                label2.Text = "+";
                toplam = a + b;
                label5.Text = toplam.ToString();
            }

            if(islem == 2)
            {
                label2.Text = "-";
                çıkar = a - b;
                label5.Text = çıkar.ToString();
            }
            if(islem == 3)
            {
                label2.Text = "*";
                çarp = a * b;
                label5.Text = çarp.ToString();
            }
            if (islem == 4)
            {
                label2.Text = "/";
                bol = a / b;
                label5.Text = bol.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if(label5.Text== textBox1.Text)
            {
                puan += 10;
                label7.Text = puan.ToString();
            }
            else
            {
                puan -= 10;
                label7.Text = puan.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label8.Text = sure.ToString();
            if (sure == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                timer1.Stop();
                sure = 30;
                button4.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button3.Enabled = false;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Start();
            sure = 30;
            button4.Visible = false;
            puan = 0;
            label7.Text = puan.ToString();
            label3.Text = "0";
            label1.Text = "0";
            textBox1.Clear();
        }
    }
}
