using FriendAssemblies.Library;
using System;
using Xunit;

namespace FriendAssemblies.Tests
{
    public class ArrayHelperTest
    {
        [Fact]
        public void ConvertToIntArray_When_StringArrayIsNull_Expected_ReturnsEmptyIntArray()
        {
            //Arrage
            string[] stringArray = null;

            //Act
            int[] intArray = ArrayHelper.ConvertToIntArray(stringArray);

            //assert
            Assert.Empty(intArray);

        }
    }
}
