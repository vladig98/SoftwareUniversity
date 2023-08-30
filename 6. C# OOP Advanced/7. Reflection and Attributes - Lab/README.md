
# **Lab: Reflection and Attributes**
Problems for exercises and homework for the ["CSharp OOP Advanced" course @ SoftUni.](https://softuni.bg/courses/csharp-oop-advanced-high-quality-code)

You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/710/Reflection-and-Attributes-Lab)
# **Part I: Reflection**
1. ## **Stealer**
Add the Hacker class from the box below to your project.

|**Hacker.cs**|
| :-: |
|<p>public class Hacker</p><p>{</p><p>`    `public string username = "securityGod82";</p><p>`    `private string password = "mySuperSecretPassw0rd";</p><p></p><p>`    `public string Password</p><p>`    `{</p><p>`        `get => this.password;</p><p>`        `set => this.password = value;</p><p>`    `}</p><p></p><p>`    `private int Id { get; set; }</p><p></p><p>`    `public double BankAccountBalance { get; private set; }</p><p></p><p>`    `public void DownloadAllBankAccountsInTheWorld()</p><p>`    `{        </p><p>`    `}</p><p>}</p>|

There is one really nasty hacker but not so wise though. He is trying to steal a big amount of money and transfer it to his own account. The police is after him but they need a proffessional… Correct - this is you!

You have the information that this hacker is keeping some of his info in private fields. Create a new class named **Spy** and add inside a method called - **StealFieldInfo** which receives:

- stirng - name of the class to investigate
- array of string - names of the filds to investigate

After finding the fields you must print on the console:

“Class under investigation: **{nameOfTheClass}**”

On the next lines print info about each field in the current format:

“**{filedName}** = **{fieldValue}**”

Use **StringBuilder** to concatenate the answer**. Don’t change anything in "Hacker" class!**

In your main Method you should be able to check your program with the current piece of code.

### **Example**

|**Output**|
| :-: |
|<p>Class under investigation: Hacker</p><p>username = securityGod82</p><p>password = mySuperSecretPassw0rd</p>|
### **Solution**

1. ## **High Quality Mistakes**
You are already expert of **High Quality Code**, so you know what kind of **access modifiers** must be set to members of class. You should have noticed our hacker is not familiar with these concepts.

Create a method inside your Spy class called - **AnalyzeAcessModifiers(string className)**. Check all **fields and methods access modifiers**. Print on console all **mistakes** in format:

- Fields
  - **{fieldName} must be private!**
- Getters
  - **{methodName} have to be public!**
- Setters 
  - **{methodName} have to be private!**

Use **StringBuilder** to concatenate the answer**. Don’t change anything in "Hacker" class!**

In your main Method you should be able to check your program with the current piece of code.

### **Example**

|**Output**|
| :-: |
|<p>username must be private!</p><p>get\_Id have to be public!</p><p>set\_Password have to be private!</p>|
### **Solution**

1. ## **Mission Private Impossible**
It’s time to see what this hacker you are dealing with aims to do.  Create a method inside your Spy class called - **RevealPrivateMethods(stirng className)**. Print all private methods in the following format:

All Private Methods of Class: **{className}**
Base Class: **{baseClassName}**
On the next lines print found method’s names each on new line
Use **StringBuilder** to concatenate the answer**. Don’t change anything in "Hacker" class!**
In your main Method you should be able to check your program with the current piece of code.

### **Example**

|**Output**|
| :-: |
|<p>All Private Methods of Class: Hacker</p><p>Base Class: Object</p><p>get\_Id</p><p>set\_Id</p><p>set\_BankAccountBalance</p><p>Finalize</p><p>MemberwiseClone</p>|
### **Solution**

1. ## **Collector**
Using reflection to get all "Hacker" methods. Then prepare algorithm that will recognize, which methods are getters and setters.

Print to console each getter on new line in format:
**{name} will return {Return Type}**

Then print all setters in format:
**{name} will set field of {Parameter Type}**

Use **StringBuilder** to concatenate the answer**. Don’t change anything in "Hacker" class!**

In your main Method you should be able to check your program with the current piece of code.

### **Example**

|**Output**|
| :-: |
|<p>get\_Password will return System.String</p><p>get\_Id will return System.Int32</p><p>get\_BankAccountBalance will return System.Double</p><p>set\_Password will set field of System.String</p><p>set\_Id will set field of System.Int32</p><p>set\_BankAccountBalance will set field of System.Double</p>|
### **Solution**

# **Part II: Attributes**
1. ## **Create Attribute**
Create attribute **SoftUni** with a **string** element called **name**, that**:**

- Can be used over classes and methods
- Allow multiple attributes of same type
### **Examples**

|**StartUp.cs**|
| :-: |
|<p>[SoftUni("Ventsi")]</p><p>class StartUp</p><p>{</p><p>`    `[SoftUni("Gosho")]</p><p>`    `static void Main(string[] args)</p><p>`    `{</p><p>`    `}</p><p>}</p>|

1. ## **Coding Tracker**
Create a class **Tracker** with a method:

- **static void printMethodsByAuthor()**
### ` `**Examples**

|**StartUp.cs**|
| :-: |
|<p>[SoftUni("Ventsi")]</p><p>class StartUp</p><p>{</p><p>`    `[SoftUni("Gosho")]</p><p>`    `static void Main(string[] args)</p><p>`    `{</p><p>`        `var tracker = new Tracker();</p><p>`        `tracker.PrintMethodsByAuthor();</p><p>`    `}</p><p>}</p>|


