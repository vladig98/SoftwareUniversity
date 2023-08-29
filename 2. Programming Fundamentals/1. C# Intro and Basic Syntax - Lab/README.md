
# **Lab: C# Intro and Basic Syntax**
Problems for exercises and homework for the [“Programming Fundamentals Extended” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).
1. ## **Greeting**
Write a program, which **greets** the user by their **name**, which it **reads** from the **console**.
1. ### **Create a New C# Project, using Visual Studio**
Open **Visual Studio** and create a new project by going into **[File à New à Project]**:

After that, the project creation window will open.

Select **Visual C#**, then **Console Application** and name it appropriately:

1. ### **Write the Program Logic**
A new file opens in the editor, which looks like this:



Let’s write the program logic. We want to **read** a name and then **print** that name with some additional text on the **console**. To accomplish this, we’ll use **Console.ReadLine()** and **Console.WriteLine()**:

1. ### **Test the Program**
After we wrote the program logic, we can **start** our program, using **[Ctrl+F5]**:

Let’s **type in** a name and see if it works:

If you followed all the steps correctly, you should be greeted by your program! Submit the code in **Judge** and test if it works correctly.

### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|Pesho|Hello, Pesho!|
|Ivan|Hello, Ivan!|
|Merry|Hello, Merry!|
1. ## **Add Two Numbers**
Write a program, which **reads 2 whole numbers** and **adds** them together. Then, print them in the following format: 

- “**a + b = sum**”
1. ### **Create a New C# Project Inside the Solution**
In **Visual Studio**, create a new project in our **current solution** by **right clicking** the **solution** in the **Solution Explorer** and navigating to **[Add à New Project…**]:

After that, name it appropriately and hit **[OK]**:

1. ### **Change the Startup Project**
Now that you’ve created a new project inside the solution, you need to **set** **the startup project to the currently selected project**, otherwise whenever you hit **[Ctrl+F5]**, the **previous problem** will start. So **right click** the **solution** and hit “**Set Startup Projects”**:

| |è||
| :- | :- | :- |
Now we’re ready to write our logic.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>2</p><p>5</p>|2 + 5 = 7|
|<p>1</p><p>3</p>|1 + 3 = 4|
|<p>-3</p><p>5</p>|-3 + 5 = 2|
1. ## **Employee Data**
Write a program to read **data** about an **employee** and print it on the console with the appropriate formatting. The order the input comes in is as such:

- Name – **no** formatting
- Age – **no** formatting
- Employee ID – **8-digit padding** (employee id 356 is 00000356)
- Monthly Salary – formatted to **2 decimal places** (2345.56789 becomes 2345.56)
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Ivan</p><p>24</p><p>1192</p><p>1500\.353</p>|<p>Name: Ivan</p><p>Age: 24</p><p>Employee ID: 00001192</p><p>Salary: 1500.35</p>|
|<p>Peter</p><p>30</p><p>113236</p><p>1738\.1112</p>|<p>Name: Peter</p><p>Age: 30</p><p>Employee ID: 00113236</p><p>Salary: 1738.11</p>|
|<p>Naiden</p><p>27</p><p>1111222</p><p>3560</p>|<p>Name: Naiden</p><p>Age: 27</p><p>Employee ID: 01111222</p><p>Salary: 3560.00</p>|
### **Hints**
- You can use “**D**” and “**F**” to format numbers in C#. You can read more about formatting strings [here](https://msdn.microsoft.com/en-us/library/dwhawy9k\(v=vs.110\).aspx).

