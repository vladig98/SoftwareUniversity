
# **Упътване за инсталация на SQL Server 2017 и SQL Server Management Studio**
Този документ съдържа **насоки** за упражнение към курса  ["Databases Basics - MSSQL" course @ Software University.](https://softuni.bg/courses/databases-basics-ms-sql-server) 
## **Задача 1. Изтегляне и инсталация на SQL Server Express**
### **Стъпка 1. Изтегляне на SQL Server 2017 (Express edition)**
Отидете на **следния линк**  от сайта на Microsoft и изтеглете **SQL Server 2017 Express:** <https://www.microsoft.com/en-us/sql-server/sql-server-downloads>
### **Стъпка 2. Инсталиране на SQL Server 2017**
1. Стартирайте **изтегления** инсталационен файл. Отваря се прозорец, от който трябва да изберете опцията **Basic**.


1. На следващия екран е нужно да се съгласите с **условията за ползване**, както в почти всеки продукт на **Microsoft**.


1. Преди инсталация се избира **директория**, в която да се **инсталира продукта**. Няма нужда от промени, освен ако нямате конкретни предпочитания.

1. След като инсталацията приключи успешно можете да използвате бутона **Install SSMS**, който ще ви препрати към сайта на Microsoft за да **свалите** инсталатор на **SQL Server Management Studio**. Същият линк е наличен в следващата задача от този документ.
## **Задача 2. Изтегляне и инсталация на SQL Server Management Studio**
### **Стъпка 1. Изтегляне на SQL Server Management Studio**
Ако не сте изтеглили инсталационен файл в предната стъпка, отидете на **следния линк**  от сайта на Microsoft и изтеглете **SQL Server Management Studio 17.7: [https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017**](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017)**
### **Стъпка 2. Инсталиране на SQL Server Management Studio**
Стартирате **изтегления** инсталационен файл и натискате бутона **Install**. След приключване на инсталацията е нужно да рестартирате компютъра си.

# **Lab: Introduction to Databases**
In this lab, we will create a **“Bank” database** in **SQL Server**, using **MS SQL Server Management Studio**. We will create **tables** and **fill them with data**, create **views**, **functions**, **procedures** and **triggers**. This tutorial is a part of the “[Databases Basics - MS SQL Server](https://softuni.bg/modules/22/csharp-db-fundamentals)” course @ SoftUni.

Before starting this tutorial, make sure you’ve followed the [SQL Server installation guide](https://softuni.bg/downloads/svn/DB-Fundamentals/DB-Basics-MSSQL/Sept-2017/02.%20DB-Basics-MSSQL-Introduction-to-Databases/01.%20DB-Basics-MSSQL-Introduction-to-Databases-Installation-Guide.docx).
1. ## **Create a Database**
Create a new **database** named **Bank** using the **MS SQL Server Management Studio GUI**.

1. Right click on **Databases** in the **Object Explorer**:
1. Choose **New Database** from** the drop-down menu:
1. A popup window will open. Go to **Options** and change the **Collation** to **Cyrillic\_General\_100\_CI\_AS**:

   The reason we do this is so that **Cyrillic characters** show up properly.
   Then go back to **General**, type in “**Bank**” as the **Database name** and click [**OK**]:
1. ## **Create Tables**
1. Using an **SQL query**,** create table **Clients** with the following properties:
- **Id <a name="_hlk493088342"></a>**– unique **number** for every client (**auto-incremented**, **primary key**)
- **FirstName** – the **name** of the user, which will be no more than **50 Unicode characters** (**Cannot** be **null**).
- **LastName** – has the **same properties** as **FirstName**

|<p>CREATE TABLE Clients (</p><p>`	`Id INT PRIMARY KEY IDENTITY,</p><p>`	`FirstName NVARCHAR(50) NOT NULL,</p><p>`	`LastName NVARCHAR(50) NOT NULL</p><p>)</p>|
| :- |

1. Create table **AccountType** with:
- **Id** – <a name="_hlk493088589"></a>unique number for every type. (Auto incremented, primary key)
- **Name** – the name of the account type, no longer than **50 Unicode characters** (**Cannot** be **null**)

***Important: Don’t forget to select the query you want to run before clicking Execute (F5) if you have multiple queries!***

|<p>CREATE TABLE AccountTypes (</p><p>`	`Id INT PRIMARY KEY IDENTITY,</p><p>`	`[Name] NVARCHAR(50) NOT NULL</p><p>**)**</p>|
| :- |

1. Create table **Accounts** with:
- **Id** - **unique number** for every user. (**Auto incremented**, **primary key**)
- **AccountTypeId** – references the **AccountTypes** table (**foreign key**)
- **Balance** – **decimal** data type with up to 15 digits including 2 after the decimal point and a default value of 0 (Not null)
- **ClientId** – references the **Clients** table (**foreign key**)

|<p>CREATE TABLE Accounts (</p><p>`	`Id INT PRIMARY KEY IDENTITY,</p><p>`	`AccountTypeId INT FOREIGN KEY REFERENCES AccountTypes(Id),</p><p>`	`Balance DECIMAL(15, 2) NOT NULL DEFAULT(0),</p><p>`	`ClientId INT FOREIGN KEY REFERENCES Clients(Id)</p><p>)</p>|
| :- |
1. ## **Insert Sample Data into Database**
We need some data to work with, so let’s use **INSERT INTO** **(…) VALUES** **(…)** queries** to fill our tables:

|<p>INSERT INTO Clients (FirstName, LastName) VALUES</p><p>('Gosho', 'Ivanov'),</p><p>('Pesho', 'Petrov'),</p><p>('Ivan', 'Iliev'),</p><p>('Merry', 'Ivanova')</p><p></p><p>INSERT INTO AccountTypes (Name) VALUES</p><p>('Checking'),</p><p>('Savings')</p><p></p><p>INSERT INTO Accounts (ClientId, AccountTypeId, Balance) VALUES</p><p>(1, 1, 175),</p><p>(2, 1, 275.56),</p><p>(3, 1, 138.01),</p><p>(4, 1, 40.30),</p><p>(4, 2, 375.50)</p>|
| :- |
1. ## **Create a Function**
Now let’s create a **function**, which **calculates** the **total balance** from **all accounts** of a single **client**. Functions in **SQL** receive **parameters**, complete certain actions with them and **always** return a **result**. Our **function** will receive an **int**, called **@ClientID** and return a **DECIMAL**. It could look like this:

|<p>CREATE FUNCTION f\_CalculateTotalBalance (@ClientID INT)</p><p>RETURNS DECIMAL(15, 2)</p><p>BEGIN</p><p>`	`DECLARE @result AS DECIMAL(15, 2) = (</p><p>`	  `SELECT SUM(Balance) </p><p>`	  `FROM Accounts WHERE ClientId = @ClientID</p><p>`	`)	</p><p>`  `RETURN @result</p><p>END</p>|
| :- |

Now try and **select** the **function**, giving it an existing **client ID** as the **parameter**, example for **client ID è 4**:

|SELECT dbo.f\_CalculateTotalBalance(4) AS Balance|
| :- |

Notice the **dbo.** before the function name – this is the name of the **schema** which we **must** type when calling **functions**.
1. ## **Create Procedures**
Next, we’ll create a **procedure** that creates a **new account** for an **existing client**. Just like functions, **procedures** receive **parameters**, but **do not return** results. Our **procedure** will receive **@ClientID** and **@AccountTypeID** as **parameters** and will look like this:

|<p>CREATE PROC p\_AddAccount @ClientId INT, @AccountTypeId INT AS</p><p>INSERT INTO Accounts (ClientId, AccountTypeId) </p><p>VALUES (@ClientId, @AccountTypeId)</p>|
| :- |

Now we can **create** a new savings **account** for our **client** with **ID = 2** like this:

|p\_AddAccount 2, 2|
| :- |

After you **execute the procedure** a couple of times, don’t forget to **check** if an account is **added correctly**, using a **SELECT** statement:

|SELECT \* FROM Accounts|
| :- |

Let’s create **two** more **procedures** to **deposit** and **withdraw** money from the **accounts**.
### **Deposit Procedure**
The **deposit procedure** will always **add** our **input amount** to the **current balance**:

|<p>CREATE PROC p\_Deposit @AccountId INT, @Amount DECIMAL(15, 2) AS</p><p>UPDATE Accounts</p><p>SET Balance += @Amount</p><p>WHERE Id = @AccountId</p>|
| :- |
### **Withdraw Procedure**
The **withdraw procedure** will **subtract** the given **amount** of money from the account **if the balance is enough** and **return an error message if it isn’t**:

|<p>CREATE PROC p\_Withdraw @AccountId INT, @Amount DECIMAL(15, 2) AS</p><p>BEGIN</p><p>`	`DECLARE @OldBalance DECIMAL(15, 2)</p><p>`	`SELECT @OldBalance = Balance FROM Accounts WHERE Id = @AccountId</p><p>`	`IF (@OldBalance - @Amount >= 0)</p><p>`	`BEGIN</p><p>`		`UPDATE Accounts</p><p>`		`SET Balance -= @Amount</p><p>`		`WHERE Id = @AccountId</p><p>`	`END</p><p>`	`ELSE</p><p>`	`BEGIN</p><p>`		`RAISERROR('Insufficient funds', 10, 1)</p><p>`	`END</p><p>END</p>|
| :- |
1. ## **Create Transactions Table and a Trigger**
Our bank will need a way to **record transactions** done by its **clients**, so we are now going to create a **new table** and a **trigger**, which will **automatically** record the **date**, **time** and **amount transferred** into the table.

We will name the table **Transactions** and it will have:

- **Id** – unique **number** for every **transaction**. (**auto-incremented**, **primary key**)
- **AccountId** – references the **Accounts** table (**foreign key**)
- **OldBalance** – the balance **before** the transaction
- **NewBalance** – the balance **after** the transaction
- **Amount** – the amount transferred (**calculated** column)
- **DateTime** – the date and time of the transaction (as **datetime2** data type)

Let’s create the **table**:

|<p>CREATE TABLE Transactions (</p><p>`	`Id INT PRIMARY KEY IDENTITY,</p><p>`	`AccountId INT FOREIGN KEY REFERENCES Accounts(Id),</p><p>`	`OldBalance DECIMAL(15, 2) NOT NULL,</p><p>`	`NewBalance DECIMAL(15, 2) NOT NULL,</p><p>`	`Amount AS NewBalance - OldBalance,</p><p>`	`[DateTime] DATETIME2</p><p>)</p>|
| :- |

Now we can create our **trigger**, which will run whenever the **Accounts** table is **updated** by the **procedures** (or regular **UPDATE** statements), like this:

|<p>CREATE TRIGGER tr\_Transaction ON Accounts</p><p>AFTER UPDATE</p><p>AS</p><p>`	`INSERT INTO Transactions (AccountId, OldBalance, NewBalance, [DateTime])</p><p>`	`SELECT inserted.Id, deleted.Balance, inserted.Balance, GETDATE() FROM inserted</p><p>`	`JOIN deleted ON inserted.Id = deleted.Id</p>|
| :- |

We used the **built in deleted** and **inserted** tables to get the **OldBalance** and **NewBalance** values.

Next, let’s do some **transactions**, which should **run** our **trigger**:

|<p>p\_Deposit 1, 25.00</p><p>GO</p><p></p><p>p\_Deposit 1, 40.00</p><p>GO</p><p></p><p>p\_Withdraw 2, 200.00</p><p>GO</p><p></p><p>p\_Deposit 4, 180.00</p><p>GO</p>|
| :- |

And finally, let’s take a look at our **Transactions table** to make sure our **trigger** is working:

|SELECT \* FROM Transactions|
| :- |

The result should be something like this:



