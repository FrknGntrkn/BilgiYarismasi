using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void LblB_Click(object sender, EventArgs e)
        {
            LblA.Enabled = false;
            LblB.Enabled = false;
            LblC.Enabled = false;
            LblD.Enabled = false;
            LblSonraki.Enabled = true;

            label3.Text = LblB.Text;
            if (label2.Text == label3.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void LblC_Click(object sender, EventArgs e)
        {
            LblA.Enabled = false;
            LblB.Enabled = false;
            LblC.Enabled = false;
            LblD.Enabled = false;
            LblSonraki.Enabled = true;

            label3.Text = LblC.Text;
            if (label2.Text == label3.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void LblD_Click(object sender, EventArgs e)
        {
            LblA.Enabled = false;
            LblB.Enabled = false;
            LblC.Enabled = false;
            LblD.Enabled = false;
            LblSonraki.Enabled = true;

            label3.Text = LblD.Text;
            if (label2.Text == label3.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void LblA_Click(object sender, EventArgs e)
        {
            LblA.Enabled= false;
            LblB.Enabled = false;
            LblC.Enabled = false;
            LblD.Enabled = false;
            LblSonraki.Enabled = true;

            label3.Text = LblA.Text;
            if(label2.Text==label3.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void LblSonraki_Click(object sender, EventArgs e)
        {
            LblA.Enabled = true;
            LblB.Enabled = true;
            LblC.Enabled = true;
            LblD.Enabled = true;
            LblSonraki.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;

            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1) 
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                LblA.Text = "1920";
                LblB.Text = "1921";
                LblC.Text = "1922";
                LblD.Text = "1923";
                label2.Text = "1923";
              
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il ege bölgesinde değildir?";
                LblA.Text = "İzmir";
                LblB.Text = "Balıkesir";
                LblC.Text = "Aydın";
                LblD.Text = "Manisa";
                label2.Text = "Balıkesir";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                LblA.Text = "Sait Faik";
                LblB.Text = "Cemal Süreyya";
                LblC.Text = "atilla İlhan";
                LblD.Text = "Reşat Nuri";
                label2.Text = "Sait Faik";
                LblSonraki.Text = "Sonuçlar";
            }
            if (soruno==4)
            {
                LblA.Enabled = false;
                LblB.Enabled = false;
                LblC.Enabled = false;
                LblD.Enabled = false;
                LblSonraki.Enabled = false;
                MessageBox.Show("Doğrular: " + dogru + "\n" + "Yanlışlar: " + yanlis);
            }
        }
    }
}
