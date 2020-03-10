using System;
using System.Collections.Generic;
using System.Text;

namespace Animation
{
    public class DoubleSetter : AbstractPropertySetter
    {
        public override void Validate()
        {
            base.Validate();
         
            if (double.TryParse(Value.ToString(),out double v)==false)
            {
                throw new Exception($"Invalid {nameof(Value)}.");
            }
            
        }
        public override void SetProperty()
        {
            Validate();
            Target.GetType().GetProperty(PropertyName).SetValue(Target, Convert.ToDouble(Value));
        }
    }
}
