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
    public partial class booksout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUDHANSHUPC\SQLEXPRESS;Initial Catalog=BookDatabase;Integrated Security=True");
        int count = 0;
        public booksout()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.BooksOut ";
            command.ExecuteNonQuery();
            DataTable bTable = new DataTable();
            SqlDataAdapter bAdapter = new SqlDataAdapter(command);
            bAdapter.Fill(bTable);
            dataGridView1.DataSource = bTable;


            con.Close();
        }

        private void booksout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDatabaseDataSet1.BooksOut' table. You can move, or remove it, as needed.
            this.booksOutTableAdapter.Fill(this.bookDatabaseDataSet1.BooksOut);

        }
    }
}
