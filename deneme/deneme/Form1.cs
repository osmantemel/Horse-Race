using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        Random sayi = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            string kazanan;
            int para=Convert.ToInt32(tutar.Text);
            int kazanılanpara=0;
            kazanılanpara = para * Convert.ToInt32(oran1.Text);
            pictureBox1.Left += sayi.Next(5, 15);
            pictureBox3.Left += sayi.Next(5, 15);
            pictureBox2.Left += sayi.Next(5, 15);
            if (pictureBox1.Left > pictureBox3.Left && pictureBox1.Left > pictureBox2.Left)
            {
                label5.Text = "1. AT ÖNDE ";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                label5.Text = "3. AT ÖNDE ";
            }
            if (pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox1.Left)
            {
                label5.Text = "2. AT ÖNDE ";
            }
            if (pictureBox1.Left >= label1.Width - pictureBox1.Width)
            {
                kazanan = "1";
                label5.Text = "1. AT KAZANDI!!!";
                timer1.Enabled = false;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                panel2.Visible = true;
                if (atnumarasi.Text == kazanan)
                {
                    metin.Text = "TEBRİKLER...";
                    metin2.Text = Convert.ToString(kazanılanpara);
                    metin3.Text = "TL_KAZANDINIZ:)";
                }
                else
                {
                    metin.Text = "ÜZGÜNÜZ";
                    metin2.Text = "KAYBETTİNİZ";
                    metin3.Text = "!!!";
                }






            }


            if (pictureBox2.Left >= label1.Width - pictureBox1.Width)
            {
                kazanan="2";
                label5.Text = "2. AT KAZANDI!!!";
                timer1.Enabled = false;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                panel2.Visible = true;
                if(atnumarasi.Text==kazanan)
                {
                metin.Text = "TEBRİKLER...";
                metin2.Text = Convert.ToString(kazanılanpara);
                metin3.Text = "TL_KAZANDINIZ:)";
                }
                else
                {
                    metin.Text = "ÜZGÜNÜZ";
                    metin2.Text = "KAYBETTİNİZ";
                    metin3.Text = "!!!";
                }

            }
            if (pictureBox3.Left >= label1.Width - pictureBox1.Width)
            {
                kazanan= "3";
                label5.Text = "3. AT KAZANDI!!!";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                timer1.Enabled = false; 

                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                panel2.Visible = true;

                if (atnumarasi.Text == kazanan)
                {
                    metin.Text = "TEBRİKLER...";
                    metin2.Text = Convert.ToString(kazanılanpara);
                    metin3.Text = "TL_KAZANDINIZ:)";
                }
                else
                { 
                    metin.Text = "ÜZGÜNÜZ";
                    metin2.Text = "KAYBETTİNİZ";
                    metin3.Text = "!!!";
                }
            }
           
        }
        Random oran = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            panel2.Visible= false;
            string sayi1, sayi2;
            oran1.Text = Convert.ToString(oran.Next(2, 10));
            oran2.Text = Convert.ToString(oran.Next(2, 10));
            oran3.Text = Convert.ToString(oran.Next(2, 10));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
        }
    }
}
