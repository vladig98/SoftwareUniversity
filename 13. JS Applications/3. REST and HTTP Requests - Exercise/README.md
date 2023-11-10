# **Exercises: AJAX and jQuey AJAX** 
Problems for exercises and homework for the ["JavaScript Applications" course @ SoftUni](https://softuni.bg/courses/javascript-applications). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1569/Exercise-AJAX-and-jQuery-AJAX>.
1. ## **Bus Stop**
Write a JS program that displays arrival times for all buses by a given bus stop ID when a button is clicked. Use the following HTML template to test your code:

|**buses.html**|
| :-: |
|<p><!DOCTYPE **html**></p><p><**html lang="en"**></p><p><**head**></p><p>`  `<**meta charset="UTF-8"**></p><p>`  `<**title**>Bus Stop</**title**></p><p>`  `<**style**></p><p>`        `**@import url(https://fonts.googleapis.com/css?family=Open+Sans);**</p><p>`        `**input[type=text] {**</p><p>`            `**padding: 12px 20px;**</p><p>`            `**margin: 8px 0;**</p><p>`            `**display: inline-block;**</p><p>`            `**border: 1px solid #ccc;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**box-sizing: border-box;**</p><p>`        `**}**</p><p>`        `**input[type=button] {**</p><p>`            `**background-color: #4CAF50;**</p><p>`            `**color: white;**</p><p>`            `**padding: 10px 16px;**</p><p>`            `**border: none;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**cursor: pointer;**</p><p>`        `**}**</p><p>`        `**input[type=button]:hover {**</p><p>`            `**background-color: #45a049;**</p><p>`        `**}**</p><p>`        `**body {**</p><p>`            `**margin: auto;**</p><p>`            `**width: 25%;**</p><p>`            `**text-align: center;**</p><p>`            `**padding: 20px;**</p><p>`            `**font-family: 'Open Sans', serif;**</p><p>`        `**}**</p><p>`        `**#stopName {**</p><p>`            `**font-size: 1.5em;**</p><p>`            `**margin: 8px 0;**</p><p>`            `**font-weight: 400;**</p><p>`            `**padding: 0.25em;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**background-color: aquamarine;**</p><p>`        `**}**</p><p>**    </**style**>**  </p><p><**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**></p><p></**head**></p><p><**body**></p><p><**div id="stopInfo" style="width**:20**em"**></p><p>`  `<**div**></p><p>`    `<**label for="stopId"**>Stop ID: </**label**></p><p>`    `<**input id="stopId" type="text"**></p><p>`    `<**input id="submit" type="button" value="Check" onclick="***getInfo*()**"**></**div**></p><p>`  `<**div id="result"**></p><p>`    `<**div id="stopName"**></**div**></p><p>`    `<**ul id="buses"**></**ul**></p><p>`  `</**div**></p><p></**div**></p><p><**script**></p><p>`  `**function** *getInfo*() {</p><p>`    `*// **TODO ...***</p><p>`  `}</p><p></**script**></p><p></**body**></p><p></**html**></p>|

When the button with ID **'submit'** is clicked, the name of the bus stop appears and the list bellow gets filled with all the buses that are expected and their time of arrival. Take the **value** of the input field with id **'stopId'**. Submit a **GET** request to **https://judgetests.firebaseio.com/businfo/{*stopId*}.json** (replace the highlighted part with the correct value) and parse the response:

**stopId: {**

`  `**name: stopName,**

`  `**buses: { busId: time, … }**

**}**

Place the name property as text inside the div with ID **'stopName'** and each bus as a list item with text:

**"Bus {busId} arrives in {time} minutes"**

Replace all highlighted parts with the relevant value from the response. If the request is **NOT** successful, or the information is not in the expected format, display **"Error"** as **stopName** and nothing in the list. The list should be cleared before every request is sent.

Submit only the **getInfo()** function.
### **Examples**


When the button is clicked, the results are displayed in the corresponding elements:


If an error occurs, the stop name changes to Error:

### **Hints**
The webhost will respond with valid data to IDs 1287, 1308, 1327 and 2334.
1. ## **Bus Schedule**
Write a JS program that tracks the progress of a bus on it's route and announces it inside an info box. The program should display which is the upcoming stop and once the bus arrives, to request from the server the name of the next one. Use the following HTML to test your solution:


|**schedule.html**|
| :-: |
|<p><!DOCTYPE **html**></p><p><**html lang="en"**></p><p><**head**></p><p>`  `<**meta charset="UTF-8"**></p><p>`  `<**title**>Bus Schedule</**title**></p><p>**      <**style**></p><p>`        `**@import url(https://fonts.googleapis.com/css?family=Open+Sans);**</p><p>`        `**input[type=text] {**</p><p>`            `**padding: 12px 20px;**</p><p>`            `**margin: 8px 0;**</p><p>`            `**display: inline-block;**</p><p>`            `**border: 1px solid #ccc;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**box-sizing: border-box;**</p><p>`        `**}**</p><p>`        `**input[type=button] {**</p><p>`            `**padding: 10px 16px;**</p><p>`            `**border: none;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**cursor: pointer;**</p><p>`        `**}**</p><p>`        `**body {**</p><p>`            `**margin: auto;**</p><p>`            `**width: 25%;**</p><p>`            `**text-align: center;**</p><p>`            `**padding: 20px;**</p><p>`            `**font-family: 'Open Sans', serif;**</p><p>`        `**}**</p><p>`        `**#schedule {**</p><p>`            `**text-align: center;**</p><p>`            `**width: 400px;**</p><p>`        `**}**</p><p>`        `**input {**</p><p>`            `**width: 120px;**</p><p>`        `**}**</p><p>`        `**#info {**</p><p>`            `**background-color: aquamarine;**</p><p>`            `**border: 1px none black;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**margin: 0.25em;**</p><p>`        `**}**</p><p>`        `**.info {**</p><p>`            `**font-size: 1.5em;**</p><p>`            `**padding: 0.25em;**</p><p>`        `**}**</p><p>**    </**style**>**  </p><p><**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**></p><p></**head**></p><p><**body**></p><p><**div id="schedule"**></p><p>`  `<**div id="info"**><**span class="info"**>Not Connected</**span**></**div**></p><p>`  `<**div id="controls"**></p><p>`    `<**input id="depart" value="Depart" type="button" onclick="*result***.depart()**"**></p><p>`    `<**input id="arrive" value="Arrive" type="button" onclick="*result***.arrive()**" disabled="true"**></p><p>`  `</**div**></p><p></**div**></p><p><**script**></p><p>`  `**function** *solve*() {</p><p>`    `*// **TODO ...***</p><p>*    **return** {</p><p>`      `*depart*,</p><p>`      `*arrive*</p><p>*    };</p><p>`  `}</p><p>`  `let ***result*** = *solve*();</p><p></**script**></p><p></**body**></p><p></**html**></p>|

The bus has two states - **moving** and **stopped**. When it is **stopped**, only the button "**Depart**" is **enabled**, while the info box shows the name of the **current** stop. When it is **moving**, only the button "**Arrive**" is **enabled**, while the info box shows the name of the **upcoming** stop. Initially, the info box shows "**Not Connected**" and the "**Arrive**" button is **disabled**. The ID of the first stop is "**depot**".

When the "**Depart**" button is clicked, make a **GET** request to the server with the ID of the current stop to address **https://judgetests.firebaseio.com/schedule/{currentId}.json** (replace the highlighted part with the relevant value). As a response, you will receive a JSON object in the following format:

**stopId {**

`  `**name: stopName,**

`  `**next: nextStopId**

**}**

Update the info box with the information from the response, disable the "Depart" button and enable the "Arrive" button. The info box text should look like this (replace the highlighted part with the relevant value):

**"Next stop {stopName}"**

When the [**Arrive**] button is clicked, update the text, disable the [**Arrive**] button and enable the [**Depart**] button. The info box text should look like this (replace the highlighted part with the relevant value):

**"Arriving at {stopName}"**

Clicking the buttons successfully will cycle through the entire schedule. If invalid data is received, show "**Error**" inside the info box and **disable** both buttons.

Submit only the **solve()** function that returns an object, containing the two click event handlers for **depart()** and **arrive()**, as shown in the sample HTML.
### **Examples**
Initially, the info box shows "Not Connected" and the arrive button is disabled.

When Depart is clicked, a request is made with the first ID. The info box is updated with the new information and the buttons are changed: 

Clicking [**Arrive**], changes the info box and swaps the buttons. This allows [**Depart**] to be clicked again, which makes a new request and updates the information:


1. ## **Messenger**
Write a JS program that records and displays messages. The user can **post** a message, supplying a name and content and retrieve all currently recorded messages. Use the following HTML to test your code: 

|**messenger.html**|
| :-: |
|<p><!DOCTYPE **html**></p><p><**html lang="en"**></p><p><**head**></p><p>`  `<**meta charset="UTF-8"**></p><p>`  `<**title**>Messenger</**title**></p><p>`  `<**style**></p><p>`    `**@import url(<https://fonts.googleapis.com/css?family=Open+Sans>);**</p><p>`        `**body {**</p><p>`            `**margin: auto;**</p><p>`            `**width: 25%;**</p><p>`            `**text-align: center;**</p><p>`            `**padding: 20px;**</p><p>`            `**font-family: 'Open Sans', serif;**</p><p>`        `**}**</p><p>`        `**input[type=text] {**</p><p>`            `**padding: 12px 20px;**</p><p>`            `**margin: 8px 0;**</p><p>`            `**display: inline-block;**</p><p>`            `**border: 1px solid #ccc;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**box-sizing: border-box;**</p><p>`        `**}**</p><p>`        `**input[type=button] {**</p><p>`            `**background: #4CAF50;**</p><p>`            `**color: white;**</p><p>`            `**padding: 10px 16px;**</p><p>`            `**border: none;**</p><p>`            `**border-radius: 4px;**</p><p>`            `**cursor: pointer;**</p><p>`            `**display: block;**</p><p>`        `**}**</p><p>`        `**input[type=button]:hover {**</p><p>`            `**background: #45a049;**</p><p>`        `**}**</p><p>`        `**label {**</p><p>`            `**display: inline-block;**</p><p>`            `**width: 5em;**</p><p>`        `**}**</p><p>`        `**#author, #content {**</p><p>`            `**width: 30em;**</p><p>`        `**}**</p><p>`        `**#controls {**</p><p>`            `**width: 38em;**</p><p>`        `**}**</p><p>`        `**#submit, #refresh {**</p><p>`            `**display: inline-block;**</p><p>`        `**}**</p><p>`        `**#submit {** </p><p>`            `**margin: 32px;**</p><p>`        `**}**</p><p>`  `</**style**></p><p>`  `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**></p><p></**head**></p><p><**body**></p><p><**div id="main"**></p><p>`  `<**textarea id="messages" cols="80" rows="12" disabled="true"**></**textarea**></p><p>`  `<**div id="controls"**></p><p>`    `<**label for="author"**>Name: </**label**><**input id="author" type="text"**><**br**></p><p>`    `<**label for="content"**>Message: </**label**><**input id="content" type="text"**></p><p>`    `<**input id="submit" type="button" value="Send"**></p><p>`    `<**input id="refresh" type="button" value="Refresh"**></p><p>`  `</**div**></p><p></**div**></p><p><**script src="solution.js"**></**script**></p><p><**script**></p><p>`    `*attachEvents*();</p><p></**script**></p><p></**body**></p><p></**html**></p>|

Submit the **attachEvents()** function that attaches event listeners to the buttons and contains all program logic.

You will need to create the database yourself - use **Firebase** and set the access rules to be public, so that anyone can post a message and read what's been posted. Since Firebase objects are by default sorted **alphabetically**, you'll need to keep a **timestamp** property so they can be ordered by **most recently** posted instead. Use the following message structure:

**{**

`  `**author: authorName,**

`  `**content: msgText,**

`  `**timestamp: time**

**}**

The key associated with each message object is **NOT** important - when making a **POST** request with the message object as parameter, Firebase will **automatically** assign a random key. To get started, you can create a "**messenger**" entry in your Firebase and import the following **JSON** object:

|**messenger.json**|
| :-: |
|<p>**{**</p><p>`  `**"-KWi2\_-QHxL1yov93j5i" : {**</p><p>`    `**"author" : "George",**</p><p>`    `**"content" : "Hey, guys!",**</p><p>`    `**"timestamp" : 1479315195400**</p><p>`  `**},**</p><p>`  `**"-KWi2aENk0utP8BLnhi6" : {**</p><p>`    `**"author" : "Marry",**</p><p>`    `**"content" : "Whats up?",**</p><p>`    `**"timestamp" : 1479315200447**</p><p>`  `**},**</p><p>`  `**"-KWi3eFIUZbh8Z3OjZEB" : {**</p><p>`    `**"author" : "George",**</p><p>`    `**"content" : "Not much, how about you?",**</p><p>`    `**"timestamp" : 1479315479039**</p><p>`  `**},**</p><p>`  `**"-KWiX5ixY39AqdD2hJzV" : {**</p><p>`    `**"author" : "LJ",**</p><p>`    `**"content" : "LEEEEROOOY JEEEEENKIIINS",**</p><p>`    `**"timestamp" : 1479323197569**</p><p>`  `**}**</p><p>**}**</p>|
### **Examples**


### **Hints**
To get a useable timestamp, you can use **Date.now()** - this will return the number of milliseconds since 1<sup>st</sup> of January 1970. The exact value is irrelevant, what's important is, it will be greater for messages that are posted later. We can then sort them by this value.

To create a new entry in Firebase, type its name in the address box and click Go:


You can then import content with the button in the upper right corner:


Put the sample data inside a file with extension **.json** and select it from the popup.

1. ## **Phonebook**
Write a JS program that can **load**, **create** and **delete** entries from a Phonebook. You will be given an HTML template to which you should bind the needed functionality. 
### **HTML Template**
You are given the following HTML:

|**phonebook.html**|
| :-: |
|<p><!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Phonebook</**title**><br>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**></p><p>`    `<**link rel="stylesheet" type="text/css" href="style.css"**></p><p>**<style><br>@import url(<https://fonts.googleapis.com/css?family=Open+Sans>);**</p><p>**body {<br>`    `font-family: 'Open Sans',serif;<br>}<br>input[type=text] {<br>`    `padding: 12px 20px;<br>`    `margin: 8px 0;<br>`    `display: inline-block;<br>`    `border: 1px solid #ccc;<br>`    `border-radius: 4px;<br>`    `box-sizing: border-box; }<br>button {<br>`    `background-color: #4CAF50;<br>`    `color: white;<br>`    `padding: 14px 20px;<br>`    `margin: 8px 0;<br>`    `border: none;<br>`    `border-radius: 4px;<br>`    `cursor: pointer;<br>}<br>button:hover {<br>`    `background-color: #45a049;<br>}<br></style>**<br></**head**><br><**body**><br>`    `<**h1**>Phonebook</**h1**><br>`    `<**ul id="phonebook"**></**ul**><br>`    `<**button id="btnLoad"**>Load</**button**><br><br>`    `<**h2**>Create Contact</**h2**><br>`    `Person: <**input type="text" id="person"**/><br>`    `<**br**><br>`    `Phone: <**input type="text" id="phone"**/><br>`    `<**br**><br>`    `<**button id="btnCreate"**>Create</**button**><br>`    `<**script src="phonebook.js"**></**script**><br>`    `<**script**><br>`        `*attachEvents*();<br>`    `</**script**><br></**body**><br></**html**></p>|

When the **[Load]** button is clicked, a **GET** request should be made to the server to get all phonebook entries. Each received entry should be in a **li** inside the **ul** with **id="phonebook"** in the following format with text **"<person>: <phone> "** and a **[Delete]** button attached. Pressing the **[Delete]** button should send a **DELETE** request to the server and delete the entry. The received response will be an object in the following format:
**"{<key>:{person:<person>, phone:<phone>}, <key2>:{person:<person2>, phone:<phone2>,…}"** where **<key>** is an unique key given by the server and **<person>** and **<phone>** are the actual values.

When the **[Create]** button is clicked, a new **POST** request should be made to the server with the information from the [**Person**] and [**Phone**] textboxes, they should be **cleared** and the Phonebook should be automatically **reloaded** (like if the **[Load]** button was pressed).

The data sent on a **POST** request should be a valid **JSON** object, containing properties **person** and **phone.** Example format: 
**{**

**"person": "<person>",**

**"phone": "<phone>"
}**

The **URL** to which your program should make requests is:

**'https://phonebook-nakov.firebaseio.com/phonebook'**

**GET** and **POST** requests should go to **https://phonebook-nakov.firebaseio.com/phonebook.json**, while **DELETE** requests should go to **https://phonebook-nakov.firebaseio.com/phonebook/<key>.json**, where **<key>** is the unique key of the entry (you can find out the **key** from the key property in the **GET** request)

**You may create your own app** in Firebase, the submitted code **will work** with any database from the same domain.
### **Screenshots:**

Submit in the Judge only the **attachEvents()** function.

|**phonebook.js**|
| :-: |
|**function** *attachEvents*() {<br>`   `*//**TODO***<br>}|




