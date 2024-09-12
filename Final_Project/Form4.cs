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
    public partial class type2 : Form
    {
        int year;
        int month;
        int day;
        int dataNum;
        bool saved = true;
        public type2()
        {
            InitializeComponent();
            saved = true;
        }
        public type2(string Date)
        {
            InitializeComponent();
            string[] numbers = Date.Split('/');
            year = Convert.ToInt32(numbers[0]);
            month = Convert.ToInt32(numbers[1]);
            day = Convert.ToInt32(numbers[2]);
            saved = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                MessageBox.Show("忘記儲存囉！小笨蛋~", "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            else Close();
        }
        private void loadDB()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|DiaryDB.mdf;" +
                "Integrated Security=True";
            SqlDataAdapter daDep = new SqlDataAdapter("SELECT * FROM diaryTable WHERE " +
                 "Year=" + year.ToString() + " and Month=" + month.ToString() + " and Date=" + day.ToString(), cn);
            DataSet ds = new DataSet();
            daDep.Fill(ds, "diaryTable");
            dataGridView1.DataSource = ds.Tables["diaryTable"];

            if(dataGridView1.RowCount > 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != null)
                    {
                        textBox1.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        break;
                    }
                }
            }
        }

        private void type2_Load(object sender, EventArgs e)
        {
            Text = "Diary";
            // TODO: 這行程式碼會將資料載入 'diaryDBDataSet.Table' 資料表。您可以視需要進行移動或移除。
            //this.tableTableAdapter.Fill(this.diaryDBDataSet.Table);
            loadDB();
            dataGridView1.Visible = false;
            textBox2.Text = year+ "/" + month + "/" + day;
            saved = true;
            Text = "Diary" + year + "/" + month + "/" + day;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataNum = 0;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|DiaryDB.mdf;" +
                "Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM diaryTable", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            // Call Read before accessing data.
            while (reader.Read())
            {
                dataNum++;
            }
            cn.Close();

            cn.Open();
            cmd = new SqlCommand("INSERT INTO diaryTable(Id,Year,Month,Date,type2textBox1,type2textBox2)VALUES(" +
            dataNum.ToString() + ", " + year.ToString() + ", " + month.ToString() + ", " + day.ToString() + ", N'" + textBox1.Text.ToString() + "',N' " + textBox2.Text.ToString() + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Save successfully!");
            saved = true;
            Text = "Diary" + year + "/" + month + "/" + day;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            Text = "*Diary"+year+"/"+month+"/"+day;
        }
    }
}
