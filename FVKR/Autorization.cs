using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FVKR
{

    public partial class Autorization : Form
    {
        public TextBox UsernameTextBox { get; set; }
        public TextBox PasswordTextBox { get; set; }

        public Autorization()
        {
            InitializeComponent();
            
        }
    
            private void guna2Button1_Click(object sender, EventArgs e)

        {
            if (guna2TextBox1.Text == "admin")
            {
                Form1 newForm = new Form1();
                newForm.Show();
            }
            else if (guna2TextBox1.Text == "doctor")
            {
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else
            {
                MessageBox.Show(
      "Введите данные учетной записи!",
      "Сообщение", MessageBoxButtons.OK);
            }

        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newDBDataSet.TestTable". При необходимости она может быть перемещена или удалена.
            this.testTableTableAdapter.Fill(this.newDBDataSet.TestTable);

        }
        

        public string EmptyCheck(string input1, string input2)
        {
            
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                return "Введите данные!";
            }
            else
                return "";
        }
        public string LoginCheck(string input1, string input2)
        {

            if (input1== "admin" || input1== "Doctor" && input2 == "12345")
            {
                return "Успешный вход";
            }
            else
            {

                return "Ошибка!Проверьте корректность введенныйх данных!";
            }

        }
        public string CheckAutorization(string input1, string input2)
        {

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                return "Введите данные!";
            }
            else
                return "";
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
