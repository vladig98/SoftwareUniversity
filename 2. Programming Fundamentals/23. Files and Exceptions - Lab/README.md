
# **Exercises: Files, Directories and Exceptions**
Problems for exercises and homework for the [“Programming Fundamentals” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).
1. # **File Operations**
1. ## **Odd Lines**
Write a program that reads a text file and writes it's every **odd** line in another file. Line numbers starts from 0. 
### **Examples**

|**Input.txt**|**Output.txt**|
| :-: | :-: |
|<a name="1"></a>Two households, both alike in dignity,<br><a name="2"></a>In fair Verona, where we lay our scene,<br><a name="3"></a>From ancient grudge break to new mutiny,<br><a name="4"></a>Where civil blood makes civil hands unclean.<br><a name="5"></a>From forth the fatal loins of these two foes<br><a name="6"></a>A pair of star-cross'd lovers take their life;<br><a name="7"></a>Whose misadventured piteous overthrows<br><a name="8"></a>Do with their death bury their parents' strife.|<p>In fair Verona, where we lay our scene,</p><p>Where civil blood makes civil hands unclean.</p><p>A pair of star-cross’d lovers take their life;</p><p>Do with their death bury their parents’ strife</p><p></p><p></p>|
1. ## **Line Numbers**
Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file. 
### **Examples**

|**Input.txt**|**Output.txt**|
| :-: | :-: |
|Two households, both alike in dignity,<br>In fair Verona, where we lay our scene,<br>From ancient grudge break to new mutiny,<br>Where civil blood makes civil hands unclean.<br>From forth the fatal loins of these two foes<br>A pair of star-cross'd lovers take their life;<br>Whose misadventured piteous overthrows<br>Do with their death bury their parents' strife.|<p>1. Two households, both alike in dignity,</p><p>2. In fair Verona, where we lay our scene,</p><p>3. From ancient grudge break to new mutiny,</p><p>4. Where civil blood makes civil hands unclean.</p><p>5. From forth the fatal loins of these two foes</p><p>6. A pair of star-cross'd lovers take their life;</p><p>7. Whose misadventured piteous overthrows</p><p>8. Do with their death bury their parents' strife.</p><p></p>|
1. ## **Word Count**
Write a program that reads a list of words from the file **words.txt** and finds how many times each of the words is contained in another file **text.txt**. Matching should be **case-insensitive**.

The result should be written to another text file. Sort the words by frequency in descending order. 
### **Examples**

|**words.txt**|**Input.txt**|**Output.txt**|
| :-: | :-: | :-: |
|<p>quick is fault</p><p></p>|<p>-I was quick to judge him, but it wasn't his fault.</p><p>-Is this some kind of joke?! Is it?</p><p>-Quick, hide here…It is safer.</p>|<p>is - 3</p><p>quick - 2</p><p>fault - 1</p>|
1. ## **Merge Files**
Write a program that reads the contents of two text files and merges them together into a third one.
### **Examples**

|**Input1.txt**|**Input2.txt**|**Output.txt**|
| :-: | :-: | :-: |
|<p>1</p><p>3</p><p>5</p><p></p>|<p>2</p><p>4</p><p>6</p>|<p>1</p><p>2</p><p>3</p><p>4</p><p>5</p><p>6</p>|
1. # **Directory Operations**
1. ## **Folder Size**
You are given a folder named “TestFolder”. Get the size of all files in the folder, which are **NOT directories.** The result should be written to another text file in **Megabytes**.
### **Examples**

|**Output.txt**|
| :-: |
|5\.16173839569092|



