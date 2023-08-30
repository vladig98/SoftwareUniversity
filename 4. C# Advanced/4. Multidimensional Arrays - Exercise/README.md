
# **Exercises: Multidimensional Arrays**
This document defines the **exercise assignments** for the ["CSharp Advanced" course @ Software University](https://softuni.bg/courses/csharp-advanced). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/573).
1. ## **Matrix of Palindromes**
Write a program to generate and print the following **matrix of palindromes** of **3** letters with **r** rows and **c** columns like at the examples below.

- **Rows** define the first and the last letter: row 0 à ‘a’, row 1 à ‘b’, row 2 à ‘c’, …
- **Columns + rows** define the middle letter: 
  - column 0, row 0 à ‘a’, column 1, row 0 à ‘b’, column 2, row 0 à ‘c’, …
  - column 0, row 1 à ‘b’, column 1, row 1 à ‘c’, column 2, row 1 à ‘d’, …
### **Input**
- On the **first line**, you are given the integers **r** and **c**, separated by a space.
### **Output**
- On **r** \***c** number of lines, print the matrix of palindromes as shown in the example.
### **Constraints**
- Constraints: **r** and **c** are integers in the range [1…26]; **r** **+** **c** ≤ 27.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1">4 6</td><td colspan="1"><p>aaa aba aca ada aea afa</p><p>bbb bcb bdb beb bfb bgb</p><p>ccc cdc cec cfc cgc chc</p><p>ddd ded dfd dgd dhd did</p></td><td colspan="1">3 2</td><td colspan="1"><p>aaa aba</p><p>bbb bcb</p><p>ccc cdc</p></td></tr>
</table>
### **Hints**
- char[] alphabet = "**abcdefghijklmnopqrstuvwxyz**".ToCharArray();

1. ## **Diagonal Difference**
Write a program that finds the **difference between the sums of the square matrix diagonals** (absolute value).

### **Input**
- On the **first line**, you are given the integer **N** – the size of the square matrix
- The next **N lines** holds the values for **every row** – **N** numbers separated by a space
### **Output**
- Print **the absolute** difference between **the sums** of the primary and the secondary diagonal
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p>3</p><p>11 2 4</p><p>4 5 6</p><p>10 8 -12</p>|15|<p>**Primary diagonal:** sum = 11 + 5 + (-12) = 4</p><p>**Secondary diagonal:** sum = 4 + 5 + 10 = 19</p><p>**Difference:** |4 - 19| = 15</p>|
1. ## **2x2 Squares in Matrix**
Find the count of **2 x 2 squares of equal chars** in a matrix.
### **Input**
- On the **first line**, you are given the integers **rows** and **cols –** the matrix’s dimensions
- Matrix characters come at the next **rows** lines (space separated)
### **Output**
- Print the number of all the squares matrixes you have found
### **Examples**

|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|<p>3 4</p><p>A B B D</p><p>E B B B</p><p>I J B B</p>|2|<p>Two 2 x 2 squares of equal cells:</p><p>A **B B** D	A B B D</p><p>E **B B** B	E B **B B**</p><p>I J B B	I J **B B**</p>|
|<p>2 2</p><p>a b</p><p>c d</p>|0|<a name="ole_link1"></a><a name="ole_link2"></a>No 2 x 2 squares of equal cells exist.|
1. ## **Maximal Sum**
Write a program that reads a rectangular integer matrix of size **N x M** and finds in it the square **3 x 3** that **has maximal sum of its elements**.
### **Input**
- On the first line, you will receive the rows **N** and columns **M**. On the next **N lines** you will receive **each row with its columns**
### **Output**
- Print the **elements** of the 3 x 3 square as a matrix, along with their **sum**
### **Examples**

|**Input**|**Matrix**|**Output**|
| :-: | :-: | :-: |
|<p>4 5</p><p>1 5 5 2 4</p><p>2 1 4 14 3</p><p>3 7 11 2 8</p><p>4 8 12 16 4</p>||<p>Sum = 75</p><p>1 4 14</p><p>7 11 2</p><p>8 12 16</p>|
5. ## **Rubik’s Matrix**
Rubik’s cube – everyone’s favorite head-scratcher. Writing a program to solve it will be quite a difficult task for an exam, though. Instead, we have a Rubik’s matrix prepared for you. You will be given a pair of dimensions: **R** and **C.** To prepare the matrix, fill each row with increasing integers, starting from one. For example, **2 x 4** matrix must look like this:

|1|2|3|4|
| :- | :- | :- | :- |
|5|6|7|8|


Next, you will receive series of commands, indicating which row or column you must move, in which direction, and how many times. For example, **1 up 1** means: column 1, direction: up, 1 move. After executing it, the matrix should look like:

|1|6|3|4|
| :- | :- | :- | :- |
|5|2|7|8|


Directions **left** and **right** means you must move the corresponding **row**, while **up** and **down** are related to the **columns.** After shuffling the Rubik’s matrix, you have to **rearrange** it (meaning that the **values in each cell** should be in **increasing order**, such as the ones in the original matrix). The rearranging process should start at **top-left** and end at **bottom-right**. Find the **position** of the value you need, and print the **swap** **command** on the console, in the format described below.
### **Input**
- On the first line, you are given the integers **R** and **C**, separated by a space
- On the second line, you are given an integer **N**, indicating the number of commands to follow
- On the next N lines, you are given commands in format **{row/col} {direction} {moves}**
### **Output**
- On **R** \* **C** number of lines, print the **swap commands** needed to rearrange the matrix, either:
  - **“Swap ({row}, {col}) with ({row}, {col})”** or
  - **“No swap required”**
### **Constraints**
- **R, C, N** are integers in range [1 … 100]
- {**row**} and {**col**} will always be inside the matrix
- {**moves**} is in range [0 … 2<sup>31</sup>-1]
- Allowed time and memory: 0.25s / 16 MB
### **Examples**

|**Input**|**Output**|**Input**|**Output**|
| - | - | - | - |
|<p>3 3</p><p>2</p><p>1 down 1</p><p>1 left 1</p>|<p>No swap required</p><p>Swap (0, 1) with (1, 0)</p><p>No swap required</p><p>Swap (1, 0) with (1, 2)</p><p>Swap (1, 1) with (2, 1)</p><p>Swap (1, 2) with (2, 1)</p><p>No swap required</p><p>No swap required</p><p>No swap required</p>|<p>3 3</p><p>2</p><p>0 down 3</p><p>0 left 3</p>|<p>No swap required</p><p>No swap required</p><p>No swap required</p><p>No swap required</p><p>No swap required</p><p>No swap required</p><p>No swap required</p><p>No swap required</p><p>No swap required</p>|
5. ## **Target Practice**
Cotton-eye Gosho has a problem. **Snakes**! An infestation of snakes! Gosho is a red-neck which means he doesn’t really care about animal rights, so he bought some ammo, loaded his shotgun and started shooting at the poor creatures. He has a favorite spot – rectangular stairs which the snakes like to climb in order to reach Gosho’s stash of whiskey in the attic. You’re tasked with the horrible cleanup of the aftermath.

A **snake** is represented by **a string**. The **stairs** are a **rectangular matrix of size NxM**. A snake starts climbing the stairs from the **bottom-right corner** and slithers its way up in a **zigzag** – first it moves left until it reaches the left wall, it climbs on the next row and starts moving right, then on the third row, moving left again and so on. The first cell (bottom-right corner) is filled with the first symbol of the snake, the second cell (to the left of the first) is filled with the second symbol, etc. The snake is as long as it takes in order to **fill the stairs completely** – if you reach the end of the string representing the snake, start again at the beginning. Gosho is patient and a sadist, he’ll wait until the stairs are completely covered with snakes and then will fire a shot.

The shot has three parameters – **impact row, impact column and radius**. When the projectile lands on the specified coordinates in the matrix it **destroys all symbols in the given radius (turns them into a space)**. You can check whether a cell is inside the blast radius using the Pythagorean Theorem (very similar to the "point inside a circle" problem).

The symbols above the impact area start **falling down until they land on other symbols (meaning a symbol moves down a row as long as there is a space below)**. When the horror ends, print on the console the **resulting staircase, each row on a new line**. You should really check out the examples at this point.
### **Input**
- The input data should be read from the console. It consists of exactly three lines
- On the first line, you’ll receive the **dimensions** of the stairs in format: **"N M"**, where **N** is the number of **rows**, and **M** is the number of **columns**. They’ll be separated by a single space
- On the second line you’ll receive the string representing the **snake**
- On the third line, you’ll receive the **shot parameters (impact row, impact column and radius)**, all separated by a **single space**
- The input data will always be valid and in the format described. There is no need to check it explicitly
### **Output**
- The output should be printed on the console. It should consist of **N lines**
- Each line should contain a string representing the respective row of the final matrix
### **Constraints**
- The **dimensions** N and M of the matrix will be integers in the range [1 … 12]
- The **snake** will be a string with length in the range [1 … 20] and **will not contain any whitespace characters**
- The shot’s **impact row and column** will always be **valid coordinates** in the matrix – they will be integers in the range [0 … N – 1] and [0 … M – 1] respectively
- The shot’s **radius** will be an integer in the range [0 … 4]
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB
### **Examples**

|**Input**|**Output**|**Comments**|
| - | - | - |
|<p>5 6</p><p>SoftUni</p><p>2 3 2</p>|<p>O</p><p>US   t</p><p>tn   f</p><p>iSi UU</p><p>nUt oS</p>|The matrix has 5 rows and 6 columns. Fill it in the described pattern:|

|o|S|i|n|U|t|
| :-: | :-: | :-: | :-: | :-: | :-: |
|U|n|i|S|o|f|
|t|f|o|S|i|n|
|i|S|o|f|t|U|
|n|U|t|f|o|S|

|||The shot lands on cell (2,3). It has a radius of 2 cells. The impact cell is shaded black and the other cells within the shot radius are shaded grey.|
| - | - | - |

|o|S|i|n|U|t|
| :-: | :-: | :-: | :-: | :-: | :-: |
|U|n|i|S|o|f|
|t|f|o|S|i|n|
|i|S|o|f|t|U|
|n|U|t|f|o|S|

|||<p></p><p>Replace all characters in the blast area with a space:</p>|
| - | - | - |

|o|S|i| |U|t|
| :-: | :-: | :-: | :-: | :-: | :-: |
|U|n| | | |f|
|t| | | | | |
|i|S||||U|
|n|U|t||o|S|

|||<p></p><p>All characters start falling down until they land on other characters:</p>|
| - | - | - |

|o|S|i| |U|t|
| :-: | :-: | :-: | :-: | :-: | :-: |
|U|n| | | |f|
|t| | | | | |
|i|S||||U|
|n|U|t||o|S|

|||<p></p><p>The resulting matrix is:</p>|
| - | - | - |

|o||| |||
| :-: | :-: | :-: | :-: | :-: | :-: |
|U|S| | | |t|
|t|n | | | |f |
|i|S|i||U|U|
|n|U|t||o|S|

||||
| - | - | - |

5. ## **Lego Blocks**
You are given two **jagged arrays**. Each array represents a **Lego block** containing integers. Your task is first to **reverse** the second jagged array and then check if it would **fit perfectly** in the first jagged array.



The picture above shows exactly what **fitting** **arrays** means. If the arrays fit perfectly you should **print out** the newly made rectangular matrix. If the arrays do not match (they do not form a rectangular matrix) you should print out the **number of cells** in the first array and in the second array combined. The examples below should help you understand the assignment better.
### **Input**
The first line of the input comes as an **integer** **number, n,** saying how many rows are there in both arrays. Then you have **2 \* n** lines of numbers separated by whitespace(s). The first **n** lines are the rows of the first jagged array; the next **n** lines are the rows of the second jagged array. There might be leading and/or trailing whitespace(s).
### **Output**
You should print out the combined matrix in the format:
**[*elem, elem, …, elem*]
[*elem, elem, …, elem*]
[*elem, elem, …, elem*]**
If the two arrays do not fit you should print out: **The total number of cells is: *count***
### **Constraints**
- The number n will be in the range [2…10]
- Time limit: 0.3 sec. Memory limit: 16 MB
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>2</p><p>1 1 1 1 1 1</p><p>2 1 1 3</p><p>1 1</p><p>2 2 2 3</p>|<p>[1, 1, 1, 1, 1, 1, 1, 1]</p><p>[2, 1, 1, 3, 3, 2, 2, 2]</p>|
|<p>2</p><p>1 1 1 1 1</p><p>1 1 1</p><p>1</p><p>1 1 1 1 1</p>|The total number of cells is: 14|
5. ## **Radioactive Mutant Vampire Bunnies**
Browsing through GitHub, you come across an old JS Basics teamwork game. It is about very nasty bunnies that multiply extremely fast. There’s also a player that has to escape from their lair. You really like the game so you decide to port it to C# because that’s your language of choice. The last thing that is left is the algorithm that decides if the player will escape the lair or not.

First, you will receive a line holding integers **N** and **M**, which represent the rows and columns in the lair. Then you receive **N** strings that can **only** consist of **“.”**, **“B”**, **“P”**. The **bunnies** are marked with “**B”,** the **player** is marked with “**P**”, and **everything** else is free space, marked with a dot **“.”**. They represent the initial state of the lair. There will be **only** one player. Then you will receive a string with **commands** such as **LLRRUUDD** – where each letter represents the next **move** of the player (Left, Right, Up, Down).

**After** each step of the player, each of the bunnies spread to the up, down, left and right (neighboring cells marked as “.” **changes** their value to B). If the player **moves** to a bunny cell or a bunny **reaches** the player, the player has died. If the player goes **out** of the lair **without** encountering a bunny, the player has won.

When the player **dies** or **wins**, the game ends. All the activities for **this** turn continue (e.g. all the bunnies spread normally), but there are no more turns. There will be **no** stalemates where the moves of the player end before he dies or escapes.

Finally, print the final state of the lair with every row on a separate line. On the last line, print either **“dead: {row} {col}”** or **“won: {row} {col}”**. Row and col are the coordinates of the cell where the player has died or the last cell he has been in before escaping the lair.
### **Input**
- On the first line of input, the numbers **N** and **M** are received – the number of **rows** and **columns** in the lair
- On the next N lines, each row is received in the form of a string. The string will contain only “.”, “B”, “P”. All strings will be the same length. There will be only one “P” for all the input
- On the last line, the directions are received in the form of a string, containing “R”, “L”, “U”, “D”
### **Output**
- On the first N lines, print the final state of the bunny lair
- On the last line, print the outcome – “won:” or “dead:” + {row} {col}
### **Constraints**
- The dimensions of the lair are in range [3…20]
- The directions string length is in range [1…20]
### **Examples**

|**Input**|**Output**|
| - | - |
|<p>5 8</p><p>.......B</p><p>...B....</p><p>....B..B</p><p>........</p><p>..P.....</p><p>ULLL</p>|<p>BBBBBBBB</p><p>BBBBBBBB</p><p>BBBBBBBB</p><p>.BBBBBBB</p><p>..BBBBBB</p><p>won: 3 0</p><p></p>|
|<p>4 5</p><p>.....</p><p>.....</p><p>.B...</p><p>...P.</p><p>LLLLLLLL</p>|<p>.B...</p><p>BBB..</p><p>BBBB.</p><p>BBB..</p><p>dead: 3 1</p><p></p>|
5. ## **Crossfire**
You will receive **two** **integers** which represent the **dimensions** of a **matrix**. Then, you must **fill** **the** **matrix** with **increasing** **integers** starting from 1, and continuing on every row, like this:
first row: 1, 2, 3, …, n
second row: n + 1, n + 2, n + 3, …, n + n
third row: 2 \* n + 1, 2 \* n + 2, …, 2 \* n + n

You will also receive several commands in the form of **3 integers** separated by a space. Those 3 integers will represent a **row** in the matrix, a **column** and a **radius**. You must then **destroy** the cells which correspond to those arguments **cross-like.**

**Destroying** a cell means that, **that** **cell** becomes completely **nonexistent** in the matrix.** Destroying cells **cross-like** means that you form a **cross figure** with center point - equal to the cell with coordinates – the **given row** and **column**, and **lines** with length equal to the **given radius**. See the examples for more info. 

The **input ends** when you receive the command “Nuke it from orbit”. When that happens, you must print what has remained from the initial matrix.
### **Input**
- On the first line you will receive the dimensions of the matrix. You must then fill the matrix according to those dimensions
- On the next several lines you will begin receiving 3 integers separated by a single **space**, which represent the row, col and radius. You must then destroy cells according to those coordinates
- When you receive the command “**Nuke it from orbit**” the input ends
### **Output**
- The output is simple. You must print what is left from the matrix
- Every row must be printed on a new line and every column of a row - separated by a space
### **Constraints**
- The dimensions of the matrix will be integers in the range [2, 100]
- The given rows and columns will be valid integers in the range [-2<sup>31</sup> + 1, 2<sup>31</sup> - 1]
- ` `The radius will be in range [0, 2<sup>31</sup> - 1]
- Allowed time/memory: 250ms/16MB
### **Examples**

|**Input**|**Output**|**Comment**|
| - | - | - |
|<p>5 5</p><p>3 3 2</p><p>4 3 2</p><p>Nuke it from orbit</p>|<p>1 2 3 4 5</p><p>6 7 8 10</p><p>11 12 13</p><p>16</p><p>21</p>|<p>Initial matrix:</p><p>1  2  3  4  5</p><p>6  7  8  9  10</p><p>11 12 13 14 15</p><p>16 17 18 19 20</p><p>21 22 23 24 25</p><p>Result from first destruction:</p><p>1  2  3  4  5</p><p>6  7  8  10</p><p>11 12 13 15</p><p>16           </p><p>21 22 23 25</p><p>Result from second destruction:</p><p>1  2  3  4  5</p><p>6  7  8  10</p><p>11 12 13</p><p>16</p><p>21</p><p></p>|
|<p>5 5</p><p>4 4 4</p><p>Nuke it from orbit</p>|<p>1 2 3 4</p><p>6 7 8 9</p><p>11 12 13 14</p><p>16 17 18 19</p>||

5. ## **The Heigan Dance**
At last, level 80. And what do level eighties do? Go raiding. This is where you are now – trying not to be wiped by the famous dance boss, Heigan the Unclean. The fight is pretty straightforward - dance around the Plague Clouds and Eruptions, and you’ll be just fine.

Heigan’s chamber is a 15-by-15 two-dimensional array. The player always starts at the **exact center.** For each turn, Heigan uses a spell that hits a certain cell and the neighboring **rows/columns**. For example, if he hits (1,1), he also hits (0,0, 0,1, 0,2, 1,0 … 2,2). If the player’s current position is within the area of damage, the player tries to move. First, he tries to move **up**, if there’s **damage/wall**, he tries to move **right**, then **down**, then **left**. If he **cannot move** in any direction, because **the cell is damaged** or there is **a wall**, the player **stays** in place and takes the damage.

**Plague cloud** does 3500 damage **when it hits**, and 3500 damage **the next turn**. Then it **expires. Eruption** does 6000 damage **when it hits.** If a spell hits a player that also has an active Plague Cloud from the previous turn, the **cloud** damage is applied **first**. **Both** Heigan and the player **may** die in the same turn. If Heigan is **dead**, the spell he **would** have casted is **ignored**.

The player always starts at **18500** hit points; Heigan starts at **3,000,000** hit points. **Each** turn, the player does damage to Heigan. The fight is over either when the player is **killed**, or Heigan is **defeated**.
### **Input**
- On the first line you receive a floating-point number **D –** the damage done to Heigan each turn
- On the next several lines – you receive input in format **{spell} {row} {col}** – **{spell}** is either **Cloud** or <a name="ole_link5"></a><a name="ole_link6"></a>**Eruption**
### **Output**
- `    `On the first line  
  - If Heigan is defeated: “**Heigan:** **Defeated!**”
  - Else: “**Heigan: {remaining**}”, where remaining is rounded to two digits after the decimal separator
- `    `On the second line:
  - If the player is killed: “<a name="ole_link7"></a><a name="ole_link8"></a>**Player:** **Killed by {spell}**”
  - Else “<a name="ole_link9"></a><a name="ole_link10"></a>**Player: {remaining}”**
- `    `On the third line: “**Final position: {row,  col}**” -> the last coordinates of the player
### **Constraints**
- **D** is a floating-point number in range [0 … 500000]
- A damaging spell will always affect at least one cell
- Allowed memory: 16 MB
- Allowed working time: 0.25s
### **Examples**

|**Input**|**Output**|
| - | - |
|<p>10000</p><p>Cloud 7 7</p><p>Eruption 6 7</p><p>Eruption 8 7</p><p>Eruption 8 7</p>|<p>Heigan: 2960000.00</p><p>Player: Killed by Eruption</p><p>Final position: 8, 7</p>|





|**Input**|**Output**|
| - | - |
|<p>500000</p><p>Cloud 7 6</p><p>Eruption 7 8</p><p>Eruption 7 7</p><p>Cloud 7 8</p><p>Eruption 7 9</p><p>Eruption 6 14</p><p>Eruption 7 11</p>|<p>Heigan: Defeated!</p><p>Player: 12500</p><p>Final position: 7, 11</p>|







|**Input**|**Output**|
| - | - |
|<p>12500\.66</p><p>Cloud 7 7</p><p>Cloud 7 7</p><p>Cloud 7 7</p><p>Cloud 7 7</p>|<p>Heigan: 2949997.36</p><p>Player: Killed by Plague Cloud</p><p>Final position: 7, 7</p>|




5. ## **Parking System**
The parking lot in front of SoftUni is one of the busiest in the country, and it’s a common cause for conflicts between the doorkeeper Bai Tzetzo and the students. The SoftUni team wants to proactively resolve all conflicts, so an automated parking system should be implemented. They are organizing a competition – Parkoniada – and the author of the best parking system will win a romantic dinner with RoYaL. That’s **exactly** what you’ve been dreaming of, so you decide to join in.

The parking lot is a **rectangular** matrix where the **first** column is **always** free and all other cells are parking spots. A car can enter from **any cell** of the **first column** and then decides to go to a specific spot. If that spot is **not** free, the car searches for the **closest** free spot on the **same** row. If **all** the cells on that specific row are used, the car cannot park and leaves. If **two** free cells are located at the **same** distance from the **initial** parking spot, the cell which is **closer** to the entrance is preferred. A car can **pass** through a used parking spot.

Your task is to calculate the distance travelled by each car to its parking spot.

Example: A car enters the parking at row 1. It wants to go to cell 2, 2 so it moves through **exactly four** cells to reach its parking spot.


### **Input**
- On the first line of input, you are given the integers **R** and **C**, defining the dimensions of the parking lot
- On the next several lines, you are given the integers **Z, X,** **Y** where **Z** is the entry row and **X, Y** are the coordinates of the desired parking spot
- The input stops with the command ‘**stop**’. All integers are separated by a **single** space
### **Output**
- For each car, print the distance travelled to the desired spot or the first free spot
- If a car cannot park on its desired row, print the message ‘**Row {row number} full**’
### **Constraints**
- 2 ≤ R,C ≤ 10000
- Z, X, Y are inside the dimensions of the matrix. Y is never on the first column
- There are no more than 1000 input lines
- Allowed time/space: 0.1s (C#) /16MB
### **Examples**

|**Input**|**Output**|
| - | - |
|<p>4 4</p><p>1 2 2</p><p>2 2 2</p><p>2 2 2</p><p>3 2 2</p><p>stop</p>|<p>4</p><p>2</p><p>4</p><p>Row 2 full</p>|
5. ## **String Matrix Rotation**
You are given a **sequence of text lines**. Assume these text lines form a **matrix of characters** (pad the missing positions with spaces to build a rectangular matrix). Write a program to **rotate the matrix** by 90, 180, 270, 360, … degrees. Print the result at the console as sequence of strings. Examples:

<table><tr><th colspan="1"><b>Input</b></th><th colspan="1"><b>Rotate(90)</b></th><th colspan="1"><b>Rotate(180)</b></th><th colspan="1"><b>Rotate(270)</b></th></tr>
<tr><td colspan="1"><p>hello</p><p>softuni</p><p>exam</p></td><td colspan="1" rowspan="2"></td><td colspan="1" rowspan="2"></td><td colspan="1" rowspan="2"></td></tr>
<tr><td colspan="1"></td></tr>
</table>
### **Input**
- The first line holds a command in format "**Rotate(X)**" where **X** are the degrees of the requested rotation
- The next lines contain the **lines of the matrix** for rotation
- The input ends with the command **"END"**

The input data will always be valid and in the format described. There is no need to check it explicitly
### **Output**
- Print at the console the **rotated matrix** as a sequence of text lines
### **Constraints**
- The rotation **degrees** are positive integer in the range [0…90000], where **degrees** is **multiple of 90**
- The number of matrix lines is in the range [1…**1 000**]
- The matrix lines are **strings** of length 1 … 1 000
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>Rotate(90)</p><p>hello</p><p>softuni</p><p>exam</p><p>END</p></td><td colspan="1" valign="top"><p>esh</p><p>xoe</p><p>afl</p><p>mtl</p><p>` `uo</p><p>` `n </p><p>` `i </p></td><td colspan="1" valign="top"><p>Rotate(180)</p><p>hello</p><p>softuni</p><p>exam</p><p>END</p></td><td colspan="1" valign="top"><p>`   `maxe</p><p>inutfos</p><p>`  `olleh</p></td><td colspan="1" valign="top"><p>Rotate(270)</p><p>hello</p><p>softuni</p><p>exam</p><p>END</p></td><td colspan="1" valign="top"><p>` `i </p><p>` `n </p><p>ou </p><p>ltm</p><p>lfa</p><p>eox</p><p>hse</p></td></tr>
</table>


<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>Rotate(720)</p><p>js</p><p>exam</p><p>END</p></td><td colspan="1" valign="top"><p>js</p><p>exam</p><p></p></td><td colspan="1" valign="top"><p>Rotate(810)</p><p>js</p><p>exam</p><p>END</p></td><td colspan="1" valign="top"><p>ej</p><p>xs</p><p>a</p><p>m</p></td><td colspan="1" valign="top"><p>Rotate(0)</p><p>js</p><p>exam</p><p>END</p></td><td colspan="1" valign="top"><p>js</p><p>exam</p></td></tr>
</table>


