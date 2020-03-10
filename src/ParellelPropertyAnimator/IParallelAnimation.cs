using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Animation
{
    public interface IParallelAnimation
    {
        List<IPropertyAnimation> PropertyAnimations { get;  set; }
      
        View Target { get; set; }
      
        Easing AnimationEasing { get; set; }
        bool IsGlobal { get; set; }

        Action<double, bool> GetFinishedAction();
        void SetFinishedAction(Action<double, bool> value);

        void Add(IPropertyAnimation propertyAnimation);
        void Play();
        void PlayReverse();
    }
}
