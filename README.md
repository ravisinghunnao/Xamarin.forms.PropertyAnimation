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
<p><span style="text-decoration: underline;"><strong>Complete Code of Demo Image</strong></span></p>
<p>&nbsp;</p>
 <StackLayout VerticalOptions="CenterAndExpand" Padding="20">
        <Button Text="Property Animation" BackgroundColor="#ffff0000" x:Name="btn"  >
            <Button.Triggers>
                <EventTrigger Event="Clicked" >
                    <PA:PropertyAnimator  Toggle="True">
                        <PA:PropertyAnimator.PropertyAnimations >
                            <PA:ColorAnimation StartValue="#ffff0000" EndValue="#ffffff00" PropertyName="BackgroundColor" Target="{x:Reference btn}" Length="250"></PA:ColorAnimation>



                        </PA:PropertyAnimator.PropertyAnimations>
                    </PA:PropertyAnimator>
                </EventTrigger>
            </Button.Triggers>
        </Button>

        <Button Text="Parallel Property Animation" BackgroundColor="#ffff0000" x:Name="btn2"  BorderColor="Black">
            <Button.Triggers>
                <EventTrigger Event="Clicked" >
                    <PA:ParellelPropertyAnimator Toggle="True">
                        <PA:ParellelPropertyAnimator.ParallelAnimations  >
                            <PA:ParallelAnimation  Target="{x:Reference btn2}">
                                <PA:ParallelAnimation.PropertyAnimations >
                                    <PA:ColorAnimation Target="{x:Reference btn2}" StartValue="#ff0000" EndValue="#ffff00" PropertyName="BackgroundColor"  Length="150"></PA:ColorAnimation>
                                    <PA:ColorAnimation Target="{x:Reference btn2}" StartValue="#ffffffff" EndValue="#000000" PropertyName="TextColor"  Length="150"  ></PA:ColorAnimation>
                                    <PA:IntegerAnimation Target="{x:Reference btn2}" StartValue="5" EndValue="25" PropertyName="CornerRadius"  Length="150"  ></PA:IntegerAnimation>
                                    <PA:DoubleAnimation StartValue="1.0" EndValue="5.0" PropertyName="BorderWidth" Length="150" Target="{x:Reference btn2}"></PA:DoubleAnimation>


                                </PA:ParallelAnimation.PropertyAnimations>
                            </PA:ParallelAnimation>
                        </PA:ParellelPropertyAnimator.ParallelAnimations>
                    </PA:ParellelPropertyAnimator>
                </EventTrigger>
            </Button.Triggers>
        </Button>
        <BoxView Color="Green" x:Name="bv1"  HeightRequest="100" WidthRequest="200"  HorizontalOptions="CenterAndExpand"  >

        </BoxView>
        <Button Text="Animate BoxView (Property Animation)" x:Name="aniboxview" >
            <Button.Triggers>
                <EventTrigger Event="Clicked">
                    <PA:PropertyAnimator Toggle="True">
                        <PA:PropertyAnimator.PropertyAnimations>
                            <PA:ColorAnimation Target="{x:Reference bv1}" StartValue="#00ff00" EndValue="#ff0000" PropertyName="Color" Length="250"></PA:ColorAnimation>
                            <PA:DoubleAnimation Target="{x:Reference bv1}" StartValue="0" EndValue="360.0" PropertyName="Rotation" Length="250"></PA:DoubleAnimation>
                            <PA:DoubleAnimation Target="{x:Reference bv1}" StartValue="1.0" EndValue="0.5" PropertyName="Scale" Length="250"></PA:DoubleAnimation>
                            <PA:CornerRadiusAnimation Target="{x:Reference bv1}" StartValue="0" EndValue="20" PropertyName="CornerRadius" Length="250"></PA:CornerRadiusAnimation>
                        </PA:PropertyAnimator.PropertyAnimations>
                    </PA:PropertyAnimator>
                </EventTrigger>
            </Button.Triggers>
        </Button>

        <BoxView Color="Green" x:Name="bv2"  HeightRequest="100" WidthRequest="200"  HorizontalOptions="CenterAndExpand" >

        </BoxView>
        <Button Text="Animate BoxView (Parellel Property Animation)" x:Name="aniboxview2" >
            <Button.Triggers>
                <EventTrigger Event="Clicked">
                    <PA:ParellelPropertyAnimator Toggle="True">
                        <PA:ParellelPropertyAnimator.ParallelAnimations>
                            <PA:ParallelAnimation Target="{x:Reference bv2}">
                                <PA:ParallelAnimation.PropertyAnimations>
                                    <PA:ColorAnimation Target="{x:Reference bv2}" StartValue="#00ff00" EndValue="#ff0000" PropertyName="Color" Length="150"></PA:ColorAnimation>
                                    <PA:DoubleAnimation Target="{x:Reference bv2}" StartValue="0" EndValue="360.0" PropertyName="Rotation" Length="150"></PA:DoubleAnimation>
                                    <PA:DoubleAnimation Target="{x:Reference bv2}" StartValue="1.0" EndValue="0.5" PropertyName="Scale" Length="150"></PA:DoubleAnimation>
                                    <PA:CornerRadiusAnimation Target="{x:Reference bv2}" StartValue="0" EndValue="20" PropertyName="CornerRadius" Length="150"></PA:CornerRadiusAnimation>

                                </PA:ParallelAnimation.PropertyAnimations>
                            </PA:ParallelAnimation>
                        </PA:ParellelPropertyAnimator.ParallelAnimations>
                    </PA:ParellelPropertyAnimator>
                </EventTrigger>
            </Button.Triggers>
        </Button>
        <StackLayout Orientation="Horizontal" HorizontalOptions="CenterAndExpand">
            <BoxView Color="Green" x:Name="boxview"  HeightRequest="100" WidthRequest="200"  HorizontalOptions="Center"  >

            </BoxView>
            <Entry x:Name="entry" Text="Sample Text"   HorizontalOptions="Center"></Entry>


        </StackLayout>
        <Button x:Name="animul2" Text="Animate multiple (Property Animation)">
            <Button.Triggers>
                <EventTrigger Event="Clicked">
                    <PA:PropertyAnimator Toggle="True" >

                        <PA:PropertyAnimator.PropertyAnimations >
                            <PA:ColorAnimation Target="{x:Reference boxview}" StartValue="#00ff00" EndValue="#ff0000" PropertyName="Color" Length="250"></PA:ColorAnimation>
                            <PA:DoubleAnimation Target="{x:Reference boxview}" StartValue="0" EndValue="360.0" PropertyName="Rotation" Length="250"></PA:DoubleAnimation>
                            <PA:DoubleAnimation Target="{x:Reference boxview}" StartValue="1.0" EndValue="0.5" PropertyName="Scale" Length="250"></PA:DoubleAnimation>
                            <PA:CornerRadiusAnimation  Target="{x:Reference boxview}" StartValue="0,0,0,0" EndValue="10,20,30,20" PropertyName="CornerRadius" Length="250"></PA:CornerRadiusAnimation>
                            <PA:ColorAnimation Target="{x:Reference entry}" StartValue="#00ff00" EndValue="#ff0000" PropertyName="BackgroundColor" Length="250"></PA:ColorAnimation>
                            <PA:DoubleAnimation Target="{x:Reference entry}" StartValue="1.0" EndValue="10.0" PropertyName="CharacterSpacing" Length="250"></PA:DoubleAnimation>
                            <PA:DoubleAnimation Target="{x:Reference entry}" StartValue="1.0" EndValue="1.5" PropertyName="Scale" Length="250"></PA:DoubleAnimation>
                        </PA:PropertyAnimator.PropertyAnimations>


                    </PA:PropertyAnimator>
                </EventTrigger>
            </Button.Triggers>
        </Button>

        <Button x:Name="animul1" Text="Animate multiple (Parallel Animation)">
            <Button.Triggers>
                <EventTrigger Event="Clicked">
                    <PA:ParellelPropertyAnimator Toggle="True" >
                        <PA:ParellelPropertyAnimator.ParallelAnimations>
                            <PA:ParallelAnimation Target="{x:Reference animul1}">
                                <PA:ParallelAnimation.PropertyAnimations >
                                    <PA:ColorAnimation Target="{x:Reference boxview}" StartValue="#00ff00" EndValue="#ff0000" PropertyName="Color" Length="50"></PA:ColorAnimation>
                                    <PA:DoubleAnimation Target="{x:Reference boxview}" StartValue="0" EndValue="360" PropertyName="Rotation" Length="50"></PA:DoubleAnimation>
                                    <PA:DoubleAnimation Target="{x:Reference boxview}" StartValue="1" EndValue="0.5" PropertyName="Scale" Length="50"></PA:DoubleAnimation>
                                    <PA:CornerRadiusAnimation Target="{x:Reference boxview}" StartValue="0,0,0,0" EndValue="10,20,30,20" PropertyName="CornerRadius" Length="50"></PA:CornerRadiusAnimation>
                                    <PA:ColorAnimation Target="{x:Reference entry}" StartValue="#00ff00" EndValue="#ff0000" PropertyName="BackgroundColor" Length="50"></PA:ColorAnimation>
                                    <PA:DoubleAnimation Target="{x:Reference entry}" StartValue="1" EndValue="10" PropertyName="CharacterSpacing" Length="50"></PA:DoubleAnimation>
                                    <PA:DoubleAnimation Target="{x:Reference entry}" StartValue="1" EndValue="1.5" PropertyName="Scale" Length="50"></PA:DoubleAnimation>
                                </PA:ParallelAnimation.PropertyAnimations>
                            </PA:ParallelAnimation>
                        </PA:ParellelPropertyAnimator.ParallelAnimations>
                    </PA:ParellelPropertyAnimator>
                </EventTrigger>
            </Button.Triggers>
        </Button>

    </StackLayout>
