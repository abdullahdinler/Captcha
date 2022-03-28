using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] smb = {"A", "B", "C", "D", "F", "G", "E", "H", "L", "K", "M", "N"};
            string[] smb2 = {"a", "b", "c", "d", "f", "g", "e", "h", "l", "k", "m", "n"};
            string[] smb3 = { "-", "%", "#", "@", "!", "_", "*", "&", "=", "+", "~", "^" };
            int s1, s2, s3, s4;
            Random rnd = new Random();
            s1 = rnd.Next(0, smb.Length);
            s2 = rnd.Next(0, smb2.Length);
            s3 = rnd.Next(0, smb3.Length);
            s4 = rnd.Next(0, 10);

            string hepsi = smb[s1] + smb2[s2] + smb3[s3] + s4.ToString();
            label1.Text = hepsi;
            label1.BackColor=Color.GreenYellow;


        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == textBox1.Text)
            {
                MessageBox.Show("Doğrulama Başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Doğrulama Başarısız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
