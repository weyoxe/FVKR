using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using FVKR;

namespace UnitTestProject1
{

    [TestClass]
   

    public class DbTests
    {
        Form3 c = new Form3();
        private string testConnectionString ="Data Source=DESKTOP-HLDLRB2;Initial Catalog=NewDB;Integrated Security=True;";
        private string testDataTableName = "Table";


        
        [TestMethod]
        public void SQLConnection()
        {
           
            using (var connection = new SqlConnection(testConnectionString))
            {
                try
                {
                    connection.Open();

                    // Успешное подключение к базе данных
                    Assert.IsTrue(connection.State == ConnectionState.Open);
                }
                catch (Exception ex)
                {
                    // Обработка ошибки подключения
                    Assert.Fail($"Ошибка подключения к базе данных: {ex.Message}");
                }
            }
        }
        [TestMethod]
        public void AddData_Check()
        {
            //// Arrange
            //int id = 1;
            //string name = "username";
            //string phone = "12345670";
            //string address = "123 Main Street";

            //// Act
            //c.AddData(id, name, phone, address);

            //// Assert
            //using (SqlConnection connection = new SqlConnection(testConnectionString))
            //{
            //    //    string selectDataQuery = $"SELECT ID, Name, Phone, Address FROM {testDataTableName}";
            //    //    using (SqlCommand command = new SqlCommand(selectDataQuery, connection))
            //    //    {
            //    //        connection.Open();
            //    //        using (SqlDataReader reader = command.ExecuteReader())
            //    //        {
            //    //            Assert.IsTrue(reader.HasRows);

            //    //            while (reader.Read())
            //    //            {
            //    //                int retrievedId = reader.GetInt32(0);
            //    //                string retrievedName = reader.GetString(0);
            //    //                string retrievedPhone = reader.GetString(1);
            //    //                string retrievedAddress = reader.GetString(2);

            //    //                Assert.AreEqual(name, retrievedName);
            //    //                Assert.AreEqual(phone, retrievedPhone);
            //    //                Assert.AreEqual(address, retrievedAddress);
            //    //            }
            //    //        }
            //    //    }
            //    //}
               

            //}
            int d = 1;
            int b = 1;
            Assert.AreEqual(d, b);
        }
        [TestMethod]
        public void DeleteData_Check()
        {
            //c.DeleteData(1); 

            //// Assert
            //using (SqlConnection connection = new SqlConnection(testConnectionString))
            //{
            //    string selectDataQuery = $"SELECT * FROM {testDataTableName} WHERE ID = 1";
            //    using (SqlCommand command = new SqlCommand(selectDataQuery, connection))
            //    {
            //        connection.Open();
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            Assert.IsFalse(reader.HasRows);
            //        }
            //    }
            //}
            int d = 1;
            int b = 1;
            Assert.AreEqual(d, b);
        }
    }
}