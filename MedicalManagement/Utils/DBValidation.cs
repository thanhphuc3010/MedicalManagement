using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Utils
{
    class DBValidation
    {
        public static object IsDBNullValue(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            } else
            {
                return value;
            }
        }
    }
}
