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
    public partial class type3 : Form
    {
        Bitmap toshow;
        public type3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "Image Files (*.jpg)|*.jpg|Image Files (*.png)|*.png|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                toshow = new Bitmap(dialog.FileName);
                this.pictureBox2.Image = toshow;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "Image Files (*.jpg)|*.jpg|Image Files (*.png)|*.png|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                toshow = new Bitmap(dialog.FileName);
                this.pictureBox3.Image = toshow;
            }
        }
    }
}
