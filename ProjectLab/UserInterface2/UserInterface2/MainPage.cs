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
using System.Diagnostics.Eventing.Reader;
using static UserInterface2.Registration;

namespace UserInterface2
{
    public partial class MainPage : Form
    {
        //Enter database info into brackets.
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BQ7U5BGD\SQLEXPRESS;Initial Catalog=BookDB;Integrated Security=True"); 
        int count = 0;

        public static string SetValueForUser = "";

        public MainPage()
        {
            InitializeComponent();
        }

         

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            } 
            
            con.Open();

        }

        private void login_Button_Click(object sender, EventArgs e)
        {
             

            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Users where UserName='" + textBox2.Text + "' and Passwordd='" + textBox3.Text +"'";
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            count = Convert.ToInt32(dataTable.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("ID or Password doesn't match.\nIf you do not have an account then register below!");
                
            }
            else
            {
                this.Hide();

                SetValueForUser = textBox2.Text;
                search_books currentUser = new search_books();
                currentUser.Show();
            }




        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Books where BookName='" + textBox1.Text + "'";
            command.ExecuteNonQuery();
            SqlDataAdapter bAdapter = new SqlDataAdapter(command);
            DataTable bTable = new DataTable();
            bAdapter.Fill(bTable);
            count = Convert.ToInt32(bTable.Rows.Count.ToString());
            if (count > -1)
            {
                MessageBox.Show("Please Login First to search and rent books");
            }
            
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Admin Department at universitylibrary_Admin@uw.edu.pl\nor\nvisit room 117A to reset password");
        }
    }
}
