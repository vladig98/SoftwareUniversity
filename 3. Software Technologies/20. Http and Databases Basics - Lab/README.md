
# **Lab: HTTP and Databases Basics**
Lab for the [“Software Technologies” course @ SoftUni](https://softuni.bg/courses/software-technologies).
1. # **Installing needed Software**
1. ## **Postman**
Download and install POSTMAN from [here](https://www.getpostman.com/apps).

1. ## **XAMPP with MySQL**
Download XAMPP from [here](https://www.apachefriends.org/index.html). 

You have to choose MySQL and phpMyAdmin, the other options are optional. We are going to need phpMyAdmin and PHP for PHP lessons. 

Don’t change the installation path!

After successful installation you can start XAMPP.
1. ## **HeidiSQL**
Download HeidiSQL from [here](https://www.heidisql.com/download.php).

You install it with Next – Next – Next.

After installing, before you run Heidi you should start MySQL server from XAMPP: 



After starting MySQL service, you can launch HeidiSQL:

If you have installed MySQL and have set a password, you should enter it.
1. # **Make basic HTTP requests**
1. ## **HTTP GET request**
Use Postman to make a simple GET request. Request some data from a resource.

Try to GET your favorite web site. 

Check the response. Is everything OK? 
1. ## <a name="_hlk508280670"></a>**GitHub Repos for Organization "Tech-Module-Jan-2018"**
First task is to list user's all public repositories. You will send a “**GET**” request to receive all the

Repositories.

**REQUEST**: <https://api.github.com/users/Tech-Module-Jan-2018/repos>

**RESPONSE**:

1. ## **GitHub: Labels Issue#1 (Tech-Module-Jan-2018/test-repo)**
Get the **first** issue from repository with **name** “test-repo”. Send a GET request to **https://api.github.com/repos/Tech-Module-Jan-2018/test-repo/issues/:id**, where :id is the issue. Try number 1.
1. ## **Github: Create Issue**
This time we have to **create** an issue (data should be **send** to the server). Send a “**POST**” request to the server with the following JSON as **body** (send it as **application/json**):

You need to use your GitHub **account credentials** to submit issues. Under the Authorization tab, select Basic and enter your username and password. Send the request to the URI from the previous task, but without the **:id**.
1. # **Create a database**
1. ## **Create a database**
Using HeidiSQL, create a database "softuni".


1. ## **Add table**
Create new table "students".


Add two columns Name and Age. Choose the datatype you need for each column. See different types here: 
<https://dev.mysql.com/doc/refman/5.7/en/data-types.html>
1. ## **Add record**
Now add a record to the newly created table.

Select Data tab and the green plus sign. Now you`ve added new record in our students table. Enter your name and age and press ctrl + Enter to post or press the green tick sign in the menu

1. ## **Remove table**
To remove table, press Drop table in the menu.

You won’t be able to restore any information, so be careful when you drop tables and databases.
1. ## **Remove database**
To remove the database, press Drop, after right clicking on the database. You will lose all information and objects in the database. So be careful what you drop.



