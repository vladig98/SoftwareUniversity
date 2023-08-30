
# **Lab: Generics**
Problems for exercises and homework for the <https://softuni.bg/courses/csharp-oop-advanced-high-quality-code>

You can check your solutions here: <https://judge.softuni.bg/Contests/706/Generics-Lab>
# **Part I: Generics** 	
1. ## **Box of T**
Create a class **Box<>** that can store anything. 

It should have two public methods:

- **void Add(element)**
- **element Remove()**
- **int Count { get; }**

Adding should add on top of its contents. Remove should get the topmost element.
### **Examples**

|<p><a name="ole_link27"></a><a name="ole_link28"></a>public static void Main(string[] args)</p><p>{</p><p>`    `<a name="ole_link1"></a><a name="ole_link2"></a>Box<int> box = new Box<int>();</p><p>`    `box.Add(1);</p><p>`    `box.Add(2);</p><p>`    `box.Add(3);</p><p>`    `Console.WriteLine(box.Remove());</p><p>`    `box.Add(4);</p><p>`    `box.Add(5);</p><p>`    `Console.WriteLine(box.Remove());</p><p>}</p>|
| :- |
### **Hints**
Use the syntax **Box<T>** to create a generic class
1. ## **Generic Array Creator**
Create a class **ArrayCreator** with a method and a single overload to it:

- **static T[] Create(int length, T item)**

The method should return an array with the given length and every element should be set to the given default item.
### **Examples**

|<p><a name="ole_link3"></a><a name="ole_link4"></a><a name="ole_link5"></a>static void Main(string[] args)</p><p>{</p><p>`   `string[] strings = ArrayCreator.Create(5, "Pesho");</p><p>`   `int[] integers = ArrayCreator.Create(10, 33);</p><p>}</p>|
| :- |

# **Part II: Generic Constraints**
1. ## **Generic Scale**
Create a class **Scale<T>** that holds two elements - left and right. The scale should receive the elements through its single constructor:

- **Scale(T left, T right)**

The scale should have a single method: 

- **T <a name="ole_link6"></a><a name="ole_link7"></a><a name="ole_link8"></a>GetHeavier()**

The greater of the two elements is heavier. The method should return **null** if elements are equal.




