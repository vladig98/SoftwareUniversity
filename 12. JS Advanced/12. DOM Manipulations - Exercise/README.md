
**Exercise: DOM Manipulations**

Problems for exercises and homework for the [“JavaScript Advanced” course @ SoftUni](https://softuni.bg/courses/javascript-advanced). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1550/Exercise-DOM-Manipulations>.

1. **Subtraction**

An HTML page holds **two text fields** with ids "**firstNumber**" and "**secondNumber**". Write a JS function to **subtract** the values from these text fields and display the result in the **div** named "**result**".

**HTML and JavaScript Code**

You are given the following **HTML** code:

|**subtract.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Subtraction</**title**><br></**head**><br><**body**><br><**div id="wrapper"**><br>`    `<**input type="text" id="firstNumber" value="13.33" disabled**><br>`    `<**input type="text" id="secondNumber" value="22.18" disabled**><br><br>`    `<**div id="result"**></**div**><br></**div**><br><**script src="subtract.js"**></**script**><br><**script**><br>`    `**window**.onload = **function** () {<br>`        `*subtract*();<br>`    `}<br></**script**><br></**body**><br></**html**>|

It comes together with the following **JavaScript** code:

|**subtract.js**|
| :-: |
|**function** *subtract*() {<br>`    `*// **TODO***<br>}|

Implement the above** to provide the following functionality: 

- Your function should take the values of "**firstNumber**" and "**secondNumber**", **convert** them to numbers, **subtract** the second number from the first one and then append the result to the **<div>** with **id="result"**.
- Your function should be able to work with **any 2 numbers** in the inputs, not only the ones given in the example.

**Example**

**Hints**

We see that the **textboxes** and the **div** have **id** attributes on them.

We can take the numbers directly from the input field by using the **getElementById()** function. After we have taken the elements from the DOM, it’s time to do the actual work. We get the values of the two **textboxes**, the value of a textbox, as one would expect, is **text**. In order to get a **number**, we need to use a function to **parse** **them**. 

All that’s left now is to append the result to the **div**. We use the same function to get the **result** element by id and change its **text content** to the result of the **subtraction.**

Our code is ready now. Submit **only** the **subtract()** function in judge. 

1. **Fill Dropdown**

Your task is to take values from **input** fields with **ids** **“newItemText”** and **“newItemValue”**.** Then you should create and append an **<option>** to the **<select>** with **id** **“menu”.**

**HTML and JavaScript Code**

You are given the following **HTML** code:

|**dropdown.html**|
| :-: |
|<p><!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Fill Dropdown</**title**></p><p>`    `<**script src="dropdown.js"**></**script**><br></**head**><br><**body**><br><**h1**>Dropdown Menu</**h1**><br><**div**><br>`    `<**select id="menu"**></**select**><br></**div**><br>`  `<**label for="newItemText"**>Text: </**label**><**input type="text" id="newItemText"** /><br>`  `<**label for="newItemValue"**>Value: </**label**><**input type="text" id="newItemValue"** /><br>`  `<**input type="button" value="Add" onclick="***addItem*()**"**><br></**body**><br></**html**></p>|

Again, you should create a separate **js** file called **dropdown.js.** In it you should have the following function:

|**dropdown.js**|
| :-: |
|**function** *addItem*() {<br>`    `*// **TODO***<br>}|

**Example**

**Hints**

- Your function should take the values of **newItemText** and **newItemValue**. After that you should create a new **option** element and set its **textContent** and its **value** to the newly taken ones. 
- Once you have done all of that, you should **append** the newly created **option** as a **child** to the **select** item with id **“menu”.**
- Finally, you should **clear** the value of the two **input** fields.
3. ## **Accordion**
An **html** file is given and your task is to show **more**/**less** information by clicking a **button** (it is not an actual button, but a **span** that has an **onlick** event attached to it). When **More** is clicked, it **reveals** the content of a **hidden** div and **changes** the text of the link to **Less**. When the same link is clicked **again** (now reading Less), **hide** the div and **change** the text of the link to More. Link action should be **toggleable** (you should be able to click the button infinite amount of times).

**HTML and JavaScript Code**

You are given the following **HTML** code:

|**accordion.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`  `<**meta charset="UTF-8"**><br>`  `<**title**>Accordion</**title**><br>`  `<**style**><br>`    `**#accordion** {<br>`      `**border**: 1**px solid black**;<br>`      `**display**: **inline-block**;<br>`      `**width**: 400**px**;<br>`    `}<br><br>`    `**#accordion p** {<br>`      `**margin**: 1**em**;<br>`    `}<br><br>    .**button** {<br>`      `**float**: **right**;<br>`      `**background**: **#5555ff**;<br>`      `**padding**: 0.1**em** 1**em** 0.1**em** 1**em**;<br>`      `**color**: **white**;<br>`      `**cursor**: **pointer**;<br>`    `}<br><br>`    `**#extra** {<br>`      `**display**: **none**;<br>`    `}<br><br>    .**head** {<br>`      `**background**: **#ccccff**;<br>`      `**padding**: 1**em**;<br>`    `}<br>`  `</**style**><br></**head**><br><**body**><br><**div id="accordion"**><br>`  `<**div class="head"**>DOM Manipulations Exercise <**span class="button" onclick="***toggle*()**"**>More</**span**></**div**><br>`  `<**div id="extra"**><br>`    `<**p**>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</**p**><br>`  `</**div**><br></**div**><br>`  `<**script**><br>`    `**function** *toggle*() {<br>`      `*// **TODO***<br>`    `}<br>`  `</**script**><br></**body**><br></**html**>|

**Example**


**Hints**

- To **change** the text content of a button, you could use **getElementsByClassName**. However, that returns a **collection** and we need only **one** element from it, so the correct way is to **use** **getElementsByClassName**(‘button’)[0] as it will return the needed span element.
- After that we should change the **display style** of the div with an id “**extra**”. If the display style is “**none**”, we should **change** it to “**block**” and the **opposite**.
- Along with all of this, we should **change** the text content of the **button** to **Less**/**More**.
4. **Sections**

You will receive an array of strings. For each string, create a **div** with a **paragraph** with the **string** in it. Each paragraph is initially **hidden (display:none)**. Add a **click** event listener to **each div** that **displays** the hidden paragraph. Finally, you should **append** all divs to the element with an id “**content**”.

**HTML and JavaScript Code**

You are given the following **HTML** code:

|**sections.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`  `<**meta charset="UTF-8"**><br>`  `<**title**>Sections</**title**><br>`  `<**style**><br>`    `**#content** {<br>`      `**width**: 1000**px**;<br>`    `}<br><br>`    `**#content div** {<br>`      `**float**: **left**;<br>`      `**width**: 300**px**;<br>`      `**height**: 300**px**;<br>`      `**margin**: 2**em**;<br>`      `**background**: **#5555ff**;<br>`      `**text-align**: **center**;<br>`    `}<br><br>`    `**#content div p** {<br>`      `**color**: **white**;<br>`      `**margin**: 6**em** 3**em** 6**em** 3**em**;<br>`    `}<br>`  `</**style**><br></**head**><br><**div id="content"**><br></**div**><br><**body onload="***create*([**'Section 1'**, **'Section 2'**, **'Section 3'**, **'Section 4'**]);**"**><br><**script**><br>`  `**function** *create*(sentences) {<br>`    `*// **TODO***<br>`  `}<br></**script**><br></**body**><br></**html**>|

**Example**

` `à 

4. **Notification**

Write a JS function that receives a string **message** and **displays** it inside a div with an id "**notification**" for 2 seconds. The div is initially **hidden** and when the function is called, it must be **shown**. After 2 seconds, **hide** the div. In the example below, a notification is shown when you click the button.

**HTML and JavaScript Code**

You are given the following **HTML** code:

|**notification.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`  `<**meta charset="UTF-8"**><br>`  `<**title**>Notification</**title**><br>`  `<**style**><br>`    `**body** { **width**: 600**px**; **text-align**: **center**; }<br>    .**header** {<br>`      `**background-color**: **#5555ff**;<br>`      `**color**: **white**;<br>`      `**position**: **relative**;<br>`      `**left**: 0;<br>`      `**top**: 0;<br>`      `**padding**: 0.5**em**;<br>`    `}<br>`    `**#container** {<br>`      `**position**: **relative**;<br>`    `}<br>    .**post** {<br>`      `**margin**: 48**px**;<br>`      `**text-align**: **left**;<br>`    `}<br>`    `**#notification** {<br>`      `**float**: **right**;<br>`      `**background**: **#119911**;<br>`      `**color**: **#ffffff**;<br>`      `**padding**: 0.5**em** 2**em** 0.5**em** 2**em**;<br>`      `**margin**: 1**em**;<br>`      `**display**: **none**;<br>`      `**position**: **absolute**;<br>`      `**top**: 0;<br>`      `**right**: 0;<br>`    `}<br>`  `</**style**><br></**head**><br><**body**><br><**div id="container"**><br>`  `<**header class="header"**><br>`    `<**h1**>Welcome to our site</**h1**><br>`  `</**header**><br>`  `<**div id="content"**><br>`    `<**article class="post"**><br>`      `<**p**>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</**p**><br>`      `<**p**>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</**p**><br>`    `</**article**><br>`    `<**button onclick="***notify*(**'Something happened!'**)**"**>Get notified</**button**><br>`  `</**div**><br>`  `<**div id="notification"**></**div**><br></**div**><br><**script**><br>`  `**function** *notify*(message) {<br>`    `*// **TODO***<br>`  `}<br></**script**><br></**body**><br></**html**>|

**Example**

When we click the “Get notified” **button**, a **div** appears in our upper-right corner. It should **disappear** in 2 seconds.

4. **Time Converter**

Create a JS program that converts different time units. Your task is to add a **click** event listener to **all** the buttons. When a button is **clicked**, read the **corresponding** input field, **convert** the value to the **three other** time units and **display** it in the input fields.

**HTML and JavaScript Code**

You are given the following **HTML** code:

|**timeConverter.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`  `<**meta charset="UTF-8"**><br>`  `<**title**>Time Converter</**title**><br>`  `<**script src="timeConverter.js"**></**script**><br>`  `<**style**><br>`    `**label**, **input** {<br>`      `**display**: **inline-block**;<br>`      `**width**: 5**em**;<br>`    `}<br>`    `**label** {<br>`      `**text-align**: **right**;<br>`    `}<br>`  `</**style**><br></**head**><br><**body onload="***attachEventsListeners*()**"**><br><**h1**>Time Converter</**h1**><br><**div**><br>`  `<**label for="days"**>Days: </**label**><br>`  `<**input type="text" id="days"**><br>`  `<**input id="daysBtn" type="button" value="Convert"**><br></**div**><br><**div**><br>`  `<**label for="hours"**>Hours: </**label**><br>`  `<**input type="text" id="hours"**><br>`  `<**input id="hoursBtn" type="button" value="Convert"**><br></**div**><br><**div**><br>`  `<**label for="minutes"**>Minutes: </**label**><br>`  `<**input type="text" id="minutes"**><br>`  `<**input id="minutesBtn" type="button" value="Convert"**><br></**div**><br><**div**><br>`  `<**label for="seconds"**>Seconds: </**label**><br>`  `<**input type="text" id="seconds"**><br>`  `<**input id="secondsBtn" type="button" value="Convert"**><br></**div**><br></**body**><br></**html**>|

You should have the following **timeConverter.js** file:

|**timeConverter.js**|
| :-: |
|**function** *attachEventsListeners*() {<br>`  `*// **TODO: attach click events to all buttons***<br>}|

**Example**

One day is equal to 24 hours/1440 minutes/86400 seconds. Whichever button we **click,** the input fields should **change** depending on the added value on the left. (For example, if we write 48 hours and click convert the days, the field value should change to 2).

4. **\* Distance Converter**

Your task is to convert from **one** distance unit to **another** by adding a **click** event listener to a button. When it is clicked, **read** the value from the input field and **get** the **selected** option from the **input** and **output** units drop downs. Then **calculate** and **display** the converted value in the **disabled** output field.

**HTML and JavaScript Code**

You are given the following **HTML** code:

|**distanceConverter.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`  `<**meta charset="UTF-8"**><br>`  `<**title**>Distance Converter</**title**><br>`  `<**script src="distanceConverter.js"**></**script**><br>`  `<**style**><br>`    `**label**, **input** {<br>`      `**display**: **inline-block**;<br>`      `**width**: 5**em**;<br>`    `}<br><br>`    `**label** {<br>`      `**text-align**: **right**;<br>`    `}<br>`  `</**style**><br></**head**><br><**body onload="***attachEventsListeners*()**"**><br><**h1**>Distance Converter</**h1**><br><**div**><br>`  `<**label for="inputDistance"**>From:</**label**><br>`  `<**input type="text" id="inputDistance"**><br>`  `<**select id="inputUnits"**><br>`    `<**option value="km"**>Kilometers</**option**><br>`    `<**option value="m"**>Meters</**option**><br>`    `<**option value="cm"**>Centimeters</**option**><br>`    `<**option value="mm"**>Millimeters</**option**><br>`    `<**option value="mi"**>Miles</**option**><br>`    `<**option value="yrd"**>Yards</**option**><br>`    `<**option value="ft"**>Feet</**option**><br>`    `<**option value="in"**>Inches</**option**><br>`  `</**select**><br>`  `<**input type="button" id="convert" value="Convert"**><br></**div**><br><**div**><br>`  `<**label for="outputDistance"**>To:</**label**><br>`  `<**input type="text" id="outputDistance" disabled="disabled"**><br>`  `<**select id="outputUnits"**><br>`    `<**option value="km"**>Kilometers</**option**><br>`    `<**option value="m"**>Meters</**option**><br>`    `<**option value="cm"**>Centimeters</**option**><br>`    `<**option value="mm"**>Millimeters</**option**><br>`    `<**option value="mi"**>Miles</**option**><br>`    `<**option value="yrd"**>Yards</**option**><br>`    `<**option value="ft"**>Feet</**option**><br>`    `<**option value="in"**>Inches</**option**><br>`  `</**select**><br></**div**><br></**body**><br></**html**>|

You should have the following **distanceConverter.js** file:

|**distanceConverter.js**|
| :-: |
|**function** *attachEventsListeners*() {<br>`  `*// **TODO: attach click event to convert button***<br>}|

Multiply the incoming distance by the following conversion rates to convert to meters. Divide to convert from meters to the required output unit.

**1 km = 1000 m**

**1 m = 1 m**

**1 cm = 0.01 m**

**1 mm = 0.001 m**

**1 mi = 1609.34 m**

**1 yrd = 0.9144 m**

**1 ft = 0.3048 m**

**1 in = 0.0254 m**

**Example**

**Hint**

To see which option is selected, read the properties of its parent: **value** gives you the value of the selected option (as displayed in the HTML), **selectedIndex** gives you the 0-based index of the selected option. For example, if miles are selected, **#inputUnits.value** is "**mi**", **#inputUnits.selectedIndex** is **4**. Option text is irrelevant.



