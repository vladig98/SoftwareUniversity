# **Exercises: Asynchronous Programming and Promises**
Problems for exercises and homework for the ["JavaScript Applications" course @ SoftUni](https://softuni.bg/trainings/2249/js-applications-march-2019) Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1571>.
1. ## **Forecaster**
Write a JS program that requests a weather report from a server and displays it on the user. Use the following HTML to test your code:

|**schedule.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`  `<**meta charset="UTF-8"**><br>`  `<**title**>Forecaster</**title**><br>`  `<**style**><br>`    `**#content** { **width**: 400**px**; }<br>`    `**#request** { **text-align**: **center**; }<br>    .**bl** { **width**: 300**px**; }<br>`    `**#current** { **text-align**: **center**; **font-size**: 2**em**; }<br>`    `**#upcoming** { **text-align**: **center**; }<br>    .**condition** { **text-align**: **left**; **display**: **inline-block**; }<br>    .**symbol** { **font-size**: 4**em**; **display**: **inline-block**; }<br>    .**forecast-data** { **display**: **block**; }<br>    .**upcoming** { **display**: **inline-block**; **margin**: 1.5**em**; }<br>    .**label** { **margin-top**: 1**em**; **font-size**: 1.5**em**; **background-color**: **aquamarine**; **font-weight**: 400; }<br>`  `</**style**><br>`  `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**><br></**head**><br><**body**><br><**div id="content"**><br>`  `<**div id="request"**><br>`    `<**input id="location" class='bl' type="text"**><br>`    `<**input id="submit" class="bl" type="button" value="Get Weather"**><br>`  `</**div**><br>`  `<**div id="forecast" style="display:none"**><br>`    `<**div id="current"**><br>`      `<**div class="label"**>Current conditions</**div**><br>`    `</**div**><br>`    `<**div id="upcoming"**><br>`      `<**div class="label"**>Three-day forecast</**div**><br>`    `</**div**><br>`  `</**div**><br></**div**><br><**script src="forecaster.js"**></**script**><br><**script**><br>`  `*attachEvents*();<br></**script**><br></**body**><br></**html**>|

Submit only the **attachEvents()** function that attaches events to the **button** with ID "**submit**" and holds all program logic.

When the user writes the name of a location and clicks “**Get Weather**”, make a **GET** request to the server at address **https://judgetests.firebaseio.com/locations.json**. The response will be an array of objects, with structure:

**{ name: locationName,**

`  `**code: locationCode }**

Find the object, corresponding to the name the user submitted in the input field with ID "**location**" and use its **code** value to make two more requests:

- For current conditions, make a **GET** request to **https://judgetests.firebaseio.com/forecast/today/{code}.json** (replace the highlighted part with the relevant value). The response from the server will be an object as follows:

**{ name: locationName,**

`  `**forecast: { low: temp,**

`              `**high: temp,**

`              `**condition: condition } }**

- For a 3-day forecast, make a **GET** request to **https://judgetests.firebaseio.com/forecast/upcoming/{code}.json** (replace the highlighted part with the relevant value). The response from the server will be an object as follows:

**{ name: locationName,**

`  `**forecast: [{ low: temp,**

`               `**high: temp,**

`               `**condition: condition }, … ] }**

Use the information from these two objects to compose a forecast in HTML and insert it inside the page. Note that the **<div>** with ID "**forecast**" must be set to **visible**. See the examples for details.

If an error occurs (the server doesn’t respond or the location name cannot be found) or the data is not in the correct format, display "Error" in the forecast section.

Use the following codes for the weather sumbols:

- Sunny			**&#x2600;** // ☀
- Partly sunny	             **&#x26C5;** // ⛅
- Overcast		**&#x2601;** // ☁
- Rain			**&#x2614;** // ☂
- Degrees		**&#176;**   // °
### **Examples**
When the app starts, the forecast div is hidden. When the user enters a name and clicks submit, the requests being.

### **Hints**
The server at the address listed above will respond with valid data for location names "London", "New York" and "Barcelona".
1. ## **Fisher Game**
Create an application at **kinvey.com** Create a collection **biggestCatches(angler, weight, species, location, bait, captureTime)** to hold information about the largest fish caught.

- **angler** - string representing the name of the person who caught the fish
- **weight** - floating point number representing the weight of the fish in kilograms
- **species** - string representing the name of the fish species
- **location** - string representing the location where the fish was caught
- **bait** - string representing the bait used to catch the fish
- **captureTime** - integer number representing the time needed to catch the fish in minutes
### **HTML Template**
You are given an HTML template to test your code, your task is to attach handlers to the **[Load]**, **[Update]**, **[Delete]** and **[Add]** buttons, which make the appropriate **GET**, **PUT**, **DELETE** and **POST** requests respectively. 

|**catch.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Biggest Catch</**title**><br>`    `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**><br>`    `<**script src="catch.js"**></**script**><br>`    `<**style**><br>`        `**h1** { **text-align**: **center**; }<br>`        `**input** { **display**: **block**; }<br>`        `**div** { **border**: 1**px solid black**; **padding**: 5**px**; **display**: **inline-table**; **width**: 24%; }<br>`        `**div#aside** { **margin-top**: 8**px**; **width**: 15%; **border**: 2**px solid grey**; }<br>`        `**div#catches**{ **width**:**auto**; }<br>`        `**button** { **display**: **inline-table**; **margin**: 5% 0 5% 5%; **width**: 39%; }<br>`        `**button**.**add** { **width**: 90%; }<br>`        `**button**.**load** { **width**: 90%; **padding**: 10**px**; }<br>`        `**button**.**load** { **vertical-align**: **top**; }<br>`        `**fieldset** { **display**: **inline-table**; **vertical-align**: **top**; }<br>`        `**fieldset#main** { **width**: 70%; }<br>`    `</**style**><br></**head**><br><**body**><br><**h1**>Biggest Catches</**h1**><br><**fieldset id="main"**><br>`    `<**legend**>Catches</**legend**><br>`    `<**div id="catches"**><br>`        `<**div class="catch" data-id="<id-goes-here>"**><br>`            `<**label**>Angler</**label**><br>`            `<**input type="text" class="angler" value="Paulo Amorim"**/><br>`            `<**label**>Weight</**label**><br>`            `<**input type="number" class="weight" value="636"**/><br>`            `<**label**>Species</**label**><br>`            `<**input type="text" class="species" value="Atlantic Blue Marlin"**/><br>`            `<**label**>Location</**label**><br>`            `<**input type="text" class="location" value="Vitória, Brazil"**/><br>`            `<**label**>Bait</**label**><br>`            `<**input type="text" class="bait" value="trolled pink"**/><br>`            `<**label**>Capture Time</**label**><br>`            `<**input type="number" class="captureTime" value="80"**/><br>`            `<**button class="update"**>Update</**button**><br>`            `<**button class="delete"**>Delete</**button**><br>`        `</**div**><br>`    `</**div**><br></**fieldset**><br><**div id="aside"**><br>`    `<**button class="load"**>Load</**button**><br>`    `<**fieldset id="addForm"**><br>`        `<**legend**>Add Catch</**legend**><br>`        `<**label**>Angler</**label**><br>`        `<**input type="text" class="angler"**/><br>`        `<**label**>Weight</**label**><br>`        `<**input type="number" class="weight"**/><br>`        `<**label**>Species</**label**><br>`        `<**input type="text" class="species"**/><br>`        `<**label**>Location</**label**><br>`        `<**input type="text" class="location"**/><br>`        `<**label**>Bait</**label**><br>`        `<**input type="text" class="bait"**/><br>`        `<**label**>Capture Time</**label**><br>`        `<**input type="number" class="captureTime"**/><br>`        `<**button class="add"**>Add</**button**><br>`    `</**fieldset**><br></**div**><br><**script**>*attachEvents*()</**script**><br></**body**><br></**html**>|

You are given an example catch in the template to show you where and how you should insert the catches. Notice that the **div** containing the catch has an attribute **data-id** that should store the **\_id** of the entry given by Kinvey. 

Kinvey will automatically create the following REST services to access your data:

- **List All Catches**
  - Endpoint: [https://baas.kinvey.com/appdata/\[:appId\]/biggestCatches](https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches)
  - Method: GET
  - Headers: 
    - Basic Authorization with **user credentials**
  - Returns (JSON)
- **Create a New Catch**
  - Endpoint: [https://baas.kinvey.com/appdata/\[:appId\]/biggestCatches](https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches)
  - Method: POST
  - Headers:
    - Basic Authorization with **user credentials**
    - Content-type: application/json
  - Request body (JSON): **{"angler":"…", "weight":…, "species":"…", "location":"…", "bait":"…", "captureTime":…}**
- **Update a Catch**
  - Endpoint: **[https://baas.kinvey.com/appdata/\[:appId\]/biggestCatches/\[:catchId\]](https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches/%5b:catchId%5d)**
  - Method: PUT
  - Headers:
    - Basic Authorization with **user credentials**
    - Content-type: application/json
  - Request body (JSON): **{"angler":"…", "weight":…, "species":"…", "location":"…", "bait":"…", "captureTime":…}**
- **Delete a Catch**
  - Endpoint: [https://baas.kinvey.com/appdata/\[:appId\]/biggestCatches/\[:catchId\]](https://baas.kinvey.com/appdata/%5b:appId%5d/biggestCatches/%5b:catchId%5d)
  - Method: DELETE
  - Headers:
    - Basic Authorization with **user credentials**
    - Content-type: application/json

Pressing the **[Load]** button should list all catches, pressing a catch's **[Update]** button should send a **PUT** requests updating that catch in kinvey.com. Pressing a catch's **[Delete]** button should delete the catch both from kinvey and from the page. Pressing the **[Add]** button should submit a new catch with the values of the inputs in the Add fieldset.
### **Screenshots**


# **Extra tasks**
The following tasks don't have automated tests in the Judge system, they are for practicing.
1. ## **Create "Books" REST Service**
Register at **kinvey.com** and create an application. Create a class **Book(title, author, isbn)** to hold book objects. Fill a few sample books:

kinvey.com will automatically create the following REST services to access your data:

- **List All Books**
  - Endpoint: [https://baas.kinvey.com/apdata/\[:appId\]/books](https://baas.kinvey.com/apdata/%5b:appId%5d/books)
  - Method: GET
  - Headers: 
    - Basic Authorization with **user credentials**
  - Returns (JSON)
- **Create a New Book**
  - Endpoint: [https://baas.kinvey.com/apdata/\[:appId\]/books](https://baas.kinvey.com/apdata/%5b:appId%5d/books)
  - Method: POST
  - Headers:
    - Basic Authorization with **user credentials**
    - Content-type: application/json
  - Request body (JSON): {"title":"…", "author":"…", "isbn":"…"}
- **Update a Book**
  - Endpoint: [https://baas.kinvey.com/apdata/\[:appId\]/books/\[:bookId\]](https://baas.kinvey.com/apdata/%5b:appId%5d/books/%5b:bookId%5d) 
  - Method: PUT
  - Headers:
    - Basic Authorization with **user credentials**
    - Content-type: application/json
  - Request body (JSON): {"title":"…", "author":"…", "isbn":"…"}
- **Delete a Book**
  - Endpoint: [https://baas.kinvey.com/apdata/\[:appId\]/books/\[:bookId\]](https://baas.kinvey.com/apdata/%5b:appId%5d/books/%5b:bookId%5d)
  - Method: DELETE
  - Headers:
    - Basic Authorization with **user credentials**
    - Content-type: application/json

To view your kinvey.com access keys, go to your application dashboard à upper-left:

Test your REST Service, e.g. using **Postman** Chrome Extension (<http://www.getpostman.com>). Try to list all books in JSON format with an HTTP GET request to the REST API of kinvey.com.

## **List All Books**
Create a HTML5 project consisting of HTML, CSS and JS files. Add an AJAX call that takes all books from your application in kinvey.com as JSON object and displays them at page load.
## **Create a Book**
Add a HTML form with submit button for adding a new book. When the button is pressed, create a new book at kinvey.com using its REST API with an AJAX request.
## **Edit a Book**
Implement "Edit a Book" functionality. Clicking on a book should load its data in a HTML form. By clicking the submit button, the book data at kinvey.com should be updated at the server side with and AJAX request.
## **Delete a Book**
Implement "Delete a Book" functionality. Each book should have "Delete" button. Clicking on it should delete the book at the server side with and AJAX request to the REST service.
## **\* Add Tags for Each Book**
Implement tags for the books. Tags should be stored at kinvey.com in the Book class in a column "**tags**" as arrays of strings. List the tags for each book. Implement add / edit / delete for tags when a book is created / updated.
# **Practice**
The following tasks don't have automated tests in the Judge system, you are expected to check the problems yourself.
1. ## **Students** 
Your task is to create functionality for creating and listing students from a database in Kinvey.

Here are the Kinvey application key and secret:

- APP KEY: **kid\_BJXTsSi-e**
- APP SECRET: **447b8e7046f048039d95610c1b039390**

Here is also a test user for you to log in with:

- Username: **guest**
- Password: **guest**

There is collection called **students**.

The student entity has:

- **ID** – a number, **non-empty**
- **FirstName** – a String, **non-empty**
- **LastName** – a String, **non-empty**
- **FacultyNumber** – a String of **numbers**, **non-empty**
- **Grade** – a number, **non-empty**

You need to write functionality for creating students. When you are creating a new student, make sure you name these properties perfectly. Create at least one student to test your code.

You will also need to extract the students. You will be given an **HTML template** with a table in it. Create an AJAX request which extracts all the students. Upon fetching all the students from Kinvey, add them to the table each on a new row, **sorted** in **ascending order** by **ID**.

|**students.html**|
| :-: |
|<!DOCTYPE **html**><br><**html lang="en"**><br><**head**><br>`    `<**meta charset="UTF-8"**><br>`    `<**title**>Shit</**title**><br>`    `<**script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"**></**script**><br>`    `<**style**><br>`        `**#results** {<br>`            `**background-color**: **#FFFFFF**;<br>`            `**display**: **flex**;<br>`            `**flex-direction**: **column**;<br>`            `**text-align**: **center**;<br>`        `}<br><br>`        `**#results tr** {<br>`            `**background-color**: **#AAAAAA**;<br>`            `**padding**: 5**vh**;<br>`            `**font-size**: 1.5**vw**;<br>`        `}<br><br>`        `**#results tr**:**nth-child**(**odd**) {<br>`            `**background-color**: **#808080**;<br>`        `}<br><br>`        `**#results tr**:**first-child** {<br>`            `**background-color**: **#000000**;<br>`            `**color**: **#FFFFFF**;<br>`            `**font-weight**: **bold**;<br>`            `**font-size**: 2**vw**;<br>`        `}<br><br>`        `**#results tr th** {<br>`            `**padding**: 1**vw**;<br>`        `}<br><br>`        `**#results tr td** {<br>`            `**padding**: 1**vw**;<br>`            `**transition**: **font-size** 0.2**s**;<br>`        `}<br><br>`        `**#results tr**:**not**(:**first-child**):**hover** {<br>`            `**background-color**: **#F0F8FF**;<br>`            `**color**: **#000000**;<br>`            `**font-size**: 2.25**vw**;<br>`        `}<br><br>`    `</**style**><br></**head**><br><**body**><br><**table id="results"**><br>`    `<**tr**><br>`        `<**th**>ID</**th**><br>`        `<**th**>First Name</**th**><br>`        `<**th**>Last Name</**th**><br>`        `<**th**>Faculty Number</**th**><br>`        `<**th**>Grade</**th**><br>`    `</**tr**><br></**table**><br>*<!--<script src="script.js"></script>-->*<br></**body**><br></**html**>|
### **Screenshots**


1. ## **Countries & Towns**
### **Create a Backend at kinvey.com**
Register at **kinvey.com**, create an application and two classes: **Country(name)** and **Town(name, country)**. Fill sample data for further use. Submit in the homework screenshots of your classes from kinvey.com.
### **List Countries**
Create a JavaScript application (HTML + CSS + JS + jQuery) that loads and displays all countries from your application at Kinvey.com into a HTML page.
### **Edit Countries**
Extend the previous application with add / edit / delete for countries.
### **List Towns by Country**
Extend the previous application to show all towns when a certain country is selected.
### **CRUD Towns**
Extend the previous application to implement add / edit / delete for towns.
1. ## **Venuemaster**
Write a JS program that displays information about venues and allows the user to buy a ticket. Use the following HTML to test your code:

|**venuemaster.html**|
| :-: |
|<p><!DOCTYPE **html**></p><p><**html lang="en"**></p><p><**head**></p><p>`  `<**meta charset="UTF-8"**></p><p>`  `<**title**>Venue Master</**title**></p><p>`  `<**script src="https://code.jquery.com/jquery-3.1.1.min.js"**></**script**></p><p>`  `<**style**></p><p>`    `**#content** { **width**: 800**px**; }</p><p>    .**venue** { **border**: 1**px solid black**; **margin**: 0.5**em**; }</p><p>    .**venue-name** { **background-color**: **beige**; **padding**: 0.1**em**; **display**: **block**; **font-size**: 2**em**; **padding-left**: 1**em**; }</p><p>    .**venue-name input** { **margin-right**: 1**em**; }</p><p>    .**head** { **background-color**: **beige**; **padding**: 0.1**em**; **padding-left**: 1.5**em**; **display**: **block**; **font-size**: 1.5**em**; }</p><p>    .**description** { **margin**: 2**em**; }</p><p>`    `**table** { **text-align**: **center**; **margin**: 2**em**; }</p><p>`    `**td**, **th** { **width**: 100**px**; }</p><p>    .**purchase-info span** { **display**: **inline-block**; **width**: 100**px**; **margin-left**: 2**em**; **margin-right**: 2**em**; }</p><p>    .**ticket** { **border**: 1**px solid black**; **text-align**: **center**; **overflow**: **hidden**; }</p><p>    .**bl** { **display**: **inline-block**; **font-size**: 1.5**em**; **margin**: 1**em** 3**em** 1**em** 3**em**; }</p><p>    .**left** { **width**: 600**px**; **float**:**left**; }</p><p>    .**right** { **float**:**right**; }</p><p>`  `</**style**></p><p></**head**></p><p><**body**></p><p><**div id="content"**></p><p>`  `<**div id="date-control"**></p><p>`    `<**input type="text" id="venueDate" placeholder="Enter date"**></p><p>`    `<**input type="button" id="getVenues" value="List Venues"**></p><p>`  `</**div**></p><p>`  `<**div id="venue-info"**></p><p>`  `</**div**></p><p></**div**></p><p><**script src="venuemaster.js"**></**script**></p><p><**script**></p><p>`  `*attachEvents*();</p><p></**script**></p><p></**body**></p><p></**html**></p>|

Submit only the **attachEvents()** function that attaches events and holds all program logic.

You can use the following Kinvey database and credentials to test your solution:

**App ID: kid\_BJ\_Ke8hZg**

**User: guest**

**Password: pass**

You can consult previous lectures about making requests to Kinvey databases: [Asynchronous Programming](https://softuni.bg/downloads/svn/js-core/Sept-2016/JS-Apps-Nov-2016/4.%20JS-Apps-Async-Programming-Promises/4.%20JS-Apps-Async-Programming-and-Promises.pptx). Note that certain requests are made to **rpc/** instead of **appdata/** – take care when copy/pasting code!

When the user clicks on the **button** with ID "**getVenues**", take the value of the input field with ID "**venueDate**" and make a **POST** request to **rpc/kid\_BJ\_Ke8hZg/custom/calendar?query={date}** (replace the highlighted part with the relevant value). The server will respond with and **array**, containing the IDs of available venues for that date. Use those IDs to obtain information from the server about **each** of the venues – make a **GET** request to **appdata/kid\_BJ\_Ke8hZg/venues/{\_id}** (replace the highlighted part with the relevant value). The server will respond with an object in the following format:

**{ name: *String*,**

`  `**description: *String*,**

`  `**startingHour: *String*,**

`  `**price: *Number* }**

Compose a list with all venues and display it on the page inside the **<div>** with ID "**venue-info**". Use the following HTML to format the results:

|**Venue Template**|
| :-: |
|<p><**div class="venue" id="{venue.\_id}"**></p><p>`  `<**span class="venue-name"**><**input class="info" type="button" value="More info"**>**{venue.name}**</**span**></p><p>`  `<**div class="venue-details" style="display**: **none**;**"**></p><p>`    `<**table**></p><p>`      `<**tr**><**th**>Ticket Price</**th**><**th**>Quantity</**th**><**th**></**th**></**tr**></p><p>`      `<**tr**></p><p>`        `<**td class="venue-price"**>**{venue.price}** lv</**td**></p><p>`        `<**td**><**select class="quantity"**></p><p>`          `<**option value="1"**>1</**option**></p><p>`          `<**option value="2"**>2</**option**></p><p>`          `<**option value="3"**>3</**option**></p><p>`          `<**option value="4"**>4</**option**></p><p>`          `<**option value="5"**>5</**option**></p><p>`        `</**select**></**td**></p><p>`        `<**td**><**input class="purchase" type="button" value="Purchase"**></**td**></p><p>`      `</**tr**></p><p>`    `</**table**></p><p>`    `<**span class="head"**>Venue description:</**span**></p><p>`    `<**p class="description"**>**{venue.description}**</**p**></p><p>`    `<**p class="description"**>Starting time: **{venue.startingHour}**</**p**></p><p>`  `</**div**></p><p></**div**></p>|

` `Each item in the list has a button "**More info**", that changes the visibility of the detailed description for the corresponding venue – hide all descriptions (set style to "**display: none**") and show the current description (set style to "**display: block**"). The detailed view has a numeric drop-down and a button "**Buy tickets**". When this button is clicked, take the user to the confirmation page – change the contents of the "**#venue-info**" div, using the following HTML:

|**Confirmation Template**|
| :-: |
|<p><**span class="head"**>Confirm purchase</**span**></p><p><**div class="purchase-info"**></p><p>`  `<**span**>**{name}**</**span**></p><p>`  `<**span**>**{qty}** x **{price}**</**span**></p><p>`  `<**span**>Total: **{qty \* price}** lv</**span**></p><p>`  `<**input type="button" value="Confirm"**></p><p></**div**></p>|

The final step is the confirmation of the purchase – when the user clicks on the button with ID "**confirm**", make a **POST** request to **rpc/kid\_BJ\_Ke8hZg/custom/purchase?venue={\_id}&qty={qty}** – the server will return an object, containing an HTML fragment in it’s html property. Display that fragment inside "**#venue-info**" along with the text "**You may print this page as your ticket**".
### **Hints**
The service at the given address will respond with valid information for dates "23-11", "24-11", "25-11", "26-11" and "27-11", in this exact format. Use these to test your solution (no validation is required).
### **Examples**





1. ## **\*\*\*Secret Knock**
Your task is to perform the Secret Knock. The Secret Knock is a secret knocking technique that is performed with requests, responses and promises. First, you will use **Kinvey**. 

The app credentials are:

- App id / key: **kid\_BJXTsSi-e**
- App secret: **447b8e7046f048039d95610c1b039390**

The guest user is:

- Username: **guest**
- Password: **guest**

You will need to log in before you perform any kind of action. Next you will have to send various requests **with queries**. Now a query is a list of parameters added to the URL of the request. Here is the base URL for the requests:

**https://baas.kinvey.com/appdata/kid\_BJXTsSi-e/knock**

And now you have to add the first query, which is “Knock Knock.” to the URL. Do it like this:

**https://baas.kinvey.com/appdata/kid\_BJXTsSi-e/knock?query=Knock Knock.**

If you send a **GET request** to this URL with this query, you will receive a response with an **answer** from the server, and the **next message**. Change the **query** with the **next message** in line, and continue this process until you receive a response **with no next message**. Print the **answer** and the **next message** after each successful request on the console, and you’ll be able to see the magic of the Secret Knock.
1. ## **Wild Wild West**
Write the REST services for a simple Western game. Create a collection **players(name, money, bullets)** to hold information about the players in the game.

- **name** - string representing the name of the current player.
- **money** - integer number representing the current player’s money.
- **bullets** - integer number representing the current bullets of the player.
### **HTML and JS**
You will be provided with a skeleton project containing an HTML template and some JS files, the **loadCanvas.js** is simple implementation for the game, your job is to attach events to all the buttons and make the needed AJAX requests. You are provided with a file to write your code:

|**attachEvents.js**|
| :-: |
|**function** *attachEvents*() {<br>`   `*//**TODO***<br>}|

When the page is loaded a **GET** request should be sent to the server to get all players and load them in the **#players div**, an example entry is left in the HTML to demonstrate the HTML representation of a player and his placement.

Whenever the **[Save]** button is pressed the progress of the current player (if there is one) should be saved (a **PUT** request sent to the server with the new data), the **canvas** and buttons **[Save]** and **[Reload]** should be hidden and the **clearInterval** should be called on the **canvas.intervarId** property (used for the main loop of the game).

Whenever the **[Reload]** button is pressed the player’s money should be **reduced by 60** and his bullets should be **set to 6**.

Whenever the **[Add Player]** button is clicked a new Player with the name specified in the corresponding input should be created and the players should be reloaded to display the new entry. Each new player starts with **500 Money** and **6 bullets**. 

Pressing the **[Play]** button on a player should first call the **[Save]** button, then display the **canvas**, **[Save]** and **[Reload]** buttons and after that call the **loadCanvas** function (from the loadCanvas.js) and pass to it the **new player** as an **object** (containing properties **name**, **money** and **bullets**).

When a player’s **[Delete]** button is pressed the player should be deleted (both from the HTML and from the server).
### **Examples**






