using System;
using ArgConvert.Converters;

namespace ArgConvert
{
    public static class ArgConvert {

        public static TimeSpan? ParseTimeOfDay(string s) {
            var timeOfDayToStringConverter = new TimeOfDayToStringConverter();
            try {
                return (TimeSpan?)ConvertWith(s, timeOfDayToStringConverter);
            }
            catch(ArgumentException){
                throw new ArgumentException("Failed to parse time of day.");
            }
        }
        public static TimeSpan? ParseTimeSpan(string s) {
            var timeSpanToStringConverter = new TimeSpanToStringConverter();
            try {
                return (TimeSpan?)ConvertWith(s, timeSpanToStringConverter);
            }
            catch(ArgumentException){
                throw new ArgumentException("Failed to parse time span.");
            }
        }
        public static DateTime? ParseDate(string s) {
            var dateTimeToStringConverter = new DateToStringConverter();
            try {
                return (DateTime?)ConvertWith(s, dateTimeToStringConverter);
            }
            catch(ArgumentException){
                throw new ArgumentException("Failed to parse date.");
            }
        }

        public static object ConvertWith(string s, IConverter converter) {
            if(s == null) return null;
            var res = converter.ConvertBack(s);
            if(res == null) {
                throw new ArgumentException("Failed to parse.");
            }
            return res;
        } 
    }
}