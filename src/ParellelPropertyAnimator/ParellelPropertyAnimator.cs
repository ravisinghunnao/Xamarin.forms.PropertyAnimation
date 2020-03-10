using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace Animation
{
    public class ParellelPropertyAnimator : TriggerAction<View>, IParellelPropertyAnimator
    {
        private bool _animated = false;

        public List<IParallelAnimation> ParallelAnimations { get; set; } = new List<IParallelAnimation>();
        public List<IPropertySetter> BeforeAnimationStart { get; set; } = new List<IPropertySetter>();
        public List<IPropertySetter> AfterAnimationEnd { get; set; } = new List<IPropertySetter>();

        public bool IsGlobal { get; set; } = false;
        public bool Toggle { get; set; } = false;

        public void Add(IParallelAnimation parallelAnimation)
        {
            ParallelAnimations.Add(parallelAnimation);

        }

        public void Remove(IParallelAnimation parallelAnimation)
        {
            ParallelAnimations.Remove(parallelAnimation);

        }

        public void Animate(View view)
        {
            this.Invoke(view);
        }

        protected override void Invoke(View sender)
        {


            if (Toggle)
            {

                if (_animated == false)
                {

                    UpdateAnimationStartProperties(sender);
                    AnimateForwarded(sender);

                    _animated = true;
                }
                else
                {
                    UpdateAnimationEndProperties(sender);
                    AnimateReversed(sender);

                    _animated = false;
                }

            }
            else
            {
                UpdateAnimationStartProperties(sender);
                AnimateForwarded(sender);
              
            }



        }

        private void UpdateAnimationEndProperties(View sender)
        {
            foreach (var propertySetter in AfterAnimationEnd)
            {
                propertySetter.Target =IsGlobal?sender: propertySetter.Target;
                propertySetter.SetProperty();
            }
        }

        private void UpdateAnimationStartProperties(View sender)
        {
            foreach (var propertySetter in BeforeAnimationStart)
            {
                propertySetter.Target = IsGlobal?sender: propertySetter.Target;
                propertySetter.SetProperty();
            }
        }

        private void AnimateReversed(View sender)
        {

            for (int i = ParallelAnimations.Count - 1; i >= 0; i--)
            {

                ParallelAnimations[i].Target = IsGlobal ? sender : ParallelAnimations[i].Target;

                var NextAnimationNumber = i - 1;
                if (NextAnimationNumber >= 0)
                {

                    ParallelAnimations[i].SetFinishedAction((d, b) => ParallelAnimations[NextAnimationNumber].PlayReverse());
                }
                else
                {
                    ParallelAnimations[i].SetFinishedAction((d, b) => UpdateAnimationStartProperties(sender));
                }
            }

            ParallelAnimations[ParallelAnimations.Count - 1].PlayReverse();
        }

        private void AnimateForwarded(View sender)
        {


            for (int i = 0; i < ParallelAnimations.Count; i++)
            {
                ParallelAnimations[i].Target = IsGlobal ? sender : ParallelAnimations[i].Target;

                var NextAnimationNumber = i + 1;
                if (NextAnimationNumber < ParallelAnimations.Count)
                {

                    ParallelAnimations[i].SetFinishedAction((d, b) => ParallelAnimations[NextAnimationNumber].Play());
                }
                else
                {
                    ParallelAnimations[i].SetFinishedAction((d, b) => UpdateAnimationEndProperties(sender));
                }
            }

            ParallelAnimations[0].Play();
        }


    }
}
