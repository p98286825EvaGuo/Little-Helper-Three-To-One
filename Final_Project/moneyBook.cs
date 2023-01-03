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
        string inOrEx;
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
            string monthLabel;
            switch (month)
            {
                case 1: monthLabel = "JAN"; break;
                case 2: monthLabel = "FEB"; break;
                case 3: monthLabel = "MAR"; break;
                case 4: monthLabel = "APR"; break;
                case 5: monthLabel = "MAY"; break;
                case 6: monthLabel = "JUN"; break;
                case 7: monthLabel = "JUL"; break;
                case 8: monthLabel = "AUG"; break;
                case 9: monthLabel = "SEP"; break;
                case 10: monthLabel = "OCT"; break;
                case 11: monthLabel = "NOV"; break;
                default: monthLabel = "DEC"; break;
            }
            label4.Text = monthLabel + " " + year.ToString();
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
            dataGridView2.Visible = false;
            chart1.Titles.Add("Income/Expense Chart");
            chart1.Series["S1"]["PieLabelStyle"] = "Disabled";

            loadDB();
        }

        private void loadDB()
        {
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
            comboBox1.Items.Add("All");
            //comboBox1.Text = "All";
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
                cmd = new SqlCommand("INSERT INTO Money(Id,Year,Month,Date,inOrOut,Amount,Class,Note,classId)VALUES(" +
                dataNum.ToString() + ", " + year.ToString() + ", " + month.ToString() + ", " + day.ToString() + ", " + inOrEx + ", " + moneyAmounttextBox.Text +
                ", '" + label3.Text + "', '" + NotetextBox.Text + "', " + classId.ToString() + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                moneyAmounttextBox.Clear();
                NotetextBox.Clear();
                MessageBox.Show("Add successfully!");
                incomeBtn.BackColor = expenseBtn.BackColor = Color.AntiqueWhite;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Try again!","Error" ,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MoneyDB.mdf;" +
                "Integrated Security=True";
            if(comboBox1.SelectedIndex != 15)
            {
                SqlDataAdapter daEmp = new SqlDataAdapter
                    ("SELECT Id,Class,Year,Month,Date,Amount,Note FROM Money WHERE classId=" + 
                    class_id[comboBox1.SelectedIndex].ToString() + " and Year=" + year.ToString() + 
                    " and month=" + month.ToString(), cn);
                daEmp.Fill(ds, "Money");
            }
            else
            {
                SqlDataAdapter daEmp = new SqlDataAdapter
                    ("SELECT Id,Class,Year,Month,Date,Amount,Note FROM Money WHERE " +
                    "Year=" + year.ToString() + " and month=" + month.ToString(), cn);
                daEmp.Fill(ds, "Money");
            }
            
            dataGridView1.DataSource = ds.Tables["Money"];
            DataGridViewColumn column = dataGridView1.Columns[0];
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column.Width = 35;
            column1.Width = 130;
            column2.Width = 65;
            column3.Width = 63;
            column4.Width = 53;
            column6.Width = 160;
            cal_sum();
        }

        private void button1_Click(object sender, EventArgs e) //back homepage
        {
            panel1.Visible = false;
            HomePanel.Visible = true;
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            incomeBtn.BackColor = Color.SandyBrown;
            expenseBtn.BackColor = Color.AntiqueWhite;
            inOrEx = "0";
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            incomeBtn.BackColor = Color.AntiqueWhite;
            expenseBtn.BackColor = Color.SandyBrown;
            inOrEx = "1";
        }

        private void button2_Click(object sender, EventArgs e) //delete
        {
            try
            {
                string Id;
                Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //Edit("DELETE FROM 員工 WHERE 員工編號='" + empId.Replace("'", "''") + "'");
                //cboDep_SelectedIndexChanged(sender, e);
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|MoneyDB.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Money WHERE Id=" + Id, cn); ;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void cal_sum()
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|MoneyDB.mdf;" +
                "Integrated Security=True";
            if(comboBox1.SelectedIndex != 15)
            {
                SqlDataAdapter daEmp = new SqlDataAdapter
                    ("SELECT inOrOut,SUM(Amount) FROM Money  WHERE classId=" + comboBox1.SelectedIndex.ToString() +
                    "and Year=" + year.ToString() + " and Month=" + month.ToString() + " GROUP BY inOrOut", cn);
                daEmp.Fill(ds, "Money");
                dataGridView2.DataSource = ds.Tables["Money"];
            }
            else
            {
                SqlDataAdapter daEmp = new SqlDataAdapter
                    ("SELECT inOrOut,SUM(Amount) FROM Money  WHERE " + 
                    "Year=" + year.ToString() + " and Month=" + month.ToString() + " GROUP BY inOrOut", cn);
                daEmp.Fill(ds, "Money");
                dataGridView2.DataSource = ds.Tables["Money"];
            }
            
            if(dataGridView2.Rows[0].Cells[0].Value != null && dataGridView2.Rows[1].Cells[0].Value != null)
            {
                incomeLabel.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                expenseLabel.Text = dataGridView2.Rows[1].Cells[1].Value.ToString();
                label8.Text = (Convert.ToInt32(incomeLabel.Text) + Convert.ToInt32(expenseLabel.Text)).ToString();
            }
            else if(dataGridView2.Rows[0].Cells[0].Value != null && dataGridView2.Rows[1].Cells[0].Value == null
                && dataGridView2.Rows[0].Cells[0].Value.ToString() == "0")
            {
                incomeLabel.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                expenseLabel.Text = "0";
                label8.Text = (Convert.ToInt32(incomeLabel.Text) + Convert.ToInt32(expenseLabel.Text)).ToString();
            }
            else if (dataGridView2.Rows[0].Cells[0].Value != null && dataGridView2.Rows[1].Cells[0].Value == null
                && dataGridView2.Rows[0].Cells[0].Value.ToString() == "1")
            {
                expenseLabel.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                incomeLabel.Text = "0";
                label8.Text = (Convert.ToInt32(incomeLabel.Text) + Convert.ToInt32(expenseLabel.Text)).ToString();
            }
            else
            {
                incomeLabel.Text = "0";
                expenseLabel.Text = "0";
                label8.Text = (Convert.ToInt32(incomeLabel.Text) + Convert.ToInt32(expenseLabel.Text)).ToString();
            }

            chart1.Series["S1"].Points.Clear();
            chart1.Series["S1"].Points.AddXY("Income", Convert.ToInt32(incomeLabel.Text));
            chart1.Series["S1"].Points.AddXY("Expense", Convert.ToInt32(expenseLabel.Text));
        }
    }
}
