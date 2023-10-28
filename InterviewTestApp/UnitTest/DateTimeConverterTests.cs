

using TestLib;

namespace UnitTest
{
    [TestClass]
    public class DateTimeConverterTests
    {
        [TestMethod]
        public void ConvertUtcToLocalFormat_ShouldConvertToLocaleFormat()
        {
            // Arrange
            DateTime utcDateTime = DateTime.UtcNow;
            string expectedLocaleFormat = utcDateTime.ToLocalTime().ToString("dd-MMM-yyyy");

            // Act
            string result = DateTime_Converter.ConvertUtcToLocalFormat(utcDateTime, "YourTimeZoneId");

            // Assert
            Assert.AreEqual(expectedLocaleFormat, result);
        }

        [TestMethod]
        public void ConvertLocalToUtc_ShouldConvertToUtc()
        {
            // Arrange
            string localDateString = "26-Sep-2023";
            DateTime expectedUtcDateTime = DateTime.ParseExact(localDateString, "dd-MMM-yyyy", null).ToUniversalTime();

            // Act
            DateTime result = DateTime_Converter.ConvertLocalToUtc(localDateString, "YourTimeZoneId");

            // Assert
            Assert.AreEqual(expectedUtcDateTime, result);
        }
    }
}
