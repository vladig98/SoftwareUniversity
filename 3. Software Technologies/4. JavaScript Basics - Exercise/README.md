
# **Exercises: JavaScript Syntax and Basic Web**
Problems for exercises and homework for the [“Software Technologies” course @ SoftUni](https://softuni.bg/courses/software-technologies).

You can submit your solutions here <https://judge.softuni.bg/Contests/224/>.
1. ## **Multiply a Number by 2**
You are given a number **N**. Create a JS function that **multiplies** the **number by 2** and prints the result. The input comes as an **array of strings**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">2</td><td colspan="1">4</td><td colspan="1" valign="top"></td><td colspan="1" valign="top">3</td><td colspan="1" valign="top">6</td><td colspan="1" valign="top">30</td><td colspan="1" valign="top">60</td><td colspan="1" valign="top">13</td><td colspan="1" valign="top">26</td></tr>
</table>
### **Hints**
- Note that the **input** comes as **array of strings**, so you should take the **first** element and **parse** it to **number**.
- Print the output to the console.

A sample solution might look like this:

Note that a simpler solution could also work, but is not recommended because it relies on automatic type conversion form array of strings to a number:

1. ## **Multiply Two Numbers**
You are given a number **X** and a number **Y**. Create a JS function that multiplies **X \* Y** and prints the result. The input comes as array of strings.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>2</p><p>3</p></td><td colspan="1" valign="top">6</td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>13</p><p>13</p></td><td colspan="1" valign="top">169</td><td colspan="1" valign="top"><p>1</p><p>2</p></td><td colspan="1" valign="top">2</td><td colspan="1" valign="top"><p>0</p><p>50</p></td><td colspan="1" valign="top">0</td></tr>
</table>
1. ## **Multiply / Divide a Number by a Given Second Number**
You are given a number **N** and a number **X**. Create a JS function that:

- Multiplies **N** **\*** **X** if **X** is greater than or equal to **N**
- Divides **N** **/** **X** if **N** is greater than **X**

The input comes as array of strings.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>2</p><p>3</p></td><td colspan="1" valign="top">6</td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>13</p><p>13</p></td><td colspan="1" valign="top">169</td><td colspan="1" valign="top"><p>3</p><p>2</p></td><td colspan="1" valign="top">1\.5</td><td colspan="1" valign="top"><p>144</p><p>12</p></td><td colspan="1" valign="top">12</td></tr>
</table>
1. ## **Product of 3 Numbers**
You are given a number **X**, **Y** and **Z**. Create a JS function that finds if **X** \* **Y** \* **Z** (the product) is negative or positive. Try to do this **WITHOUT** multiplying the 3 numbers.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>2</p><p>3</p><p>-1</p></td><td colspan="1" valign="top">Negative</td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>5</p><p>4</p><p>3</p></td><td colspan="1" valign="top">Positive</td><td colspan="1" valign="top"><p>-3</p><p>-4</p><p>5</p></td><td colspan="1" valign="top">Positive</td></tr>
</table>
### **Hint**
- Count the **negative numbers**. If they are odd number, the result will be negative, otherwise à **positive**.
- Special case: one of the numbers is **0** à the **product** is **positive**.
1. ## **Print Numbers from 1 to N**
You are given a number **N**. Create a JS function that loops through all the numbers from **1 to N** and prints them. **N** will always be positive.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|5|<p>1</p><p>2</p><p>3</p><p>4</p><p>5</p>||2|<p>1</p><p>2</p>|
1. ## **Print Numbers from N to 1**
You are given a number **N**. Create a JS function that loops through all the numbers from **N to 1** and prints them. **N** will always be positive.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|5|<p>5</p><p>4</p><p>3</p><p>2</p><p>1</p>||2|<p>2</p><p>1</p>|
1. ## **Print Lines**
You will be, continuously, given input lines, until you receive the command “**Stop**”. Print each of those lines at the moment you read them, until you reach the ending command. Do **NOT** print the ending command.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>Line 1</p><p>Line 2</p><p>Line 3</p><p>Stop</p>|<p>Line 1</p><p>Line 2</p><p>Line 3</p>||<p>3</p><p>6</p><p>5</p><p>4</p><p>Stop</p><p>10</p><p>12</p>|<p>3</p><p>6</p><p>5</p><p>4</p>|
1. ## **Print Numbers in Reversed Order**
You will be given a few numbers as input. You need to print them in reversed order, each on a new line.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>10</p><p>15</p><p>20</p></td><td colspan="1" valign="top"><p>20</p><p>15</p><p>10</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>5</p><p>5\.5</p><p>24</p><p>-3</p></td><td colspan="1" valign="top"><p>-3</p><p>24</p><p>5\.5</p><p>5</p></td><td colspan="1" valign="top"><p>20</p><p>1</p><p>20</p><p>1</p><p>20</p></td><td colspan="1" valign="top"><p>20</p><p>1</p><p>20</p><p>1</p><p>20</p></td></tr>
</table>
1. ## **Set Values to Indexes in an Array**
You will be given **N** –** an integer specifying the **length** of an **array**. Then you will start receiving an **index** and a **value**. For each received line you must **set** the **value** at the given **index** to the **given value**.

When you’ve processed all input data, **print** the array’s elements **each on a new line**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p><b>3</b></p><p>0 - 5</p><p>1 - 6</p><p>2 - 7</p></td><td colspan="1" valign="top"><p>5</p><p>6</p><p>7</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p><b>2</b></p><p>0 - 5</p><p>0 - 6</p><p>0 - 7</p></td><td colspan="1" valign="top"><p>7</p><p>0</p></td><td colspan="1" valign="top"><p><b>5</b></p><p>0 - 3</p><p>3 - -1</p><p>4 - 2</p></td><td colspan="1" valign="top"><p>3</p><p>0</p><p>0</p><p>-1</p><p>2</p></td></tr>
</table>
1. ## **Add / Remove Elements**
You will be given a sequence of **commands** (pairs of elements separated by a space): **command** and **argument**. You start by an empty array.

- The command “**add {number}**” appends the **number** to the array.
- The command “**remove {index}**”** removes the element at the specified **index**. If the index is nonexistent, ignore that input line. When an element is deleted, all elements on the right from it, go one position left.

When you process all input data, **print the array’s elements** each on a separate line.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>add 3</p><p>add 5</p><p>add 7</p></td><td colspan="1" valign="top"><p>3</p><p>5</p><p>7</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>add 3</p><p>add 5</p><p>remove 1</p><p>add 2</p></td><td colspan="1" valign="top"><p>3</p><p>2</p></td><td colspan="1" valign="top"><p>add 3</p><p>add 5</p><p>remove 2</p><p>remove 0</p><p>add 7</p></td><td colspan="1" valign="top"><p>5</p><p>7</p></td></tr>
</table>
1. ## **Working with Key-Value Pairs**
You will be given input lines, each holding **two elements** separated by a space. The first is the **key** and the second is the **value**. 

Your task is to store the **value** for each **key**. If a key **already exists**, you need to **replace** the old value with the **new one**. At the last line of input, you will receive a **key**. 

Print the **value** corresponding to that **key**. If there is no such, print “**None**”.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>key value</p><p>key eulav</p><p>test tset</p><p>key</p></td><td colspan="1" valign="top">eulav</td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>3 test</p><p>3 test1</p><p>4 test2</p><p>4 test3</p><p>4 test5</p><p>4</p></td><td colspan="1" valign="top">test5</td><td colspan="1" valign="top"><p>3 bla</p><p>3 alb</p><p>2</p></td><td colspan="1" valign="top">None</td></tr>
</table>
1. ## **Multiple Values for a Key**
You will be given input lines, each holding **two elements** separated by a space: a **key** and **value**. You need to **store** the given **values** to the given **keys**. At the last line of the input you will receive a **key**. 

Your task is to **print all the values** corresponding to that **key**. If there are no such, just print “**None**”.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>key value</p><p>key eulav</p><p>test tset</p><p>key</p></td><td colspan="1" valign="top"><p>value</p><p>eulav</p></td><td colspan="1" valign="top"></td><td colspan="1" valign="top"><p>3 test</p><p>3 test1</p><p>4 test2</p><p>4 test3</p><p>4 test5</p><p>4</p></td><td colspan="1" valign="top"><p>test2</p><p>test3</p><p>test5</p></td><td colspan="1" valign="top"><p>3 bla</p><p>3 alb</p><p>2</p></td><td colspan="1" valign="top">None</td></tr>
</table>
1. ## **Storing Objects**
You will be given input lines, each holding information about a **student**: **name**, **age** and **grade**. The data comes in the following format:

- “**{name} -> {age} -> {grade}**”

Store the information from the input lines into **JS objects**.

**Print** the objects in their order of appearance, in the format:

|<p>Name: {name}</p><p>Age: {age}</p><p>Grade: {grade}</p>|
| - |
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Pesho -> 13 -> 6.00</p><p>Ivan -> 12 -> 5.57</p><p>Toni -> 13 -> 4.90</p>|<p>Name: Pesho</p><p>Age: 13</p><p>Grade: 6.00</p><p>Name: Ivan</p><p>Age: 12</p><p>Grade: 5.57</p><p>Name: Toni</p><p>Age: 13</p><p>Grade: 4.90</p>|
1. ## **Parse JSON Objects**
You will be given input lines (**text**) holding object data in **JSON format**. Use the **JSON.parse(str)** function to **parse** the data into **JavaScript objects**, and then **print** them as shown in the examples.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>{"name":"Gosho","age":10,"date":"19/06/2005"}</p><p>{"name":"Tosho","age":11,"date":"04/04/2005"}</p>|<p>Name: Gosho</p><p>Age: 10</p><p>Date: 19/06/2005</p><p>Name: Tosho</p><p>Age: 11</p><p>Date: 04/04/2005</p>|
1. ## **Turn Object into JSON String**
You will be given input lines holding information about an object in the format “**key** **->** **value**“. Create a **JS object** and save these keys and values in it.

After you’ve processed all the input data, print the **JSON** version of the object. Use the **JSON.stringify(obj)** function.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>name -> Angel</p><p>surname -> Georgiev</p><p>age -> 20</p><p>grade -> 6.00</p><p>date -> 23/05/1995</p><p>town -> Sofia</p>|{"name":"Angel","surname":"Georgiev","age":20,"grade":6,"date":"19/05/1995","town":"Sofia"}|


