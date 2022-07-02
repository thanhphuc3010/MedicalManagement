using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalManagement.Model;
using MedicalManagement.Helper;

namespace MedicalManagement
{
    public partial class frmMedicine : Form
    {
        private List<Item> items = new List<Item>();
        public frmMedicine()
        {
            InitializeComponent();
        }

        private void frmMedicine_Load(object sender, EventArgs e)
        {
            var query = "select item.*, make.makeName as make from item left join make on item.makeId = make.id";
            var dt = Database.Instance.excuteQuery(query);
            items = dt.ToEntities<Item>();

            itemBindingSource.DataSource = items;

            BindingTextBoxData();
        }

        private void BindingTextBoxData()
        {
            object dataSource = dgvMedicine.DataSource;
            txtId.binding(dataSource, "Id");
            txtMedicineName.binding(dataSource, "ItemName");
        }
    }
}
