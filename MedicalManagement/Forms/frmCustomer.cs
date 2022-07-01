using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Forms
{
    public partial class frmCustomer : Form
    {
        public SqlConnection connection;
        public frmCustomer()
        {

            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder.Add("Server", "localhost, 1433");
            sqlStringBuilder.Add("Database", "xtlab");
            sqlStringBuilder.Add("UID", "sa");
            sqlStringBuilder.Add("PWD", "Password123");

            var connectionString = sqlStringBuilder.ToString();

            // Ở trên mỗi máy tính cá nhân: anh, em, Hiếu, Hoa là khác nhau => 4 ConnectionString khác nhau
            Console.WriteLine(connectionString);



            // string connectionString = "Data Source = localhost,1433;Initial Catalog=xtlab;User ID=sa;Password=Password123";
            connection = new SqlConnection(connectionString);
            Console.WriteLine(connection.State);

            connection.Open();
            Console.WriteLine(connection.State);
            label1.Text = connection.State.ToString();



            // Query
            //DbCommand command = new SqlCommand();
            //command.Connection = connection;
            //command.CommandText = "SELECT TOP (5) * FROM Sanpham";

            //var dataReader = command.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    Console.WriteLine($"{dataReader["TenSanpham"],10}");
            //}

            //connection.Close();


            //command.Prepare();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
                label1.Text = connection.State.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
