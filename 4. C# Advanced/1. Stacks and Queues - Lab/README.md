
# **Lab: Stacks and Queues**
Problems for exercises and homework for the ["CSharp Advanced" course @ Software University](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here: <https://judge.softuni.bg/Contests/Practice/Index/925>.
1. # **Working with Stacks**
1. ## **Reverse Strings**
Write program that:

- **Reads** an **input string**
- **Reverses** it **using a Stack<T>**
- **Prints** the result back at the terminal
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|Learning Java|avaJ gninraeL|
|Stacks and Queues|seueuQ dna skcatS|
### **Hints**
- Use a **Stack<string>**
- Use the methods **Push()**, **Pop()**
1. ## **Simple Calculator**
**Create a simple calculator** that can **evaluate simple expressions** with only addition and subtraction. There will not be any parentheses.

Solve the problem **using a Stack**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|2 + 5 + 10 - 2 - 1|14|
|2 - 2 + 5|5|
### **Hints**
- Use a **Stack<string>**
- You can either
  - add the elements and then **Pop()** them out
  - or **Push()** them and reverse the stack
1. ## **Decimal to Binary Converter**
Create a simple program that **can convert a decimal number to its binary representation**. Implement an elegant solution **using a Stack**.

**Print the binary representation** back at the terminal.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|10|1010|
|1024|10000000000|
### **Hints**
- If the given number is 0, just print 0
- Else, while the number is greater than zero, divide it by 2 and push the remainder into the stack
- When you are done dividing, pop all remainders from the stack – that is the binary representation
1. ## **Matching Brackets**
We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.

Print the result back at the terminal.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|1 + (2 - (2 + 3) \* 4 / (3 + 1)) \* 5|<p>(2 + 3)</p><p>(3 + 1)</p><p>(2 - (2 + 3) \* 4 / (3 + 1))</p>|
|(2 + 3) - (2 + 3)|<p>(2 + 3)</p><p>(2 + 3)</p>|
### **Hints**
- Scan through the expression searching for brackets
  - If you find an opening bracket, push the index into the stack
  - If you find a closing bracket pop the topmost element from the stack. This is the index of the opening bracket.
  - Use the current and the popped index to extract the sub-expression
1. # **Working with Queues**
1. ## **Hot Potato**
Hot potato is a game in which <b>children form a circle and start passing a hot potato</b>. The counting starts with the fist kid. <b>Every n<sup>th</sup> toss the child left with the potato leaves the game</b>. When a kid leaves the game, it passes the potato along. This continues <b>until there is only one kid left</b>.

Create a program that simulates the game of Hot Potato.  **Print every kid that is removed from the circle**. In the end, **print the kid that is left last**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Mimi Pepi Toshko</p><p>2</p>|<p><a name="ole_link3"></a><a name="ole_link4"></a>Removed Pepi</p><p>Removed Mimi</p><p><a name="ole_link5"></a><a name="ole_link6"></a>Last is Toshko</p>|
|<p>Gosho Pesho Misho Stefan Krasi</p><p>10</p>|<p>Removed Krasi</p><p>Removed Pesho</p><p>Removed Misho</p><p>Removed Gosho</p><p>Last is Stefan</p>|
|<p>Gosho Pesho Misho Stefan Krasi</p><p>1</p>|<p>Removed Gosho</p><p>Removed Pesho</p><p>Removed Misho</p><p>Removed Stefan</p><p>Last is Krasi</p>|
1. ## **Traffic Light**
Create a program that simulates the **queue** that forms during a **traffic** **jam**. During a traffic jam only **N** cars can **pass** the crossroads when the **light** **goes** **green**. Then the program reads the **vehicles** that **arrive** one by one and **adds** them to the **queue**. When the light **goes** **green** **N** number of cars **pass** the crossroads and **for** **each** a **message** "{car} passed!" is displayed. When the "**end**" command is given, **terminate** the program and **display** a **message** with the **total** **number** of cars that **passed** the crossroads.
### **Input**
- On the **first** **line** you will receive **N** – the number of cars that can pass during a green light
- On the **next** **lines**, until the "**end**" command is given, you will receive **commands** – a **single** **string**, either a **car** or "**green**"
### **Output**
- Every time the "**green**" command is given, **print** **out** a message for **every** **car** that **passes** the crossroads in the format "{car} passed!"
- When the "**end**" command is given, **print** **out** a message in the format "{number of cars} cars passed the crossroads."
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>4</p><p>Hummer H2</p><p>Audi</p><p>Lada</p><p>Tesla</p><p>Renault</p><p>Trabant</p><p>Mercedes</p><p>MAN Truck</p><p>green</p><p>green</p><p>Tesla</p><p>Renault</p><p>Trabant</p><p>end</p>|<p>Hummer H2 passed!</p><p>Audi passed!</p><p>Lada passed!</p><p>Tesla passed!</p><p>Renault passed!</p><p>Trabant passed!</p><p>Mercedes passed!</p><p>MAN Truck passed!</p><p>8 cars passed the crossroads.</p>|
|<p>3</p><p>Pesho's car</p><p>Gosho's car</p><p>Mercedes CLS</p><p>Nekva troshka</p><p>green</p><p>BMW X5</p><p>green</p><p>end</p>|<p>Pesho's car passed!</p><p>Gosho's car passed!</p><p>Mercedes CLS passed!</p><p>Nekva troshka passed!</p><p>BMW X5 passed!</p><p>5 cars passed the crossroads.</p>|


