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
    public partial class Oyunu_Baslat : Form
    {
        public Oyunu_Baslat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3 && textBox2.Text.Length >= 3)
            {
                if (textBox1.Text == textBox2.Text)
                    MessageBox.Show("Oyuncu isimleri aynı olamaz.", "@kodzamani.tk");
                else
                {
                    Form1 frm = new Form1();
                    frm.Oyuncu1 = textBox1.Text;
                    frm.Oyuncu2 = textBox2.Text;
                    frm.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Lütfen oyuncu isimlerini 3 karakterden fazla olarak ayarlayın.", "@kodzamani.tk");
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
    }
}
