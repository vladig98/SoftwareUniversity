
# **Exercises: XML Processing**
This document defines the **exercise assignments** for the ["Databases Advanced – EF Core" course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).
# **XML Format**
1. ## **Students XML**
Create a XML document **students.xml** in your favorite editor, which contains structured description of students. For each student you should enter information for his **name**, **gender**, **birth date** (in ISO 8601 format), **phone number** (optional), **email**, **university**, **specialty**, **faculty number** (optional) and a list of taken **exams** (exam name, date taken, grade). Use only elements (tags).

Create a new file **students.xml** and insert some xml with a structure similar to this one:

1. ## **Catalog of Musical Albums**
Create a XML file **catalog.xml** representing a catalog of musical **albums**. For each **album** you should define **name**, **artist**, **year**, **producer**, **price** and a list of **songs**. Each song should be described by **title** and **duration**.

Hint: You can take sample data from <https://gist.github.com/jasonbaldridge/2597611>.
# **Product Shop Database**
1. ## **Setup Database**
A products shop holds **users**, **products** and **categories** for the products. Users can **sell** and **buy** products.

- Users have an **id**, **first** **name** (optional) and **last** **name** (at least 3 characters) and **age** (optional).
- Products have an **id**, **name** (at least 3 characters), **price**, **buyerId** (optional) and **sellerId** as IDs of users.
- Categories have an **id** and **name** (from **3** to **15** characters)

Using Entity Framework Code First create a database following the above description.

Configure the following relations in your EF models:

- **Users** should have **many products sold** and **many products bought**. 
- **Products** should have **many categories**
- **Categories** should have **many products**
- **CategoryProducts** should **map products** and **categories**
1. ## **Import Data**
**Import** the data from the provided files (**users.xml**, **products.xml**, **categories.xml**).

Import the **users** first. When importing products, randomly **select the buyer** and **seller** from the existing users. Leave out some **products** that have **not been sold** (i.e. buyer is null).

Randomly **generate categories** for each product from the existing categories.
1. ## **Query and Export Data**
Write the below described queries and **export** the returned data to the specified **format**. Make sure that Entity Framework generates only a **single query** for each task.
1. ### **Products In Range**
Get all products in a specified **price range** between 1000 and 2000 (inclusive) which have **buyer**. Order them by price (from lowest to highest). Select only the **product name**, **price** and the **full name** **of the buyer**. Export the result to XML.

|**products-in-range.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><products></p><p>`  `<product name="TYLENOL COLD MULTI-SYMPTOM DAYTIME" price="1010.81" buyer="Sandra Riley" /></p><p>`  `<product name="Butalbital, Aspirin and Caffeine" price="1010.98" buyer=" Bennett" /></p><p>`  `<product name="SEPHORA Acne-Fighting Mattifying Moisturizer" price="1019.28" buyer="Patricia Cooper" /></p><p>` `</products></p>|
1. ### **Sold Products**
Get all users who have **at least 1 sold item**. Order them by **last name**, then by **first name**. Select the person's **first** and **last name**. For each of the **sold products**, select the product's **name** and **price**.

|**users-sold-products.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><users></p><p>`  `<user first-name="Carl" last-name="Daniels"></p><p>`      `<sold-products></p><p>`          `<product></p><p>`              `<name>Peter Island Continous sunscreen kids</name></p><p>`              `<price>471.30</price></p><p>`          `</product></p><p>`          `<product></p><p>`              `<name>Warfarin Sodium</name></p><p>`              `<price>1379.79</price></p><p>`          `</product></p><p>          ...</p><p>`      `</sold-products></p><p></user></p><p>...</p><p></users></p>|
1. ### **Categories By Products Count**
Get **all** **categories**. Order them by the **number of products** in that category (a product can be in many categories). For each category select its **name**, the **number of products**, the **average price of those products** and the **total revenue** (total price sum) of those products (regardless if they have a buyer or not).


|**categories-by-products.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><categories></p><p>`  `<category name="Sports"></p><p>`      `<products-count>49</products-count></p><p>`      `<average-price>754.327755</average-price></p><p>`      `<total-revenue>36962.06</total-revenue></p><p>`  `</category></p><p>`  `<category name="Adult"></p><p>`      `<products-count>46</products-count></p><p>`      `<average-price>905.283478</average-price></p><p>`      `<total-revenue>41643.04</total-revenue></p><p>`  `</category></p><p>...</p><p></categories></p>|
1. ### **Users and Products**
Get all users who have **at least 1 sold product**. Order them by the **number of sold products** (from highest to lowest), then by **last name** (ascending). Select only their **first** and **last name**, **age** and for each product - **name** and **price**.

Export the results to **XML**. Follow the format below to better understand how to structure your data. 

|**users-and-products.xml**|
| :-: |
|<p>` `<?xml version="1.0" encoding="utf-8"?></p><p><users count="35"></p><p>`  `<user first-name="Carl" last-name="Daniels" age="59"></p><p>`    `<sold-products count="10"></p><p>`      `<product name="Finasteride" price="1374.01" /></p><p>`      `<product name="Peter Island Continous sunscreen kids" price="471.30" /></p><p>`      `<product name="Warfarin Sodium" price="1379.79" /></p><p>`      `<product name="Gilotrif" price="1454.77" /></p><p>`      `<product name="Cold and Cough" price="218.14" /></p><p>      ...</p><p>`    `</sold-products></p><p>`  `</user></p><p>`  `<user last-name="Harris"></p><p>`    `<sold-products count="9"></p><p>`      `<product name="Clarins Paris Skin Illusion - 114 cappuccino" price="811.42" /></p><p>      ...</p><p>`    `</sold-products></p><p>`  `</user></p><p>  ...</p><p></users></p>|
# **Car Dealer Database**
1. ## **Setup Database**
A car dealer needs information about cars, their parts, parts suppliers, customers and sales. 

- **Cars** have **make, model**, travelled distance in kilometers
- **Parts** have **name**, **price** and **quantity**
- Part **supplier** have **name** and info whether he **uses imported parts**
- **Customer** has **name**, **date of birth** and info whether he **is young driver** (Young driver is a driver that has **less than 2 years of experience**. Those customers get **additional 5% off** for the sale.)
- **Sale** has **car**, **customer** and **discount percentage**

A **price of a car** is formed by **total price of its parts**.

Using Entity Framework Code First create a database following the above description.

Configure the following relations in your EF models:

- A **car** has **many parts** and **one part** can be placed **in many cars**
- **One supplier** can supply **many parts** and each **part** can be delivered by **only one supplier**
- In **one sale**, only **one car** can be sold
- **Each sale** has **one customer** and **a customer** can buy **many cars**
1. ## **Import Data**
Import data from the provided files (**suppliers.xml, parts.xml, cars.xml, customers.xml**).

First import **suppliers**. When importing **parts** set to each part **random supplier** from already imported suppliers. Then, when importing cars add **between 10 and 20 random parts** to each car. Then import **all customers**. Finally, import **sales records** by **random** selecting a **car, customer** and the amount of **discount to be applied** (discounts can be 0%, 5%, 10%, 15%, 20%, 30%, 40% or 50%).
1. ## **Query and Export Data**
Write the below described queries and **export** the returned data to the specified **format**. Make sure that Entity Framework generates only a **single query** for each task.
1. ### **Cars with Distance**
Get all **cars** with distance more than 2,000,000. Order them by make, then by model alphabetically. **Export** the list of cars **to XML** in the format provided below.

|**cars.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><cars></p><p>`  `<car></p><p>`    `<make>Alfa Romeo</make></p><p>`    `<model>156</model></p><p>`    `<travelled-distance>92233720368547</travelled-distance></p><p>`  `</car></p><p>`  `<car></p><p>`    `<make>Alfa Romeo</make></p><p>`    `<model>156</model></p><p>`    `<travelled-distance>92036854775807</travelled-distance></p><p>`  `</car></p><p>`  `<car></p><p>`    `<make>Alfa Romeo</make></p><p>`    `<model>164</model></p><p>`    `<travelled-distance>92233775807</travelled-distance></p><p>`  `</car> </p><p>  ...</p><p></cars></p>|
1. ### **Cars from make Ferrari**
Get all **cars** from make **Ferrari** and **order them by model alphabetically** and by **travelled distance descending**. **Export** the list of **cars to XML** in the format provided below.

|**ferrari-cars.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><cars></p><p>`  `<car id="232" model="250 GTO" travelled-distance="214747" /></p><p>`  `<car id="237" model="250 GTO" travelled-distance="214747" />  </p><p>  ...</p><p></cars></p>|
1. ### **Local Suppliers**
Get all **suppliers** that **do not import parts from abroad**. Get their **id**, **name** and **the number of parts they can offer to supply**. **Export** the list of suppliers **to XML** in the format provided below.

|**local-suppliers.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><suppliers></p><p>`  `<suplier id="2" name="Agway Inc." parts-count="6" /></p><p>`  `<suplier id="4" name="Airgas, Inc." parts-count="5" /></p><p>  ...</p><p></suppliers></p>|
1. ### **Cars with Their List of Parts**
Get all **cars along with their list of parts**. For the **car** get only **make, model** and **travelled distance** and for the **parts** get only **name** and **price**. **Export** the list of **cars and their parts to XML** in the format provided below.

|**cars-and-parts.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><cars></p><p>`  `<car make="Opel" model="Omega" travelled-distance="2147483647" /></p><p>`     `<parts></p><p>`         `<part name="Front Left Side Outer door handle" price="999.99" /></p><p>`         `<part name="Gudgeon pin" price="44.99" /></p><p>`         `<part name="Oil pump" price="100.19" /></p><p>`         `<part name="Transmission pan" price="106.99" /></p><p>`     `</parts></p><p>`  `</car></p><p>`  `<car make="Opel" model="Astra" travelled-distance="9223372036854775807" /></p><p>`     `<parts></p><p>`         `<part name="Overflow tank" price="1200.99" /></p><p>         ...</p><p>`     `</parts></p><p>`  `</car></p><p>  ...</p><p></cars></p>|
1. ### **Total Sales by Customer**
Get all **customers** that have bought **at least 1 car** and get their **names**, **bought cars** **count** and **total spent money** on cars. **Order** the result list **by total spent money descending** then by **total bought cars** again in **descending** order. **Export** the list of customers **to** **XML** in the format provided below.

|**customers-total-sales.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><customers></p><p>`  `<customer full-name="Hipolito Lamoreaux" bought-cars="5" spent-money="8360.48" /></p><p>`  `<customer full-name="Francis Mckim" bought-cars="4" spent-money="7115.50" /></p><p>`  `<customer full-name="Johnette Derryberry" bought-cars="4" spent-money="5337.72" /></p><p>  ...</p><p></customer></p>|
1. ### **Sales with Applied Discount**
Get all **sales** with information about the **car**, **customer** and **price** of the sale **with and without discount**. **Export** the list of sales **to XML** in the format provided below.

|**sales-discounts.xml**|
| :-: |
|<p><?xml version="1.0" encoding="utf-8"?></p><p><sales></p><p>`  `<sale></p><p>`     `<car make="Peugeot" model="405" travelled-distance="92036854775807" /></p><p>`     `<customer-name>Donnetta Soliz</customer-name></p><p>`     `<discount>0.3</discount></p><p>`     `<price>1402.53</price></p><p>`     `<price-with-discount>981.771</price-with-discount></p><p>`  `</sale></p><p>`  `<sale></p><p>  ...</p><p></sales></p>|




