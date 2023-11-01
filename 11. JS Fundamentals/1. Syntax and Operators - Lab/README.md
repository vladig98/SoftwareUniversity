# **Lab: Syntax, Functions and Statements**
Problems for in-class lab for the ["JavaScript Essentials" course @ SoftUni](https://softuni.bg/courses/js-essentials). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1421/Lab-JavaScript-Syntax-and-Operators>.
1. ## **String Length**
Write a JS function that takes **three** **string arguments** as an input. 

Calculate the **sum** of the **length** of the **strings** and the **average length** of the strings **rounded** **down** to the nearest integer.

The **input** comes as **three string arguments** passed to your function.

The **output** should be printed on the console on two lines.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|'chocolate', 'ice cream', 'cake'|<p>22</p><p>7</p>|


|**Input**|**Output**|
| :-: | :-: |
|'pasta', '5', '22.3'|<p>10</p><p>3</p>|
### **Hints**
- Write a function that receives three string arguments.
- Declare two variables named **sumLength** and **averageLength** that will keep the mathematical results.
- Calculate the length of the strings using the **length property**.


- Calculate the sum of the three lengths. 
- Calculate the **average length** of the strings **rounded** **down** to the nearest integer. Use the **Math.floor()** function.

- Print the results on the console.

1. ## **Math Operations**
Write a JS function that takes **two** **numbers** and **a string** as an input. 

The string may be one of the following: '**+**', '**-**', '**\***', '**/**', '**%**', '**\*\***'.  

Print on the console the result of the mathematical **operation** between **both numbers** and the **operator** you receive as a string.

The **input** comes as **two numbers** and **a string argument** passed to your function.

The **output** should be printed on the console.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|5, 6, '+'|11||3, 5.5, '\*'|16\.5|
### **Hints**
- Write a function which receives **three** arguments:

- Declare a variable named **result** that will keep your mathematical result. 
- Write down **switch** command that will take the string from your input and depending on it, perform the mathematical logic between the two numbers.


- Print the result on the console.

1. ## **Sum of Numbers N…M**
Write a JS function that takes two numbers **n** and **m** as an input and **prints the sum** of all numbers from **n** to **m**.

The **input** comes as **two string elements** that need to be **parsed** as numbers.

The **output** should **return** the **sum**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|'1', '5' |15|


|**Input**|**Output**|
| :-: | :-: |
|'-8', 20'|174|
### **Hints**
- Write a function that receives two string arguments and parse them as numbers. Use **Number(string)** function or just put the '**+**' sign before the string. 

- Declare a variable named **result** that will keep the mathematical results.
- Write a **for** loop from **num1** to **num2** and for every turn of the cycle, until it’s completed, add the current value.

- Finally, return the result.

1. ## **Largest Number**
Write a function that takes **three number arguments** as an input and find the **largest** of them. Print the following text on the console:  '**The largest number is {number}.**'.

The **input** comes as **three number arguments** passed to your function.

The **output** should be printed to the console.
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|5, -3, 16|The largest number is 16.|
|**Input**|**Output**|
|-3, -5, -22.5|The largest number is -3.|
### **Hints**
- Write a function that receives three number arguments.
- Declare a variable named **result** that will keep the result.

- Make several checks to find out the largest of the three numbers. Start with num1.

- Do the same for the others.

- Print the result on the console.

1. ## **Circle Area**
Write a function that takes **a single argument** as an input. 

**Check the type** of the input argument. If it is a **number**, assume it is the radius of a circle and **calculate the circle area**. Print the **area** **rounded** to **two decimal places**.

If the argument type is **NOT** a number, print the following text on the console: 
'**We cannot calculate the circle area, because we receive a {type of argument}.**'

The **input** comes as a **single argument** passed to your function.

The **output** should be printed on the console.
### **Example**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|5|78\.54||'name'|We can not calculate the circle area, because we receive a string.|
### **Hints**
- Write a function that receives a single argument.
- Declare a variable named **result** that will keep your result.



- Check the type of the input argument with the **typeof()** function.

- If the type is equal to **'number'**, calculate the circle area and print it on the console rounded to two decimal places. To do this, use the method **toFixed().**
  The **Math.pow()** function returns the base to the exponent power, that is, base exponent. You can find more information about the area [here](https://en.wikipedia.org/wiki/Circle):

- If the type is **NOT** a **'number'**, print the following text on the console:

1. ## **Square of Stars**
Write a function that **prints a rectangle** made of **stars** with variable **size**, depending on an input parameter. If there is **no parameter** specified, the rectangle should **always** be of **size 5**. Look at the examples to get an idea.

The **input** comes as a single **number** argument.

The **output** is a series of lines printed on the console, forming a rectangle of variable size.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">1</td><td colspan="1" valign="top">*</td><td colspan="1" valign="top">2</td><td colspan="1" valign="top"><p>**</p><p>**</p></td><td colspan="1" valign="top">5</td><td colspan="1" valign="top"><p>*****</p><p>*****</p><p>*****</p><p>*****</p><p>*****</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>*****</p><p>*****</p><p>*****</p><p>*****</p><p>*****</p></td></tr>
</table>

1. ## **Day of Week**
Write a function that prints a number between 1 and 7 when a **day of the week** is passed to it as a string and an **error message** if the string is **not recognized**.

The **input** comes as a single string argument.

The **output** should be returned as a result.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">Monday</td><td colspan="1" valign="top">1</td><td colspan="1" valign="top">Friday</td><td colspan="1" valign="top">5</td><td colspan="1" valign="top">Invalid</td><td colspan="1" valign="top">error</td></tr>
</table>
1. ## **Functional Calculator**
Write a program that receives **two numbers** and an **operator** and performs a calculation between the variables, using the operator. Store the different functions in variables and pass them to your calculator.

The **input** comes as three arguments - two numbers, and a string, representing the operator.

The **output** should be printed on the console.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">2, 4, '+'</td><td colspan="1" valign="top">6</td><td colspan="1" valign="top">3, 3, '/'</td><td colspan="1" valign="top">1</td><td colspan="1" valign="top">18, -1, '*'</td><td colspan="1" valign="top">-18</td></tr>
</table>
1. ## **Aggregate Elements**
Write a program that performs different operations on an array of elements. Implement the following operations:

- <b>Sum(a<sub>i</sub>)</b> - calculates the sum all elements from the input array
- <b>Sum(1/a<sub>i</sub>)</b> - calculates the sum of the inverse values (1/a<sub>i</sub>) of all elements from the array
- <b>Concat(a<sub>i</sub>)</b> - concatenates the string representations of all elements from the array

The **input** comes as an array of number elements.

The **output** should be printed on the console on a new line for each of the operations.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">[1, 2, 3]</td><td colspan="1" valign="top"><p>6</p><p>1\.8333</p><p>123</p></td><td colspan="1" valign="top">[2, 4, 8, 16]</td><td colspan="1" valign="top"><p>30</p><p>0\.9375</p><p>24816</p></td></tr>
</table>
1. ## **\*Words Uppercase**
Write a program that **extracts all words** from a passed in string and converts them to **upper case**. The extracted words in upper case must be printed on a single line separated by **", "**.

The **input** comes as a single string argument - the text to extract and convert words from.

The **output** should be a single line containing the converted string.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">'Hi, how are you?'</td><td colspan="1" valign="top"><p>HI, HOW, ARE, YOU</p><p></p></td><td colspan="1" valign="top">'hello'</td><td colspan="1" valign="top"><p>HELLO</p><p></p></td></tr>
</table>
### **Hints**
- You may need to use a [Regular Expression](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions) or alternatively check for all delimiters that can be found in a sentence (ex. ",", " ", "!", "?" and so on).



