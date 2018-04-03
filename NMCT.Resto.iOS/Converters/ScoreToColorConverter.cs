using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Platform.Converters;
using UIKit;

namespace NMCT.Resto.iOS.Converters
{
    public class ScoreToColorConverter :MvxValueConverter<double,UIColor>
    {

        protected override UIColor Convert(double value, Type targetType, object parameter, CultureInfo culture)
        {
            return GetColor(value);
        }

        private UIColor GetColor(double color)
        {
            if (double.IsNaN(color)) return null;

            else if (color <= 2)
                return UIColor.Green;
            else if (color <= 4)
                return UIColor.FromRGBA(112, 173, 71, 1);
            else if (color <= 5)
                return UIColor.FromRGBA(243, 1, 1, 1);

            return UIColor.Red;
        }
    }
}