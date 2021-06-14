using FriendAssemblies.Library;
using System;

namespace FriendAssemblies.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new[] { "123", "456", "abc" };
            int[] intArray = ArrayHelper.ConvertToIntArray(stringArray);

            Console.WriteLine(string.Join(",", intArray));
        }
    }
}
