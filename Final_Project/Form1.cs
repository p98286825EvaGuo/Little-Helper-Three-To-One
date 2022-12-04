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
        const int maxNumber = 35;
        int showNumber = 35;
        int todayOfWeek = 1;
        Button[] calendar = new Button[maxNumber];
        Label[] week = new Label[7];
        string[] weekName = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
        string textFont = "Arial";
        DateTime localDate = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*progressBar_panel.Visible = true;
            progressBar_panel.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Enabled = true;
            percentage_label.BackColor = loading_label.BackColor = Color.Transparent;
            menu_panel.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(255, 145, 159, 198);
            percentage_label.ForeColor = Color.FromArgb(255, 145, 159, 198);*/
            progressBar_panel.Visible = false;
            menu_panel.Visible = true;
            menu_panel.Size = ClientSize;
            CreateWeekLabel();
            CreateCalendar();
        }
        private void CreateWeekLabel()//創建星期的label
        {
            int labelHeight = menu_panel.Height / (showNumber / 7) / 5;
            int labelWidth = (menu_panel.Height - labelHeight) / (showNumber / 7);
            for (int i = 0; i < 7; i++) {
                week[i] = new Label
                {
                    Text = weekName[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font(textFont, (int)(labelHeight * 0.6)),
                    Size = new Size(labelWidth, labelHeight),
                    Location = new Point((menu_panel.Width - 7 * labelWidth) / 2 + i * labelWidth, 0)
                };
                menu_panel.Controls.Add(week[i]);
            }
        }
        private void CreateCalendar()//創建日期的Button
        {
            //計算第一格的日期
            int todayPosition = todayOfWeek * 7 + (int)localDate.DayOfWeek;
            DateTime startDate = localDate.AddDays(-todayPosition);
            int buttonSize = (menu_panel.Height - week[0].Height) / (showNumber / 7);
            for (int i = 0; i < maxNumber; i++)
            {
                string text = $"{startDate.Day}";
                if (i == 0 || startDate.Day == 1)
                    text = $"{startDate.Month}月\r\n{startDate.Day}";
                calendar[i] = new Button
                {
                    Size = new Size(buttonSize, buttonSize),
                    Location = new Point((menu_panel.Width - 7 * buttonSize) / 2 + (i % 7) * buttonSize, week[0].Height + (i / 7) * buttonSize),
                    Text = text,
                    TextAlign = ContentAlignment.TopLeft,
                    Font = new Font(textFont, (int)(week[0].Height * 0.6))
                };
                menu_panel.Controls.Add(calendar[i]);
                startDate = startDate.AddDays(1);
            }
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
                    //this.Opacity = 0.7;
                    break;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (calendar[0] == null || week[0] == null)
                return;
            if (ClientSize.IsEmpty)//視窗最小化
                return;
            menu_panel.Size = ClientSize;
            int labelHeight = menu_panel.Height / (showNumber / 7) / 5;
            int labelWidth = (menu_panel.Height - labelHeight) / (showNumber / 7);
            int buttonSize = (menu_panel.Height - week[0].Height) / (showNumber / 7);
            for (int i = 0; i < maxNumber; i++)
            {                
                if (i < 7) {
                    week[i].Size = new Size(labelWidth, labelHeight);
                    week[i].Location = new Point((menu_panel.Width - 7 * labelWidth) / 2 + i * labelWidth, 0);
                    week[i].Font = new Font(textFont, (int)(labelHeight * 0.6));
                }                
                calendar[i].Size = new Size(buttonSize, buttonSize);
                calendar[i].Location = new Point((menu_panel.Width - 7 * buttonSize) / 2 + (i % 7) * buttonSize, week[0].Height + (i / 7) * buttonSize);
            }
        }
    }
}
