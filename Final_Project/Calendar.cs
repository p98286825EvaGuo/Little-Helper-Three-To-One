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
        int lineIndex = 0;//游標位置
        string textFont = "微軟正黑體";
        bool saved = false;
        List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
        /*  data = [{
                    "thing" : <string>,
                    "important" : <bool> 
                },...
            ]*/
        public Calendar(List<Dictionary<string, string>> originData)
        {
            InitializeComponent();
            data = originData;
            SetSaved(true);
        }
        public Calendar()
        {
            InitializeComponent();
            SetSaved(false);
        }
        public List<Dictionary<string, string>> GetData() {
            return data;
        }
        private void SetSaved(bool s) {
            saved = s;
            if (saved)
                Text = "Calender";
            else
                Text = "*Calender";
        }
        private void Calendar_Shown(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < data.Count; i++)
                temp.Add(data[i]["thing"]);
            add_things.Lines = temp.ToArray();
            lineIndex = temp.Count - 1;
            add_things.SelectionStart = add_things.Text.Length;
            add_things.Focus();
        }
        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (!saved) {
                result = MessageBox.Show("請問是否要儲存變更?", "尚未儲存", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    SetSaved(true);
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
            if (saved) {
                data.Clear();
                for (int i = 0; i < add_things.Lines.Length; i++)
                {
                    add_things.SelectionStart = add_things.GetFirstCharIndexFromLine(i);
                    Dictionary<string, string> dataLine = new Dictionary<string, string>();
                    dataLine["thing"] = add_things.Lines[i];
                    /* if fontstyle is bold, then the thing's property is set important */
                    dataLine["important"] = (add_things.SelectionFont.Style == FontStyle.Bold).ToString();
                    data.Add(dataLine);
                }
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
        private void GetLineIndex() {
            lineIndex = add_things.GetLineFromCharIndex(add_things.SelectionStart);//游標所在的行數
            if (add_things.SelectionFont.Style == FontStyle.Bold)
                important.Text = "unimp";
            else
                important.Text = "imp";
            //add_things.SelectionFont = new Font("微軟正黑體", 12);
        }
        private void add_things_MouseClick(object sender, MouseEventArgs e)
        {
            GetLineIndex();
        }
        private void add_things_TextChanged(object sender, EventArgs e)
        {
            GetLineIndex();
            SetSaved(false);
        }
        private void add_things_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetLineIndex();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SetSaved(true);
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void important_Click(object sender, EventArgs e)
        {
            //change font will arise textchanged event
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
