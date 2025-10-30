using System;
using System.Globalization;
using System.Windows.Data; // IValueConverter

namespace SurfaceChart
{
    // Converts numeric Z index (1..5) to country names for Z-axis labels
    public class CountryIndexToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // SurfaceAxis passes LabelContent as double/string; normalize to int
            int index = 0;
            if (value is double d) index = (int)Math.Round(d);
            else if (value is string s && double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var dv)) index = (int)Math.Round(dv);

            return index switch
            {
                1 => "Canada",
                2 => "France",
                3 => "India",
                4 => "UK",
                5 => "US",
                _ => string.Empty
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotSupportedException();
    }
}
