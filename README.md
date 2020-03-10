# Xamarin.forms.PropertyAnimation

This is an animation library for xamarin forms controls. We can animate any property with supported type. Currenlty this library has three types which can be animated.These are double, Integer and color. So if any control has any property with these types, we can animate that. 

We can download Nuget package for this library from https://www.nuget.org/packages/Xamarin.Forms.PropertyAnimation. 

This library has two type of animations.

1- Sequentionals.
2- Parallel.

In sequential property animation, each animation will start after completion of its previous animation but if we want to animate multiple properties simultaneously, We can use parellel property animation. Parallel property animation provides more feature including features of Sequentional property animation.

This animator has few basic properties which need to understand.
1- StartValue : Initial value from where animation need to start:
2- EndValue: Last value where animation will finish.
3- PropertyName: Name of property which we want to animate.
4- Target: Which control property need to animate.

Except these properties there are few optional properties which also can be used to customize animation behaviour.

1- Toggle: This property instructs animator to reverse animation from EndValue to StartValue.
2- Duration: How long animation should run.
3- AnimationEasing: Animation Easing.
4- Rate: Frame rate of animation.
5- Delay: Not Implemented.



  







