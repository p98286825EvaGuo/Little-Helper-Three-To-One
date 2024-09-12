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
    public partial class type1 : Form
    {
        int year;
        int month;
        int day;
        int dataNum;
        bool saved = true;
        string path;
        public type1()
        {
            InitializeComponent();
        }
        public type1(string Date)
        {
            InitializeComponent();
            string[] numbers = Date.Split('/');
            year = Convert.ToInt32(numbers[0]);
            month = Convert.ToInt32(numbers[1]);
            day = Convert.ToInt32(numbers[2]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "Image Files (*.jpg)|*.jpg|Image Files (*.png)|*.png|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = Image.FromStream(dialog.OpenFile());
                path = Path.GetFullPath(dialog.FileName);
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

            // Call Read before accessing data.
            while (reader.Read())
            {
                dataNum++;
            }
            cn.Close();
            cn.Open();
            cmd = new SqlCommand("INSERT INTO diaryTable(Id,Year,Month,Date,type1textBox1,type1pictureBox2)VALUES(" +
            dataNum.ToString() + ", " + year.ToString() + ", " + month.ToString() + ", " + day.ToString() + ", N'" + textBox1.Text + "', N'" + path + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Save successfully!");
            saved = true;
            Text = "Diary" + year + "/" + month + "/" + day;
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
            //MessageBox.Show(dataGridView1.RowCount.ToString());
            if(dataGridView1.RowCount > 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    if (dataGridView1.Rows[i].Cells[5].Value.ToString() != null)
                    {
                        textBox1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        path = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        try
                        {
                            pictureBox2.Image = new Bitmap(path);
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
        private void type1_Load(object sender, EventArgs e)
        {
            loadDB();
            dataGridView1.Visible = false;
            saved = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            Text = "*Diary" + year + "/" + month + "/" + day;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            saved = false;
            Text = "*Diary" + year + "/" + month + "/" + day;
        }
    }
}
