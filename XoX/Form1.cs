using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Oyuncu1 { get; set; }
        public string Oyuncu2 { get; set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = Oyuncu1 + " : 0";
            label6.Text = Oyuncu2 + " : 0";
            int oyunSirasi = rnd.Next(2);
            if (oyunSirasi == 0)
                textBox1.Text = Oyuncu1;
            else
                textBox1.Text = Oyuncu2;
            int simge = rnd.Next(2);
            if (simge == 0)
                label4.Text = "O";
            else
                label4.Text = "X";
        }
        private void oyunBitir()
        {
            foreach (Control buttons in this.Controls)
                if (buttons is Button)
                {
                    if (buttons.Text == "X" || buttons.Text == "O")
                        buttons.Text = "";
                }
        }
        int oyuncu1Sayac = 0;
        int oyuncu2Sayac = 0;
        private void Oyna(object sender, EventArgs e)
        {
            Button seciliBtn = sender as Button;
            if (seciliBtn.Text == "")
            {
                    seciliBtn.Text = label4.Text;
                    label4.Text = label4.Text == "X" ? "O" : "X";
                    textBox1.Text = textBox1.Text == Oyuncu1 ? Oyuncu2 : Oyuncu1;
                if (b1.Text == b2.Text && b1.Text == b3.Text && b3.Text != "" || b4.Text == b5.Text && b4.Text == b6.Text && b6.Text != "" || b7.Text == b8.Text && b7.Text == b9.Text && b9.Text != "" || b1.Text == b4.Text && b1.Text == b7.Text && b7.Text != "" || b2.Text == b5.Text && b2.Text == b8.Text && b8.Text != "" || b3.Text == b6.Text && b3.Text == b9.Text && b9.Text != "" || b1.Text == b5.Text && b1.Text == b9.Text && b9.Text != "" || b3.Text == b5.Text && b3.Text == b7.Text && b7.Text != "")
                {
                    if (textBox1.Text == Oyuncu1)
                        oyuncu1Sayac++;
                    if (textBox1.Text == Oyuncu2)
                        oyuncu2Sayac++;
                     label6.Text = Oyuncu2 + " : " + oyuncu1Sayac;
                     label5.Text = Oyuncu1 + " : " + oyuncu2Sayac;
                    oyunBitir();
                }
            }
            bool kontrol = false;
            foreach (Control buttons in this.Controls)
                if (buttons is Button && ((Button)buttons).Text == "")
                {
                    kontrol = true; break;
                }
            if (kontrol == false)
                oyunBitir();
        }
    }
}
