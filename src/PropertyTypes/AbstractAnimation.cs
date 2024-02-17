using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
////////////////////////////////////////////////////
namespace Animation
{
    public abstract class AbstractAnimation : IPropertyAnimation
    {
        public object StartValue { get; set; }
        public object EndValue { get; set; }

        public int Delay { get; set; } = 0;
        public View Target { get; set; }
        public uint Rate { get; set; } = 16;
        public uint Length { get; set; } = 250;
        public Easing AnimationEasing { get; set; } = null;
        public string PropertyName { get; set; }

        private Action<double, bool> finishedAction;

        public Action<double, bool> GetFinishedAction()
        {
            return finishedAction;
        }

        public void SetFinishedAction(Action<double, bool> value)
        {
            finishedAction = value;
        }

        public abstract Xamarin.Forms.Animation CreateFarwardAnimation();



        public abstract Xamarin.Forms.Animation CreateReverseAnimation();
        



        public void Play()
        {
           

            Xamarin.Forms.Animation PropertyAnimation = CreateFarwardAnimation();

            PropertyAnimation.Commit(Target, $"{Target.ToString()}{PropertyName}Animation{Guid.NewGuid()}", Rate, Length, AnimationEasing, GetFinishedAction());

        }

        public void PlayReverse()
        {
          

            Xamarin.Forms.Animation PropertyAnimation = CreateReverseAnimation();

            PropertyAnimation.Commit(Target, $"{Target.ToString()}{PropertyName}Animation{Guid.NewGuid()}", Rate, Length, AnimationEasing, GetFinishedAction());
        }



        public virtual void Validate()
        {
            if (string.IsNullOrEmpty(PropertyName))
            {
                throw new Exception($"{nameof(PropertyName)} is Mandatory.");
            }

            if (StartValue==null)
            {
                throw new Exception($"{nameof(StartValue)} is Mandatory.");
            }
            if (EndValue==null)
            {
                throw new Exception($"{nameof(EndValue)} is Mandatory.");
            }

            if (Target.GetType().GetProperty(PropertyName) == null)
            {
                throw new Exception($"Invalid {nameof(PropertyName)}: {PropertyName}.");
            }

        }
    }
}
