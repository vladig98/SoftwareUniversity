# **Lab: Defining Classes**
Problems for exercises and homework for the ["C# OOP Basics" course @ SoftUni](https://softuni.bg/courses/csharp-oop-basics)".

You can check your solutions here: <https://judge.softuni.bg/Contests/674/Defining-Classes-Lab> 
1. ## **Bank Account**
Create a **class** named **BankAccount**.

The class should have **private** **fields** for:

- **id: int**
- **balance:** **decimal**

The class should also have **public** **properties** for:

- **Id:** **int**
- **Balance:** **decimal**

You should be able to use the class like this:

### **Solution**
Create a **new class** and ensure **proper naming**

1. ## **Bank Account Methods**
Create a class **BankAccount** (you can use class from previous task)

The class should have private fields for:

- **id: int**
- **balance: decimal**

The class should also have properties for:

- **Id:** **int**
- **Balance:** **decimal**
- **Deposit(decimal amount):** **void**
- **Withdraw(decimal amount):** **void**

Override the method **ToString()**.

You should be able to use the class like this:

### **Solution**
Create a method **Deposit(decimal amount)**

Create a method **Withdraw(decimal amount)**

**Override** the method **ToString()**

1. ## **Test Client**
Create a test client that tests your **BankAccount** class.

Support the **following commands**:

- **Create {Id}**
- **Deposit {Id} {amount}**
- **Withdraw {Id} {amount}**
- **Print {Id}**
- **End**

If you try to create an account with an existing Id, print **"Account already exists".**

If you try to perform an operation on a **non-existing account**, print **"<a name="ole_link3"></a>Account does not exist"**.

If you try to withdraw an amount larger than the balance, print **"<a name="ole_link4"></a><a name="ole_link5"></a>Insufficient balance"**.

The Print command should print **"Account ID{id}, balance {balance}"**. Round the balance to the second digit after the decimal separator.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Create 1</p><p>Create 1</p><p>Deposit 1 20</p><p>Withdraw 1 30</p><p>Withdraw 1 10</p><p>Print 1</p><p>End</p>|<p><a name="ole_link1"></a><a name="ole_link2"></a>Account already exists</p><p><a name="ole_link8"></a><a name="ole_link9"></a>Insufficient balance</p><p><a name="ole_link10"></a><a name="ole_link11"></a>Account ID1, balance 10.00</p>|
|<p>Deposit 2 20</p><p>Withdraw 2 30</p><p>Print 2</p><p>End</p>|<p><a name="ole_link6"></a><a name="ole_link7"></a>Account does not exist</p><p>Account does not exist</p><p>Account does not exist</p>|
### **Solution**
Create a **Dictionary<int, BankAccount>** to store existing accounts 

Create the input loop:

Check the **type of command** and **execute** accordingly (***optional:** you can create a separate method for each command*) 

Implement the **Create** command:

Implement the rest of the commands following the same logic.
1. ## **Person Class**
Create a **Person** class.

The class should have **private fields** for:

- **name:** **string**
- **age:** **int**
- **accounts:** **List<BankAccount>**

The class should have **constructors**:

- **Person(string name, int age)**
- **Person(string name, int age, List<BankAccount> accounts)**

The class should also have **public methods** for:

- **GetBalance():** **decimal**
### **Solution**
Create the class as usual:

Create a constructor with two parameters:

Create a constructor with three parameters:

Create method **GetBalance()**:

***Optional:*** You can take advantage of **constructor chaining**:



