
# **Exercise: Objects and JSON, DOM Events**
Problems for in-class lab for the ["JavaScript Fundamentals" course @ SoftUni](https://softuni.bg/trainings/2247/js-fundamentals-january-2019). Submit your solutions in the SoftUni judge system at <https://judge.softuni.bg/Contests/1485>
1. ## **Shopping Cart**
You will be given some products that you should be able to add to your cart. Each product will have a **name, picture and a price**. When the button **"Add to cart"** is clicked, add the current product in the **textarea** in the following format: **"Added {name} for {money} to the cart"**. Each **button can be clicked as much as you want**. When the button **"Buy"** is pressed, you need to calculate the **total money** that you need to pay for the products that are currently in your cart. Print the result in the **textarea** in the following format: **"You bought {list} for {totalPrice}."**. The list should contain only the **unique elements**. The list should be the products, separated by a **", ".** The total price should be rounded to the second decimal point.
### **Examples**

1. ## **Furniture**
You will be given some furniture as an **array of objects**. Each object will have a **name**, a **price** and a **decoration factor**. When clicking on **"Generate"**, add to the **div with id furniture-list** a **div** element with **class furniture** for each piece of furniture with **checkbox, name, price and decoration factor** (code example below). Then when the **"Buy"** button is clicked, get all **checkboxes that are marked** and show in the **result textbox** the **names** of the piece of furniture that **were checked**, separated by a space(**" "**) in the format: **"Bought furniture: {furniture1} {furniture2}…".** On the next line, print the total price in format: **"Total price: {totalPrice}"** (formatted to the second decimal). And finally, print the average decoration factor in the format: **"Average decoration factor: {decFactor}"**
### **Examples**


1. ## **Forum**
You will be given a registration form containing the following: **username**, **password**, **email**, **checkboxes** **for 4 different topics**: **science, cooking, art, sports**. When **the form is submitted**, a user must be **registered and displayed in the table** below. There will be a **search box** that should receive a string to search for in each row. When the button **"Search"** is clicked, display only the rows that include that searched string. (set **visibility:visible** for the matched and **visibility:hidden** for the others) 
### **Hint**
Use the **preventDefault** function to stop the page from reloading when you click the button
### **Examples**


1. ## **Salesman**
You will be given an **array of objects in textarea,** each object containing a **name of a product, quantity and a price**. When the button **"Load"** is clicked, **add** the product in some storage variable. If the **product already exists**, add the **quantity and update the price**. After a successful product addition display in the log the following message: **"Successfully added {productQuantity} {productName}. Price: {currentPrice}"**. Then, you will also be given another textarea that will contain an object with **name and quantity**. When the button **"Buy"** is clicked, **check for that product** in the storage and if you **have enough quantity**; if you **can complete** the order, **remove the quantity** of that product from the storage and **add the money profited** from that order to a profit variable. If the order **cannot be completed**, display a message **"Cannot complete order."** in the log, otherwise display this message: **"{quantity} {productName} sold for {orderMoney}."**. When the button **"End Day"** is clicked, display in the result textbox the profit for the day in the format: **"Profit: {profit}."** (formatted to the **second decimal**).You should also **not be able to click any buttons** anymore.

***Note:*** the messages in the log should be each on a separate line.
### **Examples**
#### **Step 1**

#### **Step 2**

#### **Step 3**



