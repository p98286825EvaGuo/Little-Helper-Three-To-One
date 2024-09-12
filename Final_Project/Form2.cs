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
    public partial class diary : Form
    {
        int year;
        int month;
        int day;
        string Date;
        public diary()
        {
            InitializeComponent();
        }
        public diary(string date)
        {
            InitializeComponent();
            string[] numbers = date.Split('/');
            year = Convert.ToInt32(numbers[0]);
            month = Convert.ToInt32(numbers[1]);
            day = Convert.ToInt32(numbers[2]);
            Date = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form both = new type1(Date);
            both.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form photo = new type3(Date);
            photo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type2 type2_form;
            type2_form = new type2(Date);
            type2_form.ShowDialog();
        }

        private void diary_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 240, 255);
        }
    }
}
