using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
    public class PropertySetter : AbstractPropertySetter
    {
        public override void Validate()
        {
            base.Validate();
         
           
            
        }
        public override void SetProperty()
        {
           
            string PropertyType = Target.GetType().GetProperty(PropertyName).PropertyType.ToString().ToUpper();
            switch (PropertyType)
            {
                case "SYSTEM.DOUBLE":
                    Target.GetType().GetProperty(PropertyName).SetValue(Target,Convert.ToDouble(Value));
                    break;
                default:
                    Target.GetType().GetProperty(PropertyName).SetValue(Target, Value);
                    break;
            }
            


        }
    }
}
