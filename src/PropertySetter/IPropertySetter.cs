using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
 public  interface IPropertySetter
    {
        string PropertyName { get; set; }
        object Value { get; set; }
        View Target { get; set; }

        void SetProperty();

        void Validate();
    }
}
