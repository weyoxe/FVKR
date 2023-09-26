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
    public partial class ReportPatients : Form
    {
        public ReportPatients()
        {
            InitializeComponent();
        }

        private void ReportPatients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TVKRDataSet4.Reception". При необходимости она может быть перемещена или удалена.
            this.ReceptionTableAdapter.Fill(this.TVKRDataSet4.Reception);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TVKRDataSet4.Employee". При необходимости она может быть перемещена или удалена.
            this.EmployeeTableAdapter.Fill(this.TVKRDataSet4.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TVKRDataSet1.Patient". При необходимости она может быть перемещена или удалена.
            this.PatientTableAdapter.Fill(this.TVKRDataSet1.Patient);

            this.reportViewer1.RefreshReport();
        }
    }
}
