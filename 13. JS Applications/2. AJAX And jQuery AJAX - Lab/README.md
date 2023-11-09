# **Lab: AJAX & jQuery AJAX**
Problems for in-class lab for the [“JavaScript Applications” course @ SoftUni](https://softuni.bg/courses/js-apps). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1568/Lab-AJAX>.
1. ## **XHR (XmlHttpRequest)**
Your task is to **write** a JS function that **loads** a GitHub repository **asynchronously with AJAX**. 

- Create a file called **"xhr.js"** and write the function **loadRepos()** in it. If you take a closer look at the provided skeleton, you will see that this file is linked in the head section. 
- **Create** an instance of **XmlHttpRequest** and attach an **onreadystatechange** event to it.
- Replace the text content of a **div** element with **id="res"** with the value of the **responseText** property of the request when the **readyState** attribute reaches a value of **4** (it is ready). 
- **Do NOT format** the response in any way. Submit your **loadRepos()** function. 

Read more about **XmlHttpRequest** [**here**](https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/open). 
### **Skeleton**

|**xmlHttpRequest.html**|
| :-: |
|<p>**<!DOCTYPE html>**</p><p>**<html lang="en">**</p><p>**<head>**</p><p>`    `**<meta charset="UTF-8">**</p><p>`    `**<title>XmlHttpRequest Example</title>**</p><p>`    `**<script src="xhr.js"></script>**</p><p>`    `**<style>**</p><p>`      `**@import url(https://fonts.googleapis.com/css?family=Open+Sans);**</p><p>`      `**body {**</p><p>`        `**font-family: "Open Sans", serif;**</p><p>`      `**}**</p><p>`      `**button {**</p><p>`        `**background-color: #4caf50;**</p><p>`        `**color: white;**</p><p>`        `**padding: 14px 20px;**</p><p>`        `**margin: 8px 0;**</p><p>`        `**border: none;**</p><p>`        `**border-radius: 4px;**</p><p>`        `**cursor: pointer;**</p><p>`      `**}**</p><p>`      `**button:hover {**</p><p>`        `**background-color: #45a049;**</p><p>`      `**}**</p><p>`    `**</style>**</p><p>**<*/*head>**</p><p>**<body>**</p><p>**<button onclick="loadRepos()">Load Repos</button>**</p><p>**<div id="res"></div>**</p><p>**</body>**</p><p>**</html>**</p>|
### **Example**

1. ## **AJAX Load**
Use **jQuery** to **write** a JS function that loads an online resource into a div with **id="text".** Make a request to "**text.html**" and replace the target div element's content with the returned **HTML**. Create the files **ajax-load.html** and **text.html** and place them in the same folder, so that your script can find them.

Submit your **loadTitle()** function.
### **Skeleton**

|**ajax-load.html**|
| :-: |
|<p>**<!DOCTYPE html>**</p><p>**<html lang="en">**</p><p>**<head>**</p><p>`    `**<meta charset="UTF-8">**</p><p>`    `**<title>AJAX Load Example</title>**</p><p>`    `**<script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>**</p><p>`    `**<style>**</p><p>`      `**@import url(https://fonts.googleapis.com/css?family=Open+Sans);**</p><p>`      `**body {**</p><p>`        `**font-family: "Open Sans", serif;**</p><p>`      `**}**</p><p>`      `**button {**</p><p>`        `**background-color: #4caf50;**</p><p>`        `**color: white;**</p><p>`        `**padding: 14px 20px;**</p><p>`        `**margin: 8px 0;**</p><p>`        `**border: none;**</p><p>`        `**border-radius: 4px;**</p><p>`        `**cursor: pointer;**</p><p>`      `**}**</p><p>`      `**button:hover {**</p><p>`        `**background-color: #45a049;**</p><p>`      `**}**</p><p>`    `**</style>**</p><p>**</head>**</p><p>**<body>**</p><p>**<div id="text">**</p><p>`    `**<h1>AJAX jQuery.load()</h1>**</p><p>`    `**<button onclick="loadTitle()">Load Title</button>**</p><p>**</div>**</p><p>**</body>**</p><p>**</html>**</p>|


|**text.html**|
| :-: |
|<p>**<h1>Voilla!</h1>**</p><p>**<p>I am a text loaded with AJAX request</p>**</p>|


|**ajax-load.js**|
| :-: |
|<p>**function loadTitle() {**</p><p>`  `***// TODO***</p><p>**}**</p>|
### **Example**

1. ## **Github Repos**
Your task is to **write** a JS function that **executes** an **AJAX** request with **jQuery** and loads all user **GitHub repositories** by a given username (taken from an input field with **id="username"**) into a **list** (each repository as a **list-item**) with **id="repos"**. Use the properties **full\_name** and **html\_url** of the returned objects to create a link to each repo's GitHub page. If an **error** occurs (like 404 "Not Found"), **append** to the list a list-item with **text** "Error" instead. Clear the contents of the list before any new content is appended. See the **highlighted lines** of the skeleton for formatting details of each list item. Submit your **loadRepos()** function that should be created in a file called "**loadRepos.js**".
### **Skeleton**

|**github-repos.html**|
| :-: |
|<p>**<!DOCTYPE html>**</p><p>**<html lang="en">**</p><p>**<head>**</p><p>`    `**<meta charset="UTF-8">**</p><p>`    `**<title>GitHub Repos</title>**</p><p>`    `**<script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>**</p><p>`    `**<script src="loadRepos.js"></script>**</p><p>`          `**<style>**</p><p>`      `**@import url(https://fonts.googleapis.com/css?family=Open+Sans);**</p><p>`      `**body {**</p><p>`        `**font-family: "Open Sans", serif;**</p><p>`      `**}**</p><p>`      `**button {**</p><p>`        `**background-color: #4caf50;**</p><p>`        `**color: white;**</p><p>`        `**padding: 14px 20px;**</p><p>`        `**margin: 8px 0;**</p><p>`        `**border: none;**</p><p>`        `**border-radius: 4px;**</p><p>`        `**cursor: pointer;**</p><p>`      `**}**</p><p>`      `**input[type=text] {**</p><p>`         `**padding: 12px 20px;**</p><p>`         `**margin: 8px 0;**</p><p>`         `**display: inline-block;**</p><p>`         `**border: 1px solid #ccc;**</p><p>`         `**border-radius: 4px;**</p><p>`      `**}**</p><p>`    `**</style>**</p><p>**</head>**</p><p>**<body>**</p><p>**GitHub username:**</p><p>**<input type="text" id="username" value="k1r1L" />**</p><p>**<button onclick="loadRepos()">Load Repos</button>**</p><p>**<ul id="repos">**</p><p>`  `**<li>**</p><p>`    `**<a href="*{repo.html\_url}*">**</p><p>`      `***{repo.full\_name}***</p><p>`    `**</a>**</p><p>`  `**</li>**</p><p>**</ul>**</p><p>**</body>**</p><p>**</html>**</p>|
### **Example**

1. ## **Phonebook**
Use **Firebase** and **jQuery** to create a simple phonebook app. The user should be able to see all contacts, **loaded** from the server, **create** a new contact and **delete** any of the contacts. Use the lecture presentation for detailed instructions on this task. Place your code in a file called "phonebook.js", as shown in the skeleton. This task is not evaluated by Judge, it is for practice only.
### **Skeleton**

|**phonebook.html**|
| :-: |
|<p>**<!DOCTYPE html>**</p><p>**<html lang="en">**</p><p>**<head>**</p><p>`  `**<meta charset="UTF-8">**</p><p>`  `**<title>Phonebook</title>**</p><p>`  `**<script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>**</p><p>`     `**<style>**</p><p>`      `**@import url(https://fonts.googleapis.com/css?family=Open+Sans);**</p><p>`      `**body {**</p><p>`        `**font-family: "Open Sans", serif;**</p><p>`      `**}**</p><p>`      `**button {**</p><p>`        `**background-color: #4caf50;**</p><p>`        `**color: white;**</p><p>`        `**padding: 14px 20px;**</p><p>`        `**margin: 8px 0;**</p><p>`        `**border: none;**</p><p>`        `**border-radius: 4px;**</p><p>`        `**cursor: pointer;**</p><p>`      `**}**</p><p>`      `**input[type=text] {**</p><p>`         `**padding: 12px 20px;**</p><p>`         `**margin: 8px 0;**</p><p>`         `**display: inline-block;**</p><p>`         `**border: 1px solid #ccc;**</p><p>`         `**border-radius: 4px;**</p><p>`      `**}**</p><p>`    `**</style>**</p><p>**</head>**</p><p>**<body>**</p><p>`  `**<h1>Phonebook</h1>**</p><p>`  `**<ul id="phonebook"></ul>**</p><p>`  `**<button id="btnLoad">Load</button>**</p><p>`  `**<h2>Create Contact</h2>**</p><p>`  `**Person: <input type="text" id="person" />**</p><p>`  `**<br>**</p><p>`  `**Phone: <input type="text" id="phone" />**</p><p>`  `**<br>**</p><p>`  `**<button id="btnCreate">Create</button>**</p><p>`  `**<script src="phonebook.js"></script>**</p><p>**</body>**</p><p>**</html>**</p>|
### **Example**




