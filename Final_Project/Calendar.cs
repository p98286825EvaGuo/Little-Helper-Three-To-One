using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Calendar : Form
    {
        FontStyle[] mode = { FontStyle.Regular, FontStyle.Bold, FontStyle.Strikeout};
        int lineIndex = 0;//游標位置
        string textFont = "微軟正黑體";
        string filename = "";
        bool saved = false;
        bool first = true;
        List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
        /*  data = [{
                    "thing" : <string>,
                    "property" : <int> (0,1 or 2) 
                },...
            ]*/
        public Calendar(List<Dictionary<string, string>> originData, string f)
        {
            InitializeComponent();
            add_things.LanguageOption = RichTextBoxLanguageOptions.DualFont;
            data = originData;
            first = true;
            filename = f;
        }
        public Calendar(string f)
        {
            InitializeComponent();
            add_things.LanguageOption = RichTextBoxLanguageOptions.DualFont;
            first = true;
            filename = f;
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
        private void SaveData() {
            if (saved)
                return;
            data.Clear();
            string path = $"CalendarData\\{filename}.txt";
            FileInfo finfo = new FileInfo(path);
            StreamWriter sw = finfo.CreateText();
            for (int i = 0; i < add_things.Lines.Length; i++)
            {
                add_things.SelectionStart = add_things.GetFirstCharIndexFromLine(i);
                Dictionary<string, string> dataLine = new Dictionary<string, string>();
                dataLine["thing"] = add_things.Lines[i];
                /* if fontstyle is bold, then the thing's property is set important */
                try
                {
                    if (add_things.SelectionFont.Style == FontStyle.Bold)
                        dataLine["property"] = "1";
                    else if (add_things.SelectionFont.Style == FontStyle.Strikeout)
                        dataLine["property"] = "2";
                    else
                        dataLine["property"] = "0";
                }
                catch
                {
                    dataLine["property"] = "0";
                }
                sw.WriteLine($"{dataLine["property"]}:{dataLine["thing"]}");
                data.Add(dataLine);
            }
            sw.Flush();
            sw.Close();
        }
        private void Calendar_Shown(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < data.Count; i++)
                temp.Add(data[i]["thing"]);
            add_things.Lines = temp.ToArray();
            lineIndex = 0;
            for (int i = 0; i < data.Count; i++) {
                int property = int.Parse(data[i]["property"]);
                ChangeLineFont(mode[property]);
                lineIndex++;
            }
            if (temp.Count > 0)
                lineIndex = temp.Count - 1;
            else
                lineIndex = 0;
            add_things.SelectionStart = add_things.Text.Length;
            if (first)
                SetSaved(true);
            add_things.Focus();
        }
        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (!saved) {
                result = MessageBox.Show("請問是否要儲存變更?", "尚未儲存", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes) {                    
                    SaveData();
                    SetSaved(true);
                }                    
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;//取消關閉視窗
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ChangeLineFont(FontStyle style)
        {
            add_things.SelectionStart = add_things.GetFirstCharIndexFromLine(lineIndex);
            if (add_things.Lines.Length == 0)
                add_things.SelectionLength = 0;
            else
                add_things.SelectionLength = add_things.Lines[lineIndex].Length;
            add_things.SelectionFont = new Font(textFont, 16, style);
        }
        private void GetLineIndex() {
            lineIndex = add_things.GetLineFromCharIndex(add_things.SelectionStart);//游標所在的行數
            if (add_things.SelectionFont.Style == FontStyle.Bold)
            {
                important.Text = "Unimportant";
                done.Text = "Done";
            }
            else {
                important.Text = "Important";
                if (add_things.SelectionFont.Style == FontStyle.Strikeout)
                    done.Text = "Undone";
                else
                    done.Text = "Done";
            }               
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
        private void add_things_KeyUp(object sender, KeyEventArgs e)
        {
            GetLineIndex();
        }

        private void save_Click(object sender, EventArgs e)
        {            
            SaveData();
            SetSaved(true);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (add_things.Lines.Length == 0)
                return;
            add_things.SelectionStart = add_things.GetFirstCharIndexFromLine(lineIndex);
            add_things.SelectionLength = add_things.Lines[lineIndex].Length + 1;
            add_things.SelectedText = string.Empty;
            ChangeLineFont(FontStyle.Regular);
            important.Text = "Important";
            done.Text = "Done";
        }

        private void important_Click(object sender, EventArgs e)
        {
            //change font will arise textchanged event
            if (add_things.SelectionFont.Style == FontStyle.Bold) {
                ChangeLineFont(FontStyle.Regular);
                important.Text = "Important";
            }
            else
            {
                ChangeLineFont(FontStyle.Bold);
                important.Text = "Unimportant";
            }                
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (add_things.SelectionFont.Style == FontStyle.Strikeout)
            {
                ChangeLineFont(FontStyle.Regular);
                done.Text = "Done";
            }
            else
            {
                ChangeLineFont(FontStyle.Strikeout);
                done.Text = "Undone";
            }
        }
    }
}
