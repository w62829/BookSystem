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

namespace UserInterface2
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BQ7U5BGD\SQLEXPRESS;Initial Catalog=BookDB;Integrated Security=True");
         

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text != String.Empty && txtUsername.Text != String.Empty &&
                txtPassword.Text != String.Empty && txtConfirmPassword.Text != String.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    SqlCommand command = new SqlCommand("select * from Users where UserName='" + txtUsername + "'", con);
                    var dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exists.\nTry another one");
                    }
                    else
                    {
                        dr.Close();
                        command = new SqlCommand("insert into Users values(@FullName,@UserName,@Passwordd)", con);
                        command.Parameters.AddWithValue("FullName", txtFullName.Text);
                        command.Parameters.AddWithValue("UserName", txtUsername.Text);
                        command.Parameters.AddWithValue("Passwordd", txtPassword.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Your account is created.\nPlease login now.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter same password in both the fields.");
                }
            }
            else
            { 
                MessageBox.Show("Please fill with values all fields");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
