using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class moneyBook : Form
    {
        Button[] iconBtns;
        public moneyBook()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
            HomePanel.Visible = false;

            //產生icon buttons
            for (int i = 0, j = 0, x = 40, y = 30; i < 15; i++, j++, x += 175)
            {
                if (j == 5)
                {
                    x = 40;
                    y += 130;
                    j = 0;
                }
                iconBtns[i] = new Button();
                iconBtns[i].SetBounds(x, y, 170, 80);
                iconBtns[i].ImageList = button_icons;
                iconBtns[i].ImageIndex = i;
                addPanel.Controls.Add(iconBtns[i]);
                //iconBtns[i].MouseLeave += iconBtn_mouseLeave;
                //iconBtns[i].MouseHover += iconBtn_mouseHover;

                //button 外觀
                iconBtns[i].FlatStyle = FlatStyle.Flat;
                iconBtns[i].FlatAppearance.BorderSize = 2;
                iconBtns[i].FlatAppearance.BorderColor = Color.White;
                iconBtns[i].FlatAppearance.MouseOverBackColor = Color.BurlyWood;
                iconBtns[i].ForeColor = Color.DarkBlue;
                iconBtns[i].ImageAlign = ContentAlignment.TopCenter;
                iconBtns[i].TextAlign = ContentAlignment.BottomCenter;
                iconBtns[i].Font = new Font("Ink Free", 15, FontStyle.Bold);
                switch (i)
                {
                    case 0: iconBtns[i].Text = "Food"; break;
                    case 1: iconBtns[i].Text = "Shopping"; break;
                    case 2: iconBtns[i].Text = "Transportation"; break;
                    case 3: iconBtns[i].Text = "Entertainment"; break;
                    case 4: iconBtns[i].Text = "Education"; break;
                    case 5: iconBtns[i].Text = "Bills"; break;
                    case 6: iconBtns[i].Text = "Social"; break;
                    case 7: iconBtns[i].Text = "Sport"; break;
                    case 8: iconBtns[i].Text = "Medical"; break;
                    case 9: iconBtns[i].Text = "Taxes"; break;
                    case 10: iconBtns[i].Text = "Investments"; break;
                    case 11: iconBtns[i].Text = "Donation"; break;
                    case 12: iconBtns[i].Text = "Insurance"; break;
                    case 13: iconBtns[i].Text = "Travel"; break;
                    case 14: iconBtns[i].Text = "Others"; break;
                }
                //cardBtns[i].Click += ButtonArray_Click;  //匿名函數 匿名函數中含有別的具名函數
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {

        }

        private void moneyBook_Load(object sender, EventArgs e)
        {
            iconBtns = new Button[15];
            addPanel.Visible = false;
            HomePanel.Visible = true;
        }

        private void iconBtn_mouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.BurlyWood;
        }

        private void iconBtn_mouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.AntiqueWhite;
        }

        private void addBackBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            HomePanel.Visible = true;
        }
    }
}
