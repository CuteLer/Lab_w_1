using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*label1.Text = "Начало работы.";
            BackColor = Color.FromArgb(255,249, 249, 255);
            label1.ForeColor = Color.FromArgb(137, 110, 105);
            button1.ForeColor = Color.FromArgb(255, 213, 84, 72);
            button2.ForeColor = Color.FromArgb(255, 213, 84, 72);*/

            label1.Text = "Начало работы.";
            BackColor = Color.FromArgb(137, 110, 105);
            label1.ForeColor = Color.FromArgb(255, 249, 249, 255);
            button1.ForeColor = Color.FromArgb(255, 249, 249, 255);
            button2.ForeColor = Color.FromArgb(255, 249, 249, 255);
            button1.BackColor = Color.FromArgb(157, 130, 125);
            button2.BackColor = Color.FromArgb(157, 130, 125);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.FromArgb(213, 84, 72);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.FromArgb(249, 249, 255);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.FromArgb(213, 84, 72);
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.FromArgb(249, 249, 255);
        }
    }
}
