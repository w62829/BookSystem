using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static UserInterface2.BookResult;

namespace UserInterface2
{
    public partial class search_books : Form
    {


         

        public search_books()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                allbooks currentUser = new allbooks();
                currentUser.Show();
            }
        }

        private void search_books_Load(object sender, EventArgs e)
        {
            timer1.Start();

            var userName = MainPage.SetValueForUser;
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-BQ7U5BGD\SQLEXPRESS;Initial Catalog=BookDB;Integrated Security=True");
            connection.Open();

            var strName = "select * from Users where UserName='" + userName + "'";
            SqlCommand command = new SqlCommand(strName, connection);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            label2.Text = "Hi," + reader["FullName"].ToString();

            reader.Close();
            connection.Close();
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=LAPTOP-BQ7U5BGD\SQLEXPRESS;Initial Catalog=BookDB;Integrated Security=True";
            var bookName = textBox1.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    this.Hide();
                    string query = @"select * from Books where BookName='" + bookName + "'";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    BookResult resultGrid = new BookResult();
                    resultGrid.grdData.ReadOnly = true;
                    resultGrid.grdData.DataSource = dataSet.Tables[0];
                    resultGrid.Show();

                    connection.Close();
                }

            }

            catch (SqlException)
            {
                MessageBox.Show("Exception");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            booksout currentUser = new booksout();
            currentUser.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
