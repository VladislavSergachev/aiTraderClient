using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace aiTrader
{
    public enum TransactionType
    {
        Profit = 1,
        Loss = -1
    }
    
    public class Transaction
    {
        public decimal Profit { get; set; }
        public string Issuer { get; set; }
        public DateTime TimeStamp { get; set; }
        public TransactionType Type { get; set; }
    }

    public class DateTime2TimeConverter : IValueConverter
    {
        public object Convert(object value, Type typeOf, CultureInfo culture)
        {
            DateTime dt = (DateTime)value;
            return dt.ToShortTimeString();
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime dt = (DateTime)value;
            return dt.ToShortTimeString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
