
# **Lab: Objects and JSON**
Problems for in-class lab for the ["JavaScript Fundamentals" course @ SoftUni](https://softuni.bg/trainings/2247/js-fundamentals-january-2019). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1484/>
1. ## **Towns to JSON**
You’re tasked to create and print a JSON from a text table. You will receive input as an array of strings, where each string represents a row of a table, with values on the row encompassed by pipes **"|"** and optionally spaces. The table will consist of exactly 3 columns **“Town”**, **“Latitude”** and **“Longitude”**. The **latitude** and **longitude** columns will always contain **valid numbers**. Check the examples to get a better understanding of your task.

The **input** comes as an array of strings – the first string contains the table’s headings, each next string is a row from the table.

The **output** should be printed on the console – for each entry row in the input print the object representing it.
### **Examples**

|**Input**|
| :-: |
|<p>['| Town | Latitude | Longitude |',</p><p>'| Sofia | 42.696552 | 23.32601 |',</p><p>'| Beijing | 39.913818 | 116.363625 |'];</p>|
|**Output**|
|[{"Town":"Sofia","Latitude":42.69,"Longitude":23.32},<br>{"Town":"Beijing","Latitude":39.91,"Longitude":116.36}]|
|Input|
|<p>['| Town | Latitude | Longitude |',</p><p>'| Veliko Turnovo | 43.0757 | 25.6172 |',</p><p>'| Monatevideo | 34.50 | 56.11 |']</p>|
|**Output**|
|[{"Town":"Veliko Turnovo","Latitude":43.0757,"Longitude":25.6172},<br>{"Town":"Monatevideo","Latitude":34.5,"Longitude":56.11}]|
1. ## **Score to HTML**
You are given a JSON string representing an array of objects, parse the JSON and create a table using the supplied objects. The table should have 2 columns **"name"** and **"score"**, each object in the array will also have these keys.

Any text elements must also be **escaped** in order to ensure no dangerous code can be passed.

You can either write the HTML escape function yourself or use the one from the Strings and Regular Expressions Lab.

The **input** comes as a single string argument – the array of objects as a JSON.

The **output** should be printed on the console – a table with 2 columns - **"name"** and **"score"**, containing the values from the objects as rows.

|**Input**|
| :-: |
|'[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]'|
|**Output**|
|<p><table></p><p>`  `<tr><th>name</th><th>score</th></tr></p><p>`  `<tr><td>Pesho</td><td>479</td></tr></p><p>`  `<tr><td>Gosho</td><td>205</td></tr></p><p></table></p>|
|Input|
|'[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]'|
|**Output**|
|<p><table></p><p>`  `<tr><th>name</th><th>score</th></tr></p><p>`  `<tr><td>Pesho &amp; Kiro</td><td>479</td></tr></p><p>`  `<tr><td>Gosho, Maria &amp; Viki</td><td>205</td></tr></p><p></table></p>|
1. ## **From JSON to HTML Table**
You’re tasked with creating an HTML table of students and their scores. You will receive a single string representing an **array of objects**, the **table’s headings** should be equal to the **objects’ keys**, while **each object’s values** should be a **new entry** in the table. Any **text values** in an object should be **escaped**, in order to avoid introducing dangerous code into the HTML. 

Object’s keys will always be the **same.** 

The **input** comes as single string argument – the array of objects.

The **output** should be printed on the console – for each entry row in the input print the object representing it.
### **HTML**
You are provided with an HTML file to test your table in the browser.

|**index.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>FromJSONToHTMLTable</**title**><br>`    `<**style**><br>`        `**table**,**th**{<br>`            `**border**: **groove**;<br>`            `**border-collapse**: **collapse**;<br>`        `}<br>`        `**td**{<br>`            `**border**: 1**px solid black**;<br>`        `}<br>`        `**td**,**th**{<br>`            `**padding**: 5**px**;<br>`        `}<br>`    `</**style**><br></**head**><br><**body**><br>`    `<**div id="wrapper"**><br>`    `</**div**><br>`    `<**script**><br>`        `**function** *fromJSONToHTMLTable*(input){<br>`            `*//Write your code here*<br>`        `}<br>`        `**window**.onload = **function**(){<br>`            `**let** container = **document**.getElementById(**'wrapper'**);<br>`            `container.**innerHTML** = *fromJSONToHTMLTable*([**'[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]'**]);<br>`        `};<br>`    `</**script**><br></**body**><br></**html**>|
### **Examples**

|**Input**|
| :-: |
|'[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]'|
|**Output**|
|<p><table></p><p>`   `<tr><th>Name</th><th>Price</th></tr></p><p>`   `<tr><td>Tomatoes &amp; Chips</td><td>2.35</td></tr></p><p>`   `<tr><td>J&amp;B Chocolate</td><td>0.96</td></tr></p><p></table></p>|
|Input|
|'[{"Name":"Pesho <div>-a","Age":20,"City":"Sofia"},<br>{"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}]'|
|**Output**|
|<p><table></p><p>`   `<tr><th>Name</th><th>Age</th><th>City</th></tr></p><p>`   `<tr><td>Pesho &lt;div&gt;-a</td><td>20</td><td>Sofia</td></tr></p><p>`   `<tr><td>Gosho</td><td>18</td><td>Plovdiv</td></tr></p><p>`   `<tr><td>Angel</td><td>18</td><td>Veliko Tarnovo</td></tr></p><p></table></p>|
1. ## **Sum by Town**
You’re tasked with calculating the total sum of income for a number of Towns. You will receive an array of strings representing towns and their incomes, every **even** index will be a **town** and every **odd** index will be an **income** belonging to that town. Create an object that will hold all the **towns as keys** and their **total income** (the sum of their incomes) **as values** to those keys and print it as a JSON. 

The **input** comes as an array of strings - each even index is the name of a town and each odd index is an income belonging to that town.

The **output** should be printed on the console - JSON representation of the object containing all towns and their total incomes.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Sofia</p><p>20</p><p>Varna</p><p>3</p><p>Sofia</p><p>5</p><p>Varna</p><p>4</p>|{"Sofia":25,"Varna":7}|
|<p>Sofia</p><p>20</p><p>Varna</p><p>3</p><p>sofia</p><p>5</p><p>varna</p><p>4</p>|{"Sofia":20,"Varna":3,"sofia":5,"varna":4}|
1. ## **Count Words in a Text**
You are tasked to count the number of words in a text using an object as an associative array, any combination of letters, digits and \_ (underscore) should be counted as a word. The words should be stored in the object as properties - the **key** being the **word** and the **value** being the **amount of times the word is contained** **in the text**. 

The **input** comes as an array of strings containing one entry - the text whose words should be counted. The text may consist of more than one sentence.

The **output** should be printed on the console - the JSON representation of the object containing the words.
### **Examples**

|**Input**|
| :-: |
|Far too slow, you're far too slow.|
|**Output**|
|{"Far":1,"too":2,"slow":2,"you":1,"re":1,"far":1}|
|Input|
|JS devs use Node.js for server-side JS.-- JS for devs|
|**Output**|
|{"JS":3,"devs":2,"use":1,"Node":1,"js":1,"for":2,"server":1,"side":1}|
1. ## **Count Words with Maps**
You are tasked to count the number of words in a text using a Map, any combination of letters, digits and \_ (underscore) should be counted as a word. The words should be stored in a Map - the **key** being the **word** and the **value** being the **amount of times the word is contained** **in the text**. The matching should be **case insensitive**. Print the words in a **sorted order**.

The **input** comes as an array of strings containing one entry - the text whose words should be counted. The text may consist of more than one sentence.

The **output** should be printed on the console - print each word in the map in the format **"'<word>' -> <count> times"**, each on a new line.
### **Examples**

|**Input**|
| :-: |
|Far too slow, you're far too slow.|
|**Output**|
|<p>'far' -> 2 times</p><p>'re' -> 1 times</p><p>'slow' -> 2 times</p><p>'too' -> 2 times</p><p>'you' -> 1 times</p>|
|Input|
|JS devs use Node.js for server-side JS. JS devs use JS. -- JS for devs --|
|**Output**|
|<p>'devs' -> 3 times</p><p>'for' -> 2 times</p><p>'js' -> 6 times</p><p>'node' -> 1 times</p><p>'server' -> 1 times</p><p>'side' -> 1 times</p><p>'use' -> 2 times</p>|
1. ## **Populations in Towns**
You have been tasked to create a register for different **towns** and their **population**.

The **input** comes as array of strings. Each element will contain data for a town and its population in the following format:

“**{townName} <-> {townPopulation}**”

If you receive the same town twice, **you should add** the **given population** to the **current one**.

As **output**, you must print all the towns, and their population.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>Sofia <-> 1200000</p><p>Montana <-> 20000</p><p>New York <-> 10000000</p><p>Washington <-> 2345000</p><p>Las Vegas <-> 1000000</p>|<p>Sofia : 1200000</p><p>Montana : 20000</p><p>New York : 10000000</p><p>Washington : 2345000</p><p>Las Vegas : 1000000</p>||<p>Istanbul <-> 100000</p><p>Honk Kong <-> 2100004</p><p>Jerusalem <-> 2352344</p><p>Mexico City <-> 23401925</p><p>Istanbul <-> 1000</p>|<p>Istanbul : 101000</p><p>Honk Kong : 2100004</p><p>Jerusalem : 2352344</p><p>Mexico City : 23401925</p>|
1. ## **City Markets**
You have been tasked to follow the sales of products in the different towns. For every town you need to keep track of all the products sold, and for every product, the amount of total income.

The **input** comes as array of strings. Each element will represent data about a product and its sales. The format of input is:

**{town} -> {product} -> {amountOfSales} : {priceForOneUnit}**

The **town** and **product** are both **strings**. The **amount of sales** and **price for one unit** will be **numbers**. Store all towns, for every town, store its products, and for every product, its amount of **total income**. The total income is calculated with the following formula - **amount of sales \* price for one unit**. If you receive as input a town you already have, you should just **add** the **new product** to it.

As **output** you must print every town, its products and their total income in the following format:

**“Town – {townName}**

` `**$$${product1Name} : {productTotalIncome}**

` `**$$${product2Name} : {productTotalIncome}**

` `**...”**

The **order of output** for each of those entries is – by **order of entrance**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Sofia -> Laptops HP -> 200 : 2000</p><p>Sofia -> Raspberry -> 200000 : 1500</p><p>Sofia -> Audi Q7 -> 200 : 100000</p><p>Montana -> Portokals -> 200000 : 1</p><p>Montana -> Qgodas -> 20000 : 0.2</p><p>Montana -> Chereshas -> 1000 : 0.3</p>|<p>Town - Sofia</p><p>$$$Laptops HP : 400000</p><p>$$$Raspberry : 300000000</p><p>$$$Audi Q7 : 20000000</p><p>Town - Montana</p><p>$$$Portokals : 200000</p><p>$$$Qgodas : 4000</p><p>$$$Chereshas : 300</p>|
1. ## **Lowest Prices in Cities**
You will be given several towns, with products and their price. You need to find **the lowest price** for **every product** and **the town it is sold at** for that price.

The **input** comes as array of strings. Each element will hold data about a **town**, **product**, and **its price** at that town. The **town** and **product** will be **strings**; the **price** will be a **number**. The input will come in the following format:

**{townName} | {productName} | {productPrice}**

If you receive the same **town** and **product** **more than once,** you should **update** the **old value** with the **new one**.

As **output** you must print **each** **product** with its **lowest price** and **the town** at which the product is **sold at that** **price**. If **two towns share** the **same lowest price**, print the one that was **entered first**. 
The output, for every product, should be in the following format:

**{productName} -> {productLowestPrice} ({townName})**

The **order of output** is – **order of entrance**. See the examples for more info.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Sample Town | Sample Product | 1000</p><p>Sample Town | Orange | 2</p><p>Sample Town | Peach | 1</p><p>Sofia | Orange | 3</p><p>Sofia | Peach | 2</p><p>New York | Sample Product | 1000.1</p><p>New York | Burger | 10</p>|<p>Sample Product -> 1000 (Sample Town)</p><p>Orange -> 2 (Sample Town)</p><p>Peach -> 1 (Sample Town)</p><p>Burger -> 10 (New York)</p>|
1. ## **Extract Unique Words**
Write a JS function that **extracts** all **UNIQUE** words from a **valid text**, and **stores them**. Ensure that there are **NO duplicates** in the stored words. Once you find a word, there is no need for you to store it again if you meet it again in the text. You also need to make all characters from the words you’ve stored – **lowercase**.

The **input** comes as array of strings. Each element will represent a sentence.

The **output** is all of the unique words you’ve found, each with each, **separated** by a **coma and a space**, printed in the order in which you’ve found them. 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque quis hendrerit dui. </p><p>Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla. </p><p>Vestibulum dolor diam, dignissim quis varius non, fermentum non felis. </p><p>Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut. </p><p>Morbi in ipsum varius, pharetra diam vel, mattis arcu. </p><p>Integer ac turpis commodo, varius nulla sed, elementum lectus. </p><p>Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.</p>|lorem, ipsum, dolor, sit, amet, consectetur, adipiscing, elit, pellentesque, quis, hendrerit, dui, quisque, fringilla, est, urna, vitae, efficitur, vestibulum, diam, dignissim, varius, non, fermentum, felis, ultrices, ex, massa, faucibus, nunc, aliquam, ut, morbi, in, pharetra, vel, mattis, arcu, integer, ac, turpis, commodo, nulla, sed, elementum, lectus, vivamus, malesuada, dapibus, congue, egestas, metus|
|||
|**Input**|**Output**|
|<p>Interdum et malesuada fames ac ante ipsum primis in faucibus.</p><p>Vestibulum volutpat lacinia blandit.</p><p>Pellentesque dignissim odio in hendrerit lacinia.</p><p>Vivamus placerat porttitor purus nec hendrerit.</p><p>Aliquam erat volutpat. Donec ac augue ligula.</p><p>Praesent venenatis sapien vitae libero ornare, nec pulvinar velit finibus.</p><p>Proin dui neque, rutrum vel dolor ut, placerat blandit sapien.</p><p>Pellentesque at est arcu.</p><p>Nullam eget orci laoreet, feugiat nisi vitae, egestas libero.</p><p>Pellentesque pulvinar aliquet felis.</p><p>Interdum et malesuada fames ac ante ipsum primis in faucibus.</p><p>Etiam sit amet nisl ex.</p><p>Sed lacinia pretium metus quis fermentum.</p><p>Praesent a ante suscipit, efficitur risus cursus, scelerisque risus.</p>|interdum, et, malesuada, fames, ac, ante, ipsum, primis, in, faucibus, vestibulum, volutpat, lacinia, blandit, pellentesque, dignissim, odio, hendrerit, vivamus, placerat, porttitor, purus, nec, aliquam, erat, donec, augue, ligula, praesent, venenatis, sapien, vitae, libero, ornare, pulvinar, velit, finibus, proin, dui, neque, rutrum, vel, dolor, ut, at, est, arcu, nullam, eget, orci, laoreet, feugiat, nisi, egestas, aliquet, felis, etiam, sit, amet, nisl, ex, sed, pretium, metus, quis, fermentum, a, suscipit, efficitur, risus, cursus, scelerisque|


# **Lab: Objects and JSON, DOM Events**
Problems for in-class lab for the [“JavaScript Fundamentals” course @ SoftUni](https://softuni.bg/trainings/2080/js-fundamentals-september-2018).
1. ## **Object Properties**
You will be provided with **a skeleton** which contains a **form for adding object properties**. When submitting the form, you should be able to **add a property** to an object and **display it in a read-only text box**. 
### **Example**

### **Hints**
Let us see what we have first. This is where you should complete the html you are provided with:

- You are given an empty object to start with.
- The page is prevented from reloading when you click the button, because we want to see the result in our result checkbox.

Now, let us complete the script. To begin with, each time the button is clicked, we want to **get what was submitted** in the form. To do that, we need to check the id of both fields:

So we add that to our code:

Then, we add the property to our object and fill the textbox with the stringified version of the object. To do that, we search for the id of the textbox ("result") and we fill it with the object. We use **JSON.stringify**:

Ready! You can now experiment with what we have.
1. ## **Students Register**
You will be given names of students with their grades in the format: **"{firstName} {secondName} {grade}".** Store the information about the students and at the end print the result in the textbox in the following format:
**"Students are: {students names joined by ", "}"
"Average grade: {averageGrade formatted to second decimal point}"**



### **Example**

### **Hints**
First, we have to get our input and create an empty array to store the students:

- We split the received data by a new line.

- We split the info on each line by a space.
- We create new object.
- We push the object to the array.

- Finally, we create the resulting string to put in the text box.



- We take only the **first and second name** of each student, using the **map** function.
- We join them by space.
- Then, we calculate the average grade by using the **reduce** function (this returns the **sum of all the grades**) and we have to **divide the sum by the count of the students**, which gives us the **average grade**.
- We format the grade to the second decimal point and we display it in the text box.
1. ## **Rent**
You will be given information in separate input fields. The first field will contain flat numbers, separated by a space. The second will be the families and the third will be the rents. The length of all three input fields will be with same length. For each family, you have to print the flat and the rent in the format: 

**"In flat {number} family {family} has to pay {rent}".** 

At the end, print the total rent paid in the format: **"Total rent paid: {totalRent}"**
### **Example**

### **Hints**
- Read the info from the 3 input fields and split them by ", ". 

- Create an empty array.

- Since the three fields will have the same length, create a loop until you reach the size of any of them.

- Now just build the result.
1. ## **JSON Parser**
You will be given an object in JSON format in an input field. In the next input field, you will be given a command which can be one of the following: **"typeof {objKey}"** or **"value of {objValue}"**. In any other case, write **"Invalid command"** in the result text box. 
If the command is **"typeof {objKey}"**, search for that key in the object and print its type in the format: **"Type: {typeOfTheValue}".** If there is no such key in the object, print **"No such item"**. 
If the command is **"value of {objValue}"**, search for that key and print its value in the format: **"Value: {value}".** If there is no such key, print **"No such item"**.
### **Example**



### **Hints**
- Read the object from the input field, parse it using JSON.parse.
- Get the command from the input field, split it into parameters, get the type of the command and the key you will be looking for.

- Check if the command type is about the type or the value of the key.
- Check if you have that key and print the corresponding result in the text box.


1. ## **Buttons**
You will be given **2 input fields**. The first will contain a **key**, the other will contain a **value**. You will also have **three buttons**. The first will be **"Add".** When this button is clicked, you have to **add the property with the given key and value** to an object and display a message in the text box: **"New property added!"** The second will be **"Get Value"**. When this button is clicked, you have to **search for the key, given in the input**, and **display its value in the text box**. The last one will be **"Get Object"**. When this button is clicked, you have to display the **whole object in the text box**. **The text box must not be cleared each time you press a button**. You just have to **print the results on separate lines**.
### **Example**




### **Hints**
- Add onclick events on the buttons to execute the functions, depending on the button you have clicked.


- Create an object and write three functions to perform the different tasks.



