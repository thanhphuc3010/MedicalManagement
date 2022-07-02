using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Model
{
    class Staff : ICloneable
    {
        private string id;
        private string fullName;
        private DateTime dob;
        private bool sex;
        private string certificate;
        private string phone;
        private string email;
        private string address;

        // Ctrl R + Ctrl E
        public string Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string Certificate { get => certificate; set => certificate = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        public Staff(string id, string fullName, DateTime dob, bool sex, string certificate, string phone, string email, string address)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Dob = dob;
            this.Sex = sex;
            this.Certificate = certificate;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
        }

        public object Clone()
        {
            return new Staff(id, fullName, dob, sex, certificate, phone, email, address);
        }
    }
}
