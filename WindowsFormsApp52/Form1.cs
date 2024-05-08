using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap privet = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = privet;
            Graphics cute = Graphics.FromImage(privet);
            Pen obwodka = new Pen(Color.Red);
            SolidBrush zalivka = new SolidBrush(Color.SkyBlue);
            SolidBrush zalivkaG= new SolidBrush(Color.Green);
            cute.FillRectangle(zalivka, KarX.Value, KarY.Value, Razmer.Value, Razmer.Value);
            cute.DrawRectangle(obwodka, KarX.Value, KarY.Value, Razmer.Value, Razmer.Value);
            cute.DrawLine(obwodka, KarX.Value, KarY.Value, KarX.Value + Razmer.Value, KarY.Value + Razmer.Value);
            cute.DrawLine(obwodka, KarX.Value+Razmer.Value, KarY.Value, KarX.Value, KarY.Value + Razmer.Value);
            cute.FillEllipse(zalivkaG, KarX.Value + (Razmer.Value / 3), KarY.Value + Razmer.Value/20, Razmer.Value/3, Razmer.Value/3);
            cute.FillEllipse(zalivkaG, KarX.Value + (Razmer.Value / 3), KarY.Value + Razmer.Value*3/5 , Razmer.Value / 3, Razmer.Value / 3);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KarX.Maximum = pictureBox1.Width;
            KarY.Maximum = pictureBox1.Height;
            Razmer.Maximum = 300;
        }

        private void Razmer_ValueChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void KarX_ValueChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void KarY_ValueChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
