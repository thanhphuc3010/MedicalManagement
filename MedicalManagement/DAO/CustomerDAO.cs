using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalManagement.Model;
using MedicalManagement.Helper;
using MedicalManagement.Utils;
using System.Windows.Forms;

namespace MedicalManagement.DAO
{
    class CustomerDAO
    {
        private static object[] Init(Customer customer)
        {
            string id = customer.Id;
            string name = customer.Name;
            bool type = customer.Type;
            var address = DBValidation.IsDBNullValue(customer.Address);
            var phone = DBValidation.IsDBNullValue(customer.Phone);
            var email = DBValidation.IsDBNullValue(customer.Email);
            var notes = DBValidation.IsDBNullValue(customer.Notes);
            return new object[] { id, name, type, phone, email, address, notes };
        }

        public static int InsertCustomer(Customer customer)
        {
            var parameters = Init(customer);
            var insertStatement = "INSERT INTO customer (id, name, type, phone, email, address, notes) VALUES ( @id , @name , @type , @phone , @email , @address , @notes )";
            return Database.Instance.excuteNonQuery(insertStatement, parameters);
        }

        public static int UpdateCustomer(Customer customer)
        {
            string id = customer.Id;
            string name = customer.Name;
            bool type = customer.Type;
            var address = DBValidation.IsDBNullValue(customer.Address);
            var phone = DBValidation.IsDBNullValue(customer.Phone);
            var email = DBValidation.IsDBNullValue(customer.Email);
            var notes = DBValidation.IsDBNullValue(customer.Notes);

            var updateStatement = "UPDATE customer SET name = @name , type = @type , phone = @phone , email = @email , address = @address , notes = @notes WHERE id = @id ";
            return Database.Instance.excuteNonQuery(updateStatement, new object[] { name, type, phone, email, address, notes, id });
        }

        public static bool DeleteCustomer(string customerId) 
        {
            try
            {
                var deleteStatement = "DELETE FROM customer WHERE id = @id ";
                Database.Instance.excuteNonQuery(deleteStatement, new object[] { customerId });
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Commit Exception Type: {0}", e.GetType());
                Console.WriteLine("  Message: {0}", e.Message);
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("Đã có lỗi xảy ra, xoá bản ghi thất bại");
                return false;
            }
        }
    }
}
