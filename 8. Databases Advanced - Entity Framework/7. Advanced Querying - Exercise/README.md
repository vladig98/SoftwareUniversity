
# **Exercises: Advanced Querying**
This document defines the **exercise assignments** for the ["Databases Advanced – EF Core" course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).
# **BookShop System**
For the following tasks, use the [BookShop](http://svn.softuni.org/admin/svn/csharp-databases/2017-Sept/DB-Advanced-EF-Core/06.%20DB-Advanced-EF-Core-Advanced-Querying/BookShop.zip) database. You can download the complete project or create it yourself in **task 0**,** but you should still use the pre-defined **Seed()** method from the project to have the same **sample** data.
0. ## **Book Shop Database**
You must create a **database** for a **book** **shop** **system**. It should look like this:

### **Constraints**
Your **namespaces** should be:

- **BookShop** – for your **StartUp** class
- **BookShop.Data** – for your DbContext
- **BookShop.Models** – for your models

Your **models** should be:

- **BookShopContext** – your DbContext
- **Author**:
  - AuthorId
  - FirstName (up to 50 characters, unicode, not required)
  - LastName (up to 50 characters, unicode)
- **Book**:
  - BookId
  - Title (up to 50 characters, unicode)
  - Description (up to 1000 characters, unicode)
  - ReleaseDate (not required)
  - Copies (an integer)
  - Price
  - EditionType – enum (Normal, Promo, Gold)
  - AgeRestriction – enum (Minor, Teen, Adult)
  - Author
  - BookCategories
- **Category**:
  - CategoryId
  - Name (up to 50 characters, unicode)
  - CategoryBooks
- **BookCategory** – mapping class

For the following tasks, you will be creating methods that accept a BookShopContext as a parameter and use it to run some queries. Create those methods inside your **StartUp** class and upload your whole solution to **Judge**.
0. ## **Age Restriction**
Create a **method GetBooksByAgeRestriction**(BookShopContext context, **string** **command**), that returns in a **single** **string** all** book **titles**, each on a **new line,** that have **age** **restriction**, equal to the **given** **command**. Order the titles **alphabetically**.

Read **input** from the console in your **main** **method**, and call your **method** with the **necessary** **arguments**. Print the **returned** **string** to the console. **Ignore** casing of the input.
### **Example**

|**Input**|**Output**|
| :- | :- |
|miNor|<p>A Confederacy of Dunces</p><p>A Farewell to Arms</p><p>A Handful of Dust</p><p>…</p>|
|teEN|<p>A Passage to India</p><p>A Scanner Darkly</p><p>A Swiftly Tilting Planet</p><p>…</p>|
0. ## **Golden Books**
Just like in task 1, write a method **GetGoldenBooks**(BookShopContext context), that returns in a **single** string **titles of the golden edition books** that have **less than 5000 copies**,** each on a **new line**. Order them by **book** **id** ascending.

Call the **GetGoldenBooks()** method in your **Main()** and print the returned string to the console.
### **Example**

|**Output**|
| :- |
|<p>Lilies of the Field</p><p>Look Homeward</p><p>The Mirror Crack'd from Side to Side</p><p>…</p>|
0. ## **Books by Price**
Write a **GetBooksByPrice**(BookShopContext context) method that returns in a single string all **titles and prices** **of books** with **price higher than 40**, each on a **new** **row** in the **format** given below. Order them by **price** descending.
### **Example**

|**Output**|
| :- |
|<p>O Pioneers! - $49.90</p><p>That Hideous Strength - $48.63</p><p>A Handful of Dust - $48.63</p><p>…</p>|
0. ## **Not Released In**
Write a **GetBooksNotRealeasedIn**(BookShopContext context**, int year**) method that returns in a **single** string all **titles of books** that are **NOT released** on a given year. Order them by **book** **id** ascending.
### **Example**

|**Input**|**Output**|
| :- | :- |
|2000|<p>Absalom</p><p>Nectar in a Sieve</p><p>Nine Coaches Waiting</p><p>…</p>|
|1998|<p>The Needle's Eye</p><p>No Country for Old Men</p><p>No Highway</p><p>…</p>|
0. ## **Book Titles by Category**
Write a **GetBooksByCategory**(BookShopContext context, string input) method that **selects** and **returns** in a single string the **titles of books** by a given **list of categories**. The list of **categories** will be given in a single line separated with one or more spaces. Ignore casing. Order by **title** alphabetically.
### **Example**

|**Input**|**Output**|
| :- | :- |
|horror mystery drama|<p>A Fanatic Heart</p><p>A Farewell to Arms</p><p>A Glass of Blessings</p><p>…</p>|
0. ## **Released Before Date**
Write a **GetBooksReleasedBefore**(BookShopContext context, string date) method that **returns the title, edition type and price** of all books that are **released before a given date**. The date will be a string **in format <a name="ole_link1"></a><a name="ole_link2"></a><a name="ole_link3"></a>dd-MM-yyyy**.

Return all of the rows in a **single** string, ordered by **release** **date** **descending**.
### **Example**

|**Input**|**Output**|
| :- | :- |
|12-04-1992|<p>If I Forget Thee Jerusalem - Gold - $33.21</p><p>Oh! To be in England - Normal - $46.67</p><p>The Monkey's Raincoat - Normal - $46.93</p><p>…</p>|
|30-12-1989|<p>A Fanatic Heart - Normal - $9.41</p><p>The Curious Incident of the Dog in the Night-Time - Normal - $23.41</p><p>The Other Side of Silence - Gold - $46.26</p><p>…</p>|
0. ## **Author Search**
Write a **GetAuthorNamesEndingIn**(BookShopContext context, string input) method that returns the **full** **names** of **authors**, whose **first** **name** ends with a **given** **string**.

Return all **names** in a **single** **string**, each on a **new** **row**, ordered alphabetically.
### **Example**

|**Input**|**Output**|
| :- | :- |
|e|<p>George Powell</p><p>Jane Ortiz</p>|
|dy|Randy Morales|
0. ## **Book Search**
Write a **GetBookTitlesContaining**(BookShopContext context, string input) method that returns the **titles** of **book**, which contain a **given** **string**. Ignore casing.

Return all **titles** in a **single** **string**, each on a **new** **row**, ordered alphabetically.
### **Example**

|**Input**|**Output**|
| :- | :- |
|sK|<p>A Catskill Eagle</p><p>The Daffodil Sky</p><p>The Skull Beneath the Skin</p>|
|WOR|<p>Great Work of Time</p><p>Terrible Swift Sword</p>|
0. ## **Book Search by Author**
Write a **GetBooksByAuthor**(BookShopContext context, string input) method that **returns all titles of books and their authors’ names** for books, which are written by authors whose last names **start with the given string**.

Return a single string with each title on a new row. **Ignore** casing. Order by **book** **id** ascending.
### **Example**

|**Input**|**Output**|
| :- | :- |
|R|<p>The Heart Is Deceitful Above All Things (Bozhidara Rysinova)</p><p>His Dark Materials (Bozhidara Rysinova)</p><p>The Heart Is a Lonely Hunter (Bozhidara Rysinova)</p><p>…</p>|
|po|<p>Postern of Fate (Stanko Popov)</p><p>Precious Bane (Stanko Popov)</p><p>The Proper Study (Stanko Popov)</p><p>…</p>|
0. ## **Count Books**
Write a **CountBooks**(BookShopContext context, int lengthCheck) method that **returns the number of books,** which have a **title longer than the number** given as an input.
### **Example**

|**Input**|**Output**|**Comments**|
| :- | :- | :- |
|12|169|There are 169 books with longer title than 12 symbols|
|40|2|There are 2 books with longer title than 40 symbols|
0. ## **Total Book Copies**
Write a method **CountCopiesByAuthor**(BookShopContext context) that **returns** the **total number of book copies** **for each author**. Order the results **descending by total book copies**.

Return all results in a **single** **string**, each on a **new** **line**.
### **Example**

|**Output**|
| :- |
|<p>Stanko Popov - 117778</p><p>Lyubov Ivanova - 107391</p><p>Jane Ortiz – 103673</p><p>…</p>|
0. ## **Profit by Category**
Write a method **GetTotalProfitByCategory**(BookShopContext context) that **returns** the **total profit of all books by category**. Profit for a book can be calculated by multiplying its **number of copies** by the **price per single book**. Order the results by **descending by total profit** for category and **ascending by category name**.
### **Example**

|**Output**|
| :- |
|<p>Art $6428917.79</p><p>Fantasy $5291439.71</p><p>Adventure $5153920.77</p><p>Children's $4809746.22</p><p>…</p>|
0. ## **Most Recent Books**
Get the most recent books by categories in a **GetMostRecentBooks**(BookShopContext context) method. The **categories** should be ordered by **name alphabetically**. Only take the **top 3** most recent books from each category - ordered by **release date** (descending). **Select** and **print** the **category name**, and for each **book** – its **title** and **release year**.
### **Example**

|**Output**|
| :- |
|<p>--Action</p><p>Brandy of the Damned (2015)</p><p>Bonjour Tristesse (2013)</p><p>By Grand Central Station I Sat Down and Wept (2010)</p><p>--Adventure</p><p>The Cricket on the Hearth (2013)</p><p>Dance Dance Dance (2002)</p><p>Cover Her Face (2000)</p><p>…</p>|
0. ## **Increase Prices**
Write a method **IncreasePrices**(BookShopContext context) that **increases the prices of all books** **released before 2010 by 5**.
0. ## **Remove Books**
Write a method **RemoveBooks**(BookShopContext context) that **removes from the database** those **books**, which have less than **4200 copies**. Return an **int** - the **number of books that were deleted** from the database.
### **Example**

|**Output**|
| :- |
|34 books were deleted|




