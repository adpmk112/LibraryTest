using System;
using System.Collections.Generic;
using System.Text;
using TimeZoneConverter;

namespace Readymade_utils_test
{
    public class DateTimeFormat // using TimeZoneConverter library
    {

        public static TimeZoneInfo tzi = TZConvert.GetTimeZoneInfo("Asia/Yangon");

        public string addTimeInPhoto(String photoName)
        {
            char[] delimiterChars = { '.' };
            DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tzi);
            string[] words = photoName.Split(delimiterChars, 2);
            StringBuilder sb = new StringBuilder(words[0]);
            sb.Append(now.ToString("yyyyMMddHHmmffff"));
            sb.Append(".");
            sb.Append(words[1]);
            return sb.ToString();
        }
    }
}
