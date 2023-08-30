
# **Lab: Polymorphism**
Problems for exercises and homework for the ["C# OOP Basics" course @ SoftUni](https://softuni.bg/courses/csharp-oop-basics)".

You can check your solutions here: <https://judge.softuni.bg/Contests/680/Polymorphism-Lab>.
1. ## **MathOperation**
Create a class **MathOperations**, which should have 3 times method **Add().** Method **Add()** have to be invoked with:

- Add(int, int): **int**
- Add(double, double, double): **double**
- Add(decimal, decimal, decimal): **decimal**

You should be able to use the class like this:

|**StartUp.cs**|
| :-: |
|<p><a name="ole_link3"></a><a name="ole_link4"></a>public static void Main()</p><p>{</p><p>`   `MathOperations mo = new MathOperations();</p><p>`   `Console.WriteLine(mo.Add(2, 3));</p><p>`   `Console.WriteLine(mo.Add(2.2, 3.3, 5.5));</p><p>`   `Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));</p><p>}</p>|
### **Examples**

|Output|
| :-: |
|<p>5</p><p>11</p><p>9\.9</p>|

### **Solution**
Created MathOperation class should look like this: 


1. ## **Animals**
Create a class Animal, which hold two fields:

- name: string
- favouriteFood: string

Animal have one virtual method <a name="ole_link5"></a><a name="ole_link6"></a>**ExplainSelf(): string.**
You should add two new classes **Cat** and **Dog.** There **override** **ExplainSelf()** method by adding concrete animal sound on new line. (Look at examples below) 

You should be able to use the class like this:

|**StartUp.cs**|
| :-: |
|<p>Animal cat = new Cat("Pesho", "Whiskas");</p><p>Animal dog = new Dog("Gosho", "Meat");</p><p></p><p>Console.WriteLine(cat.ExplainSelf());</p><p>Console.WriteLine(dog.ExplainSelf());</p>|
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
||<p><a name="ole_link7"></a><a name="ole_link8"></a><a name="ole_link9"></a><a name="ole_link10"></a>I am Pesho and my fovourite food is Whiskas</p><p>MEEOW</p><p><a name="ole_link1"></a><a name="ole_link2"></a>I am Gosho and my fovourite food is Meat</p><p><a name="ole_link11"></a><a name="ole_link12"></a>DJAAF</p>|
### **Solution**


1. ## **Shapes**
Create class hierarchy, starting with **abstract** class Shape:

- **Abstract methods:**
  - **CalculatePerimeter(): doulbe**
  - <a name="ole_link13"></a><a name="ole_link14"></a>**CalculateArea(): double**
- **Virtual methods:**
  - **Draw(): string**

Extend Shape class with two children:

- **Rectangle**
- **Circle**

Each of them need to have: 

- **Fields:** 
  - **height and width for Rectangle**
  - **radius for Circle**
- **Encapsulation for this fields**
- **Public constructor** 
- **Concrete methods for calculations (perimeter and area)**
- **Override methods for drawing** 


