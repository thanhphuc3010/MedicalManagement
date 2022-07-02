using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Helper
{
    public static class TextBoxExtensions
    {
        public static void binding(this TextBox textBox, object dataSoure, string field)
        {
            textBox.DataBindings.Clear();
            textBox.DataBindings.Add(new Binding("Text", dataSoure, field)
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                //ControlUpdateMode = ControlUpdateMode.Never
            });
        }

       public static void BindingWith(this TextBox textBox, object dataSource, string field)
        {
            textBox.DataBindings.Clear();
            Binding dataBinding = new Binding("Text", dataSource, field, true, DataSourceUpdateMode.OnPropertyChanged);
            textBox.DataBindings.Add(dataBinding);
        }
    }
}
