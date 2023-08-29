
# **Exercises: C# Intro and Basic Syntax**
Problems for exercises and homework for the [“Programming Fundamentals Extended” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).
1. ## **Debit Card Number**
Write a program, which receives **4** **integers** on the console and **prints them** in **4-digit debit card format**. See the examples below for the appropriate formatting.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>12</p><p>433</p><p>1</p><p>5331</p>|0012 0433 0001 5331|
|<p>9182</p><p>4221</p><p>12</p><p>3</p>|9182 4221 0012 0003|
|<p>812</p><p>321</p><p>123</p><p>22</p>|0812 0321 0123 0022|
1. ## **Rectangle Area**
Write a program, which calculates a <b>rectangle’s area</b>, based on its <b>width</b> and <b>height</b>. The <b>width</b> and <b>height</b> come as floating point numbers on the console, <b>formatted to the 2<sup>nd</sup> character after the decimal point</b>.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>2</p><p>7</p>|14\.00|
|<p>7</p><p>8</p>|56\.00|
|<p>12\.33</p><p>5</p>|61\.65|
1. ## **Miles to Kilometers**
Write a program, which <b>converts</b> <b>miles</b> to <b>kilometers</b>. <b>Format</b> the output to the <b>2<sup>nd</sup> decimal place</b>.

Note: **1 mile == 1.60934 kilometers**


### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">60</td><td colspan="1" valign="top">96\.56</td><td colspan="1" valign="top">1</td><td colspan="1" valign="top">1\.61</td><td colspan="1" valign="top">52\.1113</td><td colspan="1" valign="top">83\.86</td></tr>
</table>
1. ## **Beverage Labels**
Write a program, which reads a food product **name**, **volume**, **energy content** **per 100ml** and **sugar content per 100ml**. Calculate the **energy** and **sugar content** for the **given volume** and print them on the console in the following format:

- Name – as per the input
- Volume – **integer**, **suffixed** by “**ml**” (e.g. “**220ml**”)
- Energy content – **integer**, **suffixed** by “**kcal**” (e.g. “**500kcal**”)
- Sugar content – **integer**, **suffixed** by “**g**” (e.g. “**30g**”) 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p><a name="_hlk493601891"></a>Nuka-Cola</p><p>220</p><p>300</p><p>70</p>|<p>220ml Nuka-Cola:</p><p>660kcal, 154g sugars</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>Ice Cold Nuka-Cola</p><p>250</p><p>350</p><p>65</p>|<p>250ml Ice Cold Nuka-Cola:</p><p>875kcal, 162.5g sugars</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>Nuka-Cola Quantum</p><p>350</p><p>600</p><p>140</p>|<p>350ml Nuka-Cola Quantum:</p><p>2100kcal, 490g sugars</p>|
1. ## **\* Character Stats**
Write a program, which **displays information** about a video game character. You will receive their **name**, **current health**, **maximum health**, **current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>Mayro</p><p>5</p><p>10</p><p>9</p><p>10</p></td><td colspan="1" valign="top"><p><a name="ole_link4"></a><a name="ole_link5"></a>Name: Mayro</p><p><a name="ole_link6"></a><a name="ole_link7"></a>Health: ||||||.....|</p><p>Energy: ||||||||||.|</p></td><td colspan="1" valign="top"><p>Bauser</p><p>10</p><p>10</p><p>10</p><p>10</p></td><td colspan="1" valign="top"><p>Name: Bauser</p><p>Health: ||||||||||||</p><p>Energy: ||||||||||||</p></td></tr>
</table>


<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>Loogi</p><p>8</p><p>20</p><p>2</p><p>14</p></td><td colspan="1" valign="top"><p>Name: Loogi</p><p>Health: |||||||||............|</p><p>Energy: |||............|</p></td><td colspan="1" valign="top"><p>Toad</p><p>0</p><p>5</p><p>0</p><p>10</p></td><td colspan="1" valign="top"><p>Name: Toad</p><p>Health: |.....|</p><p>Energy: |..........|</p></td></tr>
</table>
### **Hints**
- You can print a character **multiple** times, using **new string(character, count)**.

