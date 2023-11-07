
# **Lab: Classes**
Problems for exercises and homework for the [“JavaScript Advanced” course @ SoftUni](https://softuni.bg/trainings/2081/js-advanced-october-2018). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1533>.
# **Classes**
1. ## **Rectangle**
Write a JS **class** for a rectangle object. It needs to have a **width** (Number), **height** (Number) and **color** (String) properties, which are set from the constructor and a **calcArea()** method, that calculates and **returns** the rectangle’s area.
### **Input**
The constructor function will receive valid parameters.
### **Output**
The **calcArea()** method should **return** a number.

Submit the class definition as is, **without** wrapping it in any function.
### **Examples**

|**Sample Input**|**Output**|
| :-: | :-: |
|<p>**let rect = new Rectangle(4, 5, 'red');**</p><p>**console.log(rect.width);**</p><p>**console.log(rect.height);**</p><p>**console.log(rect.color);**</p><p>**console.log(rect.calcArea());**</p>|<p></p><p>**4**</p><p>**5**</p><p>**Red**</p><p>**20**</p>|
1. ## **Person**
Write a JS **class** that represents a personal record. It has the following properties, all set from the constructor:

- **firstName**
- **lastName**
- **age**
- **email**

And a method **toString()**, which prints a summary of the information. See the example for formatting details.
### **Input**
The constructor function will receive valid parameters.
### **Output**
The **toString()**method should **return** a string.

Submit the class definition as is, **without** wrapping it in any function.

### **Examples**

|**Sample Input**|
| :-: |
|<p>**let person = new Person('Maria', 'Petrova', 22, 'mp@yahoo.com');**</p><p>**console.log(person.toString());**</p>|
|**Output**|
|**Maria Petrova (age: 22, email: mp@yahoo.com)**|
1. ## **Get Persons**
Write a JS function that returns an array of Person objects. Use the class from the previous task, create the following instances, and return them in an array:

For any empty cells, do not supply a parameter (call the constructor with less parameters).
### **Input / Output**
There will be **no input**, the data is static and matches the table above. As **output**, **return an array** with Person **instances**.

Submit a function that returns the required output.
1. ## **Circle**
Write a JS **class** that represents a **Circle**. It has only one data property – it’s **radius**, and it is set trough the **constructor**. The class needs to have **getter** and **setter** methods for its **diameter** – the setter needs to calculate the radius and change it and the getter needs to use the radius to calculate the diameter and return it.

The circle also has a getter **area()**, which calculates and **returns** its area.
### **Input**
The constructor function and diameter setter will receive valid parameters.
### **Output**
The **diameter()** and **area()** getters should **return** numbers.

Submit the class definition as is, **without** wrapping it in any function.
### **Examples**

|**Sample Input**|**Output**|
| :-: | :-: |
|<p>**let c = new Circle(2);**</p><p>**console.log(`Radius: ${c.radius}`);**</p><p>**console.log(`Diameter: ${c.diameter}`);**</p><p>**console.log(`Area: ${c.area}`);**</p><p>**c.diameter = 1.6;**</p><p>**console.log(`Radius: ${c.radius}`);**</p><p>**console.log(`Diameter: ${c.diameter}`);**</p><p>**console.log(`Area: ${c.area}`);**</p>|<p></p><p>**2**</p><p>**4**</p><p>**12.566370614359172**</p><p></p><p>**0.8**</p><p>**1.6**</p><p>**2.0106192982974678**</p>|
1. ## **Point Distance**
Write a JS **class** that represents a **Point**. It has **x** and **y** coordinates as properties, that are set through the constructor, and a **static method** for finding the distance between two points, called **distance()**.
### **Input**
The **distance()** method should receive two **Point** objects as parameters.
### **Output**
The **distance()** method should **return** a number, the distance between the two point parameters.

Submit the class definition as is, **without** wrapping it in any function.
### **Examples**

|**Sample Input**|**Output**|
| :-: | :-: |
|<p>**let p1 = new Point(5, 5);**</p><p>**let p2 = new Point(9, 8);**</p><p>**console.log(Point.distance(p1, p2));**</p>|<p></p><p></p><p>**5**</p>|
1. ## **Cards**
You need to write an **IIFE** that results in an object containing two properties **Card** which is a class and **Suits** which is an object that will hold the possible suits for the cards.

The **Suits** object should have exactly these 4 properties:

- **SPADES**: ♠
- **HEARTS**: ♥
- **DIAMONDS**: ♦
- **CLUBS**: ♣

Where the key is **SPADES**, **HEARTS** e.t.c. and the value is the actual symbol ♠, ♥ and so on.

The **Card** class should allow for creating cards, each card has 2 properties **face** and **suit**. The **valid** faces are the following **["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"]** any other are considered invalid.

The **Card** class should have **setters** and **getters** for the **face** and **suit** properties, when creating a card or setting a property validations should be performed, if an invalid face or a suit not in the **Suits** object is passed an **Error** should be **thrown**.
### **Code Template**
You are required to write and submit an **IIFE** which results in an object containing the above-mentioned **Card** and **Suits** as properties. Here is an example template you can use: 

|**cards.js**|
| :-: |
|<p>(**function**(){</p><p><br>`    `*// **TODO***</p><p>*<br>`    `**return** {<br>`        `**Suits**:***Suits***,<br>`        `**Card**:***Card***<br>`    `}<br>}())</p>|
### **Screenshot**
An example usage should look like this:

# **Unit testing on Classes**
1. ## **String Builder**
You are given the following **JavaScript class**:

|**string-builder.js**|
| :-: |
|**class** StringBuilder {<br>`  `constructor(string) {<br>`    `**if** (string !== ***undefined***) {<br>`      `StringBuilder.*\_vrfyParam*(string);<br>`      `**this**.**\_stringArray** = Array.from(string);<br>`    `} **else** {<br>`      `**this**.**\_stringArray** = [];<br>`    `}<br>`  `}<br><br>`  `append(string) {<br>`    `StringBuilder.*\_vrfyParam*(string);<br>`    `**for**(**let** i = 0; i < string.**length**; i++) {<br>`      `**this**.**\_stringArray**.push(string[i]);<br>`    `}<br>`  `}<br><br>`  `prepend(string) {<br>`    `StringBuilder.*\_vrfyParam*(string);<br>`    `**for**(**let** i = string.**length** - 1; i >= 0; i--) {<br>`      `**this**.**\_stringArray**.unshift(string[i]);<br>`    `}<br>`  `}<br><br>`  `insertAt(string, startIndex) {<br>`    `StringBuilder.*\_vrfyParam*(string);<br>`    `**this**.**\_stringArray**.splice(startIndex, 0, ...string);<br>`  `}<br><br>`  `remove(startIndex, length) {<br>`    `**this**.**\_stringArray**.splice(startIndex, length);<br>`  `}<br><br>`  `**static** *\_vrfyParam*(param) {<br>`    `**if** (**typeof** param !== **'string'**) **throw new TypeError**(**'Argument must be string'**);<br>`  `}<br><br>`  `toString() {<br>`    `**return this**.**\_stringArray**.join(**''**);<br>`  `}<br>}|
### **Functionality**
The above code defines a **class** that holds **characters** (strings with length 1) in an array. An **instance** of the class should support the following operations:

- Can be **instantiated** with a passed in **string** argument or **without** anything
- Function **append(string)** – **converts** the passed in **string** argument to an **array** and adds it to the **end** of the storage
- Function **prepend**(**string**) – **converts** the passed in **string** argument to an **array** and adds it to the **beginning** of the storage
- Function **insertAt(string, index)** – **converts** the passed in **string** argument to an **array** and adds it at the **given** index (there is **no** need to check if the index is in range)
- Function **remove(startIndex, length)** – **removes** elements from the storage, starting at the given index (**inclusive**), **length** number of characters (there is **no** need to check if the index is in range)
- Function **toString()** – **returns** a string with **all** elements joined by an **empty** string
- All passed in **arguments** should be **strings.** If any of them are **not**, **throws** a type **error** with the following message: "**Argument must be a string**"
### **Examples**
This is an example how this code is **intended to be used**:

<table><tr><th colspan="1" valign="top"><b>Sample code usage</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Corresponding output</b></th></tr>
<tr><td colspan="1" valign="top"><b>let</b> str = <b>new</b> StringBuilder(<b>'hello'</b>);<br>str.append(<b>', there'</b>);<br>str.prepend(<b>'User, '</b>);<br>str.insertAt(<b>'woop'</b>,5 );<br><b>console</b>.log(str.toString());<br>str.remove(6, 3);<br><b>console</b>.log(str.toString());</td><td colspan="1" valign="top"><p>User,woop hello, there</p><p>User,w hello, there</p></td></tr>
</table>
### **Your Task**
Using **Mocha** and **Chai** write **JS unit tests** to test the entire functionality of the **StringBuilder** class. Make sure it is **correctly defined as a class** and instances of it have all the required functionality. You may use the following code as a template:

|<p>describe(**"*TODO* …"**, **function**() {<br>`    `***it***(**"*TODO …*"**, **function**() {</p><p>`        `*// **TODO:*** …</p><p>`    `});<br>`    `*// **TODO:*** …</p><p>});</p>|
| :- |
1. ## **Payment Package**
You are given the following **JavaScript class**:

|**PaymentPackage.js**|
| :-: |
|**class** PaymentPackage {<br>`  `constructor(name, value) {<br>`    `**this**.name = name;<br>`    `**this**.value = value;<br>`    `**this**.VAT = 20;      *// Default value*    <br>`    `**this**.active = **true**; *// Default value*<br>`  `}<br><br>`  `**get** name() {<br>`    `**return this**.**\_name**;<br>`  `}<br><br>`  `**set** name(newValue) {<br>`    `**if** (**typeof** newValue !== **'string'**) {<br>`      `**throw new** Error(**'Name must be a non-empty string'**);<br>`    `}<br>`    `**if** (newValue.length === 0) {<br>`      `**throw new** Error(**'Name must be a non-empty string'**);<br>`    `}<br>`    `**this**.**\_name** = newValue;<br>`  `}<br><br>`  `**get** value() {<br>`    `**return this**.**\_value**;<br>`  `}<br><br>`  `**set** value(newValue) {<br>`    `**if** (**typeof** newValue !== **'number'**) {<br>`      `**throw new** Error(**'Value must be a non-negative number'**);<br>`    `}<br>`    `**if** (newValue < 0) {<br>`      `**throw new** Error(**'Value must be a non-negative number'**);<br>`    `}<br>`    `**this**.**\_value** = newValue;<br>`  `}<br><br>`  `**get** VAT() {<br>`    `**return this**.**\_VAT**;<br>`  `}<br><br>`  `**set** VAT(newValue) {<br>`    `**if** (**typeof** newValue !== **'number'**) {<br>`      `**throw new** Error(**'VAT must be a non-negative number'**);<br>`    `}<br>`    `**if** (newValue < 0) {<br>`      `**throw new** Error(**'VAT must be a non-negative number'**);<br>`    `}<br>`    `**this**.**\_VAT** = newValue;<br>`  `}<br><br>`  `**get** active() {<br>`    `**return this**.**\_active**;<br>`  `}<br><br>`  `**set** active(newValue) {<br>`    `**if** (**typeof** newValue !== **'boolean'**) {<br>`      `**throw new** Error(**'Active status must be a boolean'**);<br>`    `}<br>`    `**this**.**\_active** = newValue;<br>`  `}<br><br>`  `toString() {<br>`    `**const** output = [<br>`      `**`Package:** ${**this**.name}**`** + (**this**.active === **false** ? **' (inactive)'** : **''**),<br>`      `**`- Value (excl. VAT):** ${**this**.value}**`**,<br>`      `**`- Value (VAT** ${**this**.VAT}**%):** ${**this**.value \* (1 + **this**.VAT / 100)}**`**<br>`    `];<br>`    `**return** output.join(**'\n'**);<br>`  `}<br>}|
### **Functionality**
The above code defines a **class** that contains information about a **payment package**. An **instance** of the class should support the following operations:

- Can be **instantiated** with two parameters – a string name and number value
- Accessor **name** – used to get and set the value of name
- Accessor **value** – used to get and set the value of value
- Accessor **VAT** – used to get and set the value of VAT
- Accessor **active** – used to get and set the value of active
- Function **toString()** – return a string, containing an overview of the instance; if the package is **not active**, append the label "**(inactive)**" to the printed **name**

When creating an instance, or changing any of the property values, the parameters are validated. They must follow these rules:

- **name** – non-empty string
- **value** – non-negative number
- **VAT** – non-negative number
- **active** – Boolean

If any of the requirements aren’t met, the operation must throw an error.

***Scroll down for examples and details about submitting to Judge.***


### **Examples**
This is an example how this code is **intended to be used**:

|**Sample code usage**|
| :-: |
|*// Should throw an error*<br>**try** {<br>`    `**const *hrPack*** = **new** PaymentPackage(**'HR Services'**);<br>} **catch**(err) {<br>`    `**console**.log(**'Error: '** + err.**message**);<br>}<br>**const *packages*** = [<br>`    `**new** PaymentPackage(**'HR Services'**, 1500),<br>`    `**new** PaymentPackage(**'Consultation'**, 800),<br>`    `**new** PaymentPackage(**'Partnership Fee'**, 7000),<br>];<br>**console**.log(***packages***.join(**'\n'**));<br><br>**const *wrongPack*** = **new** PaymentPackage(**'Transfer Fee'**, 100);<br>*// Should throw an error*<br>**try** {<br>`    `***wrongPack***.active = **null**;<br>} **catch**(err) {<br>`    `**console**.log(**'Error: '** + err.**message**);<br>}|
|**Corresponding output**|
|<p>Error: Value must be a non-negative number</p><p>Package: HR Services</p><p>- Value (excl. VAT): 1500</p><p>- Value (VAT 20%): 1800</p><p>Package: Consultation</p><p>- Value (excl. VAT): 800</p><p>- Value (VAT 20%): 960</p><p>Package: Partnership Fee</p><p>- Value (excl. VAT): 7000</p><p>- Value (VAT 20%): 8400</p><p>Error: Active status must be a boolean</p>|
### **Your Task**
Using **Mocha** and **Chai** write **JS unit tests** to test the entire functionality of the **PaymentPackage** class. Make sure instances of it have all the required functionality and validation. You may use the following code as a template:

|<p>describe(**"*TODO* …"**, **function**() {</p><p>`    `***it***(**"*TODO …*"**, **function**() {</p><p>`        `*// **TODO:*** …</p><p>`    `});</p><p>`    `*// **TODO:*** …</p><p>});</p>|
| :- |



