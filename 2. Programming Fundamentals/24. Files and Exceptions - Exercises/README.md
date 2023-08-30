
# **Exercises: Files, Directories and Exceptions**
Problems for exercises and homework for the [“Programming Fundamentals” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

This exercise does **NOT** have **Judge Contest**. That means that you will need to **create input and output files** from the examples and **test** the solutions on your own.
1. ## ` `**Most Frequent Number**
Write a program that finds the **most frequent number** in a given sequence of numbers. 

- Numbers will be in the range **[0…65535]**.
- In case of multiple numbers with the same maximum frequency, print the **leftmost** one.
### **Examples**

|**Input**|**Output**|**Output**|
| :-: | :-: | :-: |
|**4** 1 1 **4** 2 3 **4 4** 1 2 **4** 9 3|4|The number **4** is the most frequent (occurs 5 times)|
|**2 2 2 2** 1 **2 2 2**|2|The number **2** is the most frequent (occurs 7 times)|
|**7 7 7** 0 2 2 2 0 10 10 10|7|The numbers **2**, **7** and **10** have the same maximal frequence (each occurs 3 times). The leftmost of them is **7**.|
1. ## **Index of Letters**
Write a program that creates an array containing all letters from the alphabet (**a**-**z**). Read a lowercase word from the console and print the **index of each of its letters in the letters array**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|abcz|<p>a -> 0</p><p>b -> 1</p><p>c -> 2</p><p>z -> 25</p>|
|softuni|<p>s -> 18</p><p>o -> 14</p><p>f -> 5</p><p>t -> 19</p><p>u -> 20</p><p>n -> 13</p><p>i -> 8</p>|
1. ## **Equal Sums**
Write a program that determines if there **exists an element in the array** such that the **sum of the elements on its left** is **equal** to the **sum of the elements on its right**. If there are **no elements to the left / right**, their **sum is considered to be 0**. Print the **index** that satisfies the required condition or **“no”** if there is no such index.
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|1 2 3 3|2|<p>At a[2] -> left sum = 3, right sum = 3</p><p>a[0] + a[1] = a[3]</p>|
|1 2|no|<p>At a[0] -> left sum = 0, right sum = 2</p><p>At a[1] -> left sum = 1, right sum = 0</p><p>No such index exists</p>|
|1|0|At a[0] -> left sum = 0, right sum = 0|
|1 2 3|no|No such index exists|
|10 5 5 99 3 4 2 5 1 1 4|3|<p>At a[3] -> left sum = 20, right sum = 20</p><p>a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]</p>|
1. ## **Max Sequence of Equal Elements**
Read a **list of integers** and find the **longest sequence of equal elements**. If several exist, print the **leftmost**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|3 4 4 **5 5 5** 2 2|5 5 5|
|**7 7** 4 4 5 5 3 3|7 7|
|1 2 **3 3**|3 3|
### **Hints**
- Scan positions **p** from left to right and keep the **start** and **length** of the current sequence of equal numbers ending at **p**.
- Keep also the currently best (longest) sequence (**bestStart** + **bestLength**) and update it after each step.
1. ## **A Miner Task**
You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even – quantity. Your task is to **collect** the resources and **print** them each on a new line. **Print the resources and their quantities in format**:

**{resource} –> {quantity}**

The quantities inputs will be in the range **[1 … 2 000 000 000]**
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Gold</p><p>155</p><p>Silver</p><p>10</p><p>Copper</p><p>17</p><p>stop</p>|<p>Gold -> 155</p><p>Silver -> 10</p><p>Copper -> 17</p>|
1. ## **Fix Emails**
You are given a sequence of strings, each on a new line, <a name="__ddelink__998_1408925518"></a>**until you receive “stop” command**. First string is a name of a person. On the second line, you receive his email. Your task is to collect their names and emails, and remove emails whose domain ends with "**us**" or "**uk**" (case insensitive). Print:

**{name} – > {email}** 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Ivan</p><p>ivanivan@abv.bg</p><p>Petar Ivanov</p><p>petartudjarov@abv.bg</p><p>Mike Tyson</p><p>myke@gmail.us</p><p>stop</p>|<p>Ivan -> ivanivan@abv.bg</p><p>Petar Ivanov -> petartudjarov@abv.bg</p>|
1. ## **Advertisement Message**
Write a program that **generate random fake advertisement message** to extol some product. The messages must consist of 4 parts: laudatory **phrase** + **event** + **author** + **city**. Use the following predefined parts:

- **Phrases** – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
- **Events** – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
- **Author** – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
- **Cities** – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}

The format of the output message is: **{phrase} {event} {author} – {city}**.

As an input, you take the **number of messages** to be generated. Print each random message at a separate line.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|3|<p>Such a great product. Now I feel good. Elena – Ruse</p><p>Excelent product. Makes miracles. I am happy of the results! Katya – Varna</p><p>Best product of its category. That makes miracles. Eva - Sofia</p>|
### **Hints**
- Hold the **phrases**, **events**, **authors** and **towns** in 4 arrays of strings.
- Create **Random** object and generate 4 random numbers each in its range:
  - phraseIndex à [0, phrases.Length]
  - eventIndex à [0, events.Length]
  - authorIndex à [0, authors.Length]
  - townIndex à [0, towns.Length]
- Get one **random element** from each of the four arrays and **compose a message** in the required format.
1. ## **Average Grades**
Define a class **Student**, which holds the following information about students: **name**, **list of grades** and **average grade** (calculated property, read-only). A single grade will be in range [2…6], e.g. 3.25 or 5.50.

Read a **list of students** and print the students that have **average grade ≥ 5.00** ordered **by name** (ascending), then by **average** **grade** (descending). Print the student name and the calculated average grade.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3</p><p>Ivan 3</p><p>Todor 5 5 6</p><p>Diana 6 5.50</p>|<p>Diana -> 5.75</p><p>Todor -> 5.33</p>|
|<p>6</p><p>Petar 3 5 4 3 2 5 6 2 6</p><p>Mitko 6 6 5 6 5 6</p><p>Gosho 6 6 6 6 6 6</p><p>Ani 6 5 6 5 6 5 6 5</p><p>Iva 4 5 4 3 4 5 2 2 4</p><p>Ani 5.50 5.25 6.00</p>|<p>Ani -> 5.58</p><p>Ani -> 5.50</p><p>Gosho -> 6.00</p><p>Mitko -> 5.67</p>|
### **Hints**
- Create class **Student** with properties **Name** (**string**), **Grades** (**double[]**), and property **AverageGrade** (calculated by LINQ as **Grades.Average()**, read-only).
- Make a **list of students** and **filter with LINQ** all students that has average **grade** **>=** **5.00**.
- Print the filtered students **ordered by name** in ascending order, then by **average grade** in descending order.
1. ## **Book Library** 
To model a **book library**, define classes to hold a **book** and a **library**. The library must have a **name** and a **list of books**. The books must contain the **title**, **author**, **publisher**, **release date**, **ISBN-number** and **price.** 

Read a **list of books**, add them to the library and print the **total sum of prices by author**,** ordered **descending by price** and **then by author’s name lexicographically**.

Books in the input will be in format **{title} {author} {publisher} {release date} {ISBN} {price}**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</p><p>Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25</p><p>HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50</p><p>HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00</p><p>AC OBowden PenguinBooks 20.11.2009 0395082555 14.00</p>|<p>Tolkien -> 40.25</p><p>JKRowling -> 35.50</p><p>OBowden -> 14.00</p>|
### **Hints**
- Create classes **Book** and **Library** with all the mentioned above properties:
- **Create** an object of type **Library**.
- **Read the input** and create a **Book** object for each book in the input.
- Create a **LINQ** query that will **sum the prices by author**, **order the results** as requested.
- **Print** the results.
1. ## **Book Library Modification**
Use the classes from the previous problem and make a program that **read a list of books** and **print all titles** **released after given date** ordered **by date** and then **by** **title lexicographically**. The date is given if format “**day-month-year**” at the last line in the input.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</p><p>Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25</p><p>HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50</p><p>HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00</p><p>AC OBowden PenguinBooks 20.11.2009 0395082555 14.00</p><p>30\.07.1954</p>|<p>HP1 -> 26.06.1997</p><p>HP7 -> 21.07.2007</p><p>AC -> 20.11.2009</p>|




