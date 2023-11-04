
# **Exercise: Arrays and Matrices**
Problems for exercise and homework for the ["JavaScript Fundamentals Course@SoftUni".](https://softuni.bg/trainings/2247/js-fundamentals-january-2019)  Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/313>
1. ## **Print an Array with a given Delimiter**
Write a JS function that prints a given array.

The **input** comes as an **array of strings**. The last element of the array is the delimiter.

The **output** is the same array, printed on the console, each element **separated** from the others by the **given delimiter**.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>['One', </p><p>'Two', </p><p>'Three', </p><p>'Four', </p><p>'Five', </p><p>'-']</p>|One-Two-Three-Four-Five||<p>['How about no?', </p><p>'I',</p><p>'will', </p><p>'not', </p><p>'do', </p><p>'it!', </p><p>'\_']</p>|How about no?\_I\_will\_not\_do\_it!|
### **Hints**
- Let’s start by extracting the delimiter from the input array:

- Now that we have the element, we need to delete it from the array, because we don’t need it in the output. Thankfully, the Array in JavaScript has a **built-in function** for **removing the last element**, which is **Array.pop()**.

- And last but not least, let’s print each element of the array, separated with the next one by the delimiter:

- The **result** variable holds our final string. The **if** check in the loop is necessary so that we don’t **attach an** **unneeded delimiter** somewhere in the result string.

1. ## **Print every N-th Element from an Array** 
Write a JS function that prints every element of an array, on a given step.

The **input** comes as an **array of strings**. The last element is **N - the step**.

The **output** is every element on the **N-th** step **starting from the first one**. If the step is “**3**”, you need to print the **1-st**, the **4-th**, the **7-th** … and so on, until you reach the end of the array. The elements must be printed each on a new line.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>['5', </p><p>'20', </p><p>'31', </p><p>'4', </p><p>'20', </p><p>'2']</p></td><td colspan="1" valign="top"><p>5</p><p>31</p><p>20</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>['dsa',</p><p>'asd', </p><p>'test', </p><p>'tset', </p><p>'2']</p><p></p></td><td colspan="1" valign="top"><p>dsa</p><p>test</p></td><td colspan="1" valign="top"><p>['1', </p><p>'2',</p><p>'3', </p><p>'4', </p><p>'5', </p><p>'6']</p></td><td colspan="1" valign="top">1</td></tr>
</table>
### **Hints**
- Use what you’ve seen from the **previous problem** to **extract the last element** of the array.
- Create a **step** variable to hold the **given step** of the array. Then **print all the elements** with a **for** loop, **incrementing** the **loop variable** with the value of the **step** variable.
1. ## **\*Add and Remove Elements from an Array**
Write a JS function that **adds** and **removes** numbers **to / from** an array. You will receive a command which can either be “**add**” or “**remove**”. 

The **initial number** is **1**. Each input command should **increase that number**, regardless of what it is.


Upon receiving an “**add**” command you should add the current number to your array. 
Upon receiving the “**remove**” command you should remove the last entered number, currently existent in the array.

The **input** comes as an **array of strings**. Each element holds a **command**. 

The **output** is the array itself, with each element printed on a new line. In case of an empty array, just print “**Empty**”.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>['add', </p><p>'add', </p><p>'add', </p><p>'add']</p><p></p></td><td colspan="1" valign="top"><p>1</p><p>2</p><p>3</p><p>4</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>['add', </p><p>'add', </p><p>'remove', </p><p>'add', </p><p>'add']</p></td><td colspan="1" valign="top"><p>1</p><p>4</p><p>5</p></td><td colspan="1" valign="top"><p>['remove', </p><p>'remove', </p><p>'remove']</p></td><td colspan="1" valign="top">Empty</td></tr>
</table>
1. ## **Rotate Array**
Write a JS function that rotates an array. The array should be rotated to the right side, meaning that the last element should become the first, upon rotation. 

The **input** comes as an **array of strings**. The **last element** of the array is the amount of rotation you need to perform.

The **output** is the resulted array after the rotations. The elements should be printed on one line, separated by a **single space**.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>['1', </p><p>'2', </p><p>'3', </p><p>'4', </p><p>'2']</p>|3 4 1 2||<p>['Banana', </p><p>'Orange', </p><p>'Coconut', </p><p>'Apple', </p><p>'15']</p>|Orange Coconut Apple Banana|
### **Hints**
- Check if there is a **built-in function** for inserting elements **at the** **start** of the array.
1. ## **Extract a Non-decreasing Subsequence from an Array**
Write a JS function that extracts only those numbers that **form a** **non-decreasing subsequence**. In other words, you start from the **first element** and continue to **the end** of the **given array of numbers**. Any number which is **LESS THAN** the **current biggest one** is **ignored**, alternatively if it’s equal or higher than the **current biggest one** you set it as the **current biggest one** and you continue to the next number. 

The **input** comes as an **array of numbers**.

The **output** is the processed array after the filtration, which should be a non-decreasing subsequence. Each element should be printed on a new line.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>[1, </p><p>3, </p><p>8, </p><p>4, </p><p>10, </p><p>12, </p><p>3, </p><p>2, </p><p>24]</p></td><td colspan="1" valign="top"><p>1</p><p>3</p><p>8</p><p>10</p><p>12</p><p>24</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>[1, </p><p>2, </p><p>3,</p><p>4]</p></td><td colspan="1" valign="top"><p>1</p><p>2</p><p>3</p><p>4</p></td><td colspan="1" valign="top"><p>[20, </p><p>3, </p><p>2, </p><p>15,</p><p>6, </p><p>1]</p></td><td colspan="1" valign="top">20</td></tr>
</table>
### **Hints**
- The **Array.filter()** built-in function might help you a lot with this problem.
1. ## **Sort an Array by 2 Criteria**
Write a JS function that orders a **given array of strings**, by **length** in **ascending order** as **primary criteria**, and by **alphabetical value** in **ascending order** as **second criteria**. The comparison should be **case-insensitive**.

The **input** comes as an **array of strings**.

The **output** is the ordered array of strings.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>['alpha', </p><p>'beta', </p><p>'gamma']</p></td><td colspan="1" valign="top"><p>beta</p><p>alpha</p><p>gamma</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>['Isacc', </p><p>'Theodor', </p><p>'Jack', </p><p>'Harrison', </p><p>'George']</p><p></p></td><td colspan="1" valign="top"><p>Jack</p><p>Isacc</p><p>George</p><p>Theodor</p><p>Harrison</p><p></p></td><td colspan="1" valign="top"><p>['test', </p><p>'Deny', </p><p>'omen', </p><p>'Default']</p></td><td colspan="1" valign="top"><p>Deny</p><p>omen</p><p>test</p><p>Default</p></td></tr>
</table>
### **Hints**
- An array can be sorted by passing a comparing function to the **Array.sort()** function.
- Creating a comparing function by 2 criteria can be achieved by first comparing by the **main criteria**, if the 2 items are different (the result of the compare is not 0) - return the result as the result of the comparing function. If the two items are the same by the **main criteria** (the result of the compare is 0), we need to compare by the **second criteria** and the result of that comparison is the result of the comparing function.
- You can check more about **Array.sort()** here - [https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/sort](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/sort%20) 
# **Multidimensional Arrays**
We will mainly work with 2-dimensional arrays. The concept is as simple as working with a simple 1-dimensional array. It is just an array of arrays.
1. ## **Magic Matrices**
Write a JS function that checks if a given matrix of numbers is magical. A matrix is magical if the **sums of the cells** of **every row** and **every column** are **equal**. 

The **input** comes as an **array of arrays**, containing numbers (number 2D matrix). The input numbers will **always be positive**.

The **output** is a Boolean result indicating whether the matrix is magical or not.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>[[4, 5, 6],</p><p>` `[6, 5, 4],</p><p>` `[5, 5, 5]]</p></td><td colspan="1" valign="top">true</td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>[[11, 32, 45],</p><p>` `[21, 0, 1],</p><p>` `[21, 1, 1]]</p></td><td colspan="1" valign="top"><p>false</p><p></p></td><td colspan="1" valign="top"><p>[[1, 0, 0],</p><p>` `[0, 0, 1],</p><p>` `[0, 1, 0]]</p></td><td colspan="1" valign="top">true</td></tr>
</table>
1. ## **\*Spiral Matrix**
Write a JS function that generates a **Spirally-filled** matrix with numbers, with given dimensions.

The **input** comes as **2 numbers** that represent the **dimension of the matrix**. 

The **output** is the matrix filled spirally starting from **1**. You need to print **every row on a new line**, with the cells **separated by a space**. Check the examples below. 
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|5, 5|<p>1 2 3 4 5</p><p>16 17 18 19 6</p><p>15 24 25 20 7</p><p>14 23 22 21 8</p><p>13 12 11 10 9</p>||3, 3|<p>1 2 3</p><p>8 9 4</p><p>7 6 5</p>|
1. ## **\*\*Diagonal Attack**
Write a JS function that reads a given matrix of numbers, and checks if both **main diagonals have equal sum**. If they do, set every element that is **NOT** part of **the main diagonals** to that sum, alternatively just print the matrix unchanged.

The **input** comes as **array of strings**. Each element represents a **string of numbers**, with **spaces** between them. Parse it into a **matrix of numbers**, so you can work with it.

The **output** is either the new matrix, with all cells not belonging to a main diagonal changed to the diagonal sum or the original matrix, if the two diagonals have different sums. You need to print **every row on a new line**, with cells **separated by a space**. Check the examples below. 
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>['5 3 12 3 1',</p><p>'11 4 23 2 5',</p><p>'101 12 3 21 10',</p><p>'1 4 5 2 2',</p><p>'5 22 33 11 1']</p>|<p>5 15 15 15 1</p><p>15 4 15 2 15</p><p>15 15 3 15 15</p><p>15 4 15 2 15</p><p>5 15 15 15 1</p>||<p>['1 1 1',</p><p>'1 1 1'</p><p>'1 1 0']</p><p></p>|<p>1 1 1</p><p>1 1 1</p><p>1 1 0</p>|
1. ## **\*Orbit**
You will be given an empty rectangular space of cells. Then you will be given the position of a star. You need to build the orbits around it.

You will be given a coordinate of a cell, which will **always be** **inside the matrix**, on which you will put the value – **1**. Then you must set the values of the cells **directly surrounding that cell**, including the **diagonals**, **to 2**. After which you must set the values of the next surrounding cells to 3 and so on. Check the pictures for more information.

For example, we are given a matrix which has 5 rows and 5 columns and the star is at coordinates – **0, 0**. Then the following should happen:

|**1**|||||||**1**|**2**||||||**1**|**2**|**3**|**4**|**5**|
| :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- |
|** |||||||**2**|**2**||||||**2**|**2**|**3**|**4**|**5**|
|**   ||||||||||||||**3**|**3**|**3**|**4**|**5**|
|||||||||||||||**4**|**4**|**4**|**4**|**5**|
|||||||||||||||**5**|**5**|**5**|**5**|**5**|




If the coordinates of the star are somewhere in the middle of the matrix for example – **2, 2**, then it should look like this:





|||||||||||||||**3**|**3**|**3**|**3**|**3**|
| :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- | :- |
|** ||||||||**2**|**2**|**2**||||**3**|**2**|**2**|**2**|**3**|
|**   ||**1**||||||**2**|**1**|**2**||||**3**|**2**|**1**|**2**|**3**|
|||||||||**2**|**2**|**2**||||**3**|**2**|**2**|**2**|**3**|
|||||||||||||||**3**|**3**|**3**|**3**|**3**|






The **input** comes as an **array of 4 numbers** **[width, height, x, y]** which represents the **dimensions of the matrix** and the **coordinates of the star.**

The **output** is the filled matrix, with the cells **separated by a space**, each **row on a new line**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">[4, 4, 0, 0]</td><td colspan="1" valign="top"><p>1 2 3 4</p><p>2 2 3 4</p><p>3 3 3 4</p><p>4 4 4 4</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>[5, 5, 2, 2]</p><p></p></td><td colspan="1" valign="top"><p>3 3 3 3 3</p><p>3 2 2 2 3</p><p>3 2 1 2 3</p><p>3 2 2 2 3</p><p>3 3 3 3 3 </p></td><td colspan="1" valign="top">[3, 3, 2, 2]</td><td colspan="1" valign="top"><p>3 3 3</p><p>3 2 2</p><p>3 2 1</p></td></tr>
</table>
### **Hints**
- Check if there is some **dependency** or **relation** between the **position of the numbers** and the **rows** and **columns** of those positions.

**More Exercise: Arrays and Matrices**

Problems for exercise and homework for the ["JavaScript Fundamentals Course@SoftUni".](https://softuni.bg/trainings/2247/js-fundamentals-january-2019) Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1471>.
1. ## **Car Category**
Write a function that takes as parameter an array of strings, which represent car numbers. The possible categories of car numbers are:

- **BulgarianArmy** - **"BA 123 456"** -> starts with "BA" and is followed by two 3-digit numbers.
- **CivilProtection** - **"CP 12 345"** -> starts with "СР" and is followed by two number groups, the first one with 2-digits and the second one with 3-digits.
- **Diplomatic** - **"C 1234", "CT 1234"** -> starts with "С" or "СТ" and is followed by a 4-digit 
  number.
- **Foreigners** - **"XX 1234"** -> starts with "ХХ" and is followed by a 4-digit number.
- **Transient** - **"123 В 123"** -> starts with 3 digits than a single letter and another 3 
  digits.
- **Sofia** - **"CA 1234 CA", "СВ 1234 СВ", "С 1234 С", "С 1234 СА"** -> starts with "С", "СА" or "СВ" and is followed by 4-digits, and ends with one or two letters. 
- **Province** – **"K 2412 DX"**-> starts with one or two letters, then 4 digits and one or two letters again.
- **Other** – all that do not meet the conditions above.

Display the cars **sorted** by count of numbers in **descending** then by category name. **Each row is a paragraph text.**

**Examples**

|**Input**|**Output**|
| :-: | :-: |
|["C 1234", "CT 1234", "C 1234 C", "CP 12 345", "CA 1234 CA", "BA 123 456", "XX 1234", "123 B 123", <br>"B 1234 BB", "11111111", "C1111111"]|<p>BulgarianArmy -> 1</p><p>CivilProtection -> 1</p><p>Diplomatic -> 2</p><p>Foreigners -> 1</p><p>Other -> 2</p><p>Province -> 1</p><p>Sofia -> 2</p><p>Transient -> 1</p>|


1. ## **Book Shelfs**
Write a function that stores information about **shelves** and the **books in the shelves**. Each shelf has an **Id** and a **genre** of books that can be in it. Each book has a **title**, an **author** and **genre**. The input comes as an **array of strings**. They will be in the format:

- **"{shelf id} -> {shelf genre}"** – create a shelf **if the id is not taken**
- **"{book title}: {book author}, {book genre}"** – if a shelf with that **genre exists**, add the book to the shelf

After finished reading input, sort the shelves by **count of books** in it in **descending**. For each shelf sort the **books by title** in ascending. Then display them in the following format each in a separate **<p>**.

- **"{shelveOne id} {shelf genre}: {books count}
  --> {bookOne title}: {bookOne author}
  --> {bookTwo title}: {bookTwo author}
  …
  {shelveTwo id} {shelf genre}: {books count}
  …"**
###

### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|["1 -> history", "1 -> action", "Death in Time: Criss Bell, mystery", "2 -> mystery", "3 -> sci-fi", "Child of Silver: Bruce Rich, mystery", "Hurting Secrets: Dustin Bolt, action", "Future of Dawn: Aiden Rose, sci-fi", "Lions and Rats: Gabe Roads, history", "2 -> romance", "Effect of the Void: Shay B, romance", "Losing Dreams: Gail Starr, sci-fi", "Name of Earth: Jo Bell, sci-fi", "Pilots of Stone: Brook Jay, history"]|<p>3 sci-fi: 3</p><p>--> Future of Dawn: Aiden Rose</p><p>--> Losing Dreams: Gail Starr</p><p>--> Name of Earth: Jo Bell</p><p>1 history: 2</p><p>--> Lions and Rats: Gabe Roads</p><p>--> Pilots of Stone: Brook Jay</p><p>2 mystery: 1</p><p>--> Child of Silver: Bruce Rich</p>|





## **13.** **Card Wars** 
The game is played by the rules of the game ["War"](https://en.wikipedia.org/wiki/War_\(card_game\)). 

There are **two players**, each with **13** cards. *(The cards are valid, as the standard 52-card deck.)*

The input is an **array of 2 arrays**. First starts the first player in order of input with the card at 0 index. Then it’s second one‘s turn. The process is repeated until the end of the game.

The player with the **higher** card takes both of the cards, by adding them at the **end** of his array (first the card of the first player, then the card of the second). 

The winner is either the one who collects all cards, or the one who has collected more cards than the other on 20<sup>th</sup> turn. 

2, 3, 4, 5, 6, 7, 8, 9, 10, J (11), Q (12), K (13), A (14)

Then it’s time to play.

There will be **no case**, where the two players will have the same cards.
### **Input**
Array of arrays
### **Output**
The output consists of the cards of both players, as shown below:

**<p>First -> 8, 7, 7, 7, 3, 3, K, 10, Q, J, 9, A, 4, Q, K, Q, 4, 2</p>**

**<p>Second -> 10, 6, J, 2, 3, 9, A, 5</p>**
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|[[4, 5, "J", 5],[3, 6, "K", 3]]|<p>First -> </p><p>Second -> 4, 5, 3, 6, 5, J, 3, K</p>|
|[[10, "K", "Q", 2, 4], ["A", 3, "J", 2, 8]]|<p>First -> 3, J, 2, K, 2, 10, 4, Q, 8</p><p>Second -> A</p>|


## **14. Radio Crystals**
It’s time to put your skills to work for the war effort – creating management software for a radio transmitter factory. Radios require a finely tuned quartz crystal in order to operate at the correct   frequency. The resource used to produce them is quartz ore that comes in big chunks and needs to undergo several processes, before it reaches the desired properties.

You need to write a JS program that monitors the current thickness of the crystal and recommends the next procedure that will bring it closer to the desired frequency. To reduce waste and the time it takes to make each crystal your program needs to complete the process with the least number of operations. Each operation takes the same amount of time, but since they are done at different parts of the factory, the crystals have to be transported and thoroughly washed every time an operation different from the previous must be performed, so this must also be taken into account. When determining the order, always attempt to start from the operation that removes the largest amount of material.

The different operations you can perform are the following:

- **Cut** – cuts the crystal in 4
- **Lap** – removes 20% of the crystal’s thickness
- **Grind** – removes 20 microns of thickness
- **Etch** – removes 2 microns of thickness
- **X-ray** – increases the thickness of the crystal by 1 micron; this operation can only be done once!
- **Transporting and washing** – removes any imperfections smaller than 1 micron (round down the number); do this after every batch of operations that remove material

At the beginning of your program, you will receive a **number** representing the **desired final thickness** and a **series of numbers**, representing **the thickness of crystal ore** in **microns**. Process each chunk and print the order of operations and number of times they need to be repeated to bring them to the desired thickness.

The **input** comes as a numeric array with a variable number of elements. The first number is the target thickness and all following numbers are the thickness of different chunks of quartz ore.

The **output** is the order of operation and how many times they are repeated, every operation in a 
**separate paragraph**. See the examples for more information.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|[1375, 50000]|<p>Processing chunk 50000 microns</p><p>Cut x2</p><p>Transporting and washing</p><p>Lap x3</p><p>Transporting and washing</p><p>Grind x11</p><p>Transporting and washing</p><p>Etch x3</p><p>Transporting and washing</p><p>X-ray x1</p><p>Finished crystal 1375 microns</p>|

### **Explanation**
The operation that will remove the most material is always cutting – it removes three quarters of the chunk. Starting from 50000, if we perform it twice, we bring the chunk down to 3125. If we cut again, the chunk will be 781.25, which is less than the desired thickness, so we move to the next operation, but we first round down the number (transporting & washing). Next, we lap the chunk – after three operations, the crystal reaches 1600 microns. One more lapping would take it to 1280, so we move on to the next operation instead. We do the same check with grinding, and finally by etching 2 times, the crystal has reached 1376 microns, which is one more than desired. We don’t have an operation which only takes away 1 micron, so instead we etch once more to get to 1374, wash and then x-ray to add 1 micron, which brings us to the desired thickness.

|**Input**|**Output**|
| :-: | :-: |
|[1000, 4000, 8100]|<p>Processing chunk 4000 microns</p><p>Cut x1</p><p>Transporting and washing</p><p>Finished crystal 1000 microns</p><p>Processing chunk 8100 microns</p><p>Cut x1</p><p>Transporting and washing</p><p>Lap x3</p><p>Transporting and washing</p><p>Grind x1</p><p>Transporting and washing</p><p>Etch x8</p><p>Transporting and washing</p><p>Finished crystal 1000 microns</p>|

## **15. \*DNA Helix**
Write a JS program that prints a DNA helix with length, specified by the user. The helix has a repeating structure, but the symbol in the chain follows the sequence *ATCGTTAGGG*. See the examples for more information.

The **input** comes as a single number. It represents the length of the required helix.

The **output** is the completed structure, displayed in the DOM, each line in separate **paragraph**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">4</td><td colspan="1" valign="top">**AT**<br>*C--G*<br>T----T<br>*A--G*</td><td colspan="1" valign="top">10</td><td colspan="1" valign="top">**AT**<br>*C--G*<br>T----T<br>*A--G*<br>**GG**<br>*A--T*<br>C----G<br>*T--T*<br>**AG**<br>*G--G*</td></tr>
</table>





