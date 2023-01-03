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
using System.IO;

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
        DateTime startDate;

        //月份&星期
        Label[] week = new Label[7];        
        string[] weekName = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
        Dictionary<int, Label> monthLabel = new Dictionary<int, Label>();
        string[] monthName = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        string textFont = "Arial";
        int leftMargin = 20;//日曆左邊的間隔
        int mode = 0;
        string[] symbol = { " [+] ", " [*] ", " [v] ", ""};

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
            int funcLeft = menu_panel.Width - (leftMargin + mode_panel.Width);
            mode_panel.Location = new Point(funcLeft, leftMargin);
            page_panel.Location = new Point(funcLeft, menu_panel.Height - (leftMargin + page_panel.Height));
            if (!Directory.Exists("CalendarData"))
                Directory.CreateDirectory("CalendarData");
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
                BackColor = Color.LightSteelBlue,
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
            startDate = localDate.AddDays(-todayPosition);
            int startYear = startDate.Year;
            //建立日期的button
            int buttonSize = (menu_panel.Height - week[0].Height) / (showNumber / 7);
            for (int i = 0; i < maxNumber; i++)
            {
                calendar[i] = new Button//Button的properties
                {
                    Name = startDate.ToString("yyyyMMdd"),
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
                ReadCalendarData(calendar[i].Name);
                int index = CheckState(calendar[i].Name);
                calendar[i].Text += symbol[index];
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
            //顯示年份
            if (startYear == startDate.Year)
                year.Text = startYear.ToString();
            else
                year.Text = $"{startYear}/{startDate.Year}";
            startDate = startDate.AddDays(-35);
        }
        private void ShowDate(DateTime sDate) {
            foreach (KeyValuePair<int, Label> entry in monthLabel)
                menu_panel.Controls.Remove(entry.Value);            
            monthLabel.Clear();
            string today = localDate.ToString("yyyyMMdd");
            int startYear = sDate.Year;
            for (int i = 0; i < maxNumber; i++)
            {
                calendar[i].Name = sDate.ToString("yyyyMMdd");
                ReadCalendarData(calendar[i].Name);
                int index = CheckState(calendar[i].Name);
                calendar[i].Text = $"{sDate.Day}{symbol[index]}";                
                if (i == 0 || sDate.Day == 1)//判斷該月份顯示的第一天
                    CreateMonthLabel(calendar[i].Location, sDate.Month, i);
                if (calendar[i].Name == today)//凸顯當天的日期
                    calendar[i].FlatAppearance.BorderColor = Color.Gold;
                else
                    calendar[i].FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
                sDate = sDate.AddDays(1);
            }
            //顯示年份
            if (startYear == sDate.Year)
                year.Text = startYear.ToString();
            else
                year.Text = $"{startYear}/{sDate.Year}";
        }
        private void ReadCalendarData(string filename)//讀行事曆資料
        {
            string path = $"CalendarData\\{filename}.txt";
            if (!File.Exists(path) || calendarData.ContainsKey(filename) || mode != 0)
                return;
            //FileInfo fileInfo = new FileInfo(filename);
            calendarData[filename] = new List<Dictionary<string, string>>();
            StreamReader sr = new StreamReader(path);
            do{
                string data = sr.ReadLine();
                if (data == null) break;
                string[] dataSplit = data.Split(':');
                string property = dataSplit[0];
                string thing = "";
                for (int i = 1; i < dataSplit.Length; i++) {
                    if(i == 1)
                        thing += dataSplit[i];
                    else
                        thing += ":" + dataSplit[i];
                }
                calendarData[filename].Add(new Dictionary<string, string> {
                    { "thing", thing },
                    { "property", property },
                });
            } while (true);
            sr.Close();
        }
        private int CheckState(string date) {
            //0:unimp, 1:imp, 2:all done, 3:no things
            if (mode!=0 || !calendarData.ContainsKey(date))
                return 3;
            bool done = true;
            bool imp = false;
            bool IsThing = false;
            for (int i = 0; i < calendarData[date].Count; i++) {
                IsThing = true;
                if (calendarData[date][i]["property"] != "2")
                    done = false;
                if (calendarData[date][i]["property"] == "1")
                    imp = true;
            }
            if (IsThing)
            {
                if (done)
                    return 2;
                if (imp)
                    return 1;
                else
                    return 0;
            }
            else
                return 3;
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
            int buttonSize = labelWidth;//calendar button的size(width和height相同)
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
            int funcLeft = menu_panel.Width - (leftMargin + mode_panel.Width);
            mode_panel.Location = new Point(funcLeft, leftMargin);
            page_panel.Location = new Point(funcLeft, menu_panel.Height - (leftMargin + page_panel.Height));
        }
        private void DateButton_Click(object sender, EventArgs e)
        {
            Button dateButton = (Button)sender;
            if (mode == 0)//行事曆
            {
                CalendarFunc(dateButton.Name);
                int index = CheckState(dateButton.Name);
                string day = dateButton.Name.Substring(6, 2);
                if (day[0] == '0')
                    day = day[1].ToString();
                dateButton.Text = day + symbol[index];
            }
            else if (mode == 1)//記帳
            {
                MoneyBookFunc(dateButton.Name);
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
                calendar = new Calendar(calendarData[date], date);
            else
                calendar = new Calendar(date);
            calendar.ShowDialog();
            calendarData[date] = calendar.GetData();
        }
        private void MoneyBookFunc(string date)
        {
            moneyBook moneyBook_form;
            moneyBook_form = new moneyBook(date);
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
            ShowDate(startDate);
        }

        private void moneybookBtn_Click(object sender, EventArgs e)
        {
            mode = 1;
            moneybookBtn.BackColor = Color.LightSteelBlue;
            calenderBtn.BackColor = mydiaryBtn.BackColor = Color.Transparent;
            ShowDate(startDate);
        }

        private void mydiaryBtn_Click(object sender, EventArgs e)
        {
            mode = 2;
            mydiaryBtn.BackColor = Color.LightSteelBlue;
            moneybookBtn.BackColor = calenderBtn.BackColor = Color.Transparent;
            ShowDate(startDate);
        }
        private void backpage_Click(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(-35);
            ShowDate(startDate);
        }

        private void backnow_Click(object sender, EventArgs e)
        {
            //計算第一格的日期
            int todayPosition = todayOfWeek * 7 + (int)localDate.DayOfWeek;
            startDate = localDate.AddDays(-todayPosition);
            ShowDate(startDate);
        }

        private void frontpage_Click(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(35);
            ShowDate(startDate);
        }
        private void menu_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
