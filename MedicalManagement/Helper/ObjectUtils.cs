using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Helper
{
    public static class ObjectUtils
    {
        public static string formatStringNumber(int i, string prefix)
        {
            string result;
            if (i < 10)
            {
                result = prefix + "0000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = prefix + "000" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = prefix + "00" + i.ToString().Trim();
            }
            else if (i < 10000)
            {
                result = prefix + "0" + i.ToString().Trim();
            }
            else result = prefix + i.ToString().Trim();
            return result;
        }
    }
}
