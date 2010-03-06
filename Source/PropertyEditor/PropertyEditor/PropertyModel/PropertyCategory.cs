﻿using System.Collections.ObjectModel;

namespace OpenControls
{
    public class PropertyCategory : PropertyBase
    {
        public string Name { get; set; }
        public ObservableCollection<PropertyBase> Properties { get; private set; }

        public PropertyCategory()
        {
            Properties = new ObservableCollection<PropertyBase>();
        }
    }
}
