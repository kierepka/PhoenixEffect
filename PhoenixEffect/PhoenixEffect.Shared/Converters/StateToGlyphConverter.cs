using System;

using Windows.UI.Xaml.Data;

namespace PhoenixEffect.Shared.Converters
{
    public class StateToGlyphConverter : IValueConverter
    {
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string state = value.ToString();

            string badgeGlyph = null;

            if (state == "None")
            {
                //badgeGlyph = "\uF142";
            }
            else if (state == "Accepted")
            {
                badgeGlyph = "\uF13E";
            }
            else if (state == "Declined")
            {
                badgeGlyph = "\uF13D";
            }

            return badgeGlyph;
        }
    }
}
