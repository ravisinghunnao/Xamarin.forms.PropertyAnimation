using System.Collections.Generic;
using Xamarin.Forms;

namespace Animation
{
    internal interface IParellelPropertyAnimator
    {
        List<IParallelAnimation> ParallelAnimations { get; set; }
        bool Toggle { get; set; }
        List<IPropertySetter> BeforeAnimationStart { get; set; }
        List<IPropertySetter> AfterAnimationEnd { get; set; }
        bool IsGlobal { get; set; }

        void Add(IParallelAnimation parallelAnimation);
        void Animate(View view);
        void Remove(IParallelAnimation parallelAnimation);
    }
}