
# **Lab: Iterators and Comparators**
Problems for exercises and homework for the [\["C# OOP Advanced" course @ Software University\](https://softuni.bg/courses/csharp-oop-advanced-high-quality-code)](https://softuni.bg/courses/java-oop-advanced). You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/707/Iterators-and-Comparators-Lab)[](https://judge.softuni.bg/Contests/Compete/Index/498#3)
1. ## **Library**
Create a class **Book** which should have three public properties:

- **string Title**
- **int Year**
- **List<string> Authors**

Authors can be **anonymous, one or many**. A Book should have only **one** **constructor**.

Create a class **Library** which should store a collection of books and implement the **IEnumerable<Book>** interface. 

- **List<Book> books**

A Library should be could be intilized without books or with any number of books and should have only **one** **constructor**.
### **Examples**

|**Startup.cs**|
| :-: |
|<p>` `public static void Main()</p><p>` `{</p><p>`     `Book bookOne = new Book("Animal Farm", 2003, "George Orwell");</p><p>`     `Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");</p><p>`     `Book bookThree = new Book("The Documents in the Case", 1930);</p><p></p><p>`     `Library libraryOne = new Library();</p><p>`     `Library libraryTwo = new Library(bookOne, bookTwo, bookThree); </p><p>` `}</p>|

### **Solution**


1. ## **Library Iterator**
Extend your solution from the prevoius task. Inside the Library class create a **nested class** **LibraryIterator** which should implement the **IEnumerator<Book>** interface. Try to implement the bodies of the inherited methods by yourself. You will need two more members:

- **List<Book> books**
- **int currentIndex**

Now you should be able to iterate through a Library in the Main method.
### **Examples**

|**Startup.cs**|
| :-: |
|<p>` `public static void Main()</p><p>` `{</p><p>`     `<a name="ole_link1"></a>Book bookOne = new Book("Animal Farm", 2003, "George Orwell");</p><p>`     `Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");</p><p>`     `Book bookThree = new Book("The Documents in the Case", 1930);</p><p></p><p>`     `Library libraryOne = new Library();</p><p>`     `Library libraryTwo = new Library(bookOne, bookTwo, bookThree); </p><p></p><p>`     `<a name="ole_link2"></a>foreach (var book in libraryFull)</p><p>`     `{</p><p>`         `Console.WriteLine(book.Title);</p><p>`     `}</p><p>` `}</p>|


|**Output**|
| :-: |
|<p>Animal Farm</p><p>The Documents in the Case</p><p>The Documents in the Case</p>|

### **Solution**

1. ## **Comparable Book**
Extend your solution from the prevoius task. Implement the **IComparable<Book>** interface in the existing class **Book**. The comparison between two books should happen in the following order:

- First sort them in **ascending chronological** order (by year)
- If two books are published in the **same year**, sort them **alphabetically**

Override the **ToString()** method in your Book class so it returns a string in the format:

- {**title**} - {**year**}

Change your Library class so that it stores the books in the correct order.

You don’t need to change anything in your **Main** method from the previous task except for the way to print a book on the Console. 
### **Examples**

|**Output**|
| :-: |
|<p>The Documents in the Case - 1930</p><p>The Documents in the Case - 2002</p><p>Animal Farm - 2003</p>|


### **Solution**

1. ## **Book Comparator**
Extend your solution from the prevoius task. Create a class **BookComparator** which should implement the **IComparer<Book>** interface and thus include the following method: 

- **int Compare(Book, Book)** 

**BookComparator** must **compare** two books by:

1. Book title - **alphabetical order**
1. Year of publishing a book - **from the newest to the oldest**

Modify your Library class once again to implement the **new sorting**.
### **Examples**

|**Startup.cs**|
| :-: |
|<p>` `public static void Main()</p><p>` `{</p><p>`     `Book bookOne = new Book("Animal Farm", 2003, "George Orwell");</p><p>`     `Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");</p><p>`     `Book bookThree = new Book("The Documents in the Case", 1930);</p><p></p><p>     </p><p></p><p>` `}</p>|


|**Output**|
| :-: |
|<p>Animal Farm - 2003</p><p>The Documents in the Case - 2002</p><p>The Documents in the Case - 1930</p>|

### **Solution**



