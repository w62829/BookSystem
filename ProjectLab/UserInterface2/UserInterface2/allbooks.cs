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

namespace UserInterface2
{
    public partial class allbooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BQ7U5BGD\SQLEXPRESS;Initial Catalog=BookDB;Integrated Security=True");
        int count = 0;
        public allbooks()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //con.Open();
            //SqlCommand command = con.CreateCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select * from dbo.Books ";
            //command.ExecuteNonQuery();
            //DataTable bTable = new DataTable();
            //SqlDataAdapter bAdapter = new SqlDataAdapter(command);
            //bAdapter.Fill(bTable);
            //dataGridView1.DataSource = bTable;


            //con.Close();
        }

        private void allbooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDatabaseDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookDatabaseDataSet.Books);

        }
    }
    }
