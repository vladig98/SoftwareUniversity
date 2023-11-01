# **Exercise: JavaScript Syntax and Operators**
Problems for exercises and homework for the ["JavaScript Fundamentals" course @ SoftUni](https://softuni.bg/trainings/2247/js-fundamentals-january-2019) 
` `Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/Practice/Index/1422>
1. ## **I like JavaScript!**
Write a JS function that **can receive a name** as input and print a greeting to the console.

The **input** comes as a single string that is the name of the person.

The **output** should be printed to the console.
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|'George'|Hello George, do you like JavaScript?|
|'Maria'|Hello Maria, do you like JavaScript?|
1. ## **Even Numbers 1 to N**
Write a JS function that reads an integer **n** and prints all **even numbers** from **1** to **n**.

The **input** comes as a **single number n**. The number **n** will be an integer in the range 
[1 … 100 000].

The **output** should hold the expected even numbers, each at a separate line.
### **Example**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">5</td><td colspan="1" valign="top"><p>2</p><p>4</p><p></p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top">4</td><td colspan="1" valign="top"><p>2</p><p>4</p></td><td colspan="1" valign="top">7</td><td colspan="1" valign="top"><p>2</p><p>4</p><p>6</p><p></p></td></tr>
</table>
1. ## **Fruit**
Write a JS function that calculates how much money you need to buy a fruit. You will receive a **string** for the type of fruit you want to buy, **a number** for weight in grams and another **number** for a price per kilogram. 

Print the following text on the console:  **'I need {money} leva to buy {weight} kilograms {fruit}.'** . Print the weight and the money **rounded** to two decimal places.

The **input** comes as **three arguments** passed to your function.

The **output** should be printed to the console.
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|'orange', 2500, 1.80|I need 4.50 leva to buy 2.50 kilograms orange.|


|**Input**|**Output**|
| :-: | :-: |
|'apple', 1563, 2.35|I need 3.67 leva to buy 1.56 kilograms apple.|
1. ## **Fitness Rates**
Write a JS function that calculates how much money you need to visit your favorite gym. You will receive **two strings** for a day of week and a service which you want to use and a **number** for the time in which you can go to the gym.

In the table below you can find information about the prices and services offered at the gym.

|**Service** |**Fitness**|**Sauna**|**Instructor**||||
| :-: | :-: | :-: | :-: | :- | :- | :- |
|**Hours**|8\.00-15.00|15\.00-22.00|8\.00-15.00|15\.00-22.00|8\.00-15.00|15\.00-22.00|
|**Monday**|5\.00|7\.50|4\.00|6\.50|10\.00|12\.50|
|**Tuesday**|5\.00|7\.50|4\.00|6\.50|10\.00|12\.50|
|**Wednesday**|5\.00|7\.50|4\.00|6\.50|10\.00|12\.50|
|**Thursday**|5\.00|7\.50|4\.00|6\.50|10\.00|12\.50|
|**Friday**|5\.00|7\.50|4\.00|6\.50|10\.00|12\.50|
|**Saturday**|8\.00|8\.00|7\.00|7\.00|15\.00|15\.00|
|**Sunday**|8\.00|8\.00|7\.00|7\.00|15\.00|15\.00|

Example: If you want to go to the gym on Monday at 15 o`clock and use the sauna you have to pay 4.00 leva.

The **input** comes as **three arguments** passed to your function.

The **output** should be printed to the console.



### **Example**

|**Input**|**Output**|
| :-: | :-: |
|'Monday', 'Sauna', 15.30|6\.5|


|**Input**|**Output**|
| :-: | :-: |
|'Sunday', 'Fitness', 22.00|8|
1. ## **Greatest Common Divisor – GCD**
Write a JS function that takes **two** **positive** **numbers** as input and compute the greatest common divisor.	

Print on the console the result. 

The **input** comes **as two positive integer numbers**.

The **output** should be printed to the console.
### **Example**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|15, 5|5||2154, 458|2|

1. ## **Same Numbers**
Write a JS function that takes **an integer** **number** as input and check if all the digits in a given number are the same or not.

Print on the console **true** if all numbers are same or **false** if not. On the next line print the **sum of all the digits.**

The **input** comes as an integer number.

The **output** should be printed to the console.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|2222222|<p>true</p><p>14</p>||1234|<p>false</p><p>10</p>|

1. ## **Time to Walk**
Write a JS function that **calculates** how long it takes a student to get to the university. 
The function takes **three numbers**:

- The **first** is the number of **steps** the student makes from his home to the university
- Тhe **second** number is the length of the student's footprint in **meters**
- Тhe **third** number is the student speed in **km/h**

Sometimes the student needs a rest. Every 500 meters, the person makes a **1 minute break**.

Calculate how long the student goes from home to university and print on the console the result as follows: **'hours:minutes:seconds'**.

The **input** comes as **three numbers**.

The **output** should be printed to the console.
### **Example**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|4000, 0.60, 5|00:32:48||2564, 0.70, 5.5|00:22:35|
1. ## **Flight Timetable**
Write a JS function that displays flight information.

The **input** comes as an **array of string elements**. 

- The first string can be **'Arrivals'** or **'Departures'**
- The second string is the **name** of the town
- The third is the **time** when the plain departures or arrives
- The fourth is the **flight number**
- The last one is the **gate number**

The **output** should be printed to the console in the following format:

**“Departures/Arrivals: Destination - {town}, Flight - {flight number},  Time - {departure/arrival time}, Gate - {gate number}”**
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|['Departures', 'London', '22:45', 'BR117', '42']|Departures: Destination – London, Flight – BR117, Time – 22:45, Gate - 42|
|['Arrivals', 'Paris', '02:22', 'VD17', '3']|<p>Arrivals: Destination – Paris, </p><p>Flight – VD17, Time – 02:22, Gate - 3</p>|
1. ## **Calorie Object**
Write a JS function that composes an object by given properties. Every even index of the array is the string and the name of the food. Every odd index is a number that is equal to the calories in 100 grams of product. Assign each value to its respective property of an object and print it on the console.

The **input** comes as an **array of string** **elements**.

The **output** should be printed to the console.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|['Yoghurt', 48, 'Rise', 138, 'Apple', 52]|{ Yoghurt: 48, Rise: 138, Apple: 52 }|
|['Potato', 93, 'Skyr', 63, 'Cucumber', 18, 'Milk', 42]|{ Potato: 93, Skyr: 63, Cucumber: 18, Milk: 42 }|
1. ## **\*Coffee Machine**
Write a program for a coffee machine. Calculate whether the money inserted in the machine is enough to make the order and print the corresponding output.
### **Input**
The input is an **array of strings**. Each string represents one order with different parts, separated by a single space  **' '**. 

- The **first part** is the **coins inserted**. 
- The **second** is the **type of drink** (**coffee or tea**).
- Next, if the drink type is **coffee**, you will receive **'caffeine'** or **'decaf'**.
- Next, you may receive **'milk',** if the ordered drink is with milk. **It costs** **10% of the drink price, rounded to first decimal point**
- And **last** you receive the **quantity of sugar, between 0 and 5**. **No matter the quantity (except from 0) it costs 0.10. Add the sugar at the end!**

The **prices of drinks** are:

|**Type**|**Price**|
| :-: | :-: |
|coffee caffeine|0\.80|
|coffee decaf|0\.90|
|tea|0\.80|
### ` `**Constrains**
- The input will always be **valid.**
### **Output**
For each order there are **two possible** outputs:

- If the money inserted is enough, calculate the change of the order: 

**'You ordered {drink}. Price: {price}$ Change: {change}$'**

- If the money is not enough: 

**'Not enough money for {drink}. Need {moneyNeeded}$ more'**


After proceeding all orders, print the **total money earned** from the **successful** orders in the format: **'Income Report: {totalMoney}$'**

All of the numbers should be **formatted to the second decimal point**.

### **Example**

|**Input**|**Output**|
| :-: | :-: |
|<p>['1.00, coffee, caffeine, milk, 4', '0.40, tea, milk, 2',</p><p>'1.00, coffee, decaf, 0']</p>|<p>You ordered coffee. Price: 1.00$ Change: 0.00$</p><p>Not enough money for tea. Need 0.60$ more.</p><p>You ordered coffee. Price: 0.90$ Change: 0.10$</p><p>Income Report: 1.90$</p>|
|**Comments**||
|<p>The first order is coffee with caffeine, milk and sugar. The price of the drink is 0.80$, we calculate the milk, 10% of the price, rounded to the first decimal point - 0.1$, and we add the sugar => 0.80 + 0.10 + 0.10 = 1.00.</p><p>The second order is tea with milk and sugar (0.80 + 0.10 + 0.10 = 1.00), but the money inserted is not enough.</p><p>Next, we receive order for coffee decaf with no milk and 0 sugar => 0.90$. The change is 0.10$.</p><p>Total income = 1.90</p>||
|**Input**|**Output**|
|<p>['8.00, coffee, decaf, 4',</p><p>'1.00, tea, 2']</p>|<p>You ordered coffee. Price: 1.00$ Change: 7.00$</p><p>You ordered tea. Price: 0.90$ Change: 0.10$</p><p>Income Report: 1.90$</p>|


# **More Exercise: JavaScript Syntax and Operators**
Problems for exercises lab for the ["JavaScript Fundamentals" course @ SoftUni](https://softuni.bg/trainings/2247/js-fundamentals-january-2019).
Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/Practice/Index/1423>
1. ## **Daily Calorie Intake**
Write a JS function that calculates your daily calorie intake.

All you need is a **person's sex, weight, height, age and active factor**. 

First, you need to calculate the **basic metabolism** of a person. Depending on the gender of the person, use one of the two formulas given below:

**Calories (man) = 66 + 13.8 \* weight + 5 \* height - 6.8 \* age**

**Calories (woman) = 655 + 9.7 \* weight + 1.85 \* height - 4.7 \* age**

After that, you should calculate the weekly activity:

- if a person does not exercise during the week, the active factor (AF) is **1.2;**
- for 1 or 2 workouts per week, AF = **1.375**; 
- between 3 and 5 workouts per week, AF = **1.55**; 
- 6 or 7 workouts per week, AF = **1.725**;
- For workouts that are more than 7 per week, AF = **1.90**.

The multiplication of AF and the calorie consumed by basic metabolism gives you the daily calorie intake. 

Print the following text on the console:  **'My calorie intake is {calories}'** . Print the calories rounded to the **nearest integer**.
### **Input**
The **input** comes as two arguments passed to your function. The first argument is an **array that contains the person data – sex, weight, height, age**. The second argument is a **number that represents the workouts** for that person.

The **output** should be printed on the console.
### **Example**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|['f', 46, 157, 32], 5|1924||['m', 86, 185, 25], 3|3112|

1. ## **Common Numbers**
You will receive three integer arrays. Write a JS function to find the **common** elements from the three arrays. Save the unique numbers in a new array and calculate the **average** and the **median** of it.

Print on the console:

- **'The common elements are {array}.'** – sort the array in ascending order.
- **'Average: {number}'**
- **'Median: {number}'**
### **Input**
The **input** comes as three integer arrays.

The **output** should be printed to the console.

|**Input**|**Output**|
| :-: | :-: |
|<p>[5, 6, 50, 10, 1, 2],</p><p>[5, 4, 8, 50, 2, 10], </p><p>[5, 2, 50]</p>|<p>The common elements are 2, 5, 50.</p><p>Average: 19.</p><p>Median: 5.</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>[1, 2, 3, 4, 5],</p><p>[3, 2, 1, 5, 8],</p><p>[2, 5, 3, 1, 16]</p>|<p>The common elements are 1, 2, 3, 5.</p><p>Average: 2.75.</p><p>Median: 2.5.</p>|

1. ## **Humanized Number**
You will receive a text as an input. The text will be a <b>string</b> and it can contain <b>dots, commas and blank spaces</b>. Write a JS function that <b>finds all numbers</b> in a text and humanizes them (Formats a number to a human – readable string), by adding a correct suffix, such as <b>1<sup>st</sup>, 2<sup>nd</sup>, 3<sup>rd</sup> or 4<sup>th</sup></b>. Print each number on a separate line.
### **Input**
The **input** comes as a number passed to your function.

The **output** should be printed to the console.





|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|'The school has 256 students. In each class there are 26 chairs, 13 desks and 1 board.'|<p>256th</p><p>26th</p><p>13th</p><p>1st</p>||'Yesterday I bought 12 pounds of peppers, 3 kilograms of carrots and 5 kilograms of tomatoes.'|<p>12th</p><p>3rd</p><p>5th</p>|
1. ## **Perfect Number**
Write a JS function to find the **perfect number/numbers** in an **array of numbers**. A perfect number is a **positive integer** that is **equal to the sum of its proper positive divisors**, **excluding the number itself** (also known as its aliquot sum). Equivalently, a perfect number is a number that **is half the sum of all of its positive divisors (including itself).**

Example: Perfect number is 6, because 1, 2, and 3 are its proper positive divisors, and **1 + 2 + 3 = 6**. Equivalently, the number 6 is equal to half the sum of all its positive divisors: (**1 + 2 + 3 + 6) / 2 = 6.**
### **Input**
The **input** comes as a number array passed to your function.

The **output** should be printed to the console. Print the elements on a single line, separated by a **comma and a single space**. In case of **no perfect numbers** in the array, just print **'No perfect number'**.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|[5, 6, 28]|6, 28||[5, 32, 82]|No perfect number|

1. ## **Converter to Coins**
Write a JS function to **convert** a given number into coins.**  The input comes as **two arguments** passed to your function. The first argument is an **integer** number – the amount you want to convert into coins. The second argument is an integer **array** of coin values. First, you need to **order the array in descending order** because you want to start converting from the largest coins. 

**Example:** If the amount is **57** and you have **[25, 10, 5, 1]** coins, after conversion you have to receive **two 25** cent coins, **one 5** cent coin and **two 1** cent coins.

### **Input**
The input comes as **two arguments** passed to your function.

The **output** should be printed to the console. Print the elements on a single line, separated by a **comma and a single space**. 
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|<p>46, [10, 25, 5, 1, 2] </p><p></p>|25, 10, 10, 1 |


|**Input**|**Output**|
| :-: | :-: |
|123, [5, 50, 2, 1, 10]|50, 50, 10, 10, 2, 1|





