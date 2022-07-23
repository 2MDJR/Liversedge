using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using System.Media;

namespace Liversedge
{
    public partial class Main : Form
    {
        ExploitAPI module = new ExploitAPI();
        public Main()
        {
            InitializeComponent();
        }

        SoundPlayer sound = new SoundPlayer(Liversedge.Properties.Resources.bclick);

        Point lastPoint;
        private void button1_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(TextPlate.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                TextPlate.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(TextPlate.Text);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SH openform = new SH();
            openform.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextPlate.Text = File.ReadAllText($"./scripts/{ScriptBox.SelectedItem}");
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextPlate.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScriptBox.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(ScriptBox, "./scripts", "*.txt");
            Functions.PopulateListBox(ScriptBox, "./scripts", "*.lua");
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ScriptBox.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(ScriptBox, "./scripts", "*.txt");
            Functions.PopulateListBox(ScriptBox, "./scripts", "*.lua");
        }

        private void Script1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var pName = Process.GetProcesses().Where(p => p.ProcessName == "RobloxPlayerLauncher");
            foreach (var item in pName) item.Kill();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void TopmostBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.TopmostBox.Checked)
            {
                if (!this.TopmostBox.Checked)
                {
                    base.TopMost = false;
                }
            }
            else
            {
                base.TopMost = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

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

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.Liversedge_TRANSPARENT_Glow;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.Liversedge_TRANSPARENT;
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            sound.Play();
        }
    }
}
