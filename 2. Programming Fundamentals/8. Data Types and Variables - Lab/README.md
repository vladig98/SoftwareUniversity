
# **Lab: Data Types and Variables**
Problems for exercises and homework for the [“Programming Fundamentals” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions here: <https://judge.softuni.bg/Contests/171/Data-Types-and-Variables-Lab>.
1. # **Integer and Real Numbers**
1. ## **Centuries to Minutes**
Write program to enter an integer number of **centuries** and convert it to **years**, **days**, **hours** and **minutes**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|1|1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes|
|5|5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes|
### **Hints**
- Use appropriate data type to fit the result after each data conversion.
- Assume that a year has 365.2422 days at average ([the Tropical year](https://en.wikipedia.org/wiki/Tropical_year)).
### **Solution**
You might help yourself with the code below:

1. ## **Circle Area (12 Digits Precision)**
Write program to enter a radius **r** (real number) and **print the area** of the circle with exactly **12 digits** after the decimal point. Use data type of **enough precision** to hold the results.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|2\.5|19\.634954084936||1\.2|4\.523893421169|
### **Hints**
- You might use the data type **double**. It has precision of 15-16 digits.
- To print the output with exactly 12 digits after the decimal point, you might use the following code:

1. ## **Exact Sum of Real Numbers**
Write program to enter **n** numbers and calculate and print their **exact sum** (without rounding).
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>3</p><p>1000000000000000000</p><p>5</p><p>10</p>|1000000000000000015||<p>2</p><p>0\.00000000003</p><p>333333333333.3</p>|333333333333.30000000003|
### **Hints**
- If you use types like **float** or **double**, the result will lose some of its precision. Also it might be printed in scientific notation.
- You might use the **decimal** data type which holds real numbers with high precision with less loss.
- Note that **decimal** numbers sometimes hold the unneeded zeroes after the decimal point, so **0m** is different than **0.0m** and **0.00000m**.
1. # **Data Types and Type Conversion**
1. ## **Elevator**
Calculate how many courses will be needed to **elevate n persons** by using an elevator of **capacity of p persons**. The input holds two lines: the **number of people n** and the **capacity p** of the elevator.
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p>17</p><p>3</p>|6|5 courses \* 3 people<br>+ 1 course \* 2 persons|
|<p>4</p><p>5</p>|1|<p>All the persons fit inside in the elevator.</p><p>Only one course is needed.</p>|
|<p>10</p><p>5</p>|2|2 courses \* 5 people|
### **Hints**
- You should **divide n by p**. This gives you the number of full courses (e.g. 17 / 3 = 5).
- If **n** does not divide **p** without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).
- Another approach is to round up **n** **/** **p** to the nearest integer (ceiling), e.g. 17/3 = 5.67 à rounds up to 6.
- Sample code for the round-up calculation:

1. ## **Special Numbers**
A **number** is **special** when its **sum of digits is 5, 7 or 11**.

Write a program to read an integer **n** and for all numbers in the range **1…n** to print the number and if it is special or not (**True** / **False**).
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|15|<p>1 -> False</p><p>2 -> False</p><p>3 -> False</p><p>4 -> False</p><p>5 -> True</p><p>6 -> False</p><p>7 -> True</p><p>8 -> False</p><p>9 -> False</p><p>10 -> False</p><p>11 -> False</p><p>12 -> False</p><p>13 -> False</p><p>14 -> True</p><p>15 -> False</p>|
### **Hints**
To calculate the sum of digits of given number **num**, you might repeat the following: sum the last digit (**num** **%** **10**) and remove it (**sum** **=** **sum** **/** **10**) until **num** reaches **0**.
1. ## **Triples of Latin Letters**
Write a program to read an integer **n** and print all **triples** of the first **n small Latin letters**, ordered alphabetically:
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|3|<p>aaa</p><p>aab</p><p>aac</p><p>aba</p><p>abb</p><p>abc</p><p>aca</p><p>acb</p><p>acc</p><p>baa</p><p>bab</p><p>bac</p><p>bba</p><p>bbb</p><p>bbc</p><p>bca</p><p>bcb</p><p>bcc</p><p>caa</p><p>cab</p><p>cac</p><p>cba</p><p>cbb</p><p>cbc</p><p>cca</p><p>ccb</p><p>ccc</p>|
### **Hints**
Perform 3 nested loops from **0** to **n-1**. For each number **num** print its corresponding Latin letter as follows:

1. ## **Greeting**
Write a program that enters **first name**, **last name** and **age** and prints "***Hello, <first name> <last name>. You are <age> years old.***". Use interpolated strings.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Svetlin</p><p>Nakov</p><p>25</p>|Hello, Svetlin Nakov. You are 25 years old.|
### **Hints**
You might use the following code:

1. # **Variables**
1. ## **Refactor Volume of Pyramid** 
You are given a **working code** that finds the **volume of a pyramid**. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that **have multiple purpose**.


### **Code**

|**Sample Code**|
| :-: |
|<p>double dul, sh, V = 0;</p><p>Console.Write("Length: ");</p><p>dul = double.Parse(Console.ReadLine());</p><p>Console.Write("Width: ");</p><p>sh = double.Parse(Console.ReadLine());</p><p>Console.Write("Heigth: ");</p><p>V = double.Parse(Console.ReadLine());</p><p>V = (dul + sh + V) / 3;</p><p>Console.WriteLine("Pyramid Volume: {0:F2}", V);</p>|
### **Hints**
- **Reduce the span** of the variables by declaring them in the moment they receive a value, not before
- Rename your variables to **represent their** real **purpose** (example: "dul" should become length, etc.)
- Search for variables that have multiple purpose. If you find any, **introduce a new variable**.
1. ## **Refactor Special Numbers**
You are given a **working code** that is a solution to **Problem 5. Special Numbers**. However, the variables are **improperly named, declared before** they are needed and some of them are used for multiple things. Without using your previous solution, **modify the code** so that it is **easy to read and understand**.
### **Code**

|**Sample Code**|
| :-: |
|<p>int kolkko = int.Parse(Console.ReadLine());</p><p>int obshto = 0; int takova = 0; bool toe = false;</p><p>for (int ch = 1; ch <= kolkko; ch++)</p><p>{</p><p>`    `takova = ch;</p><p>`    `while (ch > 0)</p><p>`    `{</p><p>`        `obshto += ch % 10;</p><p>`        `ch = ch / 10;</p><p>`    `}</p><p>`    `toe = (obshto == 5) || (obshto == 7) || (obshto == 11);</p><p>`    `Console.WriteLine($"{takova} -> {toe}");</p><p>`    `obshto = 0;</p><p>`    `ch = takova;</p><p>}</p>|
### **Hints**
- Reduce the span of the variables by declaring them in the moment they receive a value, not before
- Rename your variables to represent their real purpose (example: "dul" should become length, etc.)
- Search for variables that have multiple purpose. If you find any, introduce a new variable

