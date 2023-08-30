
# **Lab: Java Syntax**
Problems for exercises and homework for the [“Software Technologies” course @ SoftUni](https://softuni.bg/courses/software-technologies).

You can submit your solutions here <https://judge.softuni.bg/Contests/264>.
1. ## **Calculate Expression**
Write a Java program which prints the result of the following expression: 

- **((30 + 21) \* 1/2 \* (35 - 12 – 1/2))<sup>2</sup>**
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|*(no input)*|329189\.0625|
### **Hints**
- You can use the following code to help you out with this problem:
- You can solve this problem by either using the **Math.pow()** method or by multiplying the result by **itself**.
1. ## **Sum Two Numbers**
Write a Java program to sum **two numbers**, which are received as **floating-point numbers** on a **new** line.
### **Examples**

|**Input**|**Output**||**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :- | :-: | :-: | :-: | :-: | :-: |
|<p>14</p><p>23</p>|37||<p>1\.999</p><p>2\.001</p>|4\.00||<p>1\.2345</p><p>5\.6789</p>|6\.91|
1. ## **Three Integers Sum**
Write a Java program, which receives **three numbers**, as **integer array**. Your task is to check whether there exists a number in the sequence, which is equal to the **sum** of the other two.

- If such exist, print the numbers and their sum in the following format: “**{num1} + {num2} = {sum}**”.  Print the elements, in such way, that **num1 <= num2**
- If there’s no such element, print “**No**”.
### **Examples**

|**Input**|**Output**||**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :- | :-: | :-: | :- | :-: | :-: |
|8 15 7|7 + 8 = 15||-5 -3 -2|-3 + -2 = -5||3 8 12|No|
1. ## **Sum N Integers**
Write a Java program which receives an **integer** – **n** and finds the **sum** of the next **n** integers. On each of the next **n** lines, you will receive a **single** number. 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>**5**</p><p>10</p><p>20</p><p>30</p><p>40</p><p>-16</p>|Sum = 84|
1. ## **Symmetric Numbers**
Write a Java program, which receives **a number n**, as a **string array** with a single element, and print all symmetrical numbers in the range **[1…n]**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|50|1 2 3 4 5 6 7 8 9 11 22 33 44|


|**Input**|**Output**|
| :-: | :-: |
|888|1 2 3 4 5 6 7 8 9 11 22 33 44 55 66 77 88 99 101 111 121 131 141 151 161 171 181 191 202 212 222 232 242 252 262 272 282 292 303 313 323 333 343 353 363 373 383 393 404 414 424 434 444 454 464 474 484 494 505 515 525 535 545 555 565 575 585 595 606 616 626 636 646 656 666 676 686 696 707 717 727 737 747 757 767 777 787 797 808 818 828 838 848 858 868 878 888|
1. ## **Largest 3 Numbers**
Write a program to read an **array** of **numbers** and find and print the **largest 3** of them, sorted in **descending order**.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :- | :-: | :-: |
|10 30 15 20 50 5|<p>50</p><p>30</p><p>20</p>||20 30|<p>30</p><p>20</p>|
1. ## **Sums by Town**
Write a program, which finds the **total** income for **each** **town** you receive.

On the **first** line, you will receive an integer – **n**. 

On the **next** **n** lines, you will receive **towns** in the following format:

- **{nameOfTheTown} | {income}**

After all towns are received à print the total income for each town in the format:

- **{nameOfTheTown} -> {totalIncome}**

**Order** the towns by their names in **ascending** **alphabetical** order.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>4</p><p>Sofia  | 200.0</p><p>Varna  | 120.0</p><p>Pleven | 60.0</p><p>Varna  | 70.0</p>|<p>Pleven -> 60.0</p><p>Sofia -> 200.0</p><p>Varna -> 190.0</p>|


