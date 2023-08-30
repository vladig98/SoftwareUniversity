
# **Lab: Encapsulation**
Problems for exercises and homework for the ["C# OOP Basics" course @ SoftUni](https://softuni.bg/courses/csharp-oop-basics)".

You can check your solutions here: <https://judge.softuni.bg/Contests/678/Encapsulation-Lab>
1. ## **Sort Persons by Name and Age**
Create a class **Person**, which should have **private** fields for:

- <a name="ole_link10"></a><a name="ole_link11"></a>**firstName**: **string**
- **lastName**: **string**
- **age**: **int**
- **ToString()**: **string** - **override**

You should be able to use the class like this:

|**StartUp.cs**|
| :-: |
|<p><a name="ole_link1"></a><a name="ole_link2"></a>public static void Main()</p><p>{</p><p>`    `var lines = int.Parse(Console.ReadLine());</p><p>`    `var persons = new List<Person>();</p><p>`    `for (int i = 0; i < lines; i++)</p><p>`    `{</p><p>`        `var cmdArgs = Console.ReadLine().Split();</p><p>`        `var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));</p><p>`        `persons.Add(person);</p><p>`    `}</p><p></p><p>`    `persons.OrderBy(p => p.FirstName)</p><p>           .ThenBy(p => p.Age)</p><p>           .ToList()</p><p>           .ForEach(p => Console.WriteLine(p.ToString()));</p><p>}</p>|
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>Asen Ivanov 65</p><p>Boiko Borisov 57</p><p>Ventsislav Ivanov 27</p><p>Asen Harizanoov 44</p><p>Boiko Angelov 35</p>|<p>Asen Harizanoov is 44 years old.</p><p>Asen Ivanov is 65 years old.</p><p>Boiko Angelov is 35 years old.</p><p>Boiko Borisov is 57 years old.</p><p>Ventsislav Ivanov is 27 years old.</p>|
### **Solution**
Create a **new class** and ensure **proper naming**. Define the **private** fields:

Create a constructor for Person, which takes 3 parameters firstName, lastName, age:

Create properties for these fields, which are as strictly as possible:

Override **ToString()** method:

1. ## **Salary Increase**
**Refactor project from last task.**

Read person with their names, age and salary. Read percent bonus to every person salary. People younger than 30 **get half the increase**. Expand **Person** from the previous task.

New **fields** and **methods:**

- **salary**: **decimal** 
- <a name="ole_link14"></a><a name="ole_link15"></a>**IncreaseSalary**(**decimal** **percentage**)

You should be able to use the class like this:

|**StartUp.cs**|
| :-: |
|<p><a name="ole_link12"></a><a name="ole_link13"></a>var lines = int.Parse(Console.ReadLine());</p><p>var persons = new List<Person>();</p><p>for (int i = 0; i < lines; i++)</p><p>{</p><p>`    `var cmdArgs = Console.ReadLine().Split();</p><p>`    `var person = new Person(cmdArgs[0], </p><p>`                            `cmdArgs[1],</p><p>`                            `int.Parse(cmdArgs[2]), </p><p>`                            `decimal.Parse(cmdArgs[3]));</p><p></p><p>`    `persons.Add(person);</p><p>}</p><p>var bonus = decimal.Parse(Console.ReadLine());</p><p>persons.ForEach(p => p.IncreaseSalary(bonus));</p><p>persons.ForEach(p => Console.WriteLine(p.ToString()));</p>|
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>Asen Ivanov 65 2200</p><p>Boiko Borisov 57 3333</p><p>Ventsislav Ivanov 27 600</p><p>Asen Harizanoov 44 666.66</p><p>Boiko Angelov 35 559.4</p><p>20</p>|<p>Asen Ivanov receives 2640.00 leva.</p><p>Boiko Borisov receives 3999.60 leva.</p><p>Ventsislav Ivanov receives 660.00 leva.</p><p>Asen Harizanoov receives 799.99 leva.</p><p>Boiko Angelov receives 671.28 leva.</p>|
### **Solution**
Add new **private** field for **salary** and **refactor constructor**. Add new **method**, which will **update** salary with bonus

Refactor **ToString()** method for this task.
1. ## **Validation of Data**
Expand Person with proper validation for every field:

- **Names must be at least 3 symbols**
- **Age must not be zero or negative**
- **Salary can't be less than 460.0** 

Print proper messages to the user:

- **“Age cannot be zero or a negative integer!”**
- **“First name cannot contain fewer than 3 symbols!”**
- **“Last name cannot contain fewer than 3 symbols!”**
- **“Salary cannot be less than 460 leva!”**

Use ArgumentExeption with messages from example.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>Asen Ivanov -6 2200</p><p>B Borisov 57 3333</p><p>Ventsislav Ivanov 27 600</p><p>Asen H 44 666.66</p><p>Boiko Angelov 35 300</p><p>20</p>|<p><a name="ole_link3"></a><a name="ole_link4"></a><a name="ole_link20"></a>Age cannot be zero or a negative integer!</p><p><a name="ole_link5"></a><a name="ole_link6"></a><a name="ole_link18"></a><a name="ole_link19"></a><a name="ole_link16"></a><a name="ole_link17"></a>First name cannot contain fewer than 3 symbols!</p><p><a name="_hlk506726251"></a>Last name cannot contain fewer than 3 symbols!</p><p><a name="ole_link7"></a><a name="ole_link8"></a><a name="ole_link21"></a>Salary cannot be less than 460 leva!</p><p>Ventsislav Ivanov gets 660.00 leva.</p>|
### **Solution**
Add validation to all setters in Person. Validation may look like this or something similar:

1. ## **First and Reserve Team**
Create a Team class. Add to this team all people you read. All people younger than 40 go on the first team, others go on the reverse team. At the end print the first and reserve team sizes.

The class should have **private fields** for:

- **name**: **string**
- **firstTeam**: **List<Person>**
- <a name="ole_link22"></a><a name="ole_link23"></a>**reserveTeam**: **List<Person>**

The class should have **constructors**:

- **Team(string name)**

The class should also have **public properties** for:

- **FirstTeam: List<Person> (read only!)**
- **ReserveTeam: List<Person> (read only!)**

And a method for adding players:

- **AddPlayer**(**Person** **person**): **void**

You should be able to use the class like this:

You should **NOT** be able to use the class like this:


### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>Asen Ivanov 20 2200</p><p>Boiko Borisov 57 3333</p><p>Ventsislav Ivanov 27 600</p><p>Grigor Dimitrov 25 666.66</p><p>Boiko Angelov 35 555</p>|<p><a name="ole_link9"></a>First team has 4 players.</p><p>Reserve team has 1 players.</p>|
### **Solution**
Add new class Team. Its fields and **constructor** look like:

Properties for **FirstTeam** and **ReserveTeam** have only getters:

There will be only one method, which add players to teams:


