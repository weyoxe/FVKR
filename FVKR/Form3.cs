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

namespace FVKR
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newDBDataSet.TestTable". При необходимости она может быть перемещена или удалена.
            this.testTableTableAdapter.Fill(this.newDBDataSet.TestTable);

        }

            public void AddData(int id, string name, string phone, string address)
            {
                string connectionString = "Data Source=DESKTOP-HLDLRB2;Initial Catalog=NewDB;Integrated Security=True";
            string insertQuery = "INSERT INTO NewDB.dbo.ТestTable (ID, Name, Phone, Address) VALUES (@ID, @Name, @Phone, @Address)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                    command.Parameters.AddWithValue("ID", name);
                    command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        public void DeleteData(int id)
        {

        }

    }
}
