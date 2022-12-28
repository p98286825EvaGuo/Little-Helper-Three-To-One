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
        public diary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form both = new type1();
            both.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form photo = new type3();
            photo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form word = new type2();
            word.ShowDialog();
        }
    }
}
