
# **Exercise: Java Basics**
Problems for exercises and homework for the [“Software Technologies” course @ SoftUni](https://softuni.bg/courses/software-technologies).

You can submit your solutions here: <https://judge.softuni.bg/Contests/712/Java-Basics-Exercises>.
# **Part I: Data Types and Methods**
1. ## **Variable in Hexadecimal Format**
Write a program that reads a number in **hexadecimal format** convert it to **decimal format** and prints it.

|**Input**|**Output**|
| :-: | :-: |
|FE|254|
|37|55|
|10|16|
### **Hints**
- Use [**Integer.parseInt(string, base)**](http://www.tutorialspoint.com/java/number_parseint.htm).
1. ## **Boolean Variable**
Write a program that reads a **string**, converts it to **Boolean** variable and **prints** “**Yes**”** if the variable is **true** and “**No**” if the variable is **false**.

|**Input**|**Output**|
| :-: | :-: |
|True|Yes|
|False|No|
### **Hints**
- Java has a function, which takes a **string** and converts it to a **Boolean**.
1. ## **Reverse Characters**
Write a program to ask the user for **3 letters** and print them in **reversed order**.
### **Examples**

|**Input**|**Output**||**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
|<p>A</p><p>B</p><p>C</p>|CBA||<p>x</p><p>Y</p><p>z</p>|zYx||<p>G</p><p>g</p><p>n</p>|ngG|
1. ## **Vowel or Digit**
Create a program to check if given symbol is **digit**, **vowel** or any **other symbol**.
### **Examples**

|**Input**|**Output**||**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
|a|vowel||9|digit||g|other|
1. ## **Integer to Hex and Binary**
Write a program to convert a **decimal number** to **hexadecimal** and **binary** number and print it.
### **Examples**

|**Input**|**Output**||**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
|10|<p>A</p><p>1010</p>||420|<p>1A4</p><p>110100100</p>||256|<p>100</p><p>100000000</p>|
### **Hints**
- There are built-in methods, that convert Integer to Hex and Binary.
# **Part II: Arrays**
1. ## **Compare Char Arrays**
Write a program, which **compares** two char arrays **lexicographically** (letter by letter).

Print the them in **alphabetical order**, each on separate line.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>a b c</p><p>d e f</p>|<p>abc</p><p>def</p>|
|<p>p e t e r</p><p>a n n i e</p>|<p>annie</p><p>peter</p>|
|<p>a n n i e</p><p>a n</p>|<p>an</p><p>annie</p>|
|<p>a b</p><p>a b</p>|<p>ab</p><p>ab</p>|
### **Hints**
- Compare the first letter of **arr1[]** and **arr2[]**, if equal, compare the next letter, etc.
- If all letters are equal, the smaller array is the **shorter**.
- If all letters are equal and the array lengths are the same, the arrays are **equal**.
1. ## **Max Sequence of Equal Elements**
Write a program that finds the **longest sequence of equal elements** in an array of integers. If several longest sequences exist, print the leftmost one.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|2 1 1 2 3 3 **2 2 2** 1|2 2 2|
|**1 1 1** 2 3 1 3 3|1 1 1|
|**4 4 4 4**|4 4 4 4|
|0 **1 1** 5 2 2 6 3 3|1 1|
### **Hints**
- Start with the sequence that consists of the first element: **start**=**0**, **len**=**1**.
- Scan the elements **from left to right**, starting at the second element: **pos**=**1**…**n-1**.
  - At each step compare the current element with the element on the left:
    - Same value à you have found a sequence longer by one à **len**++.
    - Different value à **start a new sequence** from the **current element**: **start**=**pos**, **len**=**1**.
  - After each step remember the sequence it is found to be longest at the moment: **bestStart**=**start**, **bestLen**=**len**.
- Finally, print the longest sequence by using **bestStart** and **bestLen**.
1. ## **Max Sequence of Increasing Elements**
Write a program that finds the **longest increasing subsequence** in an array of integers. The longest increasing subsequence is a **portion of the array** (subsequence) that is strongly **increasing** and has the **longest possible length**. If several such subsequences exist, find the left most of them.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|3 **2 3 4** 2 2 4|2 3 4|
|4 5 **1 2 3 4 5**|1 2 3 4 5|
|**3 4 5 6**|3 4 5 6|
|**0 1** 1 2 2 3 3|0 1|
### **Hints**
- Use the same algorithm like in the previous problem (Max Sequence of Equal Elements).
1. ## **Most Frequent Number**
Write a program that finds the **most frequent number** in a given sequence of numbers. 

- Numbers will be in the range **[0…65535]**.
- In case of multiple numbers with the same maximum frequency, print the **left-most** of them.
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
1. ## **Bomb Numbers**
Write a program that **reads sequence of numbers** and **special bomb number** with a certain **power**. Your task is to **detonate every occurrence of the special bomb number** and according to its power **his neighbors from left and right**. Detonations are performed from left to right and all detonated numbers disappear. Finally print the **sum of the remaining elements** in the sequence.
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p>1 2 2 4 2 2 2 9</p><p>4 2</p>|12|Special number is **4** with power 2. After detontaion we left with the sequence [1, 2, 9] with sum 12.|
|<p>1 4 4 2 8 9 1</p><p>9 3</p>|5|Special number is **9** with power 3. After detontaion we left with the sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just it (one number instead of 3).|
|<p>1 7 7 1 2 3</p><p>7 1</p>|6|Detonations are performed from left to right. We could not detonate the second occurance of 7 because its already destroyed by the first occurance. The numbers [1, 2, 3] survive. Their sum is 6.|
|<p>1 1 2 1 1 1 2 1 1 1</p><p>2 1</p>|4|The red and yellow numbers disappear in two sequential detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4.|
# **Part IV: Strings, Maps and Stream API**
1. ## **Reverse String**
Write a program that reads a string from the console, **reverses** **its letters** and **prints** the result back at the console.
### **Examples**

|**Input**|**Output** |
| :-: | :-: |
|sample|elpmas|
|24tvcoi92|29iocvt42|
### **Hints**
- **Variant I**: convert the string to **char array**, **reverse** it, then convert it to **string** again.
- **Variant II**: print the letters of the string right-to-left in a **for**-loop.
1. ## **Fit String in 20 Chars**
Write a program that **reads** from the console a string and **fits the string in 20 characters** as follows:

- If the string has **less than 20 characters**, append asterisks ‘**\***’ to it until it’s **exactly 20 characters long**.
- If the string length is **more than 20 characters**, discard all characters after the first 20.

**Print** the result string at the console.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|Welcome to SoftUni!|Welcome to SoftUni!\*|
|A "regular expression" (abbreviated regex or regexp) is a sequence of characters that forms a search pattern.|A "regular expressio|
|C#|C#\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*|
### **Hints**
- If string has a **length** < **20**, write a **padRight(20,** **'\*') method**.
- If string has a **length** > **20**, use **substring(0,** **20)**.
1. ## **Censor Email Address**
You have some text that contains your email address. You are sick of spammers, so you want to **hide** it. You decide to **censor** your email: to **replace all characters** in it with asterisks (**'\*'**) **except the domain**.

Assume your email address will always be in format **[username]@[domain]**. You need to replace the username with asterisks of equal number of letters and keep the domain unchanged.
### **Input**
- The first line holds your **email** address.
- The second line holds a **text** where the email should be censored.
### **Examples**

|**Input**|
| :-: |
|<p>pesho.peshev@email.bg</p><p>My name is Pesho Peshev. I am from Sofia, my email is: pesho.peshev@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, pesho.peshev@email.bg</p>|
|**Output**|
|My name is Pesho Peshev. I am from Sofia, my email is: \*\*\*\*\*\*\*\*\*\*\*\*@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, \*\*\*\*\*\*\*\*\*\*\*\*@email.bg|
### **Hints**
In order to accomplish the task, you may find these steps useful:

- **Split** the email into two parts – **username** and **domain**.
- Create the **replacement** string by duplicating the '**\***' character **{username.length}** times and appending **'@'** and the **domain**.
- **Replace** all occurrences of your **email** with the **replacement string**.
1. ## **URL Parser**
Write a program that **parses an URL** given in the following format:

**[protocol]://[server]/[resource]**

The parsing extracts its parts: **protocol**, **server** and **resource**. 

- The **[server]** part is mandatory.
- The **[protocol]** and **[resource]** parts are **optional**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|http://www.abc.com/video|<p>[protocol] = "http"</p><p>[server] = "www.abc.com"</p><p>[resource] = "video"</p>|
|https://www.softuni.bg/Resources/Materials|<p>[protocol] = "https"</p><p>[server] = "www.softuni.bg"</p><p>[resource] = "Resources/Materials"</p>|
|ftp://www.su.us/TestResource|<p>[protocol] = "ftp"</p><p>[server] = "www.su.us"</p><p>[resource] = "TestResource"</p>|
|https://softuni.bg|<p>[protocol] = "https"</p><p>[server] = "softuni.bg"</p><p>[resource] = ""</p>|
|www.nakov.com|<p>[protocol] = ""</p><p>[server] = "www.nakov.com"</p><p>[resource] = ""</p>|
### **Hints**
- Find the leftmost occurrence of “**://**” in the input URL.
  - If **found**, the left side holds the **protocol**, the right side holds the **server + resource**.
  - If **not found**, the protocol is missing, the input string holds **server + resource** only.
- After the “**protocol**” part is removed from the input URL, find the **leftmost occurrence** of “**/**”.
  - If **found**, the left side holds the **server**, the right side holds the **resource**.
  - If **not found**, the resource is missing, the whole string holds the **server**.
1. ## **Change to Uppercase**
Write a program that receives a **string** and **modifies the casing of letters to uppercase** at all places **in the text surrounded** **by** **<upcase>** **and** **</upcase>** **tags**. Tags **will not** be nested.
### **Example**

|**Input**|
| :-: |
|Welcome to the **<upcase>Software University</upcase>**. Learn **<upcase>computer programming</upcase>** and start a **<upcase>job</upcase>** in a software company.|
|**Output**|
|Welcome to the **SOFTWARE UNIVERSITY**. Learn **COMPUTER PROGRAMMING** and start a **JOB** in a software company.|
### **Hints**
- You may find the position of the first **<upcase>** and the first **</upcase>**, delete the text between and insert the uppercase version of the text without the tags at the position of **<upcase>**.
- Repeat the above until no more **<upcase>** and **</upcase>** tags are found in the text.
1. ## **Phonebook**
Write a program that receives some info from the console about **people** and their **phone numbers**. Each **entry** should have just **one name** and **one number** (both **strings**). 

On each line, you will receive some of the following commands:

- **A {name} {phone}** – adds entry to the phonebook. In case of trying to add a name that is **already** in the phonebook, you should **change** the existing phone number to the **new one**.
- **S {name}** – searches for a contact by given name and prints it in format "**{name} -> {number}**".
  In case the contact isn't found, print "**Contact {name} does not exist.**".
- **END** – stop receiving more commands.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>A Nakov 0888080808</p><p>S Mariika</p><p>S Nakov</p><p>END</p>|<p>Contact Mariika does not exist.</p><p>Nakov -> 0888080808</p>|
|<p>A Nakov +359888001122</p><p>A RoYaL(Ivan) 666</p><p>A Gero 5559393</p><p>A Simo 02/987665544</p><p>S Simo</p><p>S simo</p><p>S RoYaL</p><p>S RoYaL(Ivan)</p><p>END</p>|<p>Simo -> 02/987665544</p><p>Contact simo does not exist.</p><p>Contact RoYaL does not exist.</p><p>RoYaL(Ivan) -> 666</p>|
|<p>A Misho +359883123</p><p>A Misho 02/3123</p><p>S Misho</p><p>END</p>|Misho -> 02/3123|
### **Hints**
- **Parse the commands** by splitting by space. Execute the commands until “**END**” is reached.
- Store the **phonebook entries** in **LinkedHashMap<String, String>** with key **{name}** and value **{phone number}**.
1. ## ` `**Phonebook Upgrade**
**Add functionality to the phonebook** from the previous task to **print all contacts ordered lexicographically** when receive the command “**ListAll**”.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>A Nakov +359888001122</p><p>A RoYaL(Ivan) 666</p><p>A Gero 5559393</p><p>A Simo 02/987665544</p><p>ListAll</p><p>END</p>|<p>Gero -> 5559393</p><p>Nakov -> +359888001122</p><p>RoYaL(Ivan) -> 666</p><p>Simo -> 02/987665544</p>|
### **Hints**
- **Variant I (slower):** Sort all entries in the dictionary by key and print them.
- **Variant II (faster):** Keep the entries in more appropriate data structure that will keep them in sorted order for better performance.
# **Part V: Classes and Objects**
1. ## **Count Working Days**
Write a program that **reads two dates** in the format **dd-MM-yyyy** and prints the **number of working days** between these two dates **inclusive**. Non-working days are:

- All days that are **Saturday** or **Sunday**.
- All days that are **official holidays** in Bulgaria:
  - New Year Eve (**1 Jan**)
  - Liberation Day (**3 March**)
  - Worker’s day (**1 May**)
  - Saint George’s Day (**6 May**)
  - Saints Cyril and Methodius Day (**24 May**)
  - Unification Day (**6 Sept**)
  - Independence Day (**22 Sept**)
  - National Awakening Day (**1 Nov**)
  - Christmas (**24**, **25** and **26 Dec**)

All days not mentioned above are **working** and should count.
### **Examples**

|**Input**|**Output**|**Calendar**|
| :-: | :-: | :-: |
|<p>11-04-2016</p><p>14-04-2016</p>|4||
|<p>11-04-2016</p><p>22-04-2016</p>|10||
|<p>20-12-2015</p><p>31-12-2015</p>|7||
### **Hints**
- Read **start date** and **end date** from Console.
- **Create** two objects of type **Date** – **startDate** and **endDate**.
- Create an **array of type Date** and add **all official holidays** in it.
- Loop from **startDate** to **endDate**. Add **1 day** at each iteration.
- Get the **current da**y in the loop and check whether is **Saturday**, **Sunday** or it is **contained** **in the holidays array**. If it is not, increment the **workingDaysCounter**.
1. ## **Advertisement Message**
Write a program that **generates a random fake advertisement message** to extol some product. The messages must consist of 4 parts: laudatory **phrase** + **event** + **author** + **city**. Use the following predefined parts:

- **Phrases** – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."}
- **Events** – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
- **Author** – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
- **Cities** – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}

The format of the output message is: **{phrase} {event} {author} – {city}**.

As input, you take the **number of messages** to be generated. Print each random message at a separate line.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|3|<p>Such a great product. Now I feel good. Elena – Ruse</p><p>Excelent product. Makes miracles. I am happy of the results! Katya – Varna</p><p>Best product of its category. That makes miracles. Eva - Sofia</p>|
### **Hints**
- Hold the **phrases**, **events**, **authors** and **towns** in 4 arrays of strings.
- Create **Random** object and **generate** **4 random numbers** each in its range:
  - phraseIndex à [0, phrases.Length]
  - eventIndex à [0, events.Length]
  - authorIndex à [0, authors.Length]
  - townIndex à [0, towns.Length]
- Get one **random element** from each of the four arrays and **compose a message** in the required format.
1. ## **Intersection of Circles**
Create a **Circle** class with **Center** and **Radius** properties. The center is a **point** with coordinates **X** and **Y** (make a class **Point**). Write a method **bool** **Intersect(Circle** **c1,** **Circle** **c2)** that tells whether the **two** given circles **intersect or not**. Write a program that tells if **two circles** intersect.
### **Input**
The input lines will be in format: **{X} {Y} {Radius}**. Print as output “**Yes**” or “**No**”.
### **Examples**

|**Input**|**Output**|**Visualization**|
| :-: | :-: | :-: |
|<p>4 4 2</p><p>8 8 1</p>|No||
|<p>3 3 2</p><p>4 3 6</p>|Yes||
|<p>1 1 4</p><p>4 2 5</p>|Yes||
### **Hints**
- Calculate **d** = **distance between the circle centers**.
- If the **d** **≤** **r1** **+** **r2** (the sum of radiuses**) à** the circles **intersect** (or one of the circles is inside the other or the circles have one common point when **d** **=** **r1** **+** **r2**).
- If the **d** **>** **r1** **+** **r2** **à** the circles do **not intersect** (they have not common shared point).
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
- Make a **list of students** and **filter** all students that has average **grade** **>=** **5.00** using Java’s **stream API**.
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
- Create a **STREAM** query that will **sum the prices by author**, **order the results** as requested.
- **Print** the results.
1. ## **Book Library Modification**
Use the classes from the previous problem and make a program that **read a list of books** and **print all titles** **released after given date** ordered **by date** and then **by** **title lexicographically**. The date is given if format “**day-month-year**” at the last line in the input.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</p><p>Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25</p><p>HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50</p><p>HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00</p><p>AC OBowden PenguinBooks 20.11.2009 0395082555 14.00</p><p>30\.07.1954</p>|<p>HP1 -> 26.06.1997</p><p>HP7 -> 21.07.2007</p><p>AC -> 20.11.2009</p>|


