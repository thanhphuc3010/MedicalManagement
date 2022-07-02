using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Model
{
    public class Customer : ICloneable
    {
        private string id;
        private string name;
        private bool type;
        private String phone;
        private String email;
        private String address;
        private String notes;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Type { get => type; set => type = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Notes { get => notes; set => notes = value; }

        public Customer()
        {

        }

        public Customer(string id, string name, bool type, string phone, string email, string address, string notes)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.Notes = notes;
        }

        public object Clone()
        {
            return new Customer(id, name, type, phone, email, address, notes);
        }
    }
}
