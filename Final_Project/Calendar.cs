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
    public partial class Calendar : Form
    {
        string[] flag = { "[ ]", "[#]", "[V]"};
        int lineIndex = 0;
        List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
        public Calendar()
        {
            InitializeComponent();
        }
        private void Calendar_Shown(object sender, EventArgs e)
        {
            lineIndex = 0;
            add_things.Focus();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {

        }
        private void add_things_MouseClick(object sender, MouseEventArgs e)
        {
            lineIndex = add_things.GetLineFromCharIndex(add_things.SelectionStart);//游標所在的行數
        }
        private void add_things_TextChanged(object sender, EventArgs e)
        {
            lineIndex = add_things.GetLineFromCharIndex(add_things.SelectionStart);//游標所在的行數
            /*for (int i = 0; i < add_things.Lines.Length; i++) {
                //if(add_things.Lines[i].Length)
            }*/
        }
        private void add_things_KeyPress(object sender, KeyPressEventArgs e)
        {
            lineIndex = add_things.GetLineFromCharIndex(add_things.SelectionStart);//游標所在的行數
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void important_Click(object sender, EventArgs e)
        {

        }

        
    }
}
