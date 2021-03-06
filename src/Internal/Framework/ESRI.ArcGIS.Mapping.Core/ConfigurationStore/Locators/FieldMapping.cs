/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
All other rights reserved.
*/

using System.Collections.Generic;

namespace ESRI.ArcGIS.Mapping.Core
{
    public class FieldMapping
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public List<string> Fields { get; set; }
        public string MappedFieldName { get; set; }
    }   
}
