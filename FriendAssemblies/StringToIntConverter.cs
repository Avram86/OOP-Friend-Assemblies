using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendAssemblies.Library
{
    //nu o expunem dar o folosim in int librariei
    internal static class StringToIntConverter
    {
        internal static int ConvertStringToInt(string str, int defaultValue)
        {
            if (string.IsNullOrEmpty(str))
            {
                return defaultValue;
            }

            bool canConvert = int.TryParse(str, out int convertedValue);
            if (!canConvert)
            {
                return defaultValue;
            }

            return convertedValue;
        }
    }
}
