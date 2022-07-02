using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Model
{
    class Supplier: ICloneable
    {
        private string name;
        private string phone;
        private string email;
        private string address;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        public Supplier(string name, string phone, string email, string address)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
        }

        public object Clone()
        {
            return new Supplier(name, phone, email, address);
        }
    }

}
