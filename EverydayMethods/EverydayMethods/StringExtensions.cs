using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayMethods
{
    public static class StringExtensions
    {
        public static int? ToInteger(this string str)
        {
            int intOut;
            if (int.TryParse(str, out intOut))
            {
                return intOut;
            }

            return null;
        }

        public static int ParseInt(this string str)
        {
            int intOut;
            if (int.TryParse(str, out intOut))
            {
                return intOut;
            }

            throw new ArgumentException("str is not a valid integer string.");
        }
    }
}
