using FVKR.TVKRDataSetTableAdapters;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.Blue300, Primary.Blue100, Accent.Blue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet7.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter1.Fill(this.tVKRDataSet7.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet6.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.tVKRDataSet6.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet.Warehouse_SKL". При необходимости она может быть перемещена или удалена.
            this.warehouse_SKLTableAdapter.Fill(this.tVKRDataSet.Warehouse_SKL);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.tVKRDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet.Reception". При необходимости она может быть перемещена или удалена.
            this.receptionTableAdapter.Fill(this.tVKRDataSet.Reception);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.tVKRDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.tVKRDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.tVKRDataSet.Applications);
            try
            {


                using (TVKREntities db = new TVKREntities())
                {
                    //var query = from o in db.Receptions
                    //            select o;
                    //guna2DataGridView3.DataSource = query.ToList();

                    //db.Configuration.ProxyCreationEnabled = false;
                    cmb1.DataSource = db.Employees.ToList();
                    cmb1.ValueMember = "ID";
                    cmb1.DisplayMember = "EmpName";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            applicationsBindingSource.Filter = "DateOf >= '" + bunifuDatePicker1.Value + "' AND DateOf <= '" + bunifuDatePicker2.Value + "'";
        }

        private void bunifuDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            applicationsBindingSource.Filter = "DateOf >= '" + bunifuDatePicker1.Value + "' AND DateOf <= '" + bunifuDatePicker2.Value + "'";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text))
                applicationsBindingSource.Filter = string.Empty;
            else
                applicationsBindingSource.Filter = string.Format("Name LIKE '%" + guna2TextBox1.Text + "%' OR PhoneNumber LIKE '%" + guna2TextBox1.Text + "%'");

        }

        private void guna2DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            applicationsTableAdapter.Update(this.tVKRDataSet.Applications);
        }

        private void guna2DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            applicationsTableAdapter.Update(this.tVKRDataSet.Applications);
        }

        private void guna2DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            applicationsTableAdapter.Update(this.tVKRDataSet.Applications);
        }

        private void guna2DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            applicationsTableAdapter.Update(this.tVKRDataSet.Applications);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox2.Text))
                patientBindingSource.Filter = string.Empty;
            else
                patientBindingSource.Filter = string.Format("PtName LIKE '%" + guna2TextBox2.Text + "%' OR PhoneNumber LIKE '%" + guna2TextBox2.Text + "%'");

        }

        private void guna2DataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2DataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2DataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2DataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Employee obj = cmb1.SelectedItem as Employee;
            if (obj != null)
            {

                try
                {
                    using (TVKREntities db = new TVKREntities())
                    {
                        //db.Configuration.ProxyCreationEnabled = false;
                        var query = from o in db.Receptions
                                    where o.Doctor == obj.ID
                                    select o;

                        guna2DataGridView3.DataSource = query.ToList();
                        //receptionBindingSource.DataSource=db.Reception.Where(p=>p.Doctor==obj.ID).ToList();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }

        private void bunifuDatePicker4_ValueChanged(object sender, EventArgs e)
        {
            using (TVKREntities db = new TVKREntities())
            {
                var query = from o in db.Receptions
                            where o.DateOf >= bunifuDatePicker3.Value
                            && o.DateOf <= bunifuDatePicker4.Value
                            select o;
                guna2DataGridView3.DataSource = query.ToList();
                
            }
        }

        private void bunifuDatePicker3_ValueChanged(object sender, EventArgs e)
        {
            using (TVKREntities db = new TVKREntities())
            {
                var query = from o in db.Receptions
                            where o.DateOf >= bunifuDatePicker3.Value
                            && o.DateOf <= bunifuDatePicker4.Value
                            select o;
                guna2DataGridView3.DataSource = query.ToList();
            }
        }

        private void guna2DataGridView3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            using (TVKREntities db = new TVKREntities())
            {
                var query = from o in db.Receptions
                                    select o;
                guna2DataGridView3.DataSource = query.ToList();
                db.SaveChanges();

            }

        }

        private void guna2DataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (TVKREntities db = new TVKREntities())
            {
                //var query = from o in db.Receptions
                //            select o;
                //guna2DataGridView3.DataSource = query.ToList();
                db.SaveChanges();

            }
        }

        private void guna2DataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            using (TVKREntities db = new TVKREntities())
            {
                //var query = from o in db.Receptions
                //            select o;
                //guna2DataGridView3.DataSource = query.ToList();
                db.SaveChanges();

            }
        }

        private void guna2DataGridView3_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            using (TVKREntities db = new TVKREntities())
            {
                //var query = from o in db.Receptions
                //            select o;
                //guna2DataGridView3.DataSource = query.ToList();
                db.SaveChanges();

            }
        }

        //private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Employee obj = guna2ComboBox1.SelectedItem as Employee;
        //    if (obj != null)
        //    {

        //        try
        //        {
        //            using (TVKREntities db = new TVKREntities())
        //            {
        //                db.Configuration.ProxyCreationEnabled = false;
        //                var query = from o in db.Receptions
        //                            where o.Doctor == obj.ID
        //                            select o;

        //                guna2DataGridView4.DataSource = query.ToList();
        //                //receptionBindingSource.DataSource=db.Reception.Where(p=>p.Doctor==obj.ID).ToList();

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

                

        //    }
            
        //}

        //private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    guna2DataGridView4.AutoGenerateColumns = true;
        //}

        private void guna2DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox3.Text))
                employeeBindingSource2.Filter = string.Empty;
            else
                employeeBindingSource2.Filter = string.Format("EmpName LIKE '%" + guna2TextBox3.Text + "%' OR Phone_Number LIKE '%" + guna2TextBox3.Text + "%'");

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox4.Text))
             providerBindingSource.Filter = string.Empty;
            
            else
                providerBindingSource.Filter = string.Format("PrvName LIKE '%" + guna2TextBox4.Text + "%'");
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox5.Text))
                warehouseSKLBindingSource.Filter = string.Empty;
            

            else
                warehouseSKLBindingSource.Filter = string.Format("ProdName LIKE '%" + guna2TextBox5.Text + "%'");
        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2DataGridView2_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2DataGridView2_KeyDown_1(object sender, KeyEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2DataGridView2_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            ReportPatients newForm = new ReportPatients();
            newForm.Show();
        }

        private void bunifuGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView2_CellBeginEdit_2(object sender, DataGridViewCellCancelEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2DataGridView2_CellEndEdit_2(object sender, DataGridViewCellEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }

        private void guna2DataGridView2_KeyDown_2(object sender, KeyEventArgs e)
        {
            patientTableAdapter.Update(this.tVKRDataSet.Patient);
        }
    }
}
