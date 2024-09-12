using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class type3 : Form
    {
        int year;
        int month;
        int day;
        int dataNum;
        string path1;
        string path2;
        bool saved=false;
        public type3()
        {
            InitializeComponent();
        }
        public type3(string Date)
        {
            InitializeComponent();
            string[] numbers = Date.Split('/');
            year = Convert.ToInt32(numbers[0]);
            month = Convert.ToInt32(numbers[1]);
            day = Convert.ToInt32(numbers[2]);
            saved = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                MessageBox.Show("忘記儲存囉！小笨蛋~", "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();
            dialog1.Title = "Select file";
            dialog1.Filter = "Image Files (*.jpg)|*.jpg|Image Files (*.png)|*.png|All Files (*.*)|*.*";
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image=Image.FromStream(dialog1.OpenFile());
                path1 = Path.GetFullPath(dialog1.FileName);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog2 = new OpenFileDialog();
            dialog2.Title = "Select file";
            dialog2.Filter = "Image Files (*.jpg)|*.jpg|Image Files (*.png)|*.png|All Files (*.*)|*.*";
            if (dialog2.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox3.Image = Image.FromStream(dialog2.OpenFile());
                path2 = Path.GetFullPath(dialog2.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataNum = 0;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|DiaryDB.mdf;" +
                "Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM diaryTable", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataNum++;
            }
            cn.Close();

            cn.Open();
            cmd = new SqlCommand("INSERT INTO diaryTable(Id,Year,Month,Date,type3textBox1,type3pictureBox2,type3pictureBox3) VALUES(" +
            dataNum.ToString() + ", " + year.ToString() + ", " + month.ToString() + ", " + day.ToString() + ", N'" + textBox1.Text + "', N'" + path1 + "',N'" + path2 + "' )", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Save successfully!");
            saved = true;
            Text = "Diary" + year + "/" + month + "/" + day;

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

            if (dataGridView1.RowCount > 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (dataGridView1.Rows[i].Cells[9].Value.ToString() != null && dataGridView1.Rows[i].Cells[10].Value.ToString() != null)
                    {
                        textBox1.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                        path1 = dataGridView1.Rows[i].Cells[9].Value.ToString();
                        path2 = dataGridView1.Rows[i].Cells[10].Value.ToString();
                        try
                        {
                            pictureBox2.Image = new Bitmap(path1);
                            pictureBox3.Image = new Bitmap(path2);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("請確認圖片來源路徑或名稱是否更改", "Error",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                        }
                        break;
                    }
                }
            }
        }
        private void type3_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'diaryDBDataSet.Table' 資料表。您可以視需要進行移動或移除。
            //this.tableTableAdapter.Fill(this.diaryDBDataSet.Table);
            loadDB();
            dataGridView1.Visible = false;
            textBox2.Text = year+ "/" + month+ "/" + day;
            saved = true;
            Text = "Diary" + year + "/" + month + "/" + day;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            Text = "*Diary" + year + "/" + month + "/" + day;
        }
    }
}
