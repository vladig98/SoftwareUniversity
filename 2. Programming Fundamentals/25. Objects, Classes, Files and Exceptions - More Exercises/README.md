
# **More Exercises: Objects, Classes, Files and Exceptions**
Problems for exercises and homework for the [“Programming Fundamentals” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions [here](https://judge.softuni.bg/Contests/Compete/Index/584).
1. # **Objects and Classes**
1. ## **Order by Age**
You will receive an **unknown** number of lines. On each line, you will receive array with **3** elements. **The first** element will be string and represents the name of the person. **The second** element will be a **string** and will represent the **ID** of the person. **The last** element will be an **integer** and represents the **age** of the person.

When you receive the command “**End**”, stop taking input and print **all the** **people**, **ordered** by **age**. 
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Georgi 123456 20</p><p>Pesho 78911 15</p><p>Stefan 524244 10</p><p>End</p>|<p>Stefan with ID: 524244 is 10 years old.</p><p>Pesho with ID: 78911 is 15 years old.</p><p>Georgi with ID: 123456 is 20 years old.</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>Maria 123456 120</p><p>Georgi 31241 50</p><p>Denis 41231 23</p><p>End</p>|<p>Denis with ID: 41231 is 23 years old.</p><p>Georgi with ID: 31241 is 50 years old.</p><p>Maria with ID: 123456 is 120 years old.</p>|
### **Hints**
- For C#, you can use **.OrderBy(…)** from **System.Linq** to specify according to which parameter to order the people.
- For Java, you can do the same with **.sorted(…)** from **Stream API**.
1. ## **Vehicle Catalogue**
You have to make a catalogue for vehicles. You will receive two types of vehicle – **car** or **truck**. 

Until you receive the command “**End**” you will receive **lines** of **input** in the format:

|**{typeOfVehicle} {model} {color} {horsepower}**|
| :- |

After the “**End**” command, you will start receiving **models** of **vehicles**. Print for every received vehicle its **data** in the format:

|<p>**Type: {typeOfVehicle}**</p><p>**Model: {modelOfVehicle}**</p><p>**Color: {colorOfVehicle}**</p><p>**Horsepower: {horsepowerOfVehicle}**</p>|
| :- |

When you receive the command “**Close the Catalogue**”, stop receiving input and print the **average** **horsepower** for the **cars** and for the **trucks** in the format:

**{typeOfVehicles} have average horsepower of {averageHorsepower}.**

The **average** **horsepower** is calculated by **dividing** the **sum** of **horsepower** for **all** vehicles of the type by the **total** **count** of **vehicles** from the **same** **type**.

Format the answer to the <b>2<sup>nd</sup> decimal point</b>.
### **Constraints**
- The type of vehicle will always be **car** or **truck**.
- You will not receive the **same** **model** **twice**.
- The received horsepower will be integer in the interval **[1…1000]**
- You will receive at most **50** vehicles.
- **Single** whitespace will be used for **separator**.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>truck Man red 200</p><p>truck Mercedes blue 300</p><p>car Ford green 120</p><p>car Ferrari red 550</p><p>car Lamborghini orange 570</p><p>End</p><p>Ferrari</p><p>Ford</p><p>Man</p><p>Close the Catalogue</p>|<p>Type: Car</p><p>Model: Ferrari</p><p>Color: red</p><p>Horsepower: 550</p><p>Type: Car</p><p>Model: Ford</p><p>Color: green</p><p>Horsepower: 120</p><p>Type: Truck</p><p>Model: Man</p><p>Color: red</p><p>Horsepower: 200</p><p>Cars have average horsepower of: 413.33.</p><p>Trucks have average horsepower of: 250.00.</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>Car Skoda grey 90</p><p>car Nissan black 90</p><p>car Bugatti blue 1000</p><p>End</p><p>Skoda</p><p>Close the Catalogue</p>|<p>Type: Car</p><p>Model: Skoda</p><p>Color: grey</p><p>Horsepower: 90</p><p>Cars have average horsepower of: 393.33.</p><p>Trucks have average horsepower of: 0.00.</p>|
1. ## **\* Jarvis**
Every kid’s dream is to have its own personal robot to be their butler and/or slave. Until now, we could not build a fully functional robot, but we can write a program, which simulates what it would be like to build. Let’s call him a code name – **Jarvis**.

Our robot will consist of **6** components – **2** arms, **2** legs, **torso** and a **head**. Make **classes** for these components and your robot should have **fields** for **each** of the **components**. 

**Each** component has **different** properties:

- Arms have:
  - Energy consumption **(integer)**
  - Arm reach distance **(integer)**
  - Count of fingers **(integer)**
- Legs have:
  - Energy consumption **(integer)**
  - Strength **(integer)**
  - Speed **(integer)**
- Torso has:
  - Energy consumption **(integer)**
  - Processor size in centimeters **(double)**
  - Housing material **(string)**
- Head has:
  - Energy consumption **(integer)**
  - IQ **(integer)**
  - Skin material **(string)**

On the first line, you will receive the **maximum** **energy capacity** of the **robot**. **Until** you receive the command “**Assemble!**”, you will continuously receive lines with data for **different** components in format:

**{typeOfComponent} {energyConsumption} {property1} {property2}**

The properties will **always** be given in the **same** **order** as they are described above. If you receive a **component** which is more **energy** **efficient** than **previous** one – you should **delete** the old component and **replace** it with the **new** one. When **both** of the components **consume** **more** **energy** than the one, which you try to **add** à remove the **one**, which is **added** **first**.
### **Input**
- On the **first** line, you will receive the **maximum** **energy** **capacity** of the robot.
- Until you receive the command “**Assemble!**” you will receive components in the format:
  **{typeOfComponent} {energyConsumption} {property1} {property2}**
### **Output**
- If you do **not** have enough **energy** **efficient** components to **assemble** the robot print:
  “**We need more power!**”
- If you do not have enough parts print:
  “**We need more parts!**”
- If you **can** build a **robot** with the given **components** print:

|<p>**Jarvis:**</p><p>**#Head:**</p><p>**###Energy consumption: {head’s energy consumption}**</p><p>**###IQ: {head’s IQ}**</p><p>**###Skin material: {head’s skin material}**</p><p>**#Torso:**</p><p>**###Energy consumption: {torso’s energy consumption}**</p><p>**###Processor size: {size of the processor}**</p><p>**###Corpus material: {torso’s corpus material}**</p><p>**#Arm:**</p><p>**###Energy consumption: {arm’s energy consumption}**</p><p>**###Reach: {arm’s reach}**</p><p>**###Fingers: {count of fingers}**</p><p>**#Arm:**</p><p>**###Energy consumption: {arm’s energy consumption}**</p><p>**###Reach: {arm’s reach}**</p><p>**###Fingers: {count of fingers}**</p><p>**#Leg:**</p><p>**###Energy consumption: {head’s energy consumption}**</p><p>**###Strength: {leg’s strength}**</p><p>**###Speed: {leg’s speed}**</p><p>**#Leg:**</p><p>**###Energy consumption: {head’s energy consumption}**</p><p>**###Strength: {leg’s strength}**</p><p>**###Speed: {leg’s speed}**</p>|
| :- |

Print the **legs** and the **feet** ordered by **energy** consumption in **ascending order**. 
### **Constraints**
- Jarvis’ energy will be in the interval **[0…9223372036854775807]**
- Components’ energy will be in the interval **[-2147483648…2147483647]**
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>1000</p><p>Head 500 20 Leather</p><p>Torso 300 3 Aluminum</p><p>Leg 150 20 20</p><p>Leg 100 30 30</p><p>Arm 500 20 30</p><p>Leg 80 30 30</p><p>Arm 120 20 5</p><p>Arm 100 30 4</p><p>Head 200 20 Leather</p><p>Assemble!</p>|<p>Jarvis:</p><p>#Head:</p><p>###Energy consumption: 200</p><p>###IQ: 20</p><p>###Skin material: Leather</p><p>#Torso:</p><p>###Energy consumption: 300</p><p>###Processor size: 3.0</p><p>###Corpus material: Aluminum</p><p>#Arm:</p><p>###Energy consumption: 100</p><p>###Reach: 30</p><p>###Fingers: 4</p><p>#Arm:</p><p>###Energy consumption: 120</p><p>###Reach: 20</p><p>###Fingers: 5</p><p>#Leg:</p><p>###Energy consumption: 80</p><p>###Strength: 30</p><p>###Speed: 30</p><p>#Leg:</p><p>###Energy consumption: 100</p><p>###Strength: 30</p><p>###Speed: 30</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>5000</p><p>Leg 1000 20 30</p><p>Arm 500 30 50</p><p>Arm 500 30 20</p><p>Arm 500 30 50</p><p>Arm 300 60 80</p><p>Torso 700 30 40</p><p>Leg 200 100 100</p><p>Assemble!</p>|We need more parts!|


|**Input**|**Output**|
| :-: | :-: |
|<p>500</p><p>Head 500 20 Leather</p><p>Torso 300 3 Aluminum</p><p>Leg 150 20 20</p><p>Leg 100 30 30</p><p>Arm 500 20 30</p><p>Leg 80 30 30</p><p>Arm 120 20 5</p><p>Arm 100 30 4</p><p>Head 200 20 Leather</p><p>Assemble!</p>|We need more power!|
### **Hints**
- You might want to override the **ToString(…)** method in some of your classes.
1. # **Files**
For these tasks, you will receive **sample\_text.txt file**, which you have to use to make your **exercises**. Just **submit** the **result** of the tasks as plain **text** in the **Judge**.
1. ## **Punctuation Finder**
Read the file, which is in the resource section of the exercise and print all the **punctuation** marks, which you **find** and **separate** them with **comma and a space**. For punctuation marks you can consider only: “**.**”, “**,**”, “**!**”, “**?**” and “**:**”.

Submit the **output** in **judge**.
### **Examples**

|**File Content**|**Output**|
| :-: | :-: |
|<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p><p>*More text will be given…*</p>|<p>,, ,, .,</p><p>*Continues…*</p>|
1. ## **Write to File**
Read the **same** file, as in the **previous** task, but this time write everything, **except** the **punctuation** marks to a **new** file. Again, consider as punctuations only: “**.**”, “**,**”, “**!**”, “**?**” and “**:**”.

Submit the content of the file in **judge.**
### **Examples**

|**File Content**|**Output**|
| :-: | :-: |
|<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p><p>***More text will be given…***</p>|<p>Lorem ipsum dolor sit amet consectetur adipiscing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</p><p>***Continues…***</p>|
1. ## **\*\* EXCELlent Knowledge**
You received excel table named **sample\_table.xlsx**. Write a program, which **reads** the table and **prints** all the columns **separated** with single **pipe** (‘**|**’). 
### **Examples**
The **first** line of your table should look like this:

|**Output**|
| :-: |
|<p>ZIP|Sales|Name|Year|Value|</p><p>***Continues…***</p>|
### **Hints**
- For C#:
  - Add reference to [Microsoft Excel Object Library](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interop/how-to-access-office-onterop-objects).
  - You can follow [this](https://coderwall.com/p/app3ya/read-excel-file-in-c) guide for writing the code.
- For Java:
  - You should create Maven project in IntelliJ. You can make it [this way](https://www.jetbrains.com/help/idea/getting-started-with-maven.html).
  - You can find more information about Apache Maven [here](https://maven.apache.org/).
  - After that follow, this [guide](http://www.codejava.net/coding/how-to-read-excel-files-in-java-using-apache-poi) to read the Excel file.
1. # **Exceptions**
1. ## **Play Catch**
You will receive on the **first** line an **array** of **integers**. After that you will receive **commands**, which should **manipulate** the array:

- “**Replace {index} {element}**” – **Replace** the element at the given **index** with the given **element**. 
- “**Print {startIndex} {endIndex}**” – **Print** the elements from the **start** index to the **end** index **inclusive**.
- “**Show {index}**” – **Print** the element at the **index**.

You have the task to **rewrite** the **messages** from the **exceptions** which can be **produced** from your **program**:

- If you receive an **index**, which does **not** **exist** in the **array** print:
  “**The index does not exist!**”
- If you receive a **variable**, which is of **invalid** **type**:
  “<a name="ole_link1"></a><a name="ole_link2"></a><a name="ole_link3"></a>**The variable is not in the correct format!**”

` `When you catch **3** exceptions – **stop** the **input** and **print** the **elements** of the array separated with “**,** ”.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>**1 2 3 4 5**</p><p>Replace 1 9</p><p>Replace 6 3</p><p>Show 3</p><p>Show pesho</p><p>Show 6</p>|<p>The index does not exist!</p><p>4</p><p>The variable is not in the correct format!</p><p>The index does not exist!</p><p>1, 9, 3, 4, 5</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>1 2 3 4 5</p><p>Replace 3 9</p><p>Print 1 4</p><p>Print -3 12</p><p>Print 1 5</p><p>Show 3</p><p>Show 12.3</p><p>1, 2, 3, 4, 5</p>|<p>2, 3, 9, 5</p><p>The index does not exist!</p><p>The index does not exist!</p><p>9</p><p>The variable is not in the correct format!</p><p>1, 2, 3, 9, 5</p>|
### **Constraints**
- The **elements** of the array will be in **integers** in the interval **[-2147483648…2147483647]**
- You will always receive **valid** string for the **first** part of the **command**, but the **parameters** might be **invalid**
- In the “**Print**”** command always be true **startIndex <= endIndex**
- You will always **receive** at least **3** exceptions
1. ## **\* Personal Exception**
Write your own exception, which is thrown every time a **negative** **number** is received from the **console**. The **message** of the **exception** should be “**My first exception is awesome!!!**”

Your task is to print every number **greater or equal** to **0.**

If **negative** number is given as input – **catch** the exception and **print** **exception’s** message. **Stop** the program when your Exception is **thrown**. 
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>1</p><p>2</p><p>3</p><p>-5</p></td><td colspan="1" valign="top"><p>1</p><p>2</p><p>3</p><p>My first exception is awesome!!!</p></td><td colspan="1" valign="top"><p>1</p><p>2</p><p>3</p><p>-4</p><p>5</p><p></p></td><td colspan="1" valign="top"><p>1</p><p>2</p><p>3</p><p>My first exception is awesome!!!</p></td></tr>
</table>
### **Hints**
- For C#:
  - Make **new** class for the **exception** and choose appropriate name
  - Inherit the class **System.Exception**
  - Make one **constructor**, which **inherits** the **base**
  - Pass the **message** to the **base** constructor
  - In the **Main()** make while loop and **throw** **exception**, if the input number is less than 0
  - Catch the exception and print the message. You can access the message with **Exception.Message**
- For Java:
  - Make **new** class for the **exception** and choose appropriate name
  - Inherit the class **java.lang.Exception**
  - Make one **constructor**, which **inherits** the **super**
  - Pass the **message** to the **super** constructor
  - In the **main()** make while loop and **throw** **exception**, if the input number is **less** **than** **0**
  - Catch the exception and print the message. You can access the message with **Exception.getMessage()**

Submit a **.zip** archive with the **main** method and the **exception’s class**.

