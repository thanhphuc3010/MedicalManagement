using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalManagement.Model;
using MedicalManagement.Helper;

namespace MedicalManagement.Forms
{
    public partial class frmMedicineDQG : Form
    {
        private DataTableCollection tableCollection;
        private List<Medicine> medicines = new List<Medicine>();
        public frmMedicineDQG()
        {
            InitializeComponent();
        }

        private void frmMedicineDQG_Load(object sender, EventArgs e)
        {
            using (var stream = File.Open("DQG.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration() 
                    {
                        ConfigureDataTable=(_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    tableCollection = result.Tables;
                    DataTable dt = tableCollection[0];
                    medicines = dt.ToEntities<Medicine>();

                    medicineBindingSource.DataSource = medicines;
                }
            }
        }
    }
}
