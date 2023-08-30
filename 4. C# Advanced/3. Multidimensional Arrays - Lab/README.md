
# **Lab: Multidimensional Arrays**
Problems for exercises and homework for the ["CSharp Advanced" course @ Software University](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here: <https://judge.softuni.bg/Contests/599/Multidimensional-Arrays-Lab>
1. ## **Sum Matrix Elements**
Write program that **reads a matrix** from the console and print:

- Count of **rows**
- Count of **columns**
- Sum of all **matrix elements**

On first line you will get matrix sizes in format **[rows, columns]**
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3, 6</p><p>7, 1, 3, 3, 2, 1<br>1, 3, 9, 8, 5, 6<br>4, 6, 7, 9, 1, 0</p><p></p>|<p>3</p><p>6</p><p>76</p>|
### **Hints**
- On next **[rows]** lines you will get elements for each column separated with coma and whitespace
- Try to use only **foreach** for printing
1. ## **Sum Matrix Columns**
Write program that **read a matrix** from console and print the sum for each column. On first line you will get matrix **rows**. On the next **rows** lines, you will get elements for each column separated with a space. 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3, 6</p><p>7 1 3 3 2 1</p><p>1 3 9 8 5 6</p><p>4 6 7 9 1 0</p>|<p>12</p><p>10</p><p>19</p><p>20</p><p>8</p><p>7</p>|
|<p>3, 3</p><p>1 2 3</p><p>4 5 6</p><p>7 8 9</p>|<p>12</p><p>15</p><p>18</p><p></p>|
### **Hints**
- Read matrix sizes.
- On the next row lines read the columns.
- Traverse the matrix and sum all elements in each column.
- Print the sum and continue with the other columns.
1. ## **Primary Diagonal**
Write a program that finds the **sum of matrix primary diagonal**.

### **Input**
- On the **first line**, you are given the integer **N** – the size of the square matrix
- The next **N lines** holds the values for **every row** – **N** numbers separated by a space
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3</p><p>11 2 4</p><p>4 5 6</p><p>10 8 -12</p>|4|
|<p>3</p><p>1 2 3</p><p>4 5 6</p><p>7 8 9</p>|15|
1. ## **Symbol in Matrix**
Write a program that reads **N**, number representing **rows** and **cols** of a **matrix**. On the next **N** lines, you will receive rows of the matrix. Each row consists of ASCII characters. After that, you will receive a symbol. Find the **first occurrence** of that symbol in the matrix and print its position in the format: "**({row}, {col})**". If there is no such symbol print an error message "**{symbol} does not occur in the matrix** "
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3</p><p>ABC</p><p>DEF</p><p>X!@</p><p>!</p>|(2, 1)|
|<p>4</p><p>asdd</p><p>xczc</p><p>qwee</p><p>qefw</p><p>4</p>|4 does not occur in the matrix|
1. ## **Square with Maximum Sum**
Write a program that **read a matrix** from console. Then find biggest sum of **2x2 submatrix** and print it to console.

On first line you will get matrix sizes in format **rows, columns.**

One next **rows** lines you will get elements for each **column** separated with coma.

Print **biggest top-left** square, which you find and sum of its elements.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3, 6</p><p>7, 1, 3, 3, 2, 1<br>1, 3, 9, 8, 5, 6<br>4, 6, 7, 9, 1, 0</p>|<p>9 8</p><p>7 9</p><p>33</p>|
|<p>2, 4</p><p>10, 11, 12, 13</p><p>14, 15, 16, 17</p>|<p>12 13 </p><p>16 17 </p><p>58</p>|
### **Hints**
- Think about **IndexOutOfRangeException()**
- If you find more than one max square, print the top-left one
1. ## <a name="ole_link1"></a><a name="ole_link2"></a>**Jagged-Array Modification**
Write a program that **reads a matrix** from the console. On the first line you will get matrix **rows**. On next **rows** lines you will get elements for each **column** separated with **space**. You will be receiving commands in the following format:

- **Add {row} {col} {value}** – **Increase** the number at the given **coordinates** with the **value.**
- **Subtract {row} {col} {value}** – **Decrease** the number at the given **coordinates** by the **value**.

Coordinates might be invalid. In this case you should print "**Invalid coordinates**". When you receive "**END**" you should print the matrix and stop the program.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>3</p><p>1 2 3</p><p>4 5 6</p><p>7 8 9</p><p>Add 0 0 5</p><p>Subtract 1 1 2</p><p>END</p><p></p>|<p>6 2 3</p><p>4 3 6</p><p>7 8 9</p>|
|<p>4</p><p>1 2 3 4</p><p>5 6 7 8</p><p>8 7 6 5</p><p>4 3 2 1</p><p>Add 4 4 100</p><p>Add 3 3 100</p><p>Subtract -1 -1 42</p><p>Subtract 0 0 42</p><p>END</p>|<p>Invalid coordinates</p><p>Invalid coordinates</p><p>-41 2 3 4</p><p>5 6 7 8</p><p>8 7 6 5</p><p>4 3 2 101</p>|
1. ## **Group Numbers**
Read a set of numbers and **group** them by their remainder when **dividing to 3** (0, 1 and 2).

One first line, you will get numbers separated with coma and whitespace.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2</p><p></p>|<p>3 66 </p><p>1 4 55 1 124 </p><p>113 2 557 2</p>|
|1, 4, -113, 55, -3, 1, -2, 66, 557, -124, 2|<p>-3 66 </p><p>1 4 55 1 -124 </p><p>-113 -2 557 2</p>|
### **Hints**
- Think about how to get **all rows lengths**
- First element in each array will be **easy**, but what will happen with **next numbers we need to add** to each row.  Probably you will need one more **array** to save the next **index** for each row
1. ## **Pascal Triangle**
The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other) row is 1 (the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.

If you want more info about it: <https://en.wikipedia.org/wiki/Pascal's_triangle>

Print each row elements separated with whitespace.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|4|<p>1 </p><p>1 1 </p><p>1 2 1 </p><p>1 3 3 1</p>|
|13|<p>1 </p><p>1 1 </p><p>1 2 1 </p><p>1 3 3 1 </p><p>1 4 6 4 1 </p><p>1 5 10 10 5 1 </p><p>1 6 15 20 15 6 1 </p><p>1 7 21 35 35 21 7 1 </p><p>1 8 28 56 70 56 28 8 1 </p><p>1 9 36 84 126 126 84 36 9 1 </p><p>1 10 45 120 210 252 210 120 45 10 1 </p><p>1 11 55 165 330 462 462 330 165 55 11 1 </p><p>1 12 66 220 495 792 924 792 495 220 66 12 1 </p>|
### **Hints**
- The input number **n** will be **1 <= n <= 60**
- Think about proper **type** for elements in array
- Don’t be scary to use **more and more arrays**

