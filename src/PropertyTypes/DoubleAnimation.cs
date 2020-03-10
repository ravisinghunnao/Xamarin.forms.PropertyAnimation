using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
    public class DoubleAnimation : AbstractAnimation
    {
        
    

        public override void Validate()
        {
            base.Validate();
           

            if (StartValue.GetType() != typeof(double))
            {
                throw new Exception($"Invalid {nameof(StartValue)}.");
            }
            if (EndValue.GetType() != typeof(double))
            {
                throw new Exception($"Invalid {nameof(EndValue)}.");
            }
        }

       

        public override Xamarin.Forms.Animation CreateFarwardAnimation()
        {
           
            return new Xamarin.Forms.Animation(d =>
            {
                Target.GetType().GetProperty(PropertyName).SetValue(Target, d);
                Target.IsVisible = Target.HeightRequest != 0 && Target.WidthRequest != 0;

            }, Convert.ToDouble(StartValue), Convert.ToDouble(EndValue));
        }


      
        public override Xamarin.Forms.Animation CreateReverseAnimation()
        {
           
            return new Xamarin.Forms.Animation(d =>
            {
                Target.GetType().GetProperty(PropertyName).SetValue(Target, d);
                Target.IsVisible = Target.HeightRequest != 0 && Target.WidthRequest != 0;

            }, Convert.ToDouble(EndValue), Convert.ToDouble(StartValue));
        }
    }
}
