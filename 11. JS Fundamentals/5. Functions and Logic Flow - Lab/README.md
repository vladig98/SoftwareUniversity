
# **Lab: Functions and Logic Flow**
Problems for in-class lab for the ["JavaScript Fundamentals" course @ SoftUni](https://softuni.bg/trainings/2247/js-fundamentals-january-2019). 
Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1449>
1. ## **Multiplication Table**
Write a JS function that takes **two integers** as an input. 

- **The first parameter** will be the **starting number** that needs to be **multiplied**. 
- **The second parameter** will be the **multiplier**. 

Your task is to create a **multiplication table** based on the **numbers you have received**. **Note** that if the **first number is bigger than the** **second** one, you have to **print** the following message: 

"**Try with other numbers.**"

**Otherwise**, you have to **print the multiplication table** in the following format:

**{num1} \* {num2} = {result}**

` `For more information, see the examples below:
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|2, 9|<p>2 \* 9 = 18</p><p>3 \* 9 = 27</p><p>4 \* 9 = 36</p><p>5 \* 9 = 45</p><p>6 \* 9 = 54</p><p>7 \* 9 = 63</p><p>8 \* 9 = 72</p><p>9 \* 9 = 81</p>|
|**Input**|**Output**|
|8, 3|Try with other numbers.|

### **Hints**
First, we need to take the two values and parse them into numbers:

Next, we have to take the result div in order to give it a value later.

Now let us implement the function that checks if the inputs are correct:

Now, we are going to write the function that produces the result.

And finally, we make sure that the result div is empty, then we call that functions that checks for errors, and the function that calculates the result


2. ## **Temperature Converter**
Write a JS function that receives **two arguments** as an input.

- **The** **first parameter** will be the **degrees** that need to be converted.
- **The second parameter** will be either **Fahrenheit** or **Celsius** (**case-insensitive**). Every other type of input is considered **invalid** and the following message should be printed: **"Error!"**

The **output** should consist of **one number** - the **converted** degrees, in case of a **valid** input. Note that you need to **round the degrees to the nearest integer**.	

**Otherwise**, you should just print "**Error!**"

For more information, see the example below:
### ` `**Example**

|**Input**|**Output**|
| :-: | :-: |
|79, 'celsius'|174|
|**Input**|**Output**|
|45, 'Fahrenheit'|7|
|**Input**|**Output**|
|15, 'gosho'|Error!|




### **Hints**
First, let us get all the needed information from the DOM and create some variables we are going to need:

Next, we are going to implement a function called convert:

After that, we are going to need a function that displays the result on the DOM:

Finally, we have to call that functions and display the result:



2. ## **Count Occurrences of a Given Character**
Write a JS function that takes **two parameters** as an input. 

- **The first parameter** will be a **string**.
- **The second parameter** will be a **character**.

Your task is to find **each occurrence** of the **character** in the string and **print** if the **total count** is **even** or **odd** in the following format:

**Count of ${char} is even/odd.**

There will **always** be **at least one** char **occurrence** in the string. 

For more information, see the examples below: 
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|'HoHoHoHo Merry Crisis', 'H'|Count of H is even.|
|**Input**|**Output**|
|'Is this real life?', 'f'|Count of f is odd.|




### **Hints**
We start by taking all the elements from the DOM that we are going to need and we create some variables we are going to use later:

After that, we create the function that will find the count of the occurrences

Then the function that will determinate whether that count is even or odd:

Finally, we call those functions and set the result:


4. ## **Unique Characters**
Write a JS function that takes **one string parameter** as an input. 

Your task is to **extract** only the **unique characters** from the string **except for whitespaces**.

For more information, see the examples below: 
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|'Doggos are FunnNn'|Dogs are FunN|
|**Input**|**Output**|
|'This is a random Sentence'|This  a rndom Setc|





### **Hints**
First, we create a string uniqueChars, which will hold all of the unique characters that we find and we get the string by its id:

After that, we implement a function that checks whether a given character is white space:

And a function that checks if a given character is unique:

Then we use another function that uses both of them:

And finally, we call that function and set the result:

2. ## **Special Words**
Write a JS function that receives **five parameters** as an input.

- The **first and the second parameter** will be **integers**.	
- The **third, fourth and fifth** will be **strings**.

Your task is to **iterate from the first parameter to the second** one. 

- For **numbers** which are **multiples** of **both three and five**, print **all three strings separated by a space**. 
- For **multiples only of three**, print the **second string** (the **fourth** input **parameter**).
- For **multiples only of five**, print the **third string** (the **fifth** input **parameter**).

For more information, see the examples below:
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|9, 15, "doggo", "pesho", "test"|<p>9 pesho</p><p>10 test</p><p>11</p><p>12 pesho</p><p>13</p><p>14</p><p>15 doggo-pesho-test</p>|





### **Hints**
First, we need to get all of the input fields:

Then, let us write a function that will take an element and will make some checks:

Since the function checks a single number, we have to loop through each digit and call the function with that digit:




