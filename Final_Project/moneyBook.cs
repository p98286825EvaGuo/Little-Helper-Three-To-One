using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int year;
        int month;
        int day;
        int classId;
        int dataNum;
        int[] class_id;
        public moneyBook(string date)
        {
            InitializeComponent();
            string[] numbers = date.Split('/');
            year = Convert.ToInt32(numbers[0]);
            month = Convert.ToInt32(numbers[1]);
            day = Convert.ToInt32(numbers[2]);
        }

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

                //button 外觀
                iconBtns[i].FlatStyle = FlatStyle.Flat;
                iconBtns[i].FlatAppearance.BorderSize = 2;
                iconBtns[i].FlatAppearance.BorderColor = Color.White;
                iconBtns[i].FlatAppearance.MouseOverBackColor = Color.BurlyWood;
                iconBtns[i].FlatAppearance.MouseDownBackColor = Color.SandyBrown;
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
                iconBtns[i].Click += iconBtn_Click;
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            addPanel.Visible = false;
            //this.moneyTableAdapter.Fill(this.moneyDBDataSet.Money);
        }

        private void moneyBook_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'moneyDBDataSet.Money' 資料表。您可以視需要進行移動或移除。
            //this.moneyTableAdapter.Fill(this.moneyDBDataSet.Money);
            iconBtns = new Button[15];
            addPanel.Visible = inputMoneyPanel.Visible = false;
            HomePanel.Visible = true;
            panel1.Visible = false;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MoneyDB.mdf;" +
                "Integrated Security=True";
            SqlDataAdapter daDep = new SqlDataAdapter("SELECT * FROM classTable", cn);
            DataSet ds = new DataSet();
            daDep.Fill(ds, "classTable");

            class_id = new int[ds.Tables["classTable"].Rows.Count];  //陣列宣告

            for (int i = 0; i < ds.Tables["classTable"].Rows.Count; i++)
            {
                class_id[i] = int.Parse(ds.Tables["classTable"].Rows[i]["classId"].ToString());
                comboBox1.Items.Add(ds.Tables["classTable"].Rows[i]["className"].ToString());
            }
            comboBox1.Text = (ds.Tables["classTable"].Rows[0]["className"].ToString());
        }

        private void addBackBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            HomePanel.Visible = true;
        }

        private void iconBtn_Click(object sender, EventArgs e)
        {
            Button icon_button = (Button)sender;
            addPanel.Visible = false;
            inputMoneyPanel.Visible = true;
            label3.Text = icon_button.Text;
            classId = icon_button.ImageIndex;
        }

        private void backIconBtn_Click(object sender, EventArgs e)
        {
            inputMoneyPanel.Visible = false;
            moneyAmounttextBox.Clear();
            NotetextBox.Clear();
            addPanel.Visible = true;
        }

        void Edit(string sqlstr)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MoneyDB.mdf;" +
                "Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            cmd.ExecuteNonQuery();
            //cn.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dataNum = 0;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MoneyDB.mdf;" +
                "Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Money", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            // Call Read before accessing data.
            while (reader.Read())
            {
                dataNum++;
            }
            cn.Close();
            try
            {
                cn.Open();
                string inOrOutS;
                inOrOutS = "2";
                cmd = new SqlCommand("INSERT INTO Money(Id,Year,Month,Date,inOrOut,Amount,Class,Note,classId)VALUES(" +
                dataNum.ToString() + ", " + year.ToString() + ", " + month.ToString() + ", " + day.ToString() + ", " + inOrOutS + ", " + moneyAmounttextBox.Text +
                ", '" + label3.Text + "', '" + NotetextBox.Text + "', " + classId.ToString() + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MoneyDB.mdf;" +
                "Integrated Security=True";
            SqlDataAdapter daEmp = new SqlDataAdapter
                ("SELECT Id,Class,Year,Month,Date,Amount,Note FROM Money WHERE classId=" + class_id[comboBox1.SelectedIndex].ToString(), cn);
            daEmp.Fill(ds, "Money");
            dataGridView1.DataSource = ds.Tables["Money"];
        }
    }
}
