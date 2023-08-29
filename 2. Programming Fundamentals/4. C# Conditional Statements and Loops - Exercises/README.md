
# **Exercises: C# Conditional Statements and Loops**
Problems for exercises and homework for the [“Programming Fundamentals” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).
1. ## **Choose a Drink**
Write a program, which receives a **profession** (as a **string**) and chooses the perfect **drink** for the person. The possible combinations are: 

- “**Water**” – for “**Athlete**”
- “**Coffee**” – for “**Businessman**” or “**Businesswoman**”
- “**Beer**” – for “**SoftUni Student**”
- “<a name="ole_link9"></a><a name="ole_link10"></a>**Tea**” – for all **other professions**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th></tr>
<tr><td colspan="1" valign="top">Athlete</td><td colspan="1" valign="top">Water</td><td colspan="1" valign="top">Doctor</td><td colspan="1" valign="top">Tea</td></tr>
</table>
1. ## **Choose a Drink 2.0**
Your program needs to get smarter. Now you will receive on the second line the <a name="ole_link21"></a><a name="ole_link22"></a>quantities of the drink and you have to print the calculated the price. You can see the prices of the drinks in the table below:

||**Water**|**Coffee**|**Beer**|**Tea**|
| - | :-: | :-: | :-: | :- |
|**Price**|0\.70|1\.00|1\.70|1\.20|
### **Input**
The **input** will be on two lines:

- On the **first** **line**, you will receive the **profession**
- On the **second** line, you will receive the **quantity** as an **integer**. 
### **Output**
Print the output in the following format:

<a name="ole_link19"></a><a name="ole_link20"></a>**The {profession} has to pay {totalPrice}.**

<b>Format</b> the <b>price</b> to the <b>2<sup>nd</sup> decimal place</b>.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Athlete</p><p>1</p>|The Athlete has to pay 0.70.|
|<p>SoftUni Student</p><p>8</p>|The SoftUni Student has to pay 13.60.|
|<p>Chef</p><p>3</p>|The Chef has to pay 3.60.|
1. ## **Restaurant Discount**
A restaurant want to automate their reservation process. They need a program that reads the **hall** and the **count of people** from the console and calculates **how much** the customer should **pay** to book the place.

Different halls have different prices:

||<a name="ole_link27"></a><a name="ole_link28"></a>**Small Hall**|<a name="ole_link29"></a><a name="ole_link30"></a>**Terrace**|<a name="ole_link31"></a><a name="ole_link32"></a>**Great Hall**|
| - | :-: | :-: | :-: |
|**Price**|2500$|5000$|7500$|
|**Capacity**|50|100|120|

The restaurant has **discounts** depending on the **service package,** which the group wants. 

You can see the discounts in the table below:

||**Normal**|**Gold**|**Platinum**|
| - | :-: | :-: | :-: |
|**Discount**|5%|10%|15%|
|**Price**|500$|750$|1000$|

You should **add** the **price** of the **package** to the **price** of the **hall**. The discount is calculated based on the **hall’s price + package’s price**.

Example: The group has **10 people** and wants the **gold package è $292.50 per person**:

- **10 people** <= 50 è they get the **Small Hall** è $2500
- Gold package è **$750**, **10%** discount on the entire purchase
- Total price: **$2500 + $750** = **$3250**
- Discount: $3250 - **10% discount** = $2925
- Price per person: $2925 / **10 people** = **$292.50 per person**

You should print **which hall** is the **most suitable** for the group and the **price per person**. If the group is **bigger than 120** people – print “<a name="ole_link23"></a><a name="ole_link24"></a>**We do not have an appropriate hall.**”.
### **Input**
- First line: the **group size** as an **integer**
- Second line: the **package** as a **string**
### **Output**
Print the output in the following format:

|<p>**We can offer you the {hallName}**</p><p>**The price per person is {price}$**</p>|
| :- |

<b>Format</b> the <b>price</b> to the <b>2<sup>nd</sup> decimal place</b>.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>20</p><p>Gold</p>|<p><a name="ole_link25"></a><a name="ole_link26"></a>We can offer you the **Small Hall**</p><p>The price per person is **146.25$**</p>|
|<p>90</p><p>Platinum</p>|<p>We can offer you the **Terrace**</p><p>The price per person is **56.67$**</p>|
|<p>150</p><p>Normal</p>|We do not have an appropriate hall.|
1. ## **Hotel**
A hotel has three types of rooms: **studio**, **double** and **master suite**. The prices are different for the different months: 

|<a name="ole_link33"></a><a name="ole_link34"></a>**May and October**|**June and <a name="ole_link35"></a><a name="ole_link36"></a>September**|**July, August and December**|
| :- | :- | :- |
|Studio - **50** leva per night|Studio - **60** leva per night|Studio - **68** leva per night|
|Double - **65** leva per night |Double - **72** leva per night|Double - **77** leva per night|
|Suite - **75** leva per night|Suite - **82** leva per night|Suite - **89** leva per night|

They have also the following discounts: 

- For **studio** and **more than 7** nights in **May and October**: **5% discount**
- For **double** and **more than 14** nights in **June and September**: **10% discount**
- For **suite** and **more than 14** nights in **July,** **August and December**: **15% discount**
- For **studio** and **more than 7** nights in **September and October**: **one night is free**
### **Input**
The input consists of exactly **2 lines**:

- First line: **Month** – <a name="ole_link1"></a><a name="ole_link2"></a>**May, <a name="ole_link5"></a><a name="ole_link6"></a>June, <a name="ole_link11"></a><a name="ole_link12"></a>July, <a name="ole_link13"></a><a name="ole_link14"></a>August, <a name="ole_link7"></a><a name="ole_link8"></a>September<a name="ole_link3"></a><a name="ole_link4"></a>, October** or **December**
- Second line: **Nights Count** – **an integer between [0 ... 200]**
### **Output**
Print **3 lines** on the console:

- On **the first**: “<a name="ole_link15"></a><a name="ole_link16"></a><a name="ole_link37"></a>**Studio: {price for the stay} lv.**”
- On **the second**: “<a name="ole_link17"></a><a name="ole_link18"></a>**Double: {price for the stay} lv.**”
- On **the third: “Suite: {price for the stay} lv.”**

<b>Format</b> the <b>prices</b> to the <b>2<sup>nd</sup> decimal place</b>.
### **Examples**

|**Input**|**Output**|**Comment**|
| :-: | :-: | :-: |
|<p>June</p><p>5</p>|<p>Studio: 300.00 lv.</p><p>Double: 360.00 lv.</p><p><a name="ole_link38"></a><a name="ole_link43"></a>Suite: 410.00 lv.</p>|The **nights are not enough** for getting a discount, so the studio is 60 lv, **double room = 72** and apartment = 82. We **multiply the prices by the nights** and get the total prices.|


|**Input**|**Output**|**Comment**|
| :-: | :-: | :-: |
|<p>May</p><p>10</p>|<p>Studio: 475.00 lv.</p><p>Double: 650.00 lv.</p><p>Suite: 750.00 lv.</p>|In May, we have a discount of **5%**, when the nights are **more than 7**.That means the **price for night** in the studios is **50 \* 0.95 = 47.5**. Again, we **multiply the prices by the nights** and get the total prices. |
|**Input**|**Output**||**Input**|**Output**|
|<p>July</p><p>16</p>|<p>Studio: 1088.00 lv.</p><p>Double: 1232.00 lv.</p><p>Suite: 1210.40 lv.</p>||<p>September</p><p>10</p>|<p>Studio: 540.00 lv.</p><p>Double: 720.00 lv.</p><p>Suite: 820.00 lv.</p>|
1. ## **\* Word in Plural**
Write a program, which receives a **noun** and prints the **noun** in **plural**. You will receive one of the following cases: 

- A noun that ends in **y** – remove the **y** and add **ies**
- A noun that ends in <a name="ole_link73"></a><a name="ole_link74"></a>**o**, **ch**, **s**, **sh**, **x** or **z** – add **es** at the end of the word
- In all other cases – just add **s** at the end
### **Input**
You will receive a **single** word, which you have to **pluralize.**
### **Output**
Print only the **word in plural.**
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">couch</td><td colspan="1" valign="top">couches</td><td colspan="1" valign="top">butterfly</td><td colspan="1" valign="top">butterflies</td><td colspan="1" valign="top"></td><td colspan="1" valign="top">door</td><td colspan="1" valign="top">doors</td></tr>
</table>
### **Hints**
- You can use the method **String.EndsWith(…)** and **String.Remove(…)** – search for more information on how to use this methods in internet. Do not forget that **strings are** **immutable**.
1. ## **Interval of Numbers**
Write a program, which takes **two numbers** as input and prints the **interval of numbers between them**, **starting** from the **smaller one** and **ending** with the **larger** one.
### **Input**
You will receive **two lines**. Each of them will contain **one integer**.
### **Output**
Print all the numbers separated on **new lines**.
### **Constraints**
- The numbers, which you receive will be in the interval **[0…100]**.
- The two numbers, which you take as an input will **not be equal**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>42</p><p>48</p></td><td colspan="1" valign="top"><p>42</p><p>43</p><p>44</p><p>45</p><p>46</p><p>47</p><p>48</p></td><td colspan="1" valign="top"><p>100</p><p>14</p></td><td colspan="1" valign="top"><p>14</p><p>15</p><p>16</p><p><i>continues...</i></p><p>98</p><p>99</p><p>100</p></td></tr>
</table>
1. ## **Cake Ingredients**
Write a baking program, which takes as an input ingredients and writes a message when the ingredient is in the system. For every given ingredient, you should write: <a name="_hlk482560738"></a>“Adding ingredient {name of the ingredient}.”. When you receive the command “Bake!” from the console you should stop the program and write “Preparing cake with {number of given ingredients} ingredients.”. 
### **Input**
You will receive **ingredients until the command** “**Bake!**”** is given.
### **Output**
For every given ingredient write on a **new line** the message: “<a name="ole_link44"></a><a name="ole_link45"></a>**Adding ingredient {name of the ingredient}.**”. At the end print the message: “<a name="ole_link46"></a><a name="ole_link47"></a>**Preparing cake with {number of given ingredients} ingredients.**”.
### **Constraints**
- You will receive maximum **20** ingredients.
- Every ingredient will be between **1** and **50 characters**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Flour</p><p>Bread</p><p>Sugar</p><p>Butter</p><p>Bake!</p>|<p>Adding ingredient Flour.</p><p>Adding ingredient Bread.</p><p>Adding ingredient Sugar.</p><p>Adding ingredient Butter. Preparing cake with 4 ingredients.</p>|
1. ## **Calories Counter**
You have to write a program, which **counts the calories**, which can be found in your **pizza recipe**. In your recipe, there are only **four** ingredients – **cheese**, **tomato sauce**, **salami** and **pepper**. Each ingredient contains a **fixed amount** of calories: 

- **Cheese** – **500** calories
- **Tomato sauce** – **150** calories
- **Salami** – **600** calories
- <a name="ole_link50"></a><a name="ole_link51"></a><a name="ole_link52"></a>**Pepper** – **50** calories 

If you **receive** one of these ingredients **more than once**, you should **add** the calories** to the **total amount** **again**. You should **not process any other ingredients**. Ingredients are **case-insensitive**.
### **Input**
### On the next **n lines**, you will receive different <a name="ole_link48"></a><a name="ole_link49"></a>**ingredients**. **Add** the calories **only** from the ones, **which are in your recipe**. 
### **Output**
Print the answer in the following format:

<a name="ole_link53"></a><a name="ole_link54"></a>**Total calories: {totalCaloriesAmount}**
### **Constraints**
- You will receive maximum **20** ingredients.
- Every ingredient will be between **1** and **50 characters**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p><b>5</b></p><p>cheese</p><p>toMatO sauce</p><p>flour</p><p>salami</p><p>pepper</p></td><td colspan="1" valign="top">Total calories: 1300</td><td colspan="1" valign="top"><p><b>3</b></p><p>Cheese</p><p>Cucumber</p><p>cheese</p></td><td colspan="1" valign="top">Total calories: 1000</td></tr>
</table>
1. ## **Count the Integers**
Write a program, which can receive **any type of input**, but upon receiving anything **other than an integer** – **stops** **the execution** of the program and prints **how many numbers were read**.
### **Input**
You can receive **any type of data** as **input** from the console.
### **Output**
Print only the **total count** of the numbers.
### **Constraints**
- You will receive **no more than 100 lines**.
- Every number will not be longer than **7 digits**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>1</p><p>2</p><p>3</p><p>4</p><p>5</p><p>6</p><p>PF is the best!</p></td><td colspan="1" valign="top">6</td><td colspan="1" valign="top"><p>12312</p><p>End the input</p></td><td colspan="1" valign="top">1</td></tr>
</table>
1. ## **Triangle of Numbers**
Write a program, which receives a number – **n**, and prints a triangle from **1 to n** as in the examples.
### **Constraints**
- **n** will be in the interval [**1...20]**.
### **Examples**

<table><tr><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">3</td><td colspan="1" valign="top"><p>1</p><p>2 2 </p><p>3 3 3</p></td><td colspan="1" valign="top">5</td><td colspan="1" valign="top"><p>1</p><p>2 2 </p><p>3 3 3</p><p>4 4 4 4</p><p>5 5 5 5 5</p></td><td colspan="1" valign="top">6</td><td colspan="1" valign="top"><p>1</p><p>2 2 </p><p>3 3 3</p><p>4 4 4 4</p><p>5 5 5 5 5</p><p>6 6 6 6 6 6</p></td></tr>
</table>
1. ## **5 Different Numbers**
You will be given two numbers – <b>a</b> and <b>b</b>. Generate <b>five</b> numbers - <b>n<sub>1</sub></b>, <b>n<sub>2</sub></b>, <b>n<sub>3</sub></b>, <b>n<sub>4</sub></b>,</sub> <b>n<sub>5</sub></b>, for which the following <b>conditions</b> are true: <b>a</b> ≤ <b>n<sub>1</sub></b> < <b>n<sub>2</sub></b> < <b>n<sub>3</sub></b> < <b>n<sub>4</sub></b> < <b>n<sub>5</sub></b> ≤ <b>b</b>. If there is <b>no number</b> in the given interval, which <b>satisfies the conditions</b> – print “<b>No</b>”.
### **Input**
The input contains **two integers**, each on a **new line**.
### **Output**
Print all numbers in **increasing order** and on a **new line**.
### **Constraints**
- **a** and **b** will be integers in the interval **[-100…100]**
### **Examples**

<table><tr><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>3</p><p>8</p></td><td colspan="1" valign="top"><p>3 4 5 6 7</p><p>3 4 5 6 8</p><p>3 4 5 7 8</p><p>3 4 6 7 8</p><p>3 5 6 7 8</p><p>4 5 6 7 8</p></td><td colspan="1" valign="top"><p>40</p><p>46</p></td><td colspan="1" valign="top"><p>40 41 42 43 44</p><p>40 41 42 43 45</p><p>40 41 42 43 46</p><p>40 41 42 44 45</p><p>40 41 42 44 46</p><p>40 41 42 45 46</p><p>40 41 43 44 45</p><p>40 41 43 44 46</p><p>40 41 43 45 46</p><p>40 41 44 45 46</p><p>40 42 43 44 45</p><p>40 42 43 44 46</p><p>40 42 43 45 46</p><p>40 42 44 45 46</p><p>40 43 44 45 46</p><p>41 42 43 44 45</p><p>41 42 43 44 46</p><p>41 42 43 45 46</p><p>41 42 44 45 46</p><p>41 43 44 45 46</p><p>42 43 44 45 46</p></td><td colspan="1" valign="top"><p>13</p><p>16</p></td><td colspan="1" valign="top">No</td></tr>
</table>
1. ## **Test Numbers**
Write a program, which finds all the possible combinations between two numbers – **N** and **M**.

The first digit **decreases** from **N to 1**,** and the second digit **increases** from **1 to M**. The two digits form a **number**. **Multiply the two digits**,** then **multiply** their **product** by **3**. **Add** the **result** to the **total sum**. 

You will also be given a **third number**, which will be the **maximum boundary of the sum**. If the **sum is equal or greater than this number** you should **stop the program**. See the examples for further information. 
### **Input**
The input is read from the console and consists of three lines: 

- **First line** – **N** – **integer** in the interval **[1…100]**
- **Second line** – **M** – **integer** in the interval **[1…100]**
- **Third line** – **maximum sum boundary** – **integer** in the interval **[1…1000000]**
### **Output**
The output depends on the result:

- If the **sum is equal or greater** than the **maximum sum:**
  - "**{count of combinations} combinations**"
  - "**Sum: {sum from the combinations} >= {maximum sum}**"
- If the sum is **less than** the **maximum sum**:
  - "**{count of combinations} combinations**"
  - "**Sum: {sum from the combinations}**"
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p><a name="ole_link59"></a><a name="ole_link60"></a>3</p><p>4</p><p>123</p>|<p>7 combinations</p><p><a name="ole_link57"></a><a name="ole_link58"></a>Sum: 126 >= 123</p>|<p>Total **12** combinations: 3 1; 3 2; 3 3; 3 4; 2 1; 2 2; 2 3; 2 4; 1 1; 1 2; 1 3; 1 4;</p><p>1<sup>st</sup>: 3 \* (3 \* 1) = 9; 2<sup>nd</sup>: 9 + 3 \* (3 \* 2) = 27;…; 7<sup>th</sup>:    108 + 3 \* (2 \* 3) = 126;</p><p>126 >= 123 – we have to stop our program and print the result.</p>|
|<p>2</p><p>2</p><p>50</p>|<p><a name="ole_link55"></a><a name="ole_link56"></a>4 combinations</p><p>Sum: 27</p>|<p>Total 4 combinations: 2 1; 2 2; 1 1; 1 2</p><p>1<sup>st</sup>: 3 \* (2 \* 1) = 6; 2<sup>nd</sup>: 6 + 3 \* (2 \* 2) = 18;</p><p>3<sup>rd</sup>: 18 + 3 \* (1 \* 1) = 21; 4<sup>th</sup>: 21 + 3 \* (1 \* 2) = 27</p><p>Sum: 27 < 50 -> total 4 combinations</p>|
1. ## **Game of Numbers**
Write a program, which finds all possible combinations in the interval **between two numbers**. The program should also find the **last combination**, in which a **number’s digits are equal to a given magical number**.
### **Input**
The input is read from the console and consists of three lines: 

- **First line** – **N** – **integer** in the interval **[1…999]**
- **Second line** – **M** – **integer** in the interval **[N…1000]**
- **Third line** – **magical number** – **integer** in the interval **[1…10000]**
### **Output**
The output depends on the result:

- If there is a number with **digits equal to the magical number:**
  - **"Number found! {first number} + {second number} = {magical number}"**
- If such **combination does not exist**:
  - **"<a name="ole_link63"></a><a name="ole_link64"></a>{total number of combinations} combinations - neither equals {magical number}"**
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p>1</p><p>10</p><p>**5**</p>|<a name="ole_link61"></a><a name="ole_link62"></a>Number found! 4 + 1 = 5|<p>All combinations between 1 and 10 are: 1 1, 1 2, 1 3, 1 4, 1 5, ... 2 1, 2 2, ... **4 1**, 4 2, 4 3 ... 10 9, 10 10. Last combination with sum of the digits equal to the magical number (**5**) is **4 1**</p><p></p>|
|<p>23</p><p>24</p><p>100</p>|4 combinations - neither equals 100|<p>Total 4 combinations: 23 23; 23 24; 24 23; 24 24</p><p>Neither of them has a sum of 100.</p>|
1. ## **\* Magic Letter**
Write a program, which prints all **3-letter combinations**, **using only the letters from a given interval**. You will also receive a **third letter**. Every **combination**, which **contains** this letter **should not** be printed.
### **Input**
The input is read from the console and consists three lines: 

- **First line** – lower case **English letter** from ‘a’ to ‘z’
- **Second line** – lower case **English letter** from ‘a’ to ‘z’
- **Third line** – lower case **English letter** from ‘a’ to ‘z’ – combinations, containing this letter should not be printed
### **Output**
Print **all combinations on a single line**.
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p><a name="_hlk469255819"></a>a</p><p>c</p><p>b</p>|aaa aac aca acc caa cac cca ccc|<p>All  combinations with **a**, **b**, and **c** are:</p><p>aaa aab aac aba abb abc aca acb acc baa bab bac bba bbb bbc bca bcb bcc caa cab cac cba cbb cbc cca ccb ccc</p><p>Combinations containing **b are invalid**.</p>|
|<a name="ole_link41"></a><a name="ole_link42"></a><a name="ole_link39"></a><a name="ole_link40"></a>**Input**|**Output**|
|<p><a name="_hlk469256830"></a>f</p><p>k</p><p>h</p>|fff ffg ffi ffj ffk fgf fgg fgi fgj fgk fif fig fii fij fik fjf fjg fji fjj fjk fkf fkg fki fkj fkk gff gfg gfi gfj gfk ggf ggg ggi ggj ggk gif gig gii gij gik gjf gjg gji gjj gjk gkf gkg gki gkj gkk iff ifg ifi ifj ifk igf igg igi igj igk iif iig iii iij iik ijf ijg iji ijj ijk ikf ikg iki ikj ikk jff jfg jfi jfj jfk jgf jgg jgi jgj jgk jif jig jii jij jik jjf jjg jji jjj jjk jkf jkg jki jkj jkk kff kfg kfi kfj kfk kgf kgg kgi kgj kgk kif kig kii kij kik kjf kjg kji kjj kjk kkf kkg kki kkj kkk|
|**Input**|**Output**|
|<p><a name="_hlk469256841"></a>a</p><p>c</p><p>z</p>|aaa aab aac aba abb abc aca acb acc baa bab bac bba bbb bbc bca bcb bcc caa cab cac cba cbb cbc cca ccb ccc|
1. ## **\* Neighbour Wars**
Gosho and Pesho are neighbours, but they don’t like each other very much. They don’t like violence as well, so they decided they need a save environment where they can fight each other. They hired you to write a program, which calculates who would win the fight. 

Gosho and Pesho have their own signature attacks – **Gosho** attacks with “**Thunderous fist**” **on every even turn** of the game and **Pesho** attacks with “**Roundhouse kick**” **on every odd turn**. You will receive **how much damage these attacks do from the console**.

**Both players start with 100 Health points**. On **every third turn** Pesho and Gosho **restore 10 Health Points**. Health points are restored **after the attack is made**.

When one of the **player’s health is below or equal to zero** you should **stop any other further operations** and **print who the winner is**, **how much health points** he has** and** in **which turn** he won. Since Mike Tyson is the judge of the match, the winning round is always printed with “**th**” in the end.
### **Input**
The input is read from the console and consists of two lines:

- **First line** – **Pesho’s damage**
- **Second line** – **Gosho’s damage**
### **Output**
Print on every turn who is attacking and how much health the opponent is after the attack:

**"{name of the attacker} used {name of the attack} and reduced {name of the defending player} to {health of the defending player} health."**

When one of the players is **dead** print:

**"{name of the winner} won in {number of the round}th round."**
### **Constraints**
- **Pesho’s damage** and **Gosho’s damage** will be **integers** in the interval **[0…100]**
- There will **always** be a **winner**
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p>30</p><p>40</p>|<p><a name="ole_link65"></a><a name="ole_link66"></a><a name="ole_link75"></a>Pesho used Roundhouse kick and reduced Gosho to 70 health.</p><p><a name="ole_link67"></a><a name="ole_link68"></a><a name="ole_link76"></a>Gosho used Thunderous fist and reduced Pesho to 60 health.</p><p>Pesho used Roundhouse kick and reduced Gosho to 40 health.</p><p>Gosho used Thunderous fist and reduced Pesho to 30 health.</p><p>Pesho used Roundhouse kick and reduced Gosho to 20 health.</p><p><a name="ole_link69"></a><a name="ole_link70"></a><a name="ole_link77"></a>Gosho won in 6th round.</p>|<p>1<sup>st</sup> round -> **Pesho** attacks in **odd rounds** -> so he does **30 damge to Gosho**.</p><p>2<sup>nd</sup> round -> it is **Gosho’s** turn and he **does 40 damage to Pesho**.</p><p>3<sup>rd</sup> round -> **first Pesho attacks with 30 damage and Gosho is now 40 health**. After that **both players receive 10 health**.</p><p>4<sup>th</sup> round **-> After healing Gosho is 50 health and Pesho is 70**. It is **Gosho’s turn** **and he does 40 damage to Pesho** -> Pesho is now 30 health.</p><p>5<sup>th</sup> round -> **Pesho attacks and reduces Gosho from 50 to 20 health**.</p><p>6<sup>th</sup> round -> **Gosho attacks with 40 damage** and **kills Pesho**. They will **not receive healing**, because **one of the player is dead** and we should **print the final result**.</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>20</p><p>10</p>|<p>Pesho used Roundhouse kick and reduced Gosho to 80 health.</p><p>Gosho used Thunderous fist and reduced Pesho to 90 health.</p><p>Pesho used Roundhouse kick and reduced Gosho to 60 health.</p><p>Gosho used Thunderous fist and reduced Pesho to 90 health.</p><p>Pesho used Roundhouse kick and reduced Gosho to 50 health.</p><p>Gosho used Thunderous fist and reduced Pesho to 80 health.</p><p>Pesho used Roundhouse kick and reduced Gosho to 40 health.</p><p>Gosho used Thunderous fist and reduced Pesho to 80 health.</p><p>Pesho used Roundhouse kick and reduced Gosho to 20 health.</p><p>Gosho used Thunderous fist and reduced Pesho to 80 health.</p><p>Pesho used Roundhouse kick and reduced Gosho to 10 health.</p><p>Gosho used Thunderous fist and reduced Pesho to 70 health.</p><p><a name="ole_link71"></a><a name="ole_link72"></a>Pesho won in 13th round.</p>|
|<p>100</p><p>100</p>|Pesho won in 1th round.|


