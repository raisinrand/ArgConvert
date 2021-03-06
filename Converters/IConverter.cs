using System.Globalization;

namespace ArgConvert.Converters
{
    public interface IConverter
    {
        // returns null if input is null or conversion fails
        object Convert(object value, object parameter = null, CultureInfo culture = null);
        object ConvertBack(object value, object parameter = null, CultureInfo culture = null);
    }
}