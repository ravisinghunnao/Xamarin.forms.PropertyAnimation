using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Animation
{
    public abstract class AbstractPropertySetter :TriggerAction<View>, IPropertySetter
    {
        public View Target { get; set; }
        public string PropertyName { get; set; }
        public object Value { get; set; }

        protected override void Invoke(View sender)
        {
            SetProperty();
        }

        public abstract void SetProperty();

        public virtual void Validate()
        {

            if (string.IsNullOrEmpty(PropertyName))
            {
                throw new Exception($"{nameof(PropertyName)} is Mandatory.");
            }

            if (Value == null)
            {
                throw new Exception($"{nameof(Value)} is Mandatory.");
            }

            if (Target.GetType().GetProperty(PropertyName) == null)
            {
                throw new Exception($"Invalid {nameof(PropertyName)}: {PropertyName}.");
            }


        }
    }
}
