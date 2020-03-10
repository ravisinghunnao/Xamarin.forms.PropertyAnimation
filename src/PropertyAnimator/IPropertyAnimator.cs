using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Animation
{
    public interface IPropertyAnimator 
    {
        List<IPropertyAnimation> PropertyAnimations { get; set; }

        bool Toggle { get; set; }

        void Animate(View view);

        void Add(IPropertyAnimation propertyAnimation);
        void Remove(IPropertyAnimation propertyAnimation);

        bool IsGlobal { get; set; }
    }
}
