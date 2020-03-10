using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
    public class ParallelAnimation : IParallelAnimation
    {

        public List<IPropertyAnimation> PropertyAnimations { get; set; } = new List<IPropertyAnimation>();

        private Action<double, bool> finishedAction;

        public bool IsGlobal { get; set; } = false;

        public Action<double, bool> GetFinishedAction()
        {
            return finishedAction;
        }

        public void SetFinishedAction(Action<double, bool> value)
        {
            finishedAction = value;
        }

        public View Target { get;  set; }
        private const uint Rate = 116;

        public Easing AnimationEasing { get;  set; }

        public void Add(IPropertyAnimation propertyAnimation)
        {
            PropertyAnimations.Add(propertyAnimation);
        }

        public void Play()
        {
          
            uint Length = 0;
            var Parent = new Xamarin.Forms.Animation();

            foreach (var propertyAnimation in PropertyAnimations)
            {
                propertyAnimation.Target = IsGlobal ? Target : propertyAnimation.Target;
                Length += propertyAnimation.Length;
                Parent.Add(0, 1, propertyAnimation.CreateFarwardAnimation());
            }

            
            Parent.Commit(Target, $"{nameof(ParallelAnimation)}", Rate, Length, AnimationEasing, GetFinishedAction());
        }

       

        public void PlayReverse()
        {
          
            uint Length = 0;
            var Parent = new Xamarin.Forms.Animation();

            for (int i = PropertyAnimations.Count-1; i >= 0; i--)
            {
                PropertyAnimations[i].Target = IsGlobal ? Target : PropertyAnimations[i].Target;
                Length += PropertyAnimations[i].Length;
                Parent.Add(0, 1, PropertyAnimations[i].CreateReverseAnimation());
            }

            Parent.Commit(Target, $"{nameof(ParallelAnimation)}", Rate, Length, AnimationEasing, GetFinishedAction());
        }

        public void Remove(IPropertyAnimation propertyAnimation)
        {
            PropertyAnimations.Remove(propertyAnimation);
        }

    }
}
