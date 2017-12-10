# C# Intermediate: Classes, Interfaces and OOP


Sample code for all the exercises from the [C# Intermediate: Classes, Interfaces and OOP](https://www.udemy.com/csharp-intermediate-classes-interfaces-and-oop/learn/v4/overview)
course made by [Mosh Hamedani](https://github.com/mosh-hamedani) on [Udemy](https://www.udemy.com/).

## Section 2 - Classes

In this section you will learn about classes, constructors, methods, fields, acess modifiers, properties, indexers and 
how to initialize an object.

### Design a Stopwatch

Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: 
Start and Stop. We call the start method first, and the stop method next. Then we ask the stopwatch about the duration 
between start and stop. Duration should be a value in TimeSpan. Display the duration on the console.

We should also be able to use a stopwatch multiple times. So we may start and stop it and then start and stop it again. 
Make sure the duration value each time is calculated properly.

We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). So the 
class should throw an InvalidOperationException if its started twice.

Educational tip: The aim of this exercise is to make you understand that a class should be always in a valid state. 
We use encapsulation and information hiding to achieve that. The class should not reveal its implementation detail. 
It only reveals a little bit, like a blackbox. From theoutside, you should not be able to misuse a class because you 
shouldn’t be able to see the implementation detail. 

### Design a StackOverflow Post

Design a class called Post. This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.

In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail.

Educational tip: The aim of this exercise is to help you understand that classes should
encapsulate data AND behaviour around that data. Many developers (even those with years of
experience) tend to create classes that are purely data containers, and other classes that are
purely behaviour (methods) providers. This is not object-oriented programming. This is
procedural programming. Such programs are very fragile. Making a change breaks many parts
of the code.