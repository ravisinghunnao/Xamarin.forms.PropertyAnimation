using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Animation
{
    public class PropertyAnimator : TriggerAction<View>, IPropertyAnimator
    {
        private bool _animated;

        public List<IPropertyAnimation> PropertyAnimations { get; set; } = new List<IPropertyAnimation>();
        public bool Toggle { get; set; } = false;
        public bool IsGlobal { get; set; } = false;

        public void Add(IPropertyAnimation propertyAnimation)
        {
            PropertyAnimations.Add(propertyAnimation);
        }

        public void Animate(View view)
        {
            this.Invoke(view);
        }

        public void Remove(IPropertyAnimation propertyAnimation)
        {
            PropertyAnimations.Remove(propertyAnimation);
        }

        protected override void Invoke(View sender)
        {
            if (Toggle)
            {
                if (_animated == false)
                {
                    AnimateForwarded(sender);

                    _animated = true;
                }
                else
                {
                    AnimateReversed(sender);

                    _animated = false;
                }

            }
            else
            {
                AnimateForwarded(sender);
            }

        }

        private void AnimateReversed(View sender)
        {

            int LastIndex = PropertyAnimations.Count - 1;

            for (int i = LastIndex; i >=0; i--)
            {
                PropertyAnimations[i].Target = IsGlobal ? sender : PropertyAnimations[i].Target;
                var number = i - 1;
                if (number >= 0)
                {
                    
                    Action<double, bool> fa = (d, b) => PropertyAnimations[number].PlayReverse();
                    PropertyAnimations[i].SetFinishedAction(fa);
                }
                else
                {
                    PropertyAnimations[i].SetFinishedAction(null);
                }


            }

            PropertyAnimations[LastIndex].PlayReverse();


        }

        private void AnimateForwarded(View sender)
        {
            try
            {
                for (int i = 0; i < PropertyAnimations.Count; i++)
                {
                    PropertyAnimations[i].Target = IsGlobal?sender: PropertyAnimations[i].Target;
                    if (i < PropertyAnimations.Count - 1)
                    {
                        var number = i + 1;
                        Action<double,bool> fa = (d, b) => PropertyAnimations[number].Play();
                        PropertyAnimations[i].SetFinishedAction(fa);
                    }
                    else
                    {
                        PropertyAnimations[i].SetFinishedAction(null);
                    }


                }

                PropertyAnimations[0].Play();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{nameof(PropertyAnimator)} error: {ex.ToString()}");
            }
            
           

        }
    }
}
