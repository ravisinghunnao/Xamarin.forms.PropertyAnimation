using System;
using Xamarin.Forms;

namespace Animation
{
    public interface IPropertyAnimation 
    {
        Easing AnimationEasing { get; set; }
        int Delay { get; set; }
        object EndValue { get; set; }
        uint Length { get; set; }
        string PropertyName { get; set; }
        uint Rate { get; set; }
        object StartValue { get; set; }
        View Target { get; set; }

        Action<double, bool> GetFinishedAction();
        void SetFinishedAction(Action<double, bool> value);
        void Validate();
        void Play();
        void PlayReverse();
        Xamarin.Forms.Animation CreateFarwardAnimation();
        Xamarin.Forms.Animation CreateReverseAnimation();
    }
}