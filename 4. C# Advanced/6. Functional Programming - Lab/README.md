
# **Lab: Functional Programming**
Problems for exercises and homework for the [\["CSharp Advanced" course @ Software University\](https://softuni.bg/courses/csharp-advanced).](https://softuni.bg/courses/csharp-advanced)

Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/Practice/Index/597>[.](https://judge.softuni.bg/Contests/597/Functional-Programming-Lab)
1. ## [](https://judge.softuni.bg/Contests/597/Functional-Programming-Lab)**Sort Even Numbers**
Write a program that reads one line of **integers** separated by **", "**. Then print the **even numbers** of that sequence **sorted** in **increasing** order.
### **Examples**

<table><tr><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">4, 2, 1, 3, 5, 7, 1, 4, 2, 12</td><td colspan="1" valign="top">2, 2, 4, 4, 12</td><td colspan="1" valign="top">1, 3, 5</td><td colspan="1" valign="top"></td><td colspan="1" valign="top">2, 4, 6</td><td colspan="1" valign="top">2, 4, 6</td></tr>
</table>
### **Hints**
It is up to you what type of data structures you will use to solve this problem

Using functional programming filter and sort the collection of numbers.
1. ## **Sum Numbers**
Write a program that reads a line of **integers** separated by **", "**. Print on two lines the **count** of numbers and their **sum.**
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|4, 2, 1, 3, 5, 7, 1, 4, 2, 12|<p>10</p><p>41</p>|
|2, 4, 6|<p>3</p><p>12</p>|
1. ## **Count Uppercase Words**
Write a program that reads a line of **text** from the console. Print **all** words that start with an **uppercase letter** in the **same order** you receive them in the text.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|The following example shows how to use Function|<p>The</p><p>Function</p>|
|Write a program that reads one line of text from console. Print count of words that start with Uppercase, after that print all those words in the same order like you find them in text.|<p>Write</p><p>Print</p><p>Uppercase,</p>|
### **Hints**
Use **Func<string, bool>** like or in if condition

Use **" "** for splitting words.
1. ## **Add VAT**
Write a program that reads one line of **double** prices separated by **", "**. Print the **prices** with **added** **VAT** for all of them. **Format** them to **2** **signs** after the decimal point. The **order** of the prices must be the **same**.
VAT is equal to 20% of the price.
### **Examples**

<table><tr><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">1\.38, 2.56, 4.4</td><td colspan="1" valign="top"><p>1\.66</p><p>3\.07</p><p>5\.28</p></td><td colspan="1" valign="top">1, 3, 5, 7</td><td colspan="1" valign="top"><p>1\.20</p><p>3\.60</p><p>6\.00</p><p>8\.40</p></td></tr>
</table>
1. ## **Filter by Age**
Write a program that receives an integer **N** on first line. On the next **N** lines, read pairs of **"[name], [age]".** Then read three lines with:

- **Condition** - "younger" or "older"
- **Age** - Integer
- **Format** - "name", "age" or "name age"

Depending on the **condition**, print the correct **pairs** in the correct **format**.

**Don’t use the built-in functionality from .NET. Create your own methods.**
### **Examples**

<table><tr><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>5</p><p>Pesho, 20<br>Gosho, 18<br>Mimi, 29<br>Ico, 31<br>Simo, 16</p><p>older</p><p>20</p><p>name age</p></td><td colspan="1" valign="top"><p>Pesho - 20</p><p>Mimi - 29</p><p>Ico - 31</p></td><td colspan="1" valign="top"><p>5</p><p>Pesho, 20<br>Gosho, 18<br>Mimi, 29<br>Ico, 31<br>Simo, 16</p><p>younger</p><p>20</p><p>name</p></td><td colspan="1" valign="top"><p>Gosho</p><p>Simo</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>5</p><p>Pesho, 20<br>Gosho, 18<br>Mimi, 29<br>Ico, 31<br>Simo, 16</p><p>younger</p><p>50</p><p>age</p></td><td colspan="1" valign="top"><p>20</p><p>18</p><p>29</p><p>31</p><p>16</p></td></tr>
</table>


