using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
    public class ColorAnimation :AbstractAnimation
    {




        public override void Validate()
        {
            base.Validate();

           
            if (StartValue.GetType() != typeof(Xamarin.Forms.Color))
            {
                throw new Exception($"Invalid {nameof(StartValue)}.");
            }
            if (EndValue.GetType() != typeof(Xamarin.Forms.Color))
            {
                throw new Exception($"Invalid {nameof(EndValue)}.");
            }
        }

     

        public override Xamarin.Forms.Animation CreateFarwardAnimation()
        {
        
            double A = 0, R = 0, G = 0, B = 0;
            var Parent = new Xamarin.Forms.Animation((d)=> Target.GetType().GetProperty(PropertyName).SetValue(Target, Xamarin.Forms.Color.FromRgba(R, G, B, A)),0,1,AnimationEasing);
            
            

            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
             {

                 A = d;

             }, Xamarin.Forms.Color.FromHex(StartValue.ToString()).A, Xamarin.Forms.Color.FromHex(EndValue.ToString()).A));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                R = d;

            }, Xamarin.Forms.Color.FromHex(StartValue.ToString()).R, Xamarin.Forms.Color.FromHex(EndValue.ToString()).R));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                G = d;

            }, Xamarin.Forms.Color.FromHex(StartValue.ToString()).G, Xamarin.Forms.Color.FromHex(EndValue.ToString()).G));

            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                B = d;

            }, Xamarin.Forms.Color.FromHex(StartValue.ToString()).B, Xamarin.Forms.Color.FromHex(EndValue.ToString()).B));

            


            return Parent;
        }


     

        public override Xamarin.Forms.Animation CreateReverseAnimation()
        {
          

            double A = 0, R = 0, G = 0, B = 0;

            var Parent = new Xamarin.Forms.Animation((d) => Target.GetType().GetProperty(PropertyName).SetValue(Target, Xamarin.Forms.Color.FromRgba(R, G, B, A)), 0, 1, AnimationEasing);


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {

                A = d;

            }, Xamarin.Forms.Color.FromHex(EndValue.ToString()).A, Xamarin.Forms.Color.FromHex(StartValue.ToString()).A));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                R = d;

            }, Xamarin.Forms.Color.FromHex(EndValue.ToString()).R, Xamarin.Forms.Color.FromHex(StartValue.ToString()).R));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                G = d;

            }, Xamarin.Forms.Color.FromHex(EndValue.ToString()).G, Xamarin.Forms.Color.FromHex(StartValue.ToString()).G));

            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                B = d;

            }, Xamarin.Forms.Color.FromHex(EndValue.ToString()).B, Xamarin.Forms.Color.FromHex(StartValue.ToString()).B));




            return Parent;
        }
    }
}
