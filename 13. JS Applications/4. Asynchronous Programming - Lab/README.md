# **Additional Recourses**
1. ## **Asynchronous programming**
- <https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Asynchronous>
1. ## **Promises Basic**
- <https://javascript.info/promise-basics>
1. ## **Async and Await**
- <https://hackernoon.com/understanding-async-await-in-javascript-1d81bb079b2c>
# **Lab: Asynchronous Programming**
Problems for exercises and homework for the ["JavaScript Applications" course @ SoftUni.](https://softuni.bg/trainings/2249/js-applications-march-2019) Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1570>.
1. ## **Github Commits**
Write a JS program that loads all commit messages and their authors from a github repository using a given HTML. 
### **HTML Template**
You are given the following HTML:

|**commits.html**|
| :-: |
|<p><!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Github Commits</**title**><br>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**></p><p>`    `<**style**></p><p>`        `**@import url(https://fonts.googleapis.com/css?family=Open+Sans)**;</p><p>`        `**body** {</p><p>`          `**font-family**: "Open Sans", serif;</p><p>`        `}</p><p>`        `**input[type=text**] {</p><p>`            `**padding**: **5px 10px**;</p><p>`            `**margin**: **8px 0**;</p><p>`            `**display**: **inline-block**;</p><p>`            `**border**: **1px solid #ccc**;</p><p>`            `**border-radius**: **4px**;</p><p>`        `}</p><p>`        `**button** {</p><p>`          `**background-color**: **#4caf50**;</p><p>`          `**color**: **white**;</p><p>`          `**padding**: **10px 14px**;</p><p>`          `**margin**: **8px 0**;</p><p>`          `**border**: **none**;</p><p>`          `**border-radius**: **4px**;</p><p>`          `**cursor**: **pointer**;</p><p>`        `}</p><p>`    `</**style**><br></**head**><br><**body**><br>`   `GitHub username:<br>`   `<**input type="text" id="username" value="nakov"** /> <**br**><br>`   `Repo: <**input type="text" id="repo" value="nakov.io.cin"**/><br>`   `<**button onclick="***loadCommits*()**"**>Load Commits</**button**><br>`   `<**ul id="commits"**></**ul**><br>`   `<**script**><br>`       `**function** *loadCommits*() {<br>`           `*//* **AJAX*** **call** *…* <br>`       `}<br>`   `</**script**><br></**body**><br></**html**></p>|

The **loadCommits()** function should get the **username** and **repository** from the **HTML** textboxes with ids **"username"** and **"repo"** and make a **GET** request to the **Github API**:
**"https://api.github.com/repos/<username>/<repository>/commits"**

Swap **<username>** and **<repository>** with the ones from the HTML:

- In case of **success**, for **each** entry add a **list item** (**li**) in the **unordered list** (**ul**) with **id="commits"** with text in the format:

**"<commit.author.name>: <commit.message>"** 

- In case of an **error**, add a single **list item** (**li**) with text in the format:
  **"Error: <error.status> (<error.statusText>)"**
### **Screenshots:**


Submit only the **loadCommits()** function in [Judge](https://judge.softuni.bg/Contests/1570) System.
1. ## **Blog**
Write a program for reading blog content. It needs to make **requests** to the **server** and display **all blog posts** and their **comments**. Use the following HTML to test your solution:

|**blog.html**|
| :-: |
|<p><!DOCTYPE **html**></p><p><**html**></p><p><**head**></p><p>`    `<**meta charset="UTF-8"**></p><p>`    `<**title**>Blog</**title**></p><p>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**></p><p>`    `<**style**></p><p>`    `**@import url(https://fonts.googleapis.com/css?family=Open+Sans)**;</p><p>`    `**body** {</p><p>`        `**font-family**: **'Open Sans'**, **serif**;</p><p>`    `}</p><p>`    `**select** {</p><p>`        `**padding**: **10px 15px**;</p><p>`        `**margin**: **8px 0**;</p><p>`        `**display**: **inline-block**;</p><p>`        `**border**: **1px solid #ccc**;</p><p>`        `**border-radius**: **4px**;</p><p>`    `}</p><p>`    `**button** {</p><p>`        `**background-color**: **#4CAF50**;</p><p>`        `**color**: **white**;</p><p>`        `**padding**: **10px 15px**;</p><p>`        `**margin**: **8px 0**;</p><p>`        `**border**: **none**;</p><p>`        `**border-radius**: **4px**;</p><p>`        `**cursor**: **pointer**;</p><p>`    `}</p><p>`    `</**style**></p><p></**head**></p><p><**body**></p><p>`    `<**h1**>All Posts</**h1**></p><p>`    `<**button id="btnLoadPosts"**>Load Posts</**button**></p><p>`    `<**select id="posts"**></**select**></p><p>`    `<**button id="btnViewPost"**>View</**button**></p><p>`    `<**h1 id="post-title"**>Post Details</**h1**></p><p>`    `<**ul id="post-body"**></**ul**></p><p>`    `<**h2**>Comments</**h2**></p><p>`    `<**ul id="post-comments"**></**ul**></p><p>`    `<**script src="solution.js"**></**script**></p><p>`    `<**script**></p><p>`       `*attachEvents*();</p><p>`    `</**script**></p><p></**body**></p><p></**html**></p>|

Submit only the **attachEvents()** function that attaches events to the buttons and contains all program logic. You will need to create a **Kinvey** **database** to test your code (instructions below).

The button with **id=**"**btnLoadPosts**" should make a **GET** request to "**/posts**". The **response** from the **server** will be an **array of objects** in the following format:

**{**

`  `**\_id: "postId",**

`  `**title: "postTitle",**

`  `**body: "postContent"** 

**}**

Create an **<option>** for each post using its **\_id** as value and **title** as text inside the node with **id="posts"**.

When the button with **id="btnViewPost"** is clicked, a **GET** request should be made to **"/posts/{postId}"** to obtain the selected post (from the dropdown menu with **id="posts"**) and another **request** to **"/comments/?query={"post\_id":"{postId}"}"** to obtain all comments. The **first request** will return **a single object** as described above, while the **second** will return an **array of objects** in the format:

**{** 

`  `**\_id: "commentId",**

`  `**text: "commentContent",**

`  `**post\_id: "postId"**

**}**

Display the post title inside **"#post-title"** and the post content inside **"#post-body"**. Display **each comment** as a **<li>** inside **"#post-comments"** and don’t forget to clear its content beforehand.

### **Hints**
- Create a **Kinvey database** with the required content.
- Then create a **user** and a **password**. You will need these, along with your **app ID** for authentication.
- Use the following **POST** request to **create** blog posts through **Postman**:

Note the **empty line** between the **header** and the **content** - the **request** **won’t work** without it. The authorization string consists of the **username** and **password** appended together with a **colon** between them, hashed with the **btoa()** function (built into the browser). The resulting post will have an **\_id** automatically assigned by Kinvey. You will then use this **ID** when creating comments for each blog post.

After the posts and comments are created, your database should look like this:




