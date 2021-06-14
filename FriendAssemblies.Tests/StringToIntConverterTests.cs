using FriendAssemblies.Library;
using System;
using Xunit;
namespace FriendAssemblies.Tests
{
    public class StringToIntConverterTests
    {
        [Theory]
        //inlocuieste default value cu valorile
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        public void ConvertToInt_When_StringIsNull_Expected_ReturnsDefaultValue(int defaultValue)
        {
            //Arrage
            string str = null;

            //Act
            int convertedValue = StringToIntConverter.ConvertStringToInt(str, defaultValue);

            //assert
            Assert.Equal(defaultValue, convertedValue);

        }
    }
}
