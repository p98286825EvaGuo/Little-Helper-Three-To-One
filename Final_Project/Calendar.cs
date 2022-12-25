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
        //string[] flag = { "[ ]", "[#]", "[V]" };
        int lineIndex = 0;
        string textFont = "微軟正黑體";
        List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
        public Calendar()
        {
            InitializeComponent();
        }
        public List<Dictionary<string, string>> GetData() {
            return data;
        }
        private void Calendar_Shown(object sender, EventArgs e)
        {
            lineIndex = 0;
            add_things.SelectionStart = add_things.Text.Length;
            add_things.Focus();
        }
        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < add_things.Lines.Length; i++) {
                add_things.SelectionStart = add_things.GetFirstCharIndexFromLine(i);
                Dictionary<string, string> dataLine = new Dictionary<string, string>();
                dataLine["thing"] = add_things.Lines[i];
                //if fontstyle is bold, then the thing's property is set important
                dataLine["important"] = (add_things.SelectionFont.Style == FontStyle.Bold).ToString();
                data.Add(dataLine);
            }
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
        private void ChangeLineFont(FontStyle style)
        {
            add_things.SelectionStart = add_things.GetFirstCharIndexFromLine(lineIndex);
            add_things.SelectionLength = add_things.Lines[lineIndex].Length;
            add_things.SelectionFont = new Font(textFont, 12, style);
        }
        private void add_things_MouseClick(object sender, MouseEventArgs e)
        {
            lineIndex = add_things.GetLineFromCharIndex(add_things.SelectionStart);//游標所在的行數
            if (add_things.SelectionFont.Style == FontStyle.Bold)
                important.Text = "unimp";
            else
                important.Text = "imp";
            //add_things.SelectionFont = new Font("微軟正黑體", 12);
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
            if (add_things.SelectionFont.Style == FontStyle.Bold)
                important.Text = "unimp";
            else
                important.Text = "imp";
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void important_Click(object sender, EventArgs e)
        {
            if (add_things.SelectionFont.Style == FontStyle.Bold) {
                ChangeLineFont(FontStyle.Regular);
                important.Text = "imp";
            }
            else
            {
                ChangeLineFont(FontStyle.Bold);
                important.Text = "unimp";
            }                
        }        
    }
}
