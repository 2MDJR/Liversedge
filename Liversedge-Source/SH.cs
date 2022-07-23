using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using System.Media;

namespace Liversedge
{
    public partial class SH : Form
    {
        ExploitAPI module = new ExploitAPI();
        public SH()
        {
            InitializeComponent();
        }

        SoundPlayer sound = new SoundPlayer(Liversedge.Properties.Resources.bclick);

        Point lastPoint;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
            module.SendLuaScript(Script);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SH_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SH_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.Liversedge_TRANSPARENT_Glow;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.Liversedge_TRANSPARENT_Glow;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.Liversedge_TRANSPARENT;
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sound.Play();
        }
    }
}
