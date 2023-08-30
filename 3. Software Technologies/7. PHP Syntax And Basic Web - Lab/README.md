
# **Lab Exercise: Installing XAMPP and Configuring it with PhpStorm**
This document is a walkthrough through the process of **installing and configuring XAMPP**. After following all steps you will have fully configured XAMPP with PhpStorm integration.

This lab is part of the [“Software Technologies” course @ SoftUni](https://softuni.bg/courses/software-technologies).

**XAMPP** is a software package that bundles in a single package **PHP** + **Apache** + **MySQL** + **phpMyAdmin** + some other tools for PHP Web development in Windows environment.
# **Part I: Installing XAMPP and Configuring the Apache Server and MySQL Database**
This first part will show you how to **install XAMPP**, **start the Apache** server, and **create your first MySQL DB**.
1. ## **Downloading XAMPP**
Download XAMPP version 7.2.1 from <https://www.apachefriends.org/download.html>.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.001.png)

1. ## **Installing XAMPP**
The pictures below will show you the steps that you need to go through, in order to successfully install XAMPP.

Install XAMPP in the **default directory** (“**C:\xampp**”), or you might encounter permission troubles later on.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.002.png)

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.003.png)

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.004.png)

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.005.png)
1. ## **XAMPP First Start**
The first time you **start XAMPP** you will get **language selection screen** like this one:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.006.png)

After you choose the language you prefer, you will see the **main screen of XAMPP**:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.007.png)
1. ## **Start Apache Server**
Now we need to **start Apache server**:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.008.png)

If everything is correct, the Apache label will become green, and you will see the default **ports** – **80**. If you have **Skype** or a torrent client running, the Apache server **will not start**. You need to **exit the program that holds port 80**, and the Apache server will start.

# **Part II: Connect the Debugger, Apache Server and MySQL DB to PhpStorm**
This part will show you how to **configure XAMPP with PhpStorm**.
1. ## **Go to the PhpStorm Home Page**
If it’s the first time you start PhpStorm, it will be quite easy. You will start there. If you have started PhpStorm before, you need to either close your current project using **File** -> **Close Project** option or simply skip this step and go to **File** -> **Default** **Settings**. You should see this screen:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.009.png)

As you can see in the picture, we need to go to the settings menu.
1. ## **Install the PHP Debugger**
Once we are in the settings menu we need to go to **Languages & Frameworks** tab and select **PHP**. We need to change the **PHP** **version** to **PHP** **7.2**. 

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.010.png)

After that we need to change the **PHP  Interpreter**:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.011.png)

On the default interpreters page, we need to click the green plus and press **Local Path to Interpreter**.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.012.png)

After we do that, we will see this window:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.013.png)

We need to choose the **PHP Executable** now. In order to do that, we need to find our XAMPP folder and choose the ‘**php’** directory and in it select **php.exe**

.![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.014.png)

If everything is alright, you should see this:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.015.png)

Let’s give PhpStorm a break. We need to download a debugger. We will download Xdebug from here: <https://xdebug.org/files/php_xdebug-2.6.0-7.2-vc15.dll>. Place the downloaded file to “**C:\xampp\php\ext**”.

Now we need to **edit** the **php configuration**. Open the **php.ini** file located in “**C:\xampp\php\php.ini**”.

Once you open the file add the following lines: 

**[Xdebug]**

**zend\_extension = "C:\xampp\php\ext\php\_xdebug-2.6.0-7.2-vc15.dll"**

**xdebug.remote\_enable = 1**

**Restart XAMPP** and **run** the Apache and MySQL modules again.

If you’ve done everything correctly, you should see the following screen:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.016.png)

1. ## **Create PHP Debugger Configuration**
Before we configure the debugger, we need to return to the home screen and create new project

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.017.png)

Then we need to choose **Empty PHP project** and make sure that the location of our project is in **htdocs** folder in **xampp.** We will name it “**HelloWorld**”

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.018.png)

After that we need to create a new php file inside our **HelloWorld** project. Let’s name it **index![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.019.png)**

After we create the file we need to edit the configuration

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.020.png)

Choose a **PHP Web Page** (On old PHPStorm version it might be called **PHP Web Application**) on the drop down after you click the green plus.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.021.png)


Edit the Configuration Name and **add new server**.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.022.png)

Add new server with **Host = localhost**, on **port 80** with **Xdebug** debugger.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.023.png)

At last we need to select the newly created server, and edit the **URL**. In the URL part you need **to locate the file that you want to debug** starting from **localhost**. In the example below my file is in project **HelloWorld** with file name 

**Index.php**.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.024.png)

The result should be the following:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.025.png)

Now you are **ready** **to** **start** **using** PHP!
# **Lab: PHP Syntax, Basic Web**
Problems for exercises and homework for the [“Software Technologies” course @ SoftUni](https://softuni.bg/courses/software-technologies).

You can submit your solutions here <https://judge.softuni.bg/Contests/697/PHP-Basic-Syntax-Lab>.
1. ## **Hello, PHP!**
### Write PHP script to print "**Hello, PHP!**"
### **Examples**

|**Output**|
| :-: |
|Hello, PHP!|
### **Hints**
You solutin shoud have the following structure:

![C:\Users\Kalin\AppData\Local\Microsoft\Windows\INetCache\Content.Word\phpstorm64_2017-08-03_12-52-21.png](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.026.png)
1. ## **Numbers 1 to 20**
Wrete a PHP script, which prints the **numbers** from **1 to 20** in a list. Every number on **odd** line should be **blue** amd every number on **even** line should be **green**. The list should have the following structure

|<p>**<ul>**</p><p>`  `**<li><span style='color:blue'>1</span></li>**</p><p>`  `**<li><span style='color:green'>2</span></li>**</p><p>`  `**<li><span style='color:blue'>3</span></li>**</p><p>`  `**…**</p><p>**</ul>**</p>|
| :- |
### **Examples**

|**Output**|
| :-: |
|<p>![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.027.png)</p><p>*...*</p>|
1. ## **Color Palette**
Write a PHP script to print a **color** **palette** like shown below:

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.028.png)
### **Hints**
- Every <div> should have the following structure:

|<p>**<div style='background:rgb(0, 0, 0)'>rgb(0, 0, 0)</div>**</p><p>**<div style='background:rgb(0, 0, 51)'>rgb(0, 0, 51)</div>**</p><p>**…**</p><p>**<div style='background:rgb(0, 0, 255)'>rgb(0, 0, 255)</div>**</p><p>**<div style='background:rgb(0, 51, 0)'>rgb(0, 51, 0)</div>**</p>|
| :- |

- Add the following **.css** in the **<head>** section:

|<p>**div {**</p><p>`  `**display: inline-block;**</p><p>`  `**width: 150px;**</p><p>`  `**padding: 2px;**</p><p>`  `**margin: 5px;**</p><p>**}**</p>|
| :- |
1. ## **Hello, Person!**
Write a program which receives a **name** from a **form** and prints in the html the **following** **greeting** (after youy click on the **[Submit]** button). The **form** should **dissapear** after clicking the input.:

- **Hello, {name}!**

You shoud read the name from the following form:

|<**form**><br>`    `Name: <**input type="text" name="person"** /><br>`    `<**input type="submit"** /><br></**form**>|
| :- |
### **Examples**
![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.029.png)

1. ## **Dump an HTTP GET Request**
Write a PHP script to dump the **content** of the **HTTP GET** request parameters using **var\_dump(…)**. Dump the content of the following form: 

|<**form**><br>`    `<**div**>Name:</**div**><br>`    `<**input type="text" name="personName"**/><br>`    `<**div**>Age:</**div**><br>`    `<**input type="number" name="age"**/><br>`    `<**div**>Town:</**div**><br>`    `<**select name="townId"**><br>`        `<**option value="10"**>Sofia</**option**><br>`        `<**option value="20"**>Varna</**option**><br>`        `<**option value="30"**>Plodvid</**option**><br>`    `</**select**><br>`    `<**div**><**input type="submit"**/></**div**><br></**form**>|
| :- |
### **Examples**
![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.030.png)
1. ## **Sum Two Numbers**
Write a PHP script to sum two numbers. The script should display a HTML form to enter the numbers. If the numbers are passed as parameters, display their sum. You wii receive the input from the following form:

|<**form**><br>`    `<**div**>First Number:</**div**><br>`    `<**input type="number" name="num1"** /><br>`    `<**div**>Second Number:</**div**><br>`    `<**input type="number" name="num2"** /><br>`    `<**div**><**input type="submit"** /></**div**><br></**form**>|
| :- |
### **Examples** 
### ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.031.png)
1. ## **From Celsius to Fahrenheit and Vice Versa**
Write a PHP script to convert from Celsius to Fahrenheit (**0 °C = 32 °F**). 

- If you convert from Celsius to Fahrenheit print: 
  - “**{degreesCelsius} °C = {degreesFahrenheit} °F**”
- If you convert from Fahrenheit to Celsius print: 
  - “**{degreesFahrenheit} °F = {degreesCelsius} °C**”

The form you should use is the following:

|<**form**><br>`    `Celsius: <**input type="text" name="cel"** /><br>`    `<**input type="submit" value="Convert"**><br>`    `**<?=** $msgAfterCelsius **?>**<br></**form**><br><**form**><br>`    `Fahrenheit: <**input type="text" name="fah"** /><br>`    `<**input type="submit" value="Convert"**>**<br></**form**>|
| :- |
### **Examples**
![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.032.png)![C:\Users\Kalin\AppData\Local\Microsoft\Windows\INetCache\Content.Word\chrome_2017-08-04_15-32-55.png](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.033.png)

![C:\Users\Kalin\AppData\Local\Microsoft\Windows\INetCache\Content.Word\chrome_2017-08-04_15-30-47.png](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.034.png)
### **Hints**
- Use **&deg;** for the degrees sign - **°**
1. ## **Sort Lines**
Write a PHP script that **sorts** the **text** lines from a **<textarea>**. Take the input from the following form: 

|<**form**><br>`  `<**textarea rows="10" name="lines"**>**<?=** $sortedLines<br>`      `**?>**</**textarea**> <**br**><br>`    `<**input type="submit" value="Sort"**><br></**form**>|
| :- |
### ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.035.png)**Examples**
1. ## ` `**Extract Capital-Case Words**
Write a **PHP** script to extract all **capital-case** words from an **array** of **strings**. All **non-letter** chars are considered **separators**. Use the following form:

|<**form**><br>`    `<**textarea rows="10" name="text"**>**textarea**> <**br**><br>`    `<**input type="submit" value="Extract"**><br></**form**>|
| :- |
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>We start by HTML, CSS, JavaScript, JSON and REST.</p><p>Later we touch some PHP, MySQL and SQL.</p><p>Later we play with C#, EF, SQL Server and ASP.NET MVC.</p><p>Finally, we touch some Java, Hibernate and Spring.MVC.</p>|HTML, CSS, JSON, REST, PHP, SQL, C, EF, SQL, ASP, NET, MVC, MVC|

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.037.jpeg)

Page 18 of 18

Follow us:

© Software University Foundation ([softuni.org](http://softuni.org/)). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.042.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.043.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.044.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.045.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.046.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.047.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.048.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.049.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.050.png)   ![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.051.png)
![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.036.png)![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.038.png)![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.039.png)![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.040.png)![](Aspose.Words.908e0ee7-a565-4709-83aa-2ea434f5b6a7.041.png)
