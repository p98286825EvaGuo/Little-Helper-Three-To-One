using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        int sec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar_panel.Visible = true;
            progressBar_panel.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Enabled = true;
            percentage_label.BackColor = loading_label.BackColor = Color.Transparent;
            menu_panel.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            //percentage_label.ForeColor = Color.FromArgb(255, 145, 159, 198);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            switch (sec)
            {
                case 1:
                    Bar1.Visible = true;
                    percentage_label.Text = (sec * 25).ToString() + "%";
                    break;
                case 2:
                    Bar2.Visible = true;
                    percentage_label.Text = (sec * 25).ToString() + "%";
                    break;
                case 3:
                    Bar3.Visible = true;
                    percentage_label.Text = (sec * 25).ToString() + "%";
                    break;
                case 4:
                    Bar4.Visible = true;
                    percentage_label.Text = (sec * 25).ToString() + "%";
                    break;
                case 5:
                    progressBar_panel.Visible = false;
                    timer1.Enabled = false;
                    menu_panel.Visible = true;
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    //this.BackColor = Color.FromArgb(50, 0, 0, 0);
                    this.Opacity = 0.7;
                    break;
            }
        }
    }
}
