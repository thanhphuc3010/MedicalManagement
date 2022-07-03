using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Model
{
    class Medicine
    {
        private string code;
        private string name;
        private string registrationNo;
        private string activeElement;
        private string content;
        private string manufacturerName;
        private string manufacturerCountryName;
        private string packagingSize;
        private string unit;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string RegistrationNo { get => registrationNo; set => registrationNo = value; }
        public string ActiveElement { get => activeElement; set => activeElement = value; }
        public string Content { get => content; set => content = value; }
        public string ManufacturerName { get => manufacturerName; set => manufacturerName = value; }
        public string ManufacturerCountryName { get => manufacturerCountryName; set => manufacturerCountryName = value; }
        public string PackagingSize { get => packagingSize; set => packagingSize = value; }
        public string Unit { get => unit; set => unit = value; }

        public Medicine(string code, string name, string registrationNo, string activeElement, string content, string manufacturerName, string manufacturerCountryName, string packagingSize, string unit)
        {
            Code = code;
            Name = name;
            RegistrationNo = registrationNo;
            ActiveElement = activeElement;
            Content = content;
            ManufacturerName = manufacturerName;
            ManufacturerCountryName = manufacturerCountryName;
            PackagingSize = packagingSize;
            Unit = unit;
        }

        public Medicine()
        {
        }
    }
}
