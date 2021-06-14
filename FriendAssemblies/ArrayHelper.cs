using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendAssemblies.Library
{
    public static class ArrayHelper
    {
        public static int[] ConvertToIntArray(string[] stringArray)
        {
            if(stringArray is null)
            {
                return new int[0];
            }

            int[] intArray = new int[stringArray.Length];
            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = StringToIntConverter.ConvertStringToInt(stringArray[i], 0); 
            }
            return intArray;
        }
    }
}
