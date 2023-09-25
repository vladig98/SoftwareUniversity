
# **Lab: Asynchronous Programming**
This document defines the **in-class exercises** assignments for the ["C# Web Development Basics" course @ Software University](https://softuni.bg/courses/csharp-web-development-basics).

1. **Even Numbers Thread**

Print all even numbers in a given range. Printing should be executed on a separate thread. After finishing print "**Thread finished work**".
### **Examples**

|<a name="_hlk492405192"></a>**Input**|**Output**|
| - | - |
|1 10|<p>2</p><p>4</p><p>6</p><p>8</p><p>10</p><p>Thread finished work</p>|
### **Hints**
Use the **Thread** class and its methods **Start()** and **Join()**.

1. **Slice File**

Slice given file into given number of pieces. You will receive the name of the file, the destination folder to keep the pieces and the number of pieces.

While executing the operation the console interface should stay responsive.

### **Examples**

|||
| :- | :- |
### **Hints**
Implement the slicing logic

Inside this method check if the destination folder exists and if not – create it.

Open **FileStream** to read the source file and create **FileInfo** object to keep the source file data.






Start processing each new piece by creating its name.

Open new stream to write the piece in the destination folder.

Print a message when the slicing is over.

Write a method that runs a task with the slicing logic.



Read the input and call the method, that runs the task.

1. ## **Simple Web Server**
Write a simple web server that receives requests from a client. Print the request to the console and send a message to the client.
### **Examples**

<table><tr><th colspan="1"><b>Input</b></th><th colspan="1"><b>Output</b></th></tr>
<tr><td colspan="1" rowspan="2" valign="top"></td><td colspan="1" valign="top"></td></tr>
<tr><td colspan="1" valign="top"></td></tr>
</table>

` `Note: Sent data may not be accepted by every browser (cough \*chrome\* cough).


### **Hints**
Write a task to connect with the client

Read the request and print it on the console.

Send a greeting to the client.

Close the connection.

Create a **TcpListener** object a start the connection task.




