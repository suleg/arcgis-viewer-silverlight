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

namespace ESRI.ArcGIS.Client.Application.Controls
{
    public interface ILayerStyleManager
    {
        Style GetPopupStyle(string containerName, PopupStyleName style);

        Style GetStyle(string styleName);
    }

    public static class LayoutManager
    {
        public static ILayerStyleManager Current { get; set; } 
    }
}
