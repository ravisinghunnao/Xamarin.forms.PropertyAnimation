<h1>Xamarin.forms.PropertyAnimation</h1>
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
<li><strong>Target</strong>: Which control property need to animate.<br /><br />Except these properties there are few optional properties which also can be used to customize animation behaviour.<br /><br /></li>
<li><strong>Toggle</strong>: This property instructs animator to reverse animation from EndValue to StartValue.</li>
<li><strong>Duration</strong>: How long animation should run.</li>
<li><strong>AnimationEasing</strong>: Animation Easing.</li>
<li><strong>Rate</strong>: Frame rate of animation.</li>
<li><strong>Delay</strong>: Not yet Implemented.<br /><strong><br />Usage:</strong></li>
</ol>
<p><br /> Install Nuget package Xamarin.Forms.PropertyAnimation in shared project. <br /> <br /> Add Reference in xaml file or C# file.<br /> <br /> Xaml Example:<br /> <br /> <strong>xmlns:PA="clr-namespace:Animation;assembly=Animation"</strong><br /> <br /> C# Example<br /> <br /> <strong>using Animation;</strong><br /> <br /> After importing animation namespace, we can use animation library as following:<br /> <br /> <strong>Xaml:</strong><br /> <br /> &lt;Button Text="Color Animation" BackgroundColor="#ffff0000" x:Name="btn" &gt;<br /> &lt;Button.Triggers&gt;<br /> &lt;EventTrigger Event="Clicked" &gt;<br /> &lt;PA:PropertyAnimator Toggle="True"&gt;<br /> &lt;PA:PropertyAnimator.PropertyAnimations &gt;<br /> &lt;PA:ColorAnimation StartValue="#ffff0000" EndValue="#ffffff00" PropertyName="BackgroundColor" Target="{x:Reference btn}" Length="500"&gt;&lt;/PA:ColorAnimation&gt;<br /> &lt;PA:ColorAnimation StartValue="#00000000" EndValue="#ffffffff" PropertyName="TextColor" Target="{x:Reference btn}" Length="500" &gt;&lt;/PA:ColorAnimation&gt;<br /> &lt;/PA:PropertyAnimator.PropertyAnimations&gt;<br /> &lt;/PA:PropertyAnimator&gt;<br /> &lt;/EventTrigger&gt;<br /> &lt;/Button.Triggers&gt;<br /> &lt;/Button&gt;<br /> </p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
