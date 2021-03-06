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
using ESRI.ArcGIS.Client;
using ESRI.ArcGIS.Client.WebMap;

namespace ESRI.ArcGIS.Mapping.Core
{
    public static class MapProperties
    {
        public static readonly DependencyProperty WebMapSettingsProperty = DependencyProperty.RegisterAttached(
            "WebMapSettings", typeof(WebMapSettings), typeof(Map), null);

        public static WebMapSettings GetWebMapSettings(Map map)
        {
            return map.GetValue(MapProperties.WebMapSettingsProperty) as WebMapSettings;
        }

        public static void SetWebMapSettings(Map map, WebMapSettings settings)
        {
            map.SetValue(MapProperties.WebMapSettingsProperty, settings);
        }
    }
}
