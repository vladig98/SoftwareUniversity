
# **Lab: Strings and Regular Expressions**
Problems for in-class lab for the ["JavaScript Fundamentals" course @ SoftUni](https://softuni.bg/trainings/2247/js-fundamentals-january-2019). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1476>.
1. ## **Pascal or Camel Case**
Write a JS function that takes **two string parameters** as an input.

- **The first parameter** will be the text that you need to modify depending on the second parameter. The words in it will **always** be **separated by space**.
- **The second parameter** will be either "**Camel Case**" or "**Pascal Case**". In case of a different input, you should print **"Error!"**

Convert the first string to either of the cases. The **output** should consist of only **one word** – the string you have modified. For more information, see the examples below:
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|"this is an example", "Camel Case"|thisIsAnExample|
|"secOND eXamPLE", "Pascal Case"|SecondExample|
|"pesho PEshEV", "Another Case"|Error!|

### **Hints**
First, we need to take the two values from the input fields:

Then, let us write a function that will give is the result:

- First, we make all the **letters lower-case**
- Depending on the command, we make the input **Pascal Case** or **Camel Case**
- If there is something else as command, we print **error**

And finally, **call that function**

2. ## **Find ASCII Equivalent**
Write a JS function which receives **one string parameter** as an input. It will contain different words and numbers which will **always** be **separated by space**. Your job is to find **all the** **numbers** and convert them to their **ASCII char** equivalent and find **all the words** and convert **each letter** to its **ASCII number**. If there are **other symbols** such as "%", "@", "!" etc., **convert** them to their ASCII** number **as well**. 

The **output** should consist of each number that corresponds to each letter from the ASCII table for each word, in **separate paragraph**, **separated by space**, and the final word you have received by **appending all the chars**, converted from the numbers, together. 

For more information, see the example below:
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|<p>"Test 83 Testov 111 Pesho Gosho 102 116 85 Qwerty 110 105"</p><p></p>|<p>84 101 115 116</p><p>84 101 115 116 111 118</p><p>80 101 115 104 111</p><p>71 111 115 104 111</p><p>81 119 101 114 116 121</p><p>SoftUni</p>|



### **Hints**
First, we get the input and the result:

Then, we create a function that generates the result:

- If the current **element is a number**, we convert it to **character**
- Otherwise, we loop through each **character** and **make it into a number**
- Finally, we append the result

2. ## **Split String Equally**
Write a JS function that takes **two parameters** as an input.

- The **first parameter** will be of type **string**
- The **second parameter** will always be **a positive integer**, **bigger than 0**

Your task is to **split the string equally by the number** you have received, **separated by space**. 

- However, if the string **cannot** be split into equal parts, fill the last sequence until its **length** is **equal** to the **second parameter**, starting from the **beginning** of the string.

For more information, see the examples below: 
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|"TestTestov1234", 2|<p>Te st Te st ov 12 34</p><p></p>|
|"TestTestov1234", 6|TestTe stov12 34Test|
|"JavaScript", 14|JavaScriptJava|

### **Hints**
First, get the two input fields:

Then, create the function that splits the resulting string:

- Split the string into separate parts
- Add them to an array
- Set the result to equal that array joined by a space

Don’t forget to **call your function** at the end.

2. ## **Replace a Certain Word**
Write a JS function that receives **two parameters** as an input.

- The **first parameter** will be **an array of strings**. 
- The **second parameter** will be **a string** - the **word** that will be **used for replacing**.

The word that needs to be **replaced** in each of the strings will **always** be found in the **first string** of the array **at the second index**. Your task is to **replace every word with the given** one from the input. Have in mind that the cases are **case-insensitive**.

Print each of the strings from the array on a new line.

For more information, see the examples below:
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|<p>["I love pROgRaMminG", </p><p>"proGramMing is fun", </p><p>"ProgrAmmIng.",</p><p>"JSProgramming", "!@#$proGRAMming!@#$"], "JavaScript" </p><p></p>|<p>I love JavaScript</p><p>JavaScript is fun</p><p>JavaScript.</p><p>JSJavaScript</p><p>!@#$JavaScript!@#$</p><p></p>|

### **Hints**
- Get the input fields
- Create a separate function that replaces each element of the array with the given string (use **RegEx**)
- Add paragraphs to the **<span>** containing the new strings 

2. ## **Extract User Data**
Write a JS function that receives **an array of strings** as an input.

Your task is to **extract** all **valid user data** from each of the strings. Valid data consists of:

- It will always start with **a name**. A valid name will always consist of **first name** and **surname separated by space**. Note that the first name will **always start with an uppercase letter** and can be followed by lowercase ones (**but not necessarily**). The surname will always start with a capital letter, followed by **one or more** lowercase ones. 
- The name will be followed by **a phone number**. A valid phone number will be in the following format: *+359 2 569 789*, *+359 3 759 846*, *+359-5-789-359*. Note that it will **always start with +359** and the digits can be separated by **either** **spaces** or **dashes** but **NOT** both. 
- The phone number will be followed by **an email**. A valid email can consist of only **lowercase latin letters** or **digits**, followed by **@** and **one or more lowercase latin letters**. Before the domain, there will always be **a dot**. The domain can consist of **at least** two lowercase latin letters **BUT** no more than three.

Note that the data will be **always separated by a space**.

In case part of the above described data is missing or is invalid, print "**Invalid data**" on the console. Otherwise, print each of the extracted information **in a separate paragraph** in the following format:

**Name: {extractеdName}**

**Phone Number: {extractedPhoneNumber}**

**Email: {extractedEmail}**

**- - -**

For more information, see the examples below:
### **Example**


|**Input**|**Output**|
| :-: | :-: |
|<p>["Test Testov +359 2 123 456 <goSho@abv.bg>", "T T +359-5-759-684 <valid@gmail.com>", "Pesho +359-5 789 654 pesho@abv.bg"]</p><p></p>|<p>Invalid data</p><p>- - -</p><p>Name: T T</p><p>Phone Number: +359-5-759-684</p><p>Email: valid@gmail.com</p><p>- - -</p><p>Invalid data</p><p>- - -</p>|




