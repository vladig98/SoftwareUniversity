
# **Lab: jQuery**
Problems for exercises and homework for the [“JavaScript Advanced” course @ SoftUni](https://softuni.bg/trainings/2248/js-advanced-february-2019). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1547>.
1. ## **Text from List**
A HTML page holding a **list** of items and an **[Extract Text]** button is given. Implement the **extractText** function which will be called when the button's **onClick** event is fired.
### **HTML and JavaScript Code**
You are given the following **HTML** code:

|**text.html**|
| :-: |
|<p><!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Text from List</**title**><br>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js" integrity="sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="   crossorigin="anonymous"**></**script**><br>`    `<**script src="extractText.js"**></**script**><br></**head**><br><**body**></p><p><**article**><br>`    `<**ul id="items"**><br>`        `<**li**>first item</**li**><br>`        `<**li**>second item</**li**><br>`        `<**li**>third item</**li**><br>`    `</**ul**><br>`    `<**button onclick="***extractText*()**"**></p><p>`        `Extract Text</p><p>`    `</**button**><br>`    `<**div id="result"**></**div**></p><p></**article**><br></**body**><br></**html**></p>|

It comes together with the following **JavaScript** code:

|**extract-text.js**|
| :-: |
|**function** *extractText*() {<br>`    `*// **TODO***<br>}|
### **Screenshots**

1. ## **Search in List**
An HTML page holds a **list** of towns, a **search** box and a **[Search]** button. Implement the **search** function to **bold** the items from the list which include the text from the **search** box. Also print the amount of items the current search **matches** in the format **"<matches> matches found."**
### **HTML and JavaScript Code**
You are given the following **HTML** code:

|**list.html**|
| :-: |
|<p><!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**title**>Search in List</**title**><br>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js" integrity="sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="   crossorigin="anonymous"**></**script**><br>`    `<**script src="search.js"**></**script**></p><p>`    `<**link rel="stylesheet" rel="list.css"**><br></**head**><br><**body**></p><p><**article**><br><**ul id="towns"**><br>`    `<**li**>Sofia</**li**><br>`    `<**li**>Pleven</**li**><br>`    `<**li**>Varna</**li**><br>`    `<**li**>Plovdiv</**li**><br></**ul**><br><**input type="text" id="searchText"** /><br><**button onclick="***search*()**"**>Search</**button**><br><**div id="result"**></**div**></p><p></**article**><br></**body**><br></**html**></p>|

It comes together with the following **JavaScript** code:

|**search.js**|
| :-: |
|**function** *search*() {<br>`    `*// **TODO***<br>}|
### **Screenshots**

1. ## **Link Buttons**
You are given HTML holding some buttons. Implement the **attachEvents** function which should attach **click** events on the **anchor** **elements**. When a **<a>** is clicked, you should **add** a “**selected**” **class** to him and the same time remove all others “selected” class, if any.

**Note**: **There can be only 1 <a> element with “selected” class.**
### **HTML, CSS and JavaScript Code**
You are given the following **HTML** code:

|**buttons.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Title</**title**><br>`    `<**link rel="stylesheet" href="link-buttons.css"** /><br>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**><br>`    `<**script src="link-buttons.js"**></**script**><br></**head**><br><**body onload="**attachEvents()**"**><br>`    `<**a class="button"**>Sofia</**a**><br>`    `<**a class="button"**>Plovdiv</**a**><br>`    `<**a class="button"**>Varna</**a**><br></**body**><br></**html**>|

It comes with this **CSS**:

|**link-buttons.css**|
| :-: |
|**a**.**button** {<br>`    `**border**: 1**px solid #CCC**;<br>`    `**background**: **#EEE**;<br>`    `**padding**: 5**px** 10**px**;<br>`    `**border-radius**: 5**px**;<br>`    `**color**: **#333**;<br>`    `**text-decoration**: **none**;<br>`    `**display**: **inline-block**;<br>`    `**margin**: 5**px**;<br>}<br><br>**a**.**button**.**selected** {<br>`    `**color**: **#111**;<br>`    `**font-weight**: **bold**;<br>`    `**border**: 1**px solid #AAA**;<br>`    `**background**: **#BBB**;<br>}<br><br>**a**.**button**.**selected**::**before** {<br>`    `**content**: **"\2713\20\20"**;<br>}<br><br>**a**:**hover** {<br>`    `**cursor**: **pointer**;<br>}|

and the following **JavaScript** code:

|**link-buttons.js**|
| :-: |
|**function** *attachEvents*() {<br>`    `*// **TODO***<br>}|
### **Screenshots**

### **Hints**
- Use the **attachEventListener** function.

1. ## **Selectable Towns**
Create an HTML page which is listing **towns**. A town should be selectable. Clicking on a town should **select/deselect** it, a selected town should have the **data-selected** attribute added to it and its background color should be changed to **#DDD**. Also create a button **[Show Towns]** that prints the selected towns joined with a **", "**.

You are given the **HTML** and **CSS** in the **resources**. It comes together with the following **JavaScript** code:

|**select-towns.js**|
| :-: |
|**function** *attachEvents*() {<br>`    `*// **TODO***<br>}|
### **Screenshots**
###

1. ## **Countries Table**
You are given and HTML table holding **countries** and their **capitals**. You need to implement a **[Create]** link to create a new country and for each existing country implement **[Up]**, **[Down]** and **[Delete]** links to manipulate its position in the table.

The table needs to have the following entries when it’s initialized (**add them when your functions starts**):

**Bulgaria, Sofia**

**Germany, Berlin**

**Russia, Moscow**
### **HTML and JavaScript Code**
You are given the following **HTML** code:

|**countries.html**|
| :-: |
|<p><!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Countries Table</**title**></p><p>`    `<**link rel="stylesheet" href="styles.css"**></p><p>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**><br>`    `<**script src="initialize-table.js"**></**script**><br></**head**><br><**body**><br><**table id="countriesTable"**><br>`    `<**tr**><br>`        `<**th**>Country</**th**><br>`        `<**th**>Capital</**th**><br>`        `<**th**>Action</**th**><br>`    `</**tr**><br>`    `<**tr**><br>`        `<**td**><**input type="text" id="newCountryText"** /></**td**><br>`        `<**td**><**input type="text" id="newCapitalText"** /></**td**><br>`        `<**td**><**a href="#" id="createLink"**>[Create]</**a**></**td**><br>`    `</**tr**><br></**table**><br><**script**>$(() => *initializeTable*())</**script**><br></**body**><br></**html**></p>|

It comes together with the following **JavaScript** code:

|**initialize-table.js**|
| :-: |
|**function** *initializeTable*() {<br>`    `*// **TODO***<br>}|
### **Screenshots**



