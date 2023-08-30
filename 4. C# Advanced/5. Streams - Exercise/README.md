
# **Exercise: Streams and Files**
This document defines the homework assignments from the ["CSharp Advanced" course @ Software University](https://softuni.bg/courses/csharp-advanced). Please submit as homework a single **zip** / **rar** / **7z** archive holding the solutions (source code) of all below described problems. The solutions should be written in C#.
1. ## **Odd Lines**
Write a program that reads a **text** file and prints on the console its **odd** **lines**. Line numbers start from 0. Use **StreamReader**.

|**text.txt**|**Output**|
| :-: | :-: |
|<p>-I was quick to judge him, but it wasn't his fault.</p><p>-Is this some kind of joke?! Is it?</p><p>-Quick, hide here…It is safer.</p>|<p>-Is this some kind of joke?! Is it?</p><p></p>|

1. ## **Line Numbers**
Write a program that **reads** a **text** **file** and inserts **line** **numbers** in front of **each** of its **lines**. The result should be **written** to **another** text file. Use **StreamReader** in combination with **StreamWriter**.

|**text.txt**|**output.txt**|
| :-: | :-: |
|<p>-I was quick to judge him, but it wasn't his fault.</p><p>-Is this some kind of joke?! Is it?</p><p>-Quick, hide here…It is safer.</p>|<p>Line 1: -I was quick to judge him, but it wasn't his fault.</p><p>Line 2: -Is this some kind of joke?! Is it?</p><p>Line 3: -Quick, hide here…It is safer.</p>|

1. ## **Word Count**
Write a program that reads a **list** of **words** from the file **words.txt** and finds **how** **many** **times** each of the words is **contained** in another file **text.txt**. Matching should be **case-insensitive**.

Write the results in file **results.txt**. **Sort** the words by **frequency** in **descending** order. Use **StreamReader** in combination with **StreamWriter**.

|**words.txt**|**text.txt**|**result.txt**|
| :-: | :-: | :-: |
|<p>quick</p><p>is</p><p>fault</p>|<p>-I was quick to judge him, but it wasn't his fault.</p><p>-Is this some kind of joke?! Is it?</p><p>-Quick, hide here…It is safer.</p>|<p>is - 3</p><p>quick - 2</p><p>fault - 1</p>|
1. ## **Copy Binary File**
Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using **FileStream**. You are **not allowed** to use the **File** class or similar helper classes.
1. ## **Slicing File**
Write a program that takes **any** **file** and **slices** it to **n** parts. Write the following methods:

- **Slice(string sourceFile, string destinationDirectory, int parts)** - **slices** the given source file into **n** parts and **saves** them in **destinationDirectory**.

|**Source File**|**Destination Directory**|
| :-: | :-: |
|parts = 5||

- **Assemble(List<string> files, string destinationDirectory)** - **combines** all files into one, in the **order** they are **passed**, and **saves** the result in **destinationDirectory**.

|**Source Files**|**Destination Directory**|
| :-: | :-: |
|||

Use **FileStreams**. You are **not allowed** to use the **File** class or similar helper classes.
1. ## **Zipping Sliced Files**
**Modify** your previous program to also **compress** the bytes while slicing parts and **decompress** them when assembling them back to the **original** file. Use **GzipStream**.

**Tip**: When getting files from directory, make sure you only get files with **.gz** extension (there might be hidden files).

|**Source File**|**Compressed & Sliced**|**Decompressed & Assembled**|
| :-: | :-: | :-: |
|parts = 5|||
1. ## **Directory Traversal**
Traverse a given **directory** for **all** **files** with the given **extension**. Search through the **first** **level** of the **directory** **only** and write information about each **found** file in **report.txt**.

The files should be **grouped** by their **extension**. **Extensions** should be **ordered** by the **count** of their files **descending**, then by **name alphabetically**.

**Files** under an extension should be **ordered** by their **size**.

**report.txt** should be saved on the **Desktop**. Ensure the desktop path is always valid, regardless of the user.

|**Input**|**Directory View**|**report.txt**|
| :-: | :-: | :-: |
|.||<p>.cs</p><p>--Mecanismo.cs - 0.994kb</p><p>--Program.cs - 1.108kb</p><p>--Nashmat.cs - 3.967kb</p><p>--Wedding.cs - 23.787kb</p><p>--Program - Copy.cs - 35.679kb</p><p>--Salimur.cs - 588.657kb</p><p>.txt</p><p>--backup.txt - 0.028kb</p><p>--log.txt - 6.72kb</p><p>.asm</p><p>--script.asm - 0.028kb</p><p>.config</p><p>--App.config - 0.187kb</p><p>.csproj</p><p>--01. Writing-To-Files.csproj - 2.57kb</p><p>.js</p><p>--controller.js - 1635.143kb</p><p>.php</p><p>--model.php - 0kb</p>|
1. ## **\* Full Directory Traversal**
Modify your previous program to **recursively traverse** the **sub-directories** of the starting directory as well.
1. ## **\*\* HTTP Server**
Create a simple HTTP server that should be able to **receive requests** and **return appropriate responses** accordingly to the **request path**. **Read** more on the internet to see what HTTP request and response should look like. Create a web site of 3 pages:

- <b>1<sup>st</sup></b> page should be accessible at <b>localhost:{port}/</b> - (that is the root directory). That page holds just <b>welcome message</b> and <b>link</b> to the second page
- <b>2<sup>nd</sup></b> page should be accessible at <b>localhost:{port}/info</b> – that page shows the <b>current time</b> and the <b>count of logical processors</b> on the machine
- <b>3<sup>rd</sup></b> page should be an <b>error page</b> if the user tries to access any other page return as response the error page.

You are provided with some HTML files of the needed pages to make it easier for you. You are free to modify them and even use your own HTML files.
### **Examples**







