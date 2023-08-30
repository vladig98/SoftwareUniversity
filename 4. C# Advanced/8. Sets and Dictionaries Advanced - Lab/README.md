
# **Lab: Sets and Dictionaries Advanced**
Problems for exercises and homework for the ["C# Advanced" course @ SoftUni](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here: [https://judge.softuni.bg/Contests/1181/](https://judge.softuni.bg/Contests/1181/Sets-and-Dictionaries-Advanced-Lab) 
1. ## **Dictionaries**
1. ### **Count Same Values in Array**
Write a program that counts in a given array of double values the number of occurrences of each value. 
#### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3</p><p></p>|<p>-2.5 - 3 times</p><p>4 - 2 times</p><p>3 - 4 times</p><p>-5.5 - 1 times</p>|
|<p>2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3</p><p></p>|<p>2 - 3 times</p><p>4 - 6 times</p><p>5 - 4 times</p><p>3 - 7 times</p>|
1. ### **Average Student Grades**
Write a program, which reads the **name** of a student and their **grades** and **adds** them to the **student record**, then **prints** **grades** along with their **average grade**.
#### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>7</p><p>Ivancho 5.20</p><p>Mariika 5.50</p><p>Ivancho 3.20</p><p>Mariika 2.50</p><p>Stamat 2.00</p><p>Mariika 3.46</p><p>Stamat 3.00</p>|<p>Ivancho -> 5.20 3.20 (avg: 4.20)</p><p>Mariika -> 5.50 2.50 3.46 (avg: 3.82)</p><p>Stamat -> 2.00 3.00 (avg: 2.50)</p>|
|<p>4</p><p>Vladimir 4.50</p><p>Petko 3.00</p><p>Vladimir 5.00</p><p>Petko 3.66</p>|<p>Vladimir -> 4.50 5.00 (avg: 4.75)</p><p>Petko -> 3.00 3.66 (avg: 3.33)</p>|
|<p>5</p><p>Gosho 6.00</p><p>Gosho 5.50</p><p>Gosho 6.00</p><p>Ivan 4.40</p><p>Petko 3.30</p>|<p>Gosho -> 6.00 5.50 6.00 (avg: 5.83)</p><p>Ivan -> 4.40 (avg: 4.40)</p><p>Petko -> 3.30 (avg: 3.30)</p>|
#### **Hints**
- Use a **dictionary** (**string** à **List<double>**) 
- Check if the name exists before adding the grade. If it doesn’t, add it to the dictionary.
- Pass through all **key-value pairs** in the dictionary and print the results. You can use the **.Average()** method to quickly calculate the average value from a list. 
1. ### **Product Shop**
Write a program that prints information about food shops in Sofia and the products they store. Until the "**Revision**" command you will receive an input in the format: **"{shop}, {product}, {price}"**

Take in mind that if you receive a shop you already have received you must collect its product information.

Your output must be ordered by shop name and must be in the format:

**{shop}->**

**Product: {product}, Price: {price}**
#### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>lidl, juice, 2.30</p><p>fantastico, apple, 1.20</p><p>kaufland, banana, 1.10</p><p>fantastico, grape, 2.20</p><p>Revision</p>|<p>fantastico-></p><p>Product: apple, Price: 1.2</p><p>Product: grape, Price: 2.2</p><p>kaufland-></p><p>Product: banana, Price: 1.1</p><p>lidl-></p><p>Product: juice, Price: 2.3</p>|
|<p>tmarket, peanuts, 2.20</p><p>GoGrill, meatballs, 3.30</p><p>GoGrill, HotDog, 1.40</p><p>tmarket, sweets, 2.20</p><p>Revision</p>|<p>GoGrill-></p><p>Product: meatballs, Price: 3.3</p><p>Product: HotDog, Price: 1.4</p><p>tmarket-></p><p>Product: peanuts, Price: 2.2</p><p>Product: sweets, Price: 2.2</p>|
1. ### **Cities by Continent and Country**
Write a program to read **continents**, **countries** and their **cities**, put them in a **nested dictionary** and **print** them.
#### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>9</p><p>Europe Bulgaria Sofia</p><p>Asia China Beijing</p><p>Asia Japan Tokyo</p><p>Europe Poland Warsaw</p><p>Europe Germany Berlin</p><p>Europe Poland Poznan</p><p>Europe Bulgaria Plovdiv</p><p>Africa Nigeria Abuja</p><p>Asia China Shanghai</p>|<p>Europe:</p><p>`  `Bulgaria -> Sofia, Plovdiv</p><p>`  `Poland -> Warsaw, Poznan</p><p>`  `Germany -> Berlin</p><p>Asia:</p><p>`  `China -> Beijing, Shanghai</p><p>`  `Japan -> Tokyo</p><p>Africa:</p><p>`  `Nigeria -> Abuja</p>|
|<p>3</p><p>Europe Germany Berlin</p><p>Europe Bulgaria Varna</p><p>Africa Egypt Cairo</p>|<p>Europe:</p><p>`  `Germany -> Berlin</p><p>`  `Bulgaria -> Varna</p><p>Africa:</p><p>`  `Egypt -> Cairo</p>|
|<p>8</p><p>Africa Somalia Mogadishu</p><p>Asia India Mumbai</p><p>Asia India Delhi</p><p>Europe France Paris</p><p>Asia India Nagpur</p><p>Europe Germany Hamburg</p><p>Europe Poland Gdansk</p><p>Europe Germany Danzig</p>|<p>Africa:</p><p>`  `Somalia -> Mogadishu</p><p>Asia:</p><p>`  `India -> Mumbai, Delhi, Nagpur</p><p>Europe:</p><p>`  `France -> Paris</p><p>`  `Germany -> Hamburg, Danzig</p><p>`  `Poland -> Gdansk</p>|
#### **Hints**
- Use a **nested** **dictionary** (**string** à (**Dictionary à List<string>)**) 
- Check if the continent exists before adding the country. If it doesn’t, add it to the dictionary.
- Check if the country exists, before adding the city. If it doesn’t, add it to the dictionary.
- Pass through all **key-value pairs** in the dictionary and the values’ key-value pairs and print the results.
1. ## **Sets**
1. ### **Record Unique Names**
Write a program, which will take a list of **names** and print **only** the **unique** names in the list.
#### **Examples**

|**Input**|**Output**||**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
|<p>8</p><p>Ivan</p><p>Pesho</p><p>Ivan</p><p>Stamat</p><p>Pesho</p><p>Alice</p><p>Peter</p><p>Pesho</p>|<p>Ivan</p><p>Pesho</p><p>Stamat</p><p>Alice</p><p>Peter</p>||<p>7</p><p>Lyle</p><p>Bruce</p><p>Alice</p><p>Easton</p><p>Shawn</p><p>Alice</p><p>Shawn</p><p>Peter</p>|<p>Lyle</p><p>Bruce</p><p>Alice</p><p>Easton</p><p>Shawn</p>||<p>6</p><p>Roki</p><p>Roki</p><p>Roki<br>Roki</p><p>Roki</p><p>Roki</p>|Roki|
#### **Hints**
You can store the names in a **HashSet<string>** to extract only the unique ones.

1. ### **Parking Lot**
Write program that:

- Record **car number** for every car that enter in **parking lot**
- Remove **car number** when the car go out
- Input will be string in format **[direction, carNumber]**
- input end with string **"END"**

Print the output with all car numbers which are in parking lot 
#### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>IN, CA2844AA</p><p>IN, CA1234TA</p><p>OUT, CA2844AA</p><p>IN, CA9999TT</p><p>IN, CA2866HI</p><p>OUT, CA1234TA</p><p>IN, CA2844AA</p><p>OUT, CA2866HI</p><p>IN, CA9876HH</p><p>IN, CA2822UU</p><p>END</p>|<p>CA9999TT</p><p>CA2844AA</p><p>CA9876HH</p><p>CA2822UU</p>|
|<p>IN, CA2844AA</p><p>IN, CA1234TA</p><p>OUT, CA2844AA</p><p>OUT, CA1234TA</p><p>END</p>|<a name="ole_link1"></a><a name="ole_link2"></a><a name="ole_link3"></a>Parking Lot is Empty|
#### **Hints**
- Car numbers are **unique**
- For print, first ask if set is empty
#### **Solution**
You might help yourself with the code below:


1. ### **SoftUni Party**
#### There is a party in SoftUni. Many guests are invited and there are two types:  VIP and regular. When guest come check if he/she exists in any of the two reservation lists.
#### All reservation numbers will be with 8 chars.
#### All VIP numbers start with a digit.
#### There will be 2 command lines. First is "PARTY" - party is on and guests start coming. Second is "END" – then party is over, and no more guest will come
#### Output has to be all the guests, who didn't come to the party (VIP must be first) and their count.
#### **Examples**

|**Input**|**Output**|**Input**|**Output**|
| :-: | :-: | :-: | :-: |
|<p>7IK9Yo0h</p><p>9NoBUajQ</p><p>Ce8vwPmE</p><p>SVQXQCbc</p><p>tSzE5t0p</p><p>PARTY</p><p>9NoBUajQ</p><p>Ce8vwPmE</p><p>SVQXQCbc</p><p>END</p>|<p>2</p><p>7IK9Yo0h</p><p>tSzE5t0p</p>|<p>m8rfQBvl</p><p>fc1oZCE0</p><p>UgffRkOn</p><p>7ugX7bm0</p><p>9CQBGUeJ</p><p>2FQZT3uC</p><p>dziNz78I</p><p>mdSGyQCJ</p><p>LjcVpmDL</p><p>fPXNHpm1</p><p>HTTbwRmM</p><p>B5yTkMQi</p><p>8N0FThqG</p><p>xys2FYzn</p><p>MDzcM9ZK</p><p>PARTY</p><p>2FQZT3uC</p><p>dziNz78I</p><p>mdSGyQCJ</p><p>LjcVpmDL</p><p>fPXNHpm1</p><p>HTTbwRmM</p><p>B5yTkMQi</p><p>8N0FThqG</p><p>m8rfQBvl</p><p>fc1oZCE0</p><p>UgffRkOn</p><p>7ugX7bm0</p><p>9CQBGUeJ</p><p>END</p>|<p>2</p><p>xys2FYzn</p><p>MDzcM9ZK</p>|
####

