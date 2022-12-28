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

        //日曆顯示的格子數
        const int maxNumber = 35;
        int showNumber = 35;
        int todayOfWeek = 1;//當天日期要顯示的行數
        Button[] calendar = new Button[maxNumber];//日曆
        DateTime localDate = DateTime.Now;

        //月份&星期
        Label[] week = new Label[7];        
        string[] weekName = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
        Dictionary<int, Label> monthLabel = new Dictionary<int, Label>();
        string[] monthName = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        string textFont = "Arial";
        int leftMargin = 20;//日曆左邊的間隔
        int mode = 0;

        //data
        Dictionary<string, List<Dictionary<string, string>> > calendarData = new Dictionary<string, List<Dictionary<string, string>>>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar_panel.Visible = true;
            progressBar_panel.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Enabled = true;
            menu_panel.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
            menu_panel.BackColor = Color.FromArgb(235, 235, 235);
            //percentage_label.ForeColor = Color.FromArgb(255, 145, 159, 198);            
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
                    Location = new Point(leftMargin + i * labelWidth, 0)
                };
                if (i == 0 || i == 6)
                    week[i].ForeColor = Color.Red;
                menu_panel.Controls.Add(week[i]);
            }
        }
        private void CreateMonthLabel(Point position, int month, int index)//創建月份label
        {
            Label temp = new Label
            {
                Text = $"{monthName[month - 1]}",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(textFont, (int)(week[0].Height * 0.4)),
                Size = new Size(week[0].Width/3, (int)(week[0].Height * 0.8)),
            };
            position.Y -= temp.Height;
            temp.Location = position;
            menu_panel.Controls.Add(temp);
            temp.BringToFront();
            monthLabel[index] = temp;
        }
        private void CreateCalendar()//創建日期的Button
        {
            //計算第一格的日期
            int todayPosition = todayOfWeek * 7 + (int)localDate.DayOfWeek;
            DateTime startDate = localDate.AddDays(-todayPosition);

            //建立日期的button
            int buttonSize = (menu_panel.Height - week[0].Height) / (showNumber / 7);
            for (int i = 0; i < maxNumber; i++)
            {
                calendar[i] = new Button//Button的properties
                {
                    Name = startDate.Date.ToShortDateString(),
                    Size = new Size(buttonSize, buttonSize),
                    Location = new Point(leftMargin + (i % 7) * buttonSize, week[0].Height + (i / 7) * buttonSize),
                    Text = $"{startDate.Day}",
                    TextAlign = ContentAlignment.TopLeft,
                    Font = new Font(textFont, (int)(week[0].Height * 0.6)),
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = {
                        BorderColor = Color.FromArgb(224, 224, 224),
                        BorderSize = 2,
                        MouseDownBackColor = Color.FromArgb(224, 224, 224),
                        MouseOverBackColor = Color.FromArgb(235, 235, 235)
                    }//button的appearance
                };
                if (i == 0 || startDate.Day == 1)//判斷該月份顯示的第一天
                    CreateMonthLabel(calendar[i].Location, startDate.Month, i);
                if (i % 7 == 0 || i % 7 == 6)//假日
                    calendar[i].ForeColor = Color.Red;
                if (i == todayPosition)//凸顯當天的日期
                    calendar[i].FlatAppearance.BorderColor = Color.Gold;
                calendar[i].Click += DateButton_Click;
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
                    calenderBtn.BackColor = Color.LightSteelBlue;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    menu_panel.Size = ClientSize;
                    CreateWeekLabel();
                    CreateCalendar();
                    //this.BackColor = Color.FromArgb(50, 0, 0, 0);
                    //this.Opacity = 0.7;
                    break;
            }
        }

        private int FontSizeInResize(int size) {
            //避免fontsize = 0而發生exception
            if (size == 0)
                return 1;
            else
                return size;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (calendar[0] == null || week[0] == null)//初始化
                return;         
            menu_panel.Size = ClientSize;
            int labelHeight = menu_panel.Height / (showNumber / 7) / 5;//weekday label的height
            int labelWidth = (menu_panel.Height - labelHeight) / (showNumber / 7);//weekday label的width
            int buttonSize = (menu_panel.Height - week[0].Height) / (showNumber / 7);//calendar button的size(width和height相同)
            for (int i = 0; i < maxNumber; i++)
            {
                //調整weekday label大小
                if (i < 7) {
                    week[i].Size = new Size(labelWidth, labelHeight);
                    week[i].Location = new Point(leftMargin + i * labelWidth, 0);
                    week[i].Font = new Font(textFont, FontSizeInResize((int)(labelHeight * 0.6)));
                }
                //調整calendar button大小
                calendar[i].Size = new Size(buttonSize, buttonSize);
                calendar[i].Location = new Point(leftMargin + (i % 7) * buttonSize, week[0].Height + (i / 7) * buttonSize);
                calendar[i].Font = new Font(textFont, FontSizeInResize((int)(labelHeight * 0.6)));
            }
            //調整month label大小
            foreach(KeyValuePair<int, Label> entry in monthLabel) {
                entry.Value.Size = new Size(labelWidth / 3, (int)(labelHeight * 0.8));
                entry.Value.Location = new Point(calendar[entry.Key].Left, calendar[entry.Key].Top - (int)(labelHeight * 0.8));
                entry.Value.Font = new Font(textFont, FontSizeInResize((int)(labelHeight * 0.4)));
            }            
        }
        private void DateButton_Click(object sender, EventArgs e)
        {
            Button dateButton = (Button)sender;
            if (mode == 0)//行事曆
            {
                CalendarFunc(dateButton.Name);
            }
            else if (mode == 1)//記帳
            {
                MoneyBookFunc();
            }
            else//(mode == 2) 手帳
            {
                MyDairyFunc();
            }
        }
        private void CalendarFunc(string date)
        {
            Calendar calendar;
            if(calendarData.ContainsKey(date))
                calendar = new Calendar(calendarData[date]);
            else
                calendar = new Calendar();
            calendar.ShowDialog();
            calendarData[date] = calendar.GetData();
        }
        private void MoneyBookFunc()
        {
            Form moneyBook_form = new moneyBook();
            moneyBook_form.ShowDialog();
        }
        private void MyDairyFunc()
        {
            Form diary_form = new diary();
            diary_form.ShowDialog();
        }

        private void calenderBtn_Click(object sender, EventArgs e)
        {
            mode = 0;
            calenderBtn.BackColor = Color.LightSteelBlue;
            moneybookBtn.BackColor = mydiaryBtn.BackColor = Color.Transparent;
        }

        private void moneybookBtn_Click(object sender, EventArgs e)
        {
            mode = 1;
            moneybookBtn.BackColor = Color.LightSteelBlue;
            calenderBtn.BackColor = mydiaryBtn.BackColor = Color.Transparent;
        }

        private void mydiaryBtn_Click(object sender, EventArgs e)
        {
            mode = 2;
            mydiaryBtn.BackColor = Color.LightSteelBlue;
            moneybookBtn.BackColor = calenderBtn.BackColor = Color.Transparent;
        }

        private void menu_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
