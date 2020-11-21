using System;
using Windows.UI.Xaml.Data;

namespace PhoenixEffect.Shared.Converters
{
    public class DateStringFormatConverter : IValueConverter
    {
        /// <summary>
        /// Converts a string to a date string.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType.Equals(typeof(System.String)))
            {
                DateTime dt = new DateTime();
                bool gotDate = DateTime.TryParse(value.ToString(), out dt);

                if (gotDate == true)
                {
                    if (parameter == null || parameter.ToString() == "d")
                    {
                        return dt.Date.ToString("d");
                    }
                    else if (parameter.ToString() == "D")
                    {
                        return dt.Date.ToString("D");
                    }
                    else if (parameter.ToString() == "dd MMM yyyy")
                    {
                        return dt.Date.ToString("dd MMM yyyy");
                    }
                    else if (parameter.ToString() == "t")
                    {
                        return dt.ToString("t");
                    }
                    else if (parameter.ToString() == "g")
                    {
                        return dt.ToString("g");
                    }
                }

                return value;
            }
            else
            {
                throw new ArgumentException("Unsuported type {0}", targetType.FullName);
            }
        }

        /// <summary>
        /// No need to implement converting back on a one-way binding.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
