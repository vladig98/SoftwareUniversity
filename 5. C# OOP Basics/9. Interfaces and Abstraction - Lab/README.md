
# **Lab: Interfaces and Abstraction**
Problems for exercises and homework for the ["CSharp OOP Basics" course @ Software University](https://softuni.bg/courses/csharp-oop-basics)

You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/705/Interfaces-and-Abstraction-Lab)
1. ## **Shapes**
Build hierarchy of interfaces and classes: 

You should be able to use the class like this:

|**StartUp.cs**|
| :-: |
|<p><a name="ole_link1"></a><a name="ole_link2"></a>var radius = int.Parse(Console.ReadLine());</p><p>IDrawable circle = new Circle(radius);</p><p></p><p>var width = int.Parse(Console.ReadLine());</p><p>var height = int.Parse(Console.ReadLine());</p><p>IDrawable rect = new Rectangle(width, height);</p><p></p><p>circle.Draw();</p><p>rect.Draw();</p>|
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3</p><p>4</p><p>5</p>|<p>`   `\*\*\*\*\*\*\*</p><p>` `\*\*       \*\*</p><p>\*\*         \*\*</p><p>\*           \*</p><p>\*\*         \*\*</p><p>` `\*\*       \*\*</p><p>`   `\*\*\*\*\*\*\*</p><p>\*\*\*\*</p><p>\*  \*</p><p>\*  \*</p><p>\*  \*</p><p>\*\*\*\*</p>|
### **Solution**
For circle drawing you can use this algorithm:

For rectangle drawing algorithm will be:

1. ## **Cars**
Build a hierarchy of interfaces and classes:

Your hierarchy must be used with this code:

|**StartUp.cs**|
| :-: |
|<p><a name="ole_link8"></a><a name="ole_link9"></a>ICar seat = new Seat("Leon", "Grey");</p><p>ICar tesla = new Tesla("Model 3", "Red", 2);</p><p></p><p>Console.WriteLine(seat.ToString());</p><p>Console.WriteLine(tesla.ToString());</p>|
### **Examples**

|**Output**|
| :-: |
|<p>Grey Seat Leon</p><p><a name="ole_link5"></a><a name="ole_link6"></a>Engine start</p><p>Breaaak!</p><p>Red Tesla Model 3 with 2 Batteries<br>Engine start</p><p><a name="ole_link16"></a><a name="ole_link17"></a><a name="ole_link7"></a>Breaaak!</p>|


