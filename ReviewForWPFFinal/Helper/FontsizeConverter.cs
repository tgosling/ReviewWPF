using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ReviewForWPFFinal.Helper
{
    class FontSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is int)
            {
                    int num = (int)value;
                    if (num < 2)
                        return 10;
                    else if (num < 4)
                        return 20;
                    else
                        return 30;
            }

            return 20;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
