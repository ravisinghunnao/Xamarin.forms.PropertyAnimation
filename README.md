<h1># Xamarin.forms.PropertyAnimation</h1>
<p>This is an animation library for xamarin forms controls. We can animate any property with supported type. Currenlty this library has three types which can be animated.These are double, Integer and color. So if any control has any property with these types, we can animate that.</p>
<p>We can download Nuget package for this library from https://www.nuget.org/packages/Xamarin.Forms.PropertyAnimation.</p>
<p>This library has two type of animations.</p>
<p><strong>1- Sequentional.</strong></p>
<p><strong>2- Parallel.</strong></p>
<p>In sequential property animation, each animation will start after completion of its previous animation but if we want to animate multiple properties simultaneously, We can use parellel property animation. Parallel property animation provides more feature including features of Sequentional property animation.</p>
<p>This animator has few basic properties which need to understand.</p>
<ol>
<li><strong>StartValue</strong> : Initial value from where animation need to start:</li>
<li><strong>EndValue</strong>: Last value where animation will finish.</li>
<li><strong>PropertyName</strong>: Name of property which we want to animate.</li>
<li><strong>Target</strong>: Which control's property need to animate.<br /><br />Except these properties there are few optional properties which also can be used to customize animation behaviour.<br /><br /></li>
<li><strong>Toggle</strong>: This property instructs animator to reverse animation from EndValue to StartValue.</li>
<li><strong>Duration</strong>: How long animation should run.</li>
<li><strong>AnimationEasing</strong>: Animation Easing.</li>
<li><strong>Rate</strong>: Frame rate of animation.</li>
<li><strong>Delay</strong>: Not yet Implemented.</li>
</ol>
<h2><br /><strong>Usage:</strong></h2>
<p><br /> Install Nuget package Xamarin.Forms.PropertyAnimation in shared project. <br /> <br /> Add Reference in xaml file or C# file.<br /> <br /> Xaml Example:<br /> <br /> <strong>xmlns:PA="clr-namespace:Animation;assembly=Animation"</strong><br /> <br /> C# Example<br /> <br /> <strong>using Animation;</strong><br /> <br /> After importing animation namespace, we can use animation library as following:<br /> <br /> <strong>Xaml:</strong></p>
<p><strong>PropertyAnimation:</strong></p>
<p>&lt;Button Text="Property Animation" BackgroundColor="#ffff0000" x:Name="btn" &gt;<br /> &lt;Button.Triggers&gt;<br /> &lt;EventTrigger Event="Clicked" &gt;<br /> &lt;PA:PropertyAnimator Toggle="True"&gt;<br /> &lt;PA:PropertyAnimator.PropertyAnimations &gt;<br /> &lt;PA:ColorAnimation StartValue="#ffff0000" EndValue="#ffffff00" PropertyName="BackgroundColor" Target="{x:Reference btn}" Length="500"&gt;&lt;/PA:ColorAnimation&gt;<br /> &lt;PA:ColorAnimation StartValue="#00000000" EndValue="#ffffffff" PropertyName="TextColor" Target="{x:Reference btn}" Length="500" &gt;&lt;/PA:ColorAnimation&gt;<br /> &lt;/PA:PropertyAnimator.PropertyAnimations&gt;<br /> &lt;/PA:PropertyAnimator&gt;<br /> &lt;/EventTrigger&gt;<br /> &lt;/Button.Triggers&gt;<br /> &lt;/Button&gt;</p>
<p>&nbsp;</p>
<p><strong>Parellel Property Animation:</strong></p>
<p>&lt;Button Text="Parallel Property Animation" BackgroundColor="#ffff0000" x:Name="btn2" BorderColor="Black"&gt;<br /> &lt;Button.Triggers&gt;<br /> &lt;EventTrigger Event="Clicked" &gt;<br /> &lt;PA:ParellelPropertyAnimator Toggle="True"&gt;<br /> &lt;PA:ParellelPropertyAnimator.ParallelAnimations &gt;<br /> &lt;PA:ParallelAnimation Target="{x:Reference btn2}"&gt;<br /> &lt;PA:ParallelAnimation.PropertyAnimations &gt;<br /> &lt;PA:ColorAnimation Target="{x:Reference btn2}" StartValue="#ff0000" EndValue="#ffff00" PropertyName="BackgroundColor" Length="100"&gt;&lt;/PA:ColorAnimation&gt;<br /> &lt;PA:ColorAnimation Target="{x:Reference btn2}" StartValue="#ffffffff" EndValue="#000000" PropertyName="TextColor" Length="100" &gt;&lt;/PA:ColorAnimation&gt;<br /> &lt;PA:IntegerAnimation Target="{x:Reference btn2}" StartValue="5" EndValue="25" PropertyName="CornerRadius" Length="100" &gt;&lt;/PA:IntegerAnimation&gt;<br /> &lt;PA:DoubleAnimation StartValue="1" EndValue="5" PropertyName="BorderWidth" Length="100" Target="{x:Reference btn2}"&gt;&lt;/PA:DoubleAnimation&gt;<br /> &lt;/PA:ParallelAnimation.PropertyAnimations&gt;<br /> &lt;/PA:ParallelAnimation&gt;<br /> &lt;/PA:ParellelPropertyAnimator.ParallelAnimations&gt;<br /> &lt;/PA:ParellelPropertyAnimator&gt;<br /> &lt;/EventTrigger&gt;<br /> &lt;/Button.Triggers&gt;<br /> &lt;/Button&gt;</p>
<p><br /><img src="demo.gif" alt="" /></p>
<p>&nbsp;</p>
