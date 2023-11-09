
**Lab: DOM Manipulations**

Problems for in-class lab for the [“JavaScript Advanced” course @ SoftUni](https://softuni.bg/courses/javascript-advanced). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1549/Lab-DOM-Manipulation>.

1. **List of Items**

Write a JS function that **reads** the text inside an input field and **appends** the specified text to a list inside an HTML page. 

Submit **only** the **addItem()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify** the DOM of the given HTML document.

|**Sample HTML**|
| :-: |
|<p>**<h1>List of Items</h1>**</p><p>**<ul id="items"><li>First</li><li>Second</li></ul>**</p><p>**<input type="text" id="newItemText" />**</p><p>**<input type="button" value="Add" onclick="addItem()">**</p><p>**<script>**</p><p>`  `**function addItem() {**</p><p>`    `**// TODO: add new item to the list**</p><p>`  `**}**</p><p>**</script>**</p>|

**Examples**

` `à  à 

1. **Add / Delete**

Extend the previous problem to display a **[Delete] link** after each list item. **Clicking** it should **delete** the item with no confirmation. 

Submit **only** the **addItem()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify** the DOM of the given HTML document.


|**Sample HTML**|
| :-: |
|<p>**<h1>List of Items</h1>**</p><p>**<ul id="items"></ul>**</p><p>**<input type="text" id="newText" />**</p><p>**<input type="button" value="Add"<br>`  `onclick="addItem()">**</p><p>**<script>**</p><p>`  `**function addItem() {** </p><p>`       `**//TODO**</p><p>`     `**function deleteItem() {** </p><p>`          `**//TODO**</p><p>`     `**}**</p><p>`  `**}**</p><p>**</script>**</p>|

**Examples**

à 

1. **Delete from Table**

Write a JS program that **takes** an e-mail from an **input field** and **deletes** the matching row from a table. If no entry is found, an **error** should be displayed in a **<div>** with ID "**results**". The error should be "**Not found**." 

Submit **only** the **deleteByEmail()** function in judge. 

**Input/Output**

There will be no input/output, your program should instead **modify** the DOM of the given HTML document.

|**Sample HTML**|
| :-: |
|<p>**<table border="1" id="customers">**</p><p>` `**<tr><th>Name</th><th>Email</th></tr>**</p><p>` `**<tr><td>Eve</td><td>eve@gmail.com</td></tr>**</p><p>` `**<tr><td>Nick</td><td>nick@yahooo.com</td></tr>**</p><p>` `**<tr><td>Didi</td><td>didi@didi.net</td></tr>**</p><p>` `**<tr><td>Tedy</td><td>tedy@tedy.com</td></tr>**</p><p>**</table>**</p><p>**Email: <input type="text" name="email" />**</p><p>**<button onclick="deleteByEmail()">Delete</button>**</p><p>**<div id="result" />**</p><p>**<script>**</p><p>`     `**function deleteByEmail() {**</p><p>`          `**//TODO**</p><p>`     `**}**</p><p>**</script>**</p>|

**Examples**

` `à 

1. **Stopwatch**

Write a **timer** that counts **minutes** and **seconds**. The user should be able to control it with **buttons**. Clicking **[Start]** **resets** the timer back to zero. Only **one** of the buttons should be enabled at a time (you cannot stop the timer, if it is not running). 

Submit only the **stopwatch()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify** the DOM of the given HTML document.

|**Sample HTML**|
| :-: |
|<p>**<div id="time" style="border:3px solid blue; text-align:center; font-size:2em; margin-bottom:10px">00:00</div>**</p><p>**<button id="startBtn">Start</button>**</p><p>**<button id="stopBtn" disabled="true">Stop</button>**</p><p>**<script>**</p><p>`     `**window.onload = function stopWatch() {**</p><p>`         `**//TODO**</p><p>`     `**}**</p><p>**</script>**</p>|

**Examples**

1. **Mouse Gradient**

Write a JS program that **detects** and **displays** how far along a gradient the user has **moved** their **mouse**. Use the provided HTML and stylesheet (CSS) to test locally. The result should be **rounded down** and displayed as a **percentage** inside the **<div>** with ID "**result**". 

Submit **only** the **attachGradientEvents()** function in judge. Make sure you write it in a **separate** file, called **gradient.js**.

**Input/Output**

There will be no input/output, your program should instead **modify** the DOM of the given HTML document.

|**Sample HTML**|
| :-: |
|<p>**<html>**</p><p>**<head>**</p><p>`  `**<title>Mouse in Gradient</title>**</p><p>`  `**<link rel="stylesheet" href="gradient.css" />**</p><p>`  `**<script src="gradient.js"></script>**</p><p>**</head>**</p><p>**<body onload="attachGradientEvents()">**</p><p>`  `**<div id="gradient-box">**</p><p>`    `**<div id="gradient">Click me!</div>**</p><p>`  `**</div>**</p><p>`  `**<div id="result"></div>**</p><p>**</body>**</p><p>**</html>**</p>|


|**gradient.css**|
| :-: |
|<p>**#gradient-box {**</p><p>`  `**width: 300px;**</p><p>`  `**border: 2px solid lightgrey;**</p><p>**}**</p><p>**#gradient-box:hover {**</p><p>`  `**border: 2px solid black;**</p><p>**}**</p><p>**#gradient {**</p><p>`  `**height: 30px;**</p><p>`  `**color: white;**</p><p>`  `**text-shadow: 1px 1px 10px black;**</p><p>`  `**text-align: center;**</p><p>`  `**line-height: 30px;**</p><p>`  `**background: linear-gradient(to right, black, white);**</p><p>`  `**cursor: crosshair;**</p><p>**}**</p>|

**Examples**

1. **Highlight Active**

Write a JS function that **highlights** the **currently active** section of a document. There will be **multiple** divs with **input fields** inside them. Set the class of the div that contains the **currently focused** input field to "**focus**". When focus is lost (**blurred**), **remove the class** from the element.

Submit only the **focus()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify** the DOM of the given HTML document.

|**Sample HTML**|
| :-: |
|<p>**<!DOCTYPE html><html lang="en">**</p><p>**<head>**</p><p>`  `**<meta charset="UTF-8"><title>Focus</title>**</p><p>`  `**<style>**</p><p>`    `**div { width: 470px; }**</p><p>`    `**div div {**</p><p>`      `**text-align: center;**</p><p>`      `**display: inline-block;**</p><p>`      `**width: 200px;**</p><p>`      `**height: 200px;**</p><p>`      `**margin: 15px;**</p><p>`      `**border: 1px solid #999;**</p><p>`    `**}**</p><p>`    `**.focused { background: #999999; }**</p><p>`  `**</style>**</p><p>**</head>**</p><p>**<body onload="focus()">**</p><p>`  `**<div>**</p><p>`    `**<div><h1>Section 1</h1><input type="text"/></div>**</p><p>`    `**<div><h1>Section 2</h1><input type="text"/></div>**</p><p>`    `**<div><h1>Section 3</h1><input type="text"/></div>**</p><p>`    `**<div><h1>Section 4</h1><input type="text"/></div>**</p><p>`  `**</div>**</p><p>`  `**<script>**</p><p>`    `**function focus() {**</p><p>`      `***// TODO***</p><p>`    `**}**</p><p>`  `**</script>**</p><p>**</body>**</p><p>**</html>**</p>|

**Example**

` `à 

1. **Dynamic Validation**

Write a JS function that **dynamically validates** an email input field when it is **changed**. If the input is **invalid**, apply the style "**error**". Do **not** validate on every keystroke, as it is annoying for the user, consider only **change** events.

A valid email is considered to be in the format: **<name>@<domain>.<extension>**

Only **lowercase Latin characters** are allowed for any of the parts of the email. If the input is valid, clear the style.

Submit **only** the **validate()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify** the DOM of the given HTML document.

|**Sample HTML**|
| :-: |
|<p>**<!DOCTYPE html><html lang="en">**</p><p>**<head>**</p><p>`  `**<meta charset="UTF-8"><title>Focus</title>**</p><p>`  `**<style>.error { border: 2px solid red; }</style>**</p><p>**</head>**</p><p>**<body onload="validate()">**</p><p>`  `**<label for="email">Enter email:</label>**</p><p>`  `**<input id="email" type="text"/>**</p><p>`  `**<script>**</p><p>`    `**function validate() {**</p><p>`      `***// TODO***</p><p>`    `**}**</p><p>`  `**</script>**</p><p>**</body>**</p><p>**</html>**</p>|

**Example**

à 



