/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
All other rights reserved.
*/

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Globalization;
using System.ComponentModel;

namespace ESRI.ArcGIS.Client.Application.Layout.Converters
{
    /// <summary>
    /// Converts a Boolean to a Visibility value.  Returns Collapsed if true, Visible if null or false
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class BooleanToCollapsedConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Perform the conversion to a Visibility value
        /// </summary>
        /// <param name="value">The source boolean being passed to the target</param>
        /// <param name="targetType">The <see cref="T:System.Type"/> of data expected by the target dependency property</param>
        /// <param name="parameter">An optional parameter to be used in the converter logic</param>
        /// <param name="culture">The culture of the conversion</param>
        /// <returns>
        /// The Visibility value to be passed to the target dependency property
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;
            bool? visibility = value as bool?;
            return visibility.HasValue && visibility.Value ? Visibility.Collapsed : Visibility.Visible;
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            if (!Enum.IsDefined(typeof(Visibility), value))
                return false;
            return ((Visibility)value == Visibility.Collapsed);
        }

        #endregion
    }
}
