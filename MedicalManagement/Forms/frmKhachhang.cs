using MedicalManagement.Model;
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
using MedicalManagement.Helper;
using MedicalManagement.DAO;

namespace MedicalManagement.Forms
{
    public partial class frmKhachhang : Form
    {
        private List<Customer> customers;
        private Customer customer = new Customer();
        private bool isAddNew = false;

        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        { 
            LoadData();
            BindingTextBoxData();
            pnCustomer.Enabled = false;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM customer ORDER BY id ASC";
            var dt = Database.Instance.excuteQuery(query);
            customers = dt.ToEntities<Customer>();
            customerBindingSource.DataSource = customers;
            dgvKhachhang.DataSource = customerBindingSource;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddNew = true;

            pnCustomer.Enable();
            btnAdd.Disable();
            btnEdit.Disable();
            btnDel.Disable();
            btnSave.Enable();
            btnCancle.Enable();
         
            ResetAllTextBox();
            BindingCustomerData(customer);

            txtId.Text = GenerateId("KH");
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BindingTextBoxData()
        {
            object dataSoure = dgvKhachhang.DataSource;

            txtId.binding(dataSoure, "id");
            txtName.binding(dataSoure, "name");
            txtType.binding(dataSoure, "type");
            txtAddress.binding(dataSoure, "address");
            txtPhone.binding(dataSoure, "phone");
            txtEmail.binding(dataSoure, "email");
            txtNotes.binding(dataSoure, "notes");
        }

        private void BindingCustomerData(Customer customer)
        {
            txtId.BindingWith(customer, "Id");
            txtName.BindingWith(customer, "Name");
            txtType.BindingWith(customer, "Type");
            txtAddress.BindingWith(customer, "Address");
            txtPhone.BindingWith(customer, "Phone");
            txtEmail.BindingWith(customer, "Email");
            txtNotes.BindingWith(customer, "Notes");
        }

        private void ResetAllTextBox()
        {
            txtId.Text = String.Empty;
            txtName.Text = String.Empty;
            txtType.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtNotes.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                CustomerDAO.InsertCustomer(customer);
            }
            else
            {
                CustomerDAO.UpdateCustomer(customer);
            }

            
            isAddNew = false;
            pnCustomer.Disable();
            btnAdd.Enable();
            btnEdit.Enable();
            btnDel.Enable();
            btnSave.Disable();
            btnCancle.Disable();

            BindingTextBoxData();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnCustomer.Enable();
            btnAdd.Disable();
            btnEdit.Disable();
            btnDel.Disable();
            btnSave.Enable();
            btnCancle.Enable();

            customer = customerBindingSource.Current as Customer;

            Customer editingCustomer = customer.Clone() as Customer;

            BindingCustomerData(editingCustomer);
            (sender as Button).Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            pnCustomer.Disable();
            btnAdd.Enable();
            btnEdit.Enable();
            btnDel.Enable();
            btnSave.Disable();
            btnCancle.Disable();

            BindingTextBoxData();
            customerBindingSource.ResetBindings(true);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var customer = customerBindingSource.Current as Customer;
            CustomerDAO.DeleteCustomer(customer.Id);
            LoadData();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dgvKhachhang.ClearSelection();
            dgvKhachhang.CurrentCell = dgvKhachhang[0, 0];
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dgvKhachhang.ClearSelection();
            var lastRowIndex = dgvKhachhang.RowCount - 1;
            if (lastRowIndex == -1) return;

            dgvKhachhang.CurrentCell = dgvKhachhang[0, dgvKhachhang.RowCount - 1];
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvKhachhang.CurrentRow.Index.ToString());
            if (i > 0)
            {
                dgvKhachhang.CurrentCell = dgvKhachhang[0, i - 1];
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvKhachhang.CurrentRow.Index.ToString());
            if (i < dgvKhachhang.RowCount - 1)
            {
                dgvKhachhang.CurrentCell = dgvKhachhang[0, i + 1];
            }
        }

        private string GenerateId(string prefix)
        {
            var key = 0;
            List<Customer> sortedList = customers.OrderBy(c => c.Id).ToList();
            if (sortedList.Count == 0)
            {
                key = 1;
            } else
            {
                Customer lastCustomer = sortedList.Last();
                string lastID = lastCustomer.Id.ToString();
                string index = lastID.Substring(prefix.Length);
                key = Convert.ToInt16(index) + 1;
            }

            return ObjectUtils.formatStringNumber(key, prefix);
        }
    }
}

