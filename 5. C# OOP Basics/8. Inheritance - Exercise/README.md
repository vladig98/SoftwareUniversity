
# **Exercises: Inheritance**
This document defines the exercises for ["C# OOP Basics" course @ Software University](https://softuni.bg/courses/csharp-oop-basics). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/239/Inheritance-Exercise).
1. ## **Person**
You are asked to model an application for storing data about people. You should be able to have a person and a child. The child is derived of the person. Your task is to model the application. The only constraints are:

- People should **not** be able to have **negative age**
- Children should **not** be able to have age **more than 15**.

- **Person** – represents the base class by which all others are implemented
- **Child** - represents a class which is derived by the **Person.**
### **Note**
Your class’s names **MUST** be the same as the names shown above!!!

|**Sample Main()**|
| :-: |
|<p><a name="ole_link1"></a><a name="ole_link2"></a>static void Main()</p><p>{</p><p>`    `string name = Console.ReadLine();</p><p>`    `int age = int.Parse(Console.ReadLine());</p><p></p><p>`    `try</p><p>`    `{</p><p>`        `Child child = new Child(name, age);</p><p>`        `Console.WriteLine(child);</p><p>`    `}</p><p>`    `catch (ArgumentException ae)</p><p>`    `{</p><p>`        `Console.WriteLine(ae.Message);</p><p>`    `}</p><p>}</p>|

Create a new empty class and name it **Person**. Set its access modifier to **public** so it can be instantiated from any project. Every person has a name, and age.

|**Sample Code**|
| :-: |
|<p>public class Person</p><p>{</p><p>`   `// 1. Add Fields</p><p></p><p>`   `// 2. Add Constructor</p><p></p><p>`   `// 3. Add Properties</p><p></p><p>`   `// 4. Add Methods</p><p>}</p>|
### **Step 2 – Define the fields**
Define a **field** for each property the class should have (e.g. **Name**, **Age**) 
### **Step 3 - Define the Properties of a Person**
Define the **Name** and **Age** properties of a Person. Ensure that they can only be **changed by the class itself or its descendants** (pick the most appropriate access modifier). 

|**Sample Code**|
| :-: |
|<p>public virtual string Name</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`        `//TODO</p><p>`    `}</p><p>`    `set</p><p>`    `{</p><p>`        `//TODO</p><p>`    `}</p><p>}</p><p></p><p>public virtual int Age</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`        `//TODO</p><p>`    `}</p><p>`    `set</p><p>`    `{</p><p>`        `//TODO</p><p>`    `}</p><p>}</p>|
### **Step 4 - Define a Constructor**
Define a constructor that accepts **name and age**.

|**Sample Code**|
| :-: |
|<p>public Person(string name, int age)</p><p>{</p><p>`    `this.Name = name;</p><p>`    `this.Age = age;</p><p>}</p>|
### **Step 5 - Perform Validations**
After you have created a **field** for each property (e.g. **Name** and **Age**). Next step is to **perform validations** for each one. The **getter should return the corresponding field’s value** and the **setter should validate** the input data before setting it. Do this for each property.

|**Sample Code**|
| :-: |
|<p>public virtual int Age</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`         `return this.age;</p><p>`    `}</p><p>`    `set</p><p>`    `{</p><p>`        `if (value < 0)</p><p>`        `{</p><p>`            `throw new ArgumentException("Age must be positive!");</p><p>`        `}</p><p></p><p>`        `//TODO set field age with value</p><p>`    `}</p><p>}</p>|
### **Constraints**
- If the age of a person is negative – exception’s message is: **"Age must be positive!"**
- If the age of a child is bigger than 15 – exception’s message is: **"<a name="ole_link5"></a><a name="ole_link6"></a>Child's age must be less than 15!"**
- If the name of a child or a person is no longer than 3 symbols – exception’s message is: **"<a name="ole_link3"></a><a name="ole_link4"></a>Name's length should not be less than 3 symbols!"**
### **Step 6 - Override ToString()**
As you probably already know, all classes in C# inherit the **Object** class and therefore have all its **public** members (**ToString()**, **Equals()** and **GetHashCode()** methods). **ToString()** serves to return information about an instance as string. Let's **override** (change) its behavior for our **Person** class.

|**Sample Code**|
| :-: |
|<p>public override string ToString()</p><p>{</p><p>`    `<a name="ole_link7"></a><a name="ole_link8"></a>StringBuilder stringBuilder = new StringBuilder();</p><p>`    `stringBuilder.Append(String.Format("Name: {0}, Age: {1}",</p><p>`                         `this.Name,</p><p>`                         `this.Age));</p><p></p><p>`    `return stringBuilder.ToString();</p><p>}</p>|

And voila! If everything is correct, we can now create **Person objects** and display information about them.
### **Step 7 – Create a Child**
Create a **Child** class that inherits **Person** and has the same constructor definition. However, do not copy the code from the Person class - **reuse the Person class’s constructor**.

|**Sample Code**|
| :-: |
|<p>public Child(string name, int age)</p><p>`    `: base(name, age)</p><p>{</p><p>}</p>|

There is **no need** to rewrite the Name and Age properties since **Child** inherits **Person** and by default has them.
### **Step 8 – Validate the Child’s setter**

|**Sample Code**|
| :-: |
|<p>public override int Age</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`        `return base.Age;</p><p>`    `}</p><p></p><p>`    `set</p><p>`    `{</p><p>`        `//TODO validate childs age</p><p>`        `base.Age = value;</p><p>`    `}</p><p>}</p>|
1. ## **Book Shop**
You are working in a library. And you are pissed of writing descriptions for books by hand, so you wish to use the computer to speed up the process. The task is simple - your program should have two classes – one for the ordinary books – **Book**, and another for the special ones – **GoldenEditionBook**. So let’s get started! We need two classes:

- **Book** - represents a book that holds **title**, **author** and **price**. A book should offer **information** about itself in the format shown in the output below.
- **GoldenEditionBook** - represents a special book holds the same properties as any **Book**, but its **price** is always **30% higher**.
### **Constraints**
- If the author’s second name is starting with a digit– exception’s message is: **"<a name="ole_link13"></a><a name="ole_link14"></a>Author not valid!"**
- If the title’s length is less than 3 symbols – exception’s message is: **"<a name="ole_link15"></a><a name="ole_link16"></a>Title not valid!"**
- If the price is zero or it is negative – exception’s message is: **"<a name="ole_link17"></a><a name="ole_link18"></a>Price not valid!"**
- Price must be formatted to **two** symbols after the decimal separator

|**Sample Main()**|
| :-: |
|<p>static void Main()</p><p>{</p><p>`    `<a name="ole_link9"></a><a name="ole_link10"></a>try</p><p>`    `{</p><p>`        `string author = Console.ReadLine();</p><p>`        `string title = Console.ReadLine();</p><p>`        `decimal price = decimal.Parse(Console.ReadLine());</p><p></p><p>`        `Book book = new Book(author, title, price);</p><p>`        `GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);</p><p></p><p>`        `Console.WriteLine(book + Environment.NewLine);</p><p>`        `Console.WriteLine(goldenEditionBook);</p><p>`    `}</p><p>`    `catch (ArgumentException ae)</p><p>`    `{</p><p>`        `Console.WriteLine(ae.Message);</p><p>`    `}</p><p>}</p>|
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Ivo 4ndonov</p><p>Under Cover</p><p>9999999999999999999</p>|Author not valid!|
|<p>Petur Ivanov</p><p>Life of Pesho</p><p>20</p>|<p>Type: Book</p><p>Title: Life of Pesho</p><p>Author: Petur Ivanov</p><p>Price: 20.00</p><p></p><p>Type: GoldenEditionBook</p><p>Title: Life of Pesho</p><p>Author: Petur Ivanov</p><p>Price: 26.00</p>|

### **Step 1 - Create a Book Class**
Create a new empty class and name it **Book**. Set its access modifier to **public** so it can be instantiated from any project.


|**Sample Code**|
| :-: |
|<p>public class Book</p><p>{</p><p>`    `//1. Add Fields</p><p></p><p>`    `//2. Add Constructors</p><p></p><p>`    `//3. Add Properties</p><p></p><p>`    `//4. Add Methods</p><p>}</p>|
### **Step 2 - Define the Properties of a Book**
Define the **Title**, **Author** and **Price** properties of a Book. Ensure that they can only be **changed by the class itself or its descendants** (pick the most appropriate access modifier). 
### **Step 3 - Define a Constructor**
Define a constructor that accepts **author, title** and **price** arguments.

|**Sample Code**|
| :-: |
|<p>public Book(string author, string title, decimal price)</p><p>{</p><p>`    `this.Author = author;</p><p>`    `this.Title = title;</p><p>`    `this.Price = price;</p><p>}</p>|
### **Step 4 - Perform Validations**
Create a **field** for each property (**Price**, **Title** and **Author**) and **perform validations** for each one. The **getter should return the corresponding field** and the **setter should validate** the input data before setting it. Do this for every property.

|**Sample Code**|
| :-: |
|<p>public string Author</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`        `return this.author;</p><p>`    `}</p><p>`    `set</p><p>`    `{</p><p>`        `//TODO validate value</p><p>`        `this.author = value;</p><p>`    `}</p><p>}</p><p></p><p></p><p>public string Title</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`        `return this.title;</p><p>`    `}</p><p>`    `set</p><p>`    `{</p><p>`        `//TODO validate value</p><p>`        `this.title = value;</p><p>`    `}</p><p>}</p><p></p><p>public virtual decimal Price</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`        `return this.price;</p><p>`    `}</p><p>`    `set</p><p>`    `{</p><p>`        `//TODO validate value</p><p>`        `this.price = value;</p><p>`    `}</p><p>}</p><p></p>|
### **Step 5 - Override ToString()**
We already mentioned that all classes in C# inherit the **System.Object** class and therefore have all its **public** members. Let's **override** (change)  the **ToString()** method’s behavior again acordingly our **Book** class’s data.

|**Sample Code**|
| :-: |
|<p>public override string ToString()</p><p>{</p><p>`    `var resultBuilder = new StringBuilder();</p><p>`    `resultBuilder.AppendLine($"Type: {this.GetType().Name}")</p><p>        .AppendLine($"Title: {this.Title}")</p><p>        .AppendLine($"Author: {this.Author}")</p><p>        .AppendLine($"Price: {this.Price:f2}");</p><p></p><p>`    `string result = resultBuilder.ToString().TrimEnd();</p><p>`    `return result;</p><p>}</p>|

And voila! If everything is correct, we can now create **Book objects** and display information about them.
### **Step 6 – Create a GoldenEditionBook**
Create a **GoldenEditionBook** class that inherits **Book** and has the same constructor definition. However, do not copy the code from the Book class - **reuse the Book class constructor**.

|**Sample Code**|
| :-: |
|<p>public GoldenEditionBook(string author, string title, decimal price) </p><p>`    `: base(author, title, price)</p><p>{</p><p></p><p>}</p>|

There is **no need** to rewrite the Price, Title and Author properties since **GoldenEditionBook** inherits **Book** and by default has them.
### **Step 7 - Override the Price Property**
Golden edition books should return a **30%** higher **price** than the original price. In order for the getter to return a different value, we need to override the Price property. 

Back to the **GoldenEditionBook** class, let's override the Price property and change the getter body

|**Sample Code**|
| :-: |
|<p>public override decimal Price</p><p>{</p><p>`    `get</p><p>`    `{</p><p>`        `return base.Price \* 1.3;</p><p>`    `}</p><p>}</p>|
1. ## **Mankind**
Your task is to model an application. It is very simple. The mandatory models of our application are 3:  **Human**, **Worker** and **Student**.

The parent class – Human should have **first name** and **last name**. Every student has a **faculty number**. Every worker has a **week salary** and **work hours per day**. It should be able to calculate the money he earns by hour. You can see the constraints below.
### **Input**
On the first input line you will be given info about a single student - a name and faculty number. 

On the second input line you will be given info about a single worker - first name, last name, salary and working hours.
### **Output**
You should first print the info about the student following a single blank line and the info about the worker in the given formats:

- Print the student info in the following format: 

`	`**First Name: {student's first name}**

`	`**Last Name: {student's last name}**

`	`**Faculty number: {student's faculty number}**

- Print the worker info in the following format:

`	`**First Name: {worker's first name}**

**Last Name: {worker's second name}**

**Week Salary: {worker's salary}**

**Hours per day: {worker's working hours}**

**Salary per hour: {worker's salary per hour}**

Print exactly two digits after every double value's decimal separator (e.g. 10.00). Consider the workweek from Monday to Friday. A faculty number should be consisted only of digits and letters.
### **Constraints**

|**Parameter**|**Constraint**|**Exception Message**|
| :-: | :-: | :-: |
|Human first name|Should start with a capital letter|"<a name="ole_link19"></a><a name="ole_link20"></a>Expected upper case letter! Argument: firstName"|
|Human first name|Should be more than 3 symbols|"<a name="ole_link21"></a><a name="ole_link22"></a>Expected length at least 4 symbols! Argument: firstName"|
|Human last name|Should start with a capital letter|"Expected upper case letter! Argument: lastName"|
|Human last name|Should be more than 2 symbols|"<a name="ole_link23"></a><a name="ole_link24"></a>Expected length at least 3 symbols! Argument: lastName "|
|Faculty number|Should be in range [5..10] symbols|"<a name="ole_link25"></a><a name="ole_link26"></a>Invalid faculty number!"|
|Week salary|Should be more than 10|"<a name="ole_link27"></a><a name="ole_link28"></a>Expected value mismatch! Argument: weekSalary"|
|Working hours|Should be in the range [1..12]|"<a name="ole_link29"></a><a name="ole_link30"></a>Expected value mismatch! Argument: workHoursPerDay"|
### **Example**

|**Input**|**Output**|
| :-: | :-: |
|<p>Ivan Ivanov 08</p><p>Pesho Kirov 1590 10</p>|Invalid faculty number!|
|<p>Stefo Mk321 0812111</p><p>Ivcho Ivancov 1590 10</p>|<p>First Name: Stefo</p><p>Last Name: Mk321</p><p>Faculty number: 0812111</p><p></p><p>First Name: Ivcho</p><p>Last Name: Ivancov</p><p>Week Salary: 1590.00</p><p>Hours per day: 10.00</p><p>Salary per hour: 31.80</p>|
1. ## <a name="__ddelink__2168_1635918253"></a>**Online Radio Database**
Create an online radio station database. It should keep information about all added songs. On the first line you are going to get the number of songs you are going to try to add. On the next lines you will get the songs to be added in the format **<artist name>;<song name>;<minutes:seconds>**. To be valid, every song should have an artist name, a song name and length. 

Design a custom exception hierarchy for invalid songs: 

- InvalidSongException
  - InvalidArtistNameException
  - InvalidSongNameException
  - InvalidSongLengthException
    - InvalidSongMinutesException
    - InvalidSongSecondsException
### **Validation**
- Artist name should be between 3 and 20 symbols. 
- Song name should be between 3 and 30 symbols. 
- Song length should be between 0 second and 14 minutes and 59 seconds.
- Song minutes should be between 0 and 14.
- Song seconds should be between 0 and 59.
### **Exception Messages**

|**Exception**|**Message**|
| :-: | :-: |
|InvalidSongException|"Invalid song."|
|InvalidArtistNameException|"<a name="ole_link31"></a><a name="ole_link32"></a>Artist name should be between 3 and 20 symbols."|
|InvalidSongNameException|"<a name="ole_link33"></a><a name="ole_link34"></a>Song name should be between 3 and 30 symbols."|
|InvalidSongLengthException|"Invalid song length."|
|InvalidSongMinutesException|"<a name="ole_link35"></a><a name="ole_link36"></a><a name="ole_link39"></a>Song minutes should be between 0 and 14."|
|InvalidSongSecondsException|"<a name="ole_link37"></a><a name="ole_link38"></a><a name="ole_link40"></a>Song seconds should be between 0 and 59."|

**Note**: Check validity in the order **artist name** -> **song name** -> **song length**
### **Output**
If the song is added, print "**Song added.**". If you **can’t add a song**, print an **appropriate exception message**. On the last two lines print the **number of songs added** and the **total length of the playlist** in format **{Playlist length: 0h 7m 47s}.**
### **Examples**

|**Exception**|**Message**|
| :-: | :-: |
|<p>3</p><p>ABBA;Mamma Mia;3:35</p><p>Nasko Mentata;Shopskata salata;4:123</p><p>Nasko Mentata;Shopskata salata;4:12</p>|<p>Song added.</p><p>Song seconds should be between 0 and 59.</p><p>Song added.</p><p>Songs added: 2</p><p>Playlist length: 0h 7m 47s</p>|
|<p>5</p><p>Nasko Mentata;Shopskata salata;14:59</p><p>Nasko Mentata;Shopskata salata;14:59</p><p>Nasko Mentata;Shopskata salata;14:59</p><p>Nasko Mentata;Shopskata salata;14:59</p><p>Nasko Mentata;Shopskata salata;0:5</p>|<p>Song added.</p><p>Song added.</p><p>Song added.</p><p>Song added.</p><p>Song added.</p><p>Songs added: 5</p><p>Playlist length: 1h 0m 1s</p>|
1. ## **\*Mordor’s Cruel Plan**
Gandalf the Gray is a great wizard but he also loves to eat and the food makes him loose his capability of fighting the dark. The Mordor’s orcs have asked you to design them a program which is calculating the Gandalf’s mood. So they could predict the battles between them and try to beat The Gray Wizard.  When Gandalf is hungry he gets angry and he could not fight well. Because the orcs have a spy, he has told them the foods that Gandalf is eating and the result on his mood after he has eaten some food. So here is the list:

- **Cram**: 2 points of happiness;
- **Lembas**: 3 points of happiness;
- **Apple**: 1 point of happiness;
- **Melon**: 1 point of happiness;
- **HoneyCake**: 5 points of happiness;
- **Mushrooms**: -10 points of happiness;
- **Everything else**: -1 point of happiness;

Gandalf moods are:

- **Angry** - below -5 points of happiness;
- **Sad** - from -5 to 0 points of happiness;
- **Happy** - from 1 to 15 points of happiness;
- **JavaScript** - when happiness points are more than 15;

The task is simple. Model an application which is calculating the happiness points, Gandalf has after eating all the food passed in the input. After you are done, print on the first line – total happiness points Gandalf had collected. On the second line – print <a name="__ddelink__2217_1635918253"></a>the **Mood’s** name which is corresponding to the points.
### **Input**
The input comes from the console. It will hold a single line: all the Gandalf`s foods he has eaten separated by a whitespace.
### **Output**
Print on the console Gandalf`s happiness points and the **Mood’s** name which is corresponding to the points.
### **Constraints**
- The characters in the input string will be no more than: **1000.**
- The food count would be in the range **[1…100]**.
- Time limit: 0.3 sec. Memory limit: 16 MB.

### **Note**
Try to implement a factory pattern. You should have two factory classes – **FoodFactory** and **MoodFactory**. And their task is to produce objects (e.g. **FoodFactory**, produces – **Food** and the **MoodFactory** - **Mood**). Try to implement abstract classes (e.g. classes which can’t be instantiated directly)
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<a name="__ddelink__2117_1635918253"></a>Cram melon honeyCake Cake|<p>7</p><p>Happy</p>|
|<a name="__ddelink__2165_1635918253"></a>gosho, pesho, meze, Melon, HoneyCake@;|<p>-5</p><p>Sad</p>|
1. ## **Animals**
Create a hierarchy of **Animals**. Your program should have 3 different animals – **Dog**, **Frog** and **Cat**. Deeper in the hierarchy you should have two additional classes – **Kitten** and **Tomcat**. **Kittens are female and Tomcats are male!**

All types of animals should be able to produce some kind of sound (**ProduceSound()**). For example, the dog should be able to bark.

Your task is to model the hierarchy and test its functionality. Create an animal of each kind and make them all produce sound.

You will be given some lines of input. Each two lines will represent an animal. On the first line will be the type of animal and on the second – the name, the age and the gender. When the command "**Beast!**" is given, stop the input and print all the animals in the format shown below.
### **Output**
- Print the information for each animal on three lines. On the first line, print: "<**AnimalType**>"
- On the second line print: "<**Name**> <**Age**> <**Gender**>"
- On the third line print the sounds it produces: "<**ProduceSound()**>"
### **Constraints**
- Each **Animal** should have a **name**, an **age** and a **gender**
- **All** input values should **not be blank** (e.g. name, age and so on…)
- If you receive an input for the **gender** of a **Tomcat** or a **Kitten**, ignore it but **create** the animal
- If the input is invalid for one of the properties, throw an exception with message: "I**nvalid input!**"
- Each animal should have the functionality to **ProduceSound()**
- Here is the type of sound each animal should produce:
  - **Dog: "Woof!"**
  - **Cat: "Meow meow"**
  - **Frog: "Ribbit"**
  - **Kittens: "Meow"**
  - **Tomcat: "MEOW"**
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Cat</p><p>Tom 12 Male</p><p>Dog</p><p>Sharo 132 Male</p><p>Beast!</p>|<p>Cat </p><p>Tom 12 Male</p><p>Meow meow</p><p>Dog </p><p>Sharo 132 Male</p><p>Woof!</p>|
|<p>Frog</p><p>Kermit 12 Male</p><p>Beast!</p>|<p>Frog </p><p>Kermit 12 Male</p><p>Ribbit</p>|
|<p>Frog</p><p>Sashko -2 Male</p><p>Frog</p><p>Sashko 2 Male</p><p>Beast!</p>|<p>Invalid input!</p><p>Frog</p><p>Sashko 2 Male</p><p>Ribbit</p>|
### **Bonus**
Create an interface **ISoundProducable** and implement it in the **Animal** class.



