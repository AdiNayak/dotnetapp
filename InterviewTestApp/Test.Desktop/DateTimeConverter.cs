using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Desktop
{
    public static class DateTime_Converter
    {
        public static string ConvertUtcToLocalFormat(DateTime utcDateTime, string locale)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(locale);
            DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZone);
            return localDateTime.ToString("dd-MMM-yyyy");
        }

        public static DateTime ConvertLocalToUtc(string localDateString, string locale)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(locale);
            DateTime localDateTime = DateTime.ParseExact(localDateString, "dd-MMM-yyyy", null);
            DateTime utcDateTime = TimeZoneInfo.ConvertTimeToUtc(localDateTime, timeZone);
            return utcDateTime;
        }
    }
}
