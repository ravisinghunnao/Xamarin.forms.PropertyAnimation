using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
    public class CornerRadiusAnimation : AbstractAnimation
    {

        private string[] _structStartValues = default;
        private string[] _structEndValues = default;



        public override void Validate()
        {
            base.Validate();

            _structStartValues = StartValue.ToString().Split(',');

            _structEndValues = EndValue.ToString().Split(',');

            foreach (var startValue in _structStartValues)
            {
                if (!double.TryParse(startValue.ToString(), out double _))
                {
                    throw new Exception($"Invalid {nameof(StartValue)}.");
                }
            }


            foreach (var endValue in _structEndValues)
            {
                if (!double.TryParse(endValue.ToString(), out double _))
                {
                    throw new Exception($"Invalid {nameof(EndValue)}.");
                }
            }

            if (_structStartValues.Length != _structEndValues.Length)
            {
                throw new Exception($"{nameof(StartValue)} and {nameof(EndValue)} has different structure.");
            }
            switch (_structStartValues.Length)
            {
                case 1:
                case 4:
                    break;

                default:
                    throw new Exception($"Supported formats are 'double' and 'double,double,double,double'.");

            }


        }



        public override Xamarin.Forms.Animation CreateFarwardAnimation()
        {
            Validate();

            if (_structStartValues.Length == 1)
            {
                return CreateFarwardAnimationForSingleValue();
            }
            else if (_structStartValues.Length == 4)
            {
                return CreateFarwardAnimationForFourValues();
            }
            else
            {
                throw new Exception("Unknow structure");
            }


        }
        #region "Forward Animations"
        private Xamarin.Forms.Animation CreateFarwardAnimationForFourValues()
        {
            double v1 = 0, v2 = 0, v3 = 0, v4 = 0;


            var Parent = new Xamarin.Forms.Animation((d) => Target.GetType().GetProperty(PropertyName).SetValue(Target, new CornerRadius(v1, v2, v3, v4)), 0, 1, AnimationEasing);



            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {

                v1 = d;

            }, Convert.ToDouble(_structStartValues[0]), Convert.ToDouble(_structEndValues[0])));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                v2 = d;

            }, Convert.ToDouble(_structStartValues[1]), Convert.ToDouble(_structEndValues[1])));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                v3 = d;

            }, Convert.ToDouble(_structStartValues[2]), Convert.ToDouble(_structEndValues[2])));

            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                v4 = d;

            }, Convert.ToDouble(_structStartValues[3]), Convert.ToDouble(_structEndValues[3])));




            return Parent;
        }






        private Xamarin.Forms.Animation CreateFarwardAnimationForSingleValue()
        {
            return new Xamarin.Forms.Animation(d =>
            {
                Target.GetType().GetProperty(PropertyName).SetValue(Target, new CornerRadius(d));

            }, Convert.ToDouble(StartValue), Convert.ToDouble(EndValue));
        }
        #endregion

        public override Xamarin.Forms.Animation CreateReverseAnimation()
        {
            Validate();

            if (_structStartValues.Length == 1)
            {
                return CreateReverseAnimationForSingleValue();
            }
            else if (_structStartValues.Length == 4)
            {
                return CreateReverseAnimationForFourValues();
            }
            else
            {
                throw new Exception("Unknow structure");
            }



        }

        private Xamarin.Forms.Animation CreateReverseAnimationForSingleValue()
        {
            return new Xamarin.Forms.Animation(d =>
            {
                Target.GetType().GetProperty(PropertyName).SetValue(Target, new CornerRadius(d));

            }, Convert.ToDouble(EndValue), Convert.ToDouble(StartValue));
        }



        private Xamarin.Forms.Animation CreateReverseAnimationForFourValues()
        {
            double v1 = 0, v2 = 0, v3 = 0, v4 = 0;

            var Parent = new Xamarin.Forms.Animation((d) => Target.GetType().GetProperty(PropertyName).SetValue(Target, new CornerRadius(v1, v2, v3, v4)), 0, 1, AnimationEasing);


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {

                v1 = d;

            }, Convert.ToDouble(_structEndValues[0]), Convert.ToDouble(_structStartValues[0])));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                v2 = d;

            }, Convert.ToDouble(_structEndValues[1]), Convert.ToDouble(_structStartValues[1])));


            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                v3 = d;

            }, Convert.ToDouble(_structEndValues[2]), Convert.ToDouble(_structStartValues[2])));

            Parent.Add(0, 1, new Xamarin.Forms.Animation(d =>
            {
                v4 = d;

            }, Convert.ToDouble(_structEndValues[3]), Convert.ToDouble(_structStartValues[3])));




            return Parent;
        }
    }
}
