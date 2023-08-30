
# **Lab: Inheritance**
Problems for exercises and homework for the ["C# OOP Basics" course @ SoftUni](https://softuni.bg/courses/csharp-oop-basics)".

You can check your solutions here: <https://judge.softuni.bg/Contests/679/Inheritance-Lab>.
# **Part I: Inheritance**
1. ## **Single Inheritance**
Create two classes named **Animal** and **Dog**.

**Animal** with a single public method **Eat()** that prints: **"eating…"**

**Dog** with a single public method **Bark()** that prints: **"barking…"**

**Dog** should inherit from **Animal**.

### **Hints**
Use the **: operator** to build a hierarchy
1. ## **Multiple Inheritance**
Create three classes named **Animal**, **Dog** and **Puppy**. 

**Animal** with a single public method **Eat()** that prints: **"eating…"**

**Dog** with a single public method **Bark()** that prints: **"barking…"**

**Puppy** with a single public method **Weep()** that prints: **"<a name="ole_link1"></a><a name="ole_link2"></a><a name="ole_link3"></a>weeping…"**

**Dog** should inherit from **Animal**. **Puppy** should inherit from **Dog**. 

1. ## **Hierarchical Inheritance**
Create three classes named **Animal**, **Dog** and **Cat**. 

**Animal** with a single public method **Eat()** that prints: **"eating…"**

**Dog** with a single public method **Bark()** that prints: **"barking…"**

**Cat** with a single public method **Meow()** that prints: **"meowing…"**

**Dog** and **Cat** should inherit from **Animal**.


# **Part II: Reusing Classes**
1. ## **Random List**
Create a <a name="ole_link4"></a><a name="ole_link5"></a>**RandomList** class that has all the functionality of **List<string>**.

Add additional function that **returns** and **removes** a random element from the list.

- Public method: **RandomString(): string**
1. ## **Stack of Strings**
Create a class **StackOfStrings** which can store only strings and has the following functionality:

- Private field: **data: List<string>**
- Public method: **Push(string item): void**
- Public method: **Pop(): string**
- Public method: **Peek(): string**
- Public method: **IsEmpty(): bool**

Use composition/delegation in order to have a field in which to store the stack's data


