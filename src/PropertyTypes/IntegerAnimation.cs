using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
    public class IntegerAnimation : AbstractAnimation
    {
        public override void Validate()
        {
            base.Validate();
         

            if (StartValue.GetType() != typeof(int))
            {
                throw new Exception($"Invalid {nameof(StartValue)}.");
            }
            if (EndValue.GetType() != typeof(int))
            {
                throw new Exception($"Invalid {nameof(EndValue)}.");
            }
        }



        public override Xamarin.Forms.Animation CreateFarwardAnimation()
        {
           
            return new Xamarin.Forms.Animation(d =>
            {
                Target.GetType().GetProperty(PropertyName).SetValue(Target, Convert.ToInt32(d));
                

            }, Convert.ToInt32(StartValue), Convert.ToInt32(EndValue));
        }



        public override Xamarin.Forms.Animation CreateReverseAnimation()
        {
          
            return new Xamarin.Forms.Animation(d =>
            {
                Target.GetType().GetProperty(PropertyName).SetValue(Target, Convert.ToInt32(d));
              

            }, Convert.ToInt32(EndValue), Convert.ToInt32(StartValue));
        }
    }
}
