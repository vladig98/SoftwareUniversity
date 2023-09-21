# Exercises: External Format Processing

This document defines the **exercise assignments** for the ["Databases
Advanced – EF Core" course @ Software
University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).

# Products Shop

A products shop holds **users**, **products** and **categories** for the
products. Users can **sell** and **buy** products.

- Users have an **id**, **first** **name** (optional) and **last**
  **name** (at least 3 characters) and **age** (optional).

- Products have an **id**, **name** (at least 3 characters), **price**,
  **buyerId** (optional) and **sellerId** as IDs of users.

- Categories have an **id** and **name** (from **3** to **15**
  characters)

Using Entity Framework Code First create a database following the above
description.

<img src="media/image1.jpg" style="width:6.32654in;height:4.59722in" />

Configure the following relations in your EF models:

- **Users** should have **many products sold** and **many products
  bought**.

- **Products** should have **many categories**

- **Categories** should have **many products**

## Import data

**Import** the data from the provided files (**users.json**,
**products.json**, **categories.json**).

Import the **users** first. When importing products, randomly **select
the buyer** and **seller** from the existing users. Leave out some
**products** that have **not been sold** (i.e. buyer is null).

Randomly **generate categories** for each product from the existing
categories.

## Query and Export Data

Write the below described queries and **export** the returned data to
the specified **format**. Make sure that Entity Framework generates only
a **single query** for each task.

Note that because of the random generation of the data output probably
will be different.

### Products In Range

Get all products in a specified **price range:** 500 to 1000
(inclusive). Order them by price (from lowest to highest). Select only
the **product name**, **price** and the **full name** **of the seller**.
Export the result to JSON.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>products-in-range.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><mark>[</mark></p>
<p><mark>{</mark></p>
<p><mark>"name": "TRAMADOL HYDROCHLORIDE",</mark></p>
<p><mark>"price": 516.48,</mark></p>
<p><mark>"seller": "Christine Gomez"</mark></p>
<p><mark>},</mark></p>
<p><mark>{</mark></p>
<p><mark>"name": "Allopurinol",</mark></p>
<p><mark>"price": 518.50,</mark></p>
<p><mark>"seller": "Kathy Gilbert"</mark></p>
<p><mark>},</mark></p>
<p><mark>{</mark></p>
<p><mark>"name": "Parsley",</mark></p>
<p><mark>"price": 519.06,</mark></p>
<p><mark>"seller": "Jacqueline Perez"</mark></p>
<p><mark>},</mark></p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Successfully Sold Products

Get all users who have **at least 1 sold item** with a **buyer**. Order
them by **last name**, then by **first name**. Select the person's
**first** and **last name**. For each of the **sold products** (products
with buyers), select the product's **name**, **price** and the buyer's
**first** and **last name**.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>users-sold-products.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><mark>[</mark></p>
<p><mark>{</mark></p>
<p><mark>"firstName": "Carl",</mark></p>
<p><mark>"lastName": "Daniels",</mark></p>
<p><mark>"soldProducts": [</mark></p>
<p><mark>{</mark></p>
<p><mark>"name": "Peter Island Continous sunscreen kids",</mark></p>
<p><mark>"price": 471.30,</mark></p>
<p><mark>"buyerFirstName": "Anna",</mark></p>
<p><mark>"buyerLastName": "Parker"</mark></p>
<p><mark>},</mark></p>
<p><mark>{</mark></p>
<p><mark>"name": "Warfarin Sodium",</mark></p>
<p><mark>"price": 1379.79,</mark></p>
<p><mark>"buyerFirstName": "Brandon",</mark></p>
<p><mark>"buyerLastName": "Fuller"</mark></p>
<p><mark>}</mark></p>
<p><mark>]</mark></p>
<p><mark>},</mark></p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Categories By Products Count

Get **all** **categories**. Order them by the category’s **products
count**. For each category select its **name**, the **number of
products**, the **average price of those products** and the **total
revenue** (total price sum) of those products (regardless if they have a
buyer or not).

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>categories-by-products.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><mark>[</mark></p>
<p><mark>{</mark></p>
<p><mark>"category": "Sports",</mark></p>
<p><mark>"productsCount": 49,</mark></p>
<p><mark>"averagePrice": 754.327755,</mark></p>
<p><mark>"totalRevenue": 36962.06</mark></p>
<p><mark>},</mark></p>
<p><mark>{</mark></p>
<p><mark>"category": "Adult",</mark></p>
<p><mark>"productsCount": 46,</mark></p>
<p><mark>"averagePrice": 905.283478,</mark></p>
<p><mark>"totalRevenue": 41643.04</mark></p>
<p><mark>},</mark></p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Users and Products

Get all users who have **at least 1 sold product**. Order them by the
**number of sold products** (from highest to lowest), then by **last
name** (ascending). Select only their **first** and **last name**,
**age** and for each product - **name** and **price**.

Export the results to **JSON**. Follow the format below to better
understand how to structure your data.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>users-and-products.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>{</p>
<p>"usersCount":35,</p>
<p>"users":</p>
<p>[</p>
<p>{</p>
<p>"firstName":<mark>"</mark>Carl<mark>"</mark>,</p>
<p>"lastName":<mark>"</mark>Daniels<mark>"</mark>,</p>
<p>"age":59,</p>
<p>"soldProducts":</p>
<p>{</p>
<p>"count":10,</p>
<p>"products":</p>
<p>[</p>
<p>{</p>
<p>"name":<mark>"</mark>Finasteride",</p>
<p>"price":1374.01</p>
<p>},</p>
<p>{</p>
<p>"name":<mark>"</mark>Peter Island Continous sunscreen
kids<mark>"</mark>,</p>
<p>"price":471.30</p>
<p>},</p>
<p>{</p>
<p>"name":<mark>"</mark>Warfarin Sodium<mark>"</mark>,</p>
<p>"price":1379.79</p>
<p>},</p>
<p>{</p>
<p>"name":<mark>"</mark>Gilotrif<mark>"</mark>,</p>
<p>"price":1454.77</p>
<p>},</p>
<p>{</p>
<p>"name":<mark>"</mark>Cold and Cough<mark>"</mark>,</p>
<p>"price":218.14</p>
<p>},</p>
<p>...</p>
<p>]</p>
<p>}</p>
<p>},</p>
<p>{</p>
<p>"firstName": null,</p>
<p>"lastName": <mark>"</mark>Harris<mark>"</mark>,</p>
<p>"age": 0,</p>
<p>"soldProducts":</p>
<p>{</p>
<p>"count":9,</p>
<p>"products":</p>
<p>[</p>
<p>{</p>
<p>"name":<mark>"</mark>Clarins Paris Skin Illusion – 114
cappuccino<mark>"</mark>,</p>
<p>"price":811.42</p>
<p>},</p>
<p>...</p>
<p>]</p>
<p>}</p>
<p>},</p>
<p>...</p>
<p>]</p>
<p>}</p></td>
</tr>
</tbody>
</table>

# Car Dealer

## Setup Database

A car dealer needs information about cars, their parts, parts suppliers,
customers and sales.

- **Cars** have **make, model**, travelled distance in kilometers

- **Parts** have **name**, **price** and **quantity**

- Part **supplier** have **name** and info whether he **uses imported
  parts**

- **Customer** has **name**, **date of birth** and info whether he **is
  young driver** (Young driver is a driver that has **less than 2 years
  of experience**. Those customers get **additional 5% off** for the
  sale.)

- **Sale** has **car**, **customer** and **discount percentage**

A **price of a car** is formed by **total price of its parts**.

Using Entity Framework Code First create a database following the above
description.

<img src="media/image2.png" style="width:7.23958in;height:3.32292in"
alt="dbdas" />

Configure the following relations in your EF models:

- A **car** has **many parts** and **one part** can be placed **in many
  cars**

- **One supplier** can supply **many parts** and each **part** can be
  delivered by **only one supplier**

- In **one sale**, only **one car** can be sold

- **Each sale** has **one customer** and **a customer** can buy **many
  cars**

## Import Data

Import data from the provided files (**suppliers.json, parts.json,
cars.json, customers.json**)

First import **suppliers**. When importing **parts** set to each part
**random supplier** from already imported suppliers. Then, when
importing cars add **between 10 and 20 random parts** to each car. Then
import **all customers**. Finally, import **sales records** by
**random** selecting a **car, customer** and the amount of **discount to
be applied** (discounts can be 0%, 5%, 10%, 15%, 20%, 30%, 40% or 50%).

## Query and Export Data

Write the below described queries and **export** the returned data to
the specified **format**. Make sure that Entity Framework generates only
a **single query** for each task.

### Ordered Customers

Get all **customers** ordered by their **birth date ascending**. If two
customers are born on the same date **first print those who are not
young drivers** (e.g. print experienced drivers first). **Export** the
list of customers **to JSON** in the format provided below.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>ordered-customers.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><mark>[</mark></p>
<p><mark>{</mark></p>
<p><mark>"Id": 29,</mark></p>
<p><mark>"Name": "</mark>Louann Holzworth<mark>",</mark></p>
<p><mark>"BirthDate": "</mark> 1960-10-01T00:00:00<mark>",</mark></p>
<p><mark>"IsYoungDriver": false,</mark></p>
<p><mark>"Sales": [],</mark></p>
<p>},</p>
<p><mark>{</mark></p>
<p><mark>"Id": 28,</mark></p>
<p><mark>"Name": "</mark>Donnetta Soliz<mark>",</mark></p>
<p><mark>"BirthDate": "</mark> 1963-10-01T00:00:00<mark>",</mark></p>
<p><mark>"IsYoungDriver": true,</mark></p>
<p><mark>"Sales": [],</mark></p>
<p>},</p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Cars from make Toyota

Get all **cars** from make **Toyota** and **order them by model
alphabetically** and by **travelled distance descending**. **Export**
the list of **cars to JSON** in the format provided below.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>toyota-cars.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>[</p>
<p>{</p>
<p><mark>"</mark>Id<mark>"</mark>: 117,</p>
<p><mark>"</mark>Make<mark>"</mark>:
<mark>"</mark>Toyota<mark>"</mark>,</p>
<p><mark>"</mark>Model<mark>"</mark>: <mark>"</mark>Camry
Hybrid<mark>"</mark>,</p>
<p><mark>"</mark>TravelledDistance<mark>"</mark>: 954775807,</p>
<p>},</p>
<p>{</p>
<p><mark>"</mark>Id<mark>"</mark>: 112,</p>
<p><mark>"</mark>Make<mark>"</mark>:
<mark>"</mark>Toyota<mark>"</mark>,</p>
<p><mark>"</mark>Model<mark>"</mark>: <mark>"</mark>Camry
Hybrid<mark>"</mark>,</p>
<p><mark>"</mark>TravelledDistance<mark>"</mark>: 92275807,</p>
<p>},</p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Local Suppliers

Get all suppliers that do not import parts from abroad. Get their id,
name and the number of parts they can offer to supply. Export the list
of suppliers to JSON in the format provided below.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>local-suppliers.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>[</p>
<p>{</p>
<p>"Id": 2,</p>
<p>"Name": "Agway Inc.",</p>
<p>"PartsCount": 6</p>
<p>},</p>
<p>{</p>
<p>"Id": 4,</p>
<p>"Name": "Airgas, Inc.",</p>
<p>"PartsCount": 5</p>
<p>},</p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Cars with Their List of Parts

Get all **cars along with their list of parts**. For the **car** get
only **make, model** and **travelled distance** and for the **parts**
get only **name** and **price**. **Export** the list of **cars and their
parts to JSON** in the format provided below.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>cars-and-parts.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>[</p>
<p>{</p>
<p>"car": {</p>
<p>"Make": "Opel",</p>
<p>"Model": "Omega",</p>
<p>"TravelledDistance": 2147483647,</p>
<p>},</p>
<p>"parts": [</p>
<p>{</p>
<p>"Name": "Front Left Side Outer door handle",</p>
<p>"Price": 999.99</p>
<p>},</p>
<p>{</p>
<p>"Name": "Gudgeon pin",</p>
<p>"Price": 44.99</p>
<p>},</p>
<p>{</p>
<p>"Name": "Oil pump",</p>
<p>"Price": 100.19</p>
<p>},</p>
<p>{</p>
<p>"Name": "Transmission pan",</p>
<p>"Price": 106.99</p>
<p>}</p>
<p>]</p>
<p>},</p>
<p>{</p>
<p>"car": {</p>
<p>"Make": "Opel",</p>
<p>"Model": "Astra",</p>
<p>"TravelledDistance": 9223372036854775807</p>
<p>},</p>
<p>"parts": [</p>
<p>{</p>
<p>"Name": "Overflow tank",</p>
<p>"Price": 1200.99</p>
<p>},</p>
<p>...</p>
<p>]</p>
<p>},</p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Total Sales by Customer

Get all customers that have bought at least 1 car and get their names,
bought cars count and total spent money on cars. Order the result list
by total spent money descending then by total bought cars again in
descending order. Export the list of customers to JSON in the format
provided below.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>customers-total-sales.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>[</p>
<p>{</p>
<p>"fullName": "Hipolito Lamoreaux",</p>
<p>"boughtCars": 5,</p>
<p>"spentMoney": 8360.48</p>
<p>},</p>
<p>{</p>
<p>"fullName": "Francis Mckim",</p>
<p>"boughtCars": 4,</p>
<p>"spentMoney": 7115.50</p>
<p>},</p>
<p>{</p>
<p>"fullName": "Johnette Derryberry",</p>
<p>"boughtCars": 4,</p>
<p>"spentMoney": 5337.72</p>
<p>},</p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>

### Sales with Applied Discount

Get all **sales** with information about the **car**, **customer** and
**price** of the sale **with and without discount**. **Export** the list
of sales **to JSON** in the format provided below.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>sales-discounts.json</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>[</p>
<p>{</p>
<p>"car": {</p>
<p>"Make": "Peugeot",</p>
<p>"Model": "405",</p>
<p>"TravelledDistance": 92036854775807</p>
<p>},</p>
<p>"customerName": "Donnetta Soliz",</p>
<p>"Discount": 0.3,</p>
<p>"price": 1402.53,</p>
<p>"priceWithDiscount": 981.771</p>
<p>},</p>
<p>{</p>
<p>"car": {</p>
<p>"Make": "Mercedes",</p>
<p>"Model": "W124",</p>
<p>"TravelledDistance": 2147647</p>
<p>},</p>
<p>"customerName": "Carri Knapik",</p>
<p>"Discount": 0.2,</p>
<p>"price": 254.96999999999997,</p>
<p>"priceWithDiscount": 203.97599999999997</p>
<p>},</p>
<p>...</p>
<p>]</p></td>
</tr>
</tbody>
</table>
