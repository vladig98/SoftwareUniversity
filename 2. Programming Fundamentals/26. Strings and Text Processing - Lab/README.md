
# **Lab: Strings and Text Processing**
This document defines the homework assignments from the ["Programming Fundamentals" Course @ Software University](https://softuni.bg/courses/programming-fundamentals). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/320/Strings-Lab).
1. ## **Reverse String**
Write a program that reads a string from the console, reverses it and prints the result back at the console.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|sample|elpmas|
|24tvcoi92|29iocvt42|
1. ## **Count Substring Occurrences**
Write a program to **find how many times a given string appears in a given text as substring**. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the **character casing**. **Overlapping** between occurrences is **allowed**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>**Wel**come to the Software University (SoftUni)! **Wel**come to programming. Programming is **wel**lness for developers, said Max**wel**l.</p><p>wel</p>|<p>4</p><p></p>|
|<p>**aaaaaa**</p><p>aa</p>|5|
|<p>**ababa** c**aba**</p><p>aba</p>|3|
|<p>Welcome to SoftUni</p><p>Java</p>|0|
1. ## **Text Filter**
Write a program that takes a **text** and a **string of banned words**. All words included in the ban list should be replaced with **asterisks** "**\***", equal to the word's length. The entries in the ban list will be separated by a **comma** and **space** "**,** ".

The ban list should be entered on the first input line and the text on the second input line. 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Linux, Windows</p><p>It is not **Linux**, it is GNU/**Linux**. **Linux** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/**Linux**! Sincerely, a **Windows** client</p>|It is not \*\*\*\*\*, it is GNU/\*\*\*\*\*. \*\*\*\*\* is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/\*\*\*\*\*! Sincerely, a \*\*\*\*\*\*\* client|
1. ## **Palindromes**
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only **unique** palindromes, **sorted** lexicographically.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|Hi,exe? ABBA! Hog fully a string. Bob|a, ABBA, exe|



