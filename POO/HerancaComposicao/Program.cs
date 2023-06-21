using _Men;
using _Monkey;
using _Sardine;
using _Walk;
using _Swim;

WalkBehavior walkBehavior = new();
SwimBehavior swimBehavior = new();



Monkey monkey = new(walkBehavior);

monkey.Eat();
monkey.Sleep();
monkey.Locomotion();

//Eating...
//Sleeping...
//Monkey
//Walking...

Men men = new(walkBehavior);

men.Eat();
men.Sleep();
men.Locomotion();

//Eating...
//Sleeping...
//Men
//Walking...

Sardine sardine = new(swimBehavior);

sardine.Eat();
sardine.Sleep();
sardine.Locomotion();

//Eating...
//Sleeping...
//Sardine
//Swimming..
