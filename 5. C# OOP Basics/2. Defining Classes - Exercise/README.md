
# **Exercises: Defining Classes**
This document defines the **exercise assignments** for the ["CSharp OOP Basics" course @ Software University](https://softuni.bg/courses/csharp-oop-basics).

Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/228/Defining-Classes).
1. ## **Define a Class Person**
Define a class **Person** with **private** fields for **name** and **age** and **public** properties **Name** and **Age**.
### **Bonus\***
Try to create a few objects of type Person:

|**Name**|**Age**|
| :-: | :-: |
|Pesho|20|
|Gosho|18|
|Stamat|43|

Use both the inline initialization and the default constructor.
1. ## **Creating Constructors**
Add 3 constructors to the **Person** class from the last task, use constructor chaining to reuse code:

1. The first should take no arguments and produce a person with name “**No name**” and age = **1**. 
1. The second should accept only an integer number for the age and produce a person with name “**No name**” and age equal to the passed parameter.
1. The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age.
1. ## **Oldest Family Member**
Use your **Person** **class** from the previous tasks. Create a class **Family**. The class should have **list of people**, a method for adding members (**void AddMember(Person member)**) and a method returning the oldest family member** (**Person GetOldestMember())**. Write a program that reads the names and ages of **N** people and **adds them to the family**. Then **print** the **name** and **age** of the oldest member.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>3</p><p>Pesho 3</p><p>Gosho 4</p><p>Annie 5</p>|Annie 5||<p>5</p><p>Steve 10</p><p>Christopher 15</p><p>Annie 4</p><p>Ivan 35</p><p>Maria 34</p>|Ivan 35|
1. ## **Opinion Poll**
Using the **Person** class, write a program that reads from the console **N** lines of personal information and then prints all people whose **age** is **more than 30** years, **sorted in alphabetical order**.
### **Examples**

|**Input**|**Output**|
| :- | :-: |
|<p>3</p><p>Pesho 12</p><p>Stamat 31</p><p>Ivan 48</p>|<p>Ivan - 48</p><p>Stamat - 31</p>|
|<p>5</p><p>Nikolai 33</p><p>Yordan 88</p><p>Tosho 22</p><p>Lyubo 44</p><p>Stanislav 11</p>|<p>Lyubo - 44</p><p>Nikolai - 33</p><p>Yordan - 88</p>|
1. ## **Date Modifier**
Create a class **DateModifier** which stores the difference of the days between two dates. It should have a method which takes **two string parameters** **representing a date** as strings and **calculates the** difference in the days between them. 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p><a name="__ddelink__1089_453159428"></a>1992 05 31</p><p><a name="__ddelink__1091_453159428"></a>2016 06 17</p>|8783|
|<p><a name="__ddelink__1093_453159428"></a><a name="__ddelink__1097_453159428"></a>2016 05 31</p><p><a name="__ddelink__1095_453159428"></a><a name="__ddelink__1099_453159428"></a>2016 04 19</p>|42|
1. ## **Company Roster**
Define a class **Employee** that holds the following information: **name, salary, position, department, email** and **age**. The **name, salary**, **position** and **department** are **mandatory** while the rest are **optional**. 

Your task is to write a program which takes **N** lines of employees from the console and calculates the department with the highest average salary and prints for each employee in that department his **name, salary, email and age** – **sorted by salary in descending order**. If an employee **doesn’t have** an **email** – in place of that field you should print “**n/a**” instead, if he doesn’t have an **age** – print “**-1**” instead. The **salary** should be printed to **two decimal places** after the seperator.
### **Examples**

|**Input**|**Output**|
| :- | :-: |
|<p>4</p><p>Pesho 120.00 Dev Development pesho@abv.bg 28</p><p>Toncho 333.33 Manager Marketing 33</p><p>Ivan 840.20 ProjectLeader Development ivan@ivan.com</p><p>Gosho 0.20 Freeloader Nowhere 18</p>|<p><a name="ole_link1"></a><a name="ole_link2"></a>Highest Average Salary: Development</p><p><a name="ole_link6"></a>Ivan 840.20 ivan@ivan.com -1</p><p>Pesho 120.00 pesho@abv.bg 28</p>|
|<p>6</p><p>Stanimir 496.37 Temp Coding stancho@yahoo.com</p><p>Yovcho 610.13 Manager Sales</p><p>Toshko 609.99 Manager Sales toshko@abv.bg 44</p><p>Venci 0.02 Director BeerDrinking beer@beer.br 23</p><p>Andrei 700.00 Director Coding</p><p>Popeye 13.3333 Sailor SpinachGroup popeye@pop.ey</p>|<p>Highest Average Salary: Sales</p><p>Yovcho 610.13 n/a -1</p><p>Toshko 609.99 toshko@abv.bg 44</p>|
1. ## **Speed Racing**
Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class **Car** that keeps track of a car’s **model, fuel amount, fuel consumption for 1 kilometer** and **distance traveled**. A Car’s model is **unique** - there will never be 2 cars with the same model.

` `On the first line of the input you will receive a number **N** – the number of cars you need to track, on each of the next **N** lines you will receive information for a car in the following format “<**Model> <FuelAmount> <FuelConsumptionFor1km>**”. All **cars start at 0 kilometers traveled**.

After the **N** lines, until the command “**End**” is received, you will receive commands in the following format “**Drive <CarModel>  <amountOfKm>**”. Implement a method in the **Car** class to calculate whether or not a car can move that distance. If it can, the car’s **fuel amount** should be **reduced** by the amount of **used** **fuel** and its **distance traveled** should be increased by the number of **kilometers** **traveled**. Otherwise, the car should not move (its fuel amount and distance traveled should stay the same) and you should print on the console <a name="ole_link9"></a><a name="ole_link10"></a>“<a name="ole_link7"></a><a name="ole_link8"></a>**Insufficient fuel for the drive**”. After the “**End**” command is received, print **each car** and its **current fuel amount** and **distance traveled** in the format “**<Model> <fuelAmount>  <distanceTraveled>**”. Print the fuel amount rounded to **two decimal places** after the separator.
### **Examples**

|**Input**|**Output**|
| :- | :-: |
|<p>2</p><p>AudiA4 23 0.3</p><p>BMW-M2 45 0.42</p><p>Drive BMW-M2 56</p><p>Drive AudiA4 5</p><p>Drive AudiA4 13</p><p>End</p>|<p>AudiA4 17.60 18</p><p>BMW-M2 21.48 56</p>|
|<p>3</p><p>AudiA4 18 0.34</p><p>BMW-M2 33 0.41</p><p>Ferrari-488Spider 50 0.47</p><p>Drive Ferrari-488Spider 97</p><p>Drive Ferrari-488Spider 35</p><p>Drive AudiA4 85</p><p>Drive AudiA4 50</p><p>End</p>|<p>Insufficient fuel for the drive</p><p>Insufficient fuel for the drive</p><p>AudiA4 1.00 50</p><p>BMW-M2 33.00 0</p><p>Ferrari-488Spider 4.41 97</p>|
1. ## **Raw Data**
You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a class **Car** that holds information about **model, engine, cargo** and a **collection of exactly 4 tires**. The **engine**, **cargo** and **tire** should** be **separate classes**. Create a constructor that receives all information about the **Car** and creates and initializes its inner components (engine, cargo and tires).

On the first line of input you will receive a number **N** - the amount of cars you have. On each of the next **N** lines you will receive information about a car in the format “**<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>”** where the speed, power, weight and tire age are **integers**, tire pressure is a **double.** 

After the **N** lines you will receive a single line with one of 2 commands: “**fragile**” or “**flamable**”. If the command is “**fragile**” print all cars whose **Cargo Type is “fragile”** with **a tire** whose **pressure is**  **< 1**. If the command is “**flamable**” print all cars whose **Cargo Type is “flamable”** and have **Engine Power > 250**. The cars should be printed in order of appearing in the input.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>2</p><p>ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4</p><p>Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1</p><p>fragile</p>|Citroen2CV|
|<p>4</p><p>ChevroletExpress 215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1</p><p>ChevroletAstro 210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1</p><p>DaciaDokker 230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1</p><p>Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2</p><p>flamable</p>|<p>ChevroletExpress</p><p>DaciaDokker</p>|
1. ## **Rectangle Intersection**
Create a class **Rectangle**. It should consist of an **id, width, height** and the **coordinates of its top left corner** (**horizontal and vertical**). Create a **method** which **receives as a parameter** **another Rectangle**, checks if the two rectangles **intersect** and **returns true or false**. 

On the first line you will receive the **number of rectangles** – **N** and the number of **intersection checks** – **M**. On the next **N** lines, you will get the rectangles with their **id, width, height and coordinates**. On the last **M** lines, you will get **pairs of ids** which represent rectangles. Print if each of the pairs **intersect.**

You will always receive valid data. There is no need to check if a rectangle exists.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>2 1</p><p>Pesho 2 2 0 0</p><p>Gosho 2 2 0 0</p><p>Pesho Gosho</p>|true|
1. ## **Car Salesman**
Define two classes **Car** and **Engine.** A **Car** has a **model, engine, weight** and **color**. An Engine has **model**, **power, displacement** and **efficiency**. A Car’s **weight** and **color** and its Engine’s **displacements** and **efficiency** are **optional**. 

On the first line you will read a number **N** which will specify how many lines of engines you will receive. On each of the next **N** lines you will receive information about an **Engine** in the following format “<**Model> <Power> <Displacement> <Efficiency>**”. After the lines with engines, on the next line you will receive a number **M** – specifying the number of Cars that will follow. On each of the next **M** lines information about a **Car** will follow in the format “<**Model> <Engine> <Weight> <Color>**”, where the engine will be the **model of an existing** **Engine**. When creating the object for a **Car**, you should keep a **reference to the real engine** in it, instead of just the engine’s model.
Note that the optional properties **might be missing** from the formats.

Your task is to print each car (in the order you received them) and its information in the format defined bellow, if any of the optional fields has not been given print “**n/a**” in its place instead:

**<CarModel>:
`  `<EngineModel>:
`    `Power: <EnginePower>
`    `Displacement: <EngineDisplacement>
`    `Efficiency: <EngineEfficiency>
`  `Weight: <CarWeight>
`  `Color: <CarColor>**
### **Bonus\***
Override the classes’ **ToString**() methods to have a reusable way of displaying the objects.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>2</p><p>V8-101 220 50</p><p>V4-33 140 28 B</p><p>3</p><p>FordFocus V4-33 1300 Silver</p><p>FordMustang V8-101</p><p>VolkswagenGolf V4-33 Orange </p>|<p>FordFocus:</p><p>`  `V4-33:</p><p>`    `Power: 140</p><p>`    `Displacement: 28</p><p>`    `Efficiency: B</p><p>`  `Weight: 1300</p><p>`  `Color: Silver</p><p>FordMustang:</p><p>`  `V8-101:<br>`    `Power: 220<br>`    `Displacement: 50</p><p>`    `Efficiency: n/a</p><p>`  `Weight: n/a</p><p>`  `Color: n/a</p><p>VolkswagenGolf:</p><p>`  `V4-33:</p><p>`    `Power: 140</p><p>`    `Displacement: 28</p><p>`    `Efficiency: B</p><p>`  `Weight: n/a</p><p>`  `Color: Orange</p>|
|<p>4</p><p>DSL-10 280 B</p><p>V7-55 200 35</p><p>DSL-13 305 55 A+</p><p>V7-54 190 30 D</p><p>4</p><p>FordMondeo DSL-13 Purple</p><p>VolkswagenPolo V7-54 1200 Yellow</p><p>VolkswagenPassat DSL-10 1375 Blue</p><p>FordFusion DSL-13</p>|<p>FordMondeo:</p><p>`  `DSL-13:</p><p>`    `Power: 305</p><p>`    `Displacement: 55</p><p>`    `Efficiency: A+</p><p>`  `Weight: n/a</p><p>`  `Color: Purple</p><p>VolkswagenPolo:</p><p>`  `V7-54:</p><p>`    `Power: 190</p><p>`    `Displacement: 30</p><p>`    `Efficiency: D</p><p>`  `Weight: 1200</p><p>`  `Color: Yellow</p><p>VolkswagenPassat:</p><p>`  `DSL-10:</p><p>`    `Power: 280</p><p>`    `Displacement: n/a</p><p>`    `Efficiency: B</p><p>`  `Weight: 1375</p><p>`  `Color: Blue</p><p>FordFusion:</p><p>`  `DSL-13:</p><p>`    `Power: 305</p><p>`    `Displacement: 55</p><p>`    `Efficiency: A+</p><p>`  `Weight: n/a</p><p>`  `Color: n/a</p>|
1. ## **Pokemon Trainer**
You wanna be the very best pokemon trainer, like no one ever was, so you set out to catch pokemon. Define a class **Trainer** and a class **Pokemon**. Trainers have a **name**, **number of badges** and a **collection of pokemon**, **Pokemon** have a **name**, an **element** and **health**, all values are **mandatory**. Every Trainer **starts with 0 badges**.

From the console you will receive an unknown number of lines until you receive the command “**Tournament**”. Each line will carry information about a pokemon and the trainer who caught it in the format “<**TrainerName> <PokemonName> <PokemonElement> <PokemonHealth>”** where **TrainerName** is the name of the Trainer who caught the pokemon. Trainer names are **unique**.
After receiving the command “**Tournament**”, an unknown number of lines containing one of the three elements “**Fire**”, “**Water**”, “**Electricity**” will follow until the “**End**” command is received. For every command you must check if a trainer has at least 1 pokemon with the given element. If he does, he receives 1 badge. Otherwise, all of his pokemon **lose 10 health**. If a pokemon falls **to 0 or less health**, **he dies** and must be deleted from the trainer’s collection.
After the “**End**” command is received you should print all trainers **sorted by the amount of badges they have in descending order** (if two trainers have the same amount of badges they should be sorted by order of appearance in the input)** in the format “<**TrainerName> <Badges> <NumberOfPokemon>**”.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Pesho Charizard Fire 100</p><p>Gosho Squirtle Water 38</p><p>Pesho Pikachu Electricity 10</p><p>Tournament</p><p>Fire</p><p>Electricity</p><p>End</p>|<p>Pesho 2 2</p><p>Gosho 0 1</p>|
|<p>Stamat Blastoise Water 18</p><p>Nasko Pikachu Electricity 22</p><p>Jicata Kadabra Psychic 90</p><p>Tournament</p><p>Fire</p><p>Electricity</p><p>Fire</p><p>End</p>|<p>Nasko 1 1</p><p>Stamat 0 0</p><p>Jicata 0 1</p>|
1. ## **Google**
Google is always watching you, so it should come as no surprise that they **know** **everything** **about** **you** (even your pokemon collection). Since you’re really good at writing classes, Google asked you to design a class that can hold **all** the **information** they need **for** **people**.

From the console you will receive an unkown amount of lines until the command “**End**” is read. On each of those lines there will be information about a person in one of the following formats:

- “**<Name> company <companyName> <department> <salary>**”  
- “**<Name> pokemon <pokemonName> <pokemonType>”**
- “**<Name> parents <parentName> <parentBirthday>**”
- “**<Name> children <childName> <childBirthday>**”
- “**<Name> car <carModel> <carSpeed>**”

You should structure all information about a person in a class with nested subclasses. People’s names are **unique** - there won’t be 2 people with the same name. A person can also have **only 1** **company** and **car**, but can have **multiple** **parents, children** and **pokemons**. After the command “**End**” is received, on the next line you will receive a single name. You should print all information about that person. Note that information can change during the input - for instance if we receive multiple lines which specify a person’s company, only the **last one** should be the one remembered. The salary must be formated to **two decimal places** after the seperator.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>PeshoPeshev company PeshInc Management 1000.00</p><p>TonchoTonchev car Trabant 30</p><p>PeshoPeshev pokemon Pikachu Electricity</p><p>PeshoPeshev parents PoshoPeshev 22/02/1920</p><p>TonchoTonchev pokemon Electrode Electricity</p><p>End</p><p>TonchoTonchev</p>|<p>TonchoTonchev</p><p>Company:</p><p>Car:</p><p>Trabant 30</p><p>Pokemon:</p><p>Electrode Electricity</p><p>Parents:</p><p>Children:</p><p></p>|
|<p>JelioJelev pokemon Onyx Rock</p><p>JelioJelev parents JeleJelev 13/03/1933</p><p>GoshoGoshev pokemon Moltres Fire</p><p>JelioJelev company JeleInc Jelior 777.77</p><p>JelioJelev children PudingJelev 01/01/2001</p><p>StamatStamatov pokemon Blastoise Water</p><p>JelioJelev car AudiA4 180</p><p>JelioJelev pokemon Charizard Fire</p><p>End</p><p>JelioJelev</p>|<p>JelioJelev</p><p>Company:</p><p>JeleInc Jelior 777.77</p><p>Car:</p><p>AudiA4 180</p><p>Pokemon:</p><p>Onyx Rock</p><p>Charizard Fire</p><p>Parents:</p><p>JeleJelev 13/03/1933</p><p>Children:</p><p>PudingJelev 01/01/2001</p><p></p>|
### **Bonus\***
Override the ToString() method in the classes to standardize the displaying of objects.
1. ## **Family Tree**
You want to build your family tree, so you went to ask your grandmother. Sadly, your grandmother keeps remembering information about your predecessors in pieces, so it falls to you to group the information and build the family tree.

On the first line of input you will receive either a name or a birthdate in the format “<**FirstName> <LastName>”** or **“day/month/year**” – your task is to find the person’s information in the family tree. On the next lines until the command “**End**” is received you will receive information about your predecessors that you will use to build the family tree. 

The information will be in one of the following formats: 

- “**FirstName LastName - FirstName LastName**”
- “**FirstName LastName - day/month/year**”
- “**day/month/year - FirstName LastName**”
- “**day/month/year - day/month/year**”
- “**FirstName LastName day/month/year**”

The first 4 formats reveal a family tie – **the person on the left is parent to the person on the right** (as you can see the format does not need to contain names, for example the 4<sup>th</sup> format means the person born on the left date is parent to the person born on the right date). The last format ties different information together – i.e. **the person with that name was born on that date**. **Names** and **birthdates** are **unique** – there won’t be 2 people with the same name or birthdate, there will **always** be enough entries to construct the family tree (all people’s names and birthdates are known and they have atleast one connection to another person in the tree). 

After the command “**End**” is received you should print all information about the person whose name or birthdate you received on the first line – his **name, birthday, parents and children** (check the examples for the format). The people in the parents and childrens lists should be ordered by their first appearance in the input (regardless if they appeared as a birthdate or a name, for example in the first input Stamat is before Penka because he has appeared first on the second line, while she appears on the third one).
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Pesho Peshev</p><p>11/11/1951 - 23/5/1980</p><p>Penka Pesheva - 23/5/1980</p><p>Penka Pesheva 9/2/1953</p><p>Pesho Peshev - Gancho Peshev</p><p>Gancho Peshev 1/1/2005</p><p>Stamat Peshev 11/11/1951</p><p>Pesho Peshev 23/5/1980</p><p>End</p>|<p>Pesho Peshev 23/5/1980</p><p>Parents:</p><p>Stamat Peshev 11/11/1951</p><p>Penka Pesheva 9/2/1953</p><p>Children:</p><p>Gancho Peshev 1/1/2005</p><p></p>|
|<p>13/12/1993</p><p>25/3/1934 - 4/4/1961</p><p>Poncho Tonchev 25/3/1934</p><p>4/4/1961 - Moncho Tonchev</p><p>Toncho Tonchev - Lomcho Tonchev</p><p>Moncho Tonchev 13/12/1993</p><p>Lomcho Tonchev 7/7/1995</p><p>Toncho Tonchev 4/4/1961</p><p>End</p>|<p>Moncho Tonchev 13/12/1993</p><p>Parents:</p><p>Toncho Tonchev 4/4/1961</p><p>Children:</p>|
1. ## **\*Cat Lady**
Ginka has many cats of various breeds in her house. Since some breeds have specific characteristics, Ginka needs some way to catalogue the cats. Help her by creating a class hierarchy with all her breeds of cats, so she can easily check on their characteristics. Ginka has 3 specific breeds of cats: “Siamese”, “Cymric” and the very famous bulgarian breed “Street Extraordinaire”. Each breed has a specific characteristic about which information should be kept. For the Siamese cats their **ear size** should be kept, for Cymric cats - the **length of their fur** in centimeters and for the Street Extraordinaire - the **decibels of their meowing** during the night.

From the console you will receive lines of information with cats. Until the command “**End**” is received, the information will come in one of the following formats:

- “**Siamese <name> <earSize>”**
- “**Cymric <name> <furLength>”**
- “**StreetExtraordinaire <name> <decibelsOfMeows>”**

On the last line after the “**End**” command you will receive the name of a cat. You should print that cat’s information in the same format in which you received it (with **fur size** being formated to **two decimal places** after the separator).
### **Constraints**
- Ear size and decibels will always be **positive integers**
- Cat names are **unique**
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|<p>StreetExtraordinaire Maca 85</p><p>Siamese Sim 4</p><p>Cymric Tom 2.80</p><p>End</p><p>Tom</p>|Cymric Top 2.80|
|<p>StreetExtraordinaire Koti 80</p><p>StreetExtraordinaire Maca 100</p><p>Cymric Tim 3.10</p><p>End</p><p>Maca</p>|StreetExtraordinaire Maca 100|
### **Hint**
Use class inheritance to represent the cat hierarchy and override the ToString() methods of concrete breeds to allow for easy printing of the cat, regardless the breed.
1. ## **\*Drawing tool**
You are a young programmer and your boss gave you a task to create a tool, which draws figures on the console. He knows you are not too good at OOP tasks, so he told you to create a class - **DrawingTool**. Its task is to draw <a name="tw-target-text"></a>rectangular figures on the console.

**DrawingTool**’s constructor should take as a parameter a **Square** or a **Rectangle** object, extract its characteristics and draw the figure. Like we said, your boss is a good guy and he has some more info for you:

One of the extra classes you will need should be a class named **Square** that should have only one method – **Draw()** which uses the length of the square’s sides and draws them on the console. For horizontal lines, use dashes ("-") and spaces (" "). For vertical lines – pipes ("|"). If the size of the figure is 6, the dashes should also be 6. 
### **Hint**
Search in the internet for abstract classes and try implementing one. This will help you to reduce the input parameters in the **DrawingTool**’s constructor to one.
### **Examples**

|**Input**|**Output**|**Comment**|
| :-: | :-: | :-: |
|<p>Square</p><p>3</p>|<p>|---|</p><p>|   |</p><p>|---|</p>|Square’s size is 3 so we draw 3 pipes down and 3 dashes across|


|**Input**|**Output**|**Comment**|
| :-: | :-: | :-: |
|<p>Rectangle</p><p>7</p><p>3</p>|<p>|-------|</p><p>|       |</p><p>|-------|</p>|The Rectangle’s width is 7 and the length is 3 |




