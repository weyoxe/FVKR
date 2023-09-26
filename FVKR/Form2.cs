using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FVKR
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.Blue300, Primary.Blue100, Accent.Blue200, TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.tVKRDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet4.NMedPlan". При необходимости она может быть перемещена или удалена.
            this.nMedPlanTableAdapter1.Fill(this.tVKRDataSet4.NMedPlan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet4.MedCardShort". При необходимости она может быть перемещена или удалена.
            this.medCardShortTableAdapter1.Fill(this.tVKRDataSet4.MedCardShort);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet4.Curator". При необходимости она может быть перемещена или удалена.
            this.curatorTableAdapter.Fill(this.tVKRDataSet4.Curator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet4.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.tVKRDataSet4.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet4.Reception". При необходимости она может быть перемещена или удалена.
            this.receptionTableAdapter.Fill(this.tVKRDataSet4.Reception);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.SPR_Service". При необходимости она может быть перемещена или удалена.
            this.sPR_ServiceTableAdapter.Fill(this.tVKRDataSet1.SPR_Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.SPR_Diagnosis". При необходимости она может быть перемещена или удалена.
            this.sPR_DiagnosisTableAdapter.Fill(this.tVKRDataSet1.SPR_Diagnosis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.SPR_Complaints_J". При необходимости она может быть перемещена или удалена.
            this.sPR_Complaints_JTableAdapter.Fill(this.tVKRDataSet1.SPR_Complaints_J);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.Service_Category". При необходимости она может быть перемещена или удалена.
            this.service_CategoryTableAdapter.Fill(this.tVKRDataSet1.Service_Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet3.NMedPlan". При необходимости она может быть перемещена или удалена.
            this.nMedPlanTableAdapter.Fill(this.tVKRDataSet3.NMedPlan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet3.MedPlan". При необходимости она может быть перемещена или удалена.
            this.medPlanTableAdapter.Fill(this.tVKRDataSet3.MedPlan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet2.UsedMaterials". При необходимости она может быть перемещена или удалена.
            this.usedMaterialsTableAdapter.Fill(this.tVKRDataSet2.UsedMaterials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.MD_Service". При необходимости она может быть перемещена или удалена.
            this.mD_ServiceTableAdapter.Fill(this.tVKRDataSet1.MD_Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.MD_Diagnosis". При необходимости она может быть перемещена или удалена.
            this.mD_DiagnosisTableAdapter.Fill(this.tVKRDataSet1.MD_Diagnosis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.MD_Complaints". При необходимости она может быть перемещена или удалена.
            this.mD_ComplaintsTableAdapter.Fill(this.tVKRDataSet1.MD_Complaints);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tVKRDataSet1.MedCardShort". При необходимости она может быть перемещена или удалена.
            this.medCardShortTableAdapter.Fill(this.tVKRDataSet1.MedCardShort);


        }

        private void guna2DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Complaints");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            bunifuPages1.SetPage("Diagnosis");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Service");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("ServiceCategory");
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Employee obj = guna2ComboBox3.SelectedItem as Employee;
            //if (obj != null)
            //{

            //    try
            //    {
            //        using (TVKREntities db = new TVKREntities())
            //        {
            //            //db.Configuration.ProxyCreationEnabled = false;
            //            var query = from o in db.Receptions
            //                        where o.Doctor == obj.ID
            //                        select o;

            //            guna2DataGridView12.DataSource = query.ToList();

            //            //receptionBindingSource.DataSource=db.Reception.Where(p=>p.Doctor==obj.ID).ToList();

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //DataTable dataTable = new DataTable();

            //    // Определение столбцов таблицы
            //    foreach (var column in guna2DataGridView12.Columns)
            //    {
            //        dataTable.Columns.Add(column.HeaderText);
            //    }

            //    // Заполнение таблицы данными из списка
            //    foreach (var item in personList)
            //    {
            //        var row = dataTable.NewRow();

            //        foreach (var column in dataGridView.Columns)
            //        {
            //            var cellValue = item.GetType().GetProperty(column.HeaderText).GetValue(item, null);
            //            row[column.HeaderText] = cellValue;
            //        }

            //        dataTable.Rows.Add(row);
            //    }

            //    // Установка источника данных для DataGridView
            //    dataGridView.DataSource = dataTable;
            //}

            //}
            //guna2DataGridView12.DataSource = this.receptionTableAdapter.Fill(this.tVKRDataSet4.Reception);

            //string selectedValue = guna2ComboBox3.SelectedValue.ToString();
            //string selectedDisplay = guna2ComboBox3.GetItemText(guna2ComboBox3.SelectedItem);

            //foreach (DataGridViewRow row in guna2DataGridView12.Rows)
            //{
            //    if (row.Cells[selectedDisplay].Value != null && row.Cells[selectedDisplay].Value.ToString().Equals(selectedValue))
            //    {
            //        row.Visible = true;
            //    }
            //    else
            //    {
            //        row.Visible = false;
            //    }
            //}

            //int selectedId = (int)guna2ComboBox3.SelectedValue;

            //foreach (DataGridViewRow row in guna2DataGridView12.Rows)
            //{
            //    if (row.Cells["Doctor"].Value != null && (int)row.Cells["Doctor"].Value == selectedId)
            //    {
            //        row.Visible = true;
            //    }
            //    else
            //    {
            //        row.Visible = false;
            //    }
            //}
            //string selectedColumn = guna2ComboBox3.SelectedValue.ToString();
            //string selectedValue = guna2ComboBox3.GetItemText(guna2ComboBox3.SelectedItem);

            //receptionBindingSource.Filter = $"{selectedColumn} = {selectedValue}"; ;
            //guna2DataGridView12.Refresh();
            string selectedValueString = Convert.ToString(guna2ComboBox3.SelectedValue);
           
            //receptionBindingSource.Filter = $"Doctor = '{guna2ComboBox3.SelectedValue}'"; // За
            //    guna2DataGridView12.EndEdit();
            //    guna2DataGridView12.Refresh();
            if (int.TryParse(selectedValueString, out int selectedValue))
            {
                receptionBindingSource.Filter = $"Doctor = {selectedValue}";
            }

        }

        private void bunifuGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            ReportPatients newForm = new ReportPatients();
            newForm.Show();
        }
    }
}
