
# **Exercises: Sets and Dictionaries Advanced**
Problems for exercises and homework for the ["C# Advanced" course @ SoftUni](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here: <https://judge.softuni.bg/Contests/1182/>
1. ## **Unique Usernames**
On the first line you will be given an integer **N**. On the next **N** lines you will receive one username per line. Write a simple program that reads from the console a sequence of **N** usernames and keeps a collection only of the unique ones. Print the collection on the console in order of insertion:
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>6</p><p>Ivan</p><p>Ivan</p><p>Ivan</p><p>SemoMastikata</p><p>Ivan</p><p>Hubaviq1234</p>|<p>Ivan</p><p>SemoMastikata</p><p>Hubaviq1234</p>|

1. ## **Sets of Elements**
On the first line you are given the length of two sets **n** and **m**. On the next **n** + **m** lines there are **n** numbers that are in the first set and **m** numbers that are in the second one. Find all non-repeating elements that appear in both of them and print those from the **n** set.

Set with length n = 4: {1, **3**, **5**, 7}

Set with length m = 3: {**3**, 4, **5**}

Set that contains all repeating elements -> {**3**, **5**}
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>4 3</p><p>1</p><p>3</p><p>5</p><p>7</p><p>3</p><p>4</p><p>5</p>|3 5|
|<p>2 2</p><p>1</p><p>3</p><p>1</p><p>5</p>|1|

1. ## **Periodic Table**
You are given an **n** number of chemical compounds joined with space (' '). You need to keep track of all chemical elements used in the compounds and at the end print all unique ones in ascending order:
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>4</p><p>Ce O</p><p>Mo O Ce</p><p>Ee</p><p>Mo</p>|Ce Ee Mo O|
|<p>3</p><p>Ge Ch O Ne</p><p>Nb Mo Tc</p><p>O Ne</p>|Ch Ge Mo Nb Ne O Tc|

1. ## **Even Times**
You are given a list of **N** integer numbers all but one of which appears an odd number of times. Write a program to find the one integer which appears an **even number of times**.
### **Examples**

|**Input**|**Output**|**Input**|**Output**|
| :-: | :-: | :-: | :-: |
|<p>3</p><p>2</p><p>-1</p><p>2</p>|2|<p>5</p><p>1</p><p>2</p><p>3</p><p>1</p><p>5</p>|1|
1. ## **Count Symbols**
Write a program that reads some text from the console and counts the occurrences of each character in it. Print the results in **alphabetical** (lexicographical) order. 
### **Examples**

|**Input**|**Output**|**Input**|**Output**|
| :-: | :-: | :-: | :-: |
|SoftUni rocks|<p>` `: 1 time/s</p><p>S: 1 time/s</p><p>U: 1 time/s</p><p>c: 1 time/s</p><p>f: 1 time/s</p><p>i: 1 time/s</p><p>k: 1 time/s</p><p>n: 1 time/s</p><p>o: 2 time/s</p><p>r: 1 time/s</p><p>s: 1 time/s</p><p>t: 1 time/s</p>|Did you know Math.Round rounds to the nearest even integer?|<p>` `: 9 time/s</p><p>.: 1 time/s</p><p>?: 1 time/s</p><p>D: 1 time/s</p><p>M: 1 time/s</p><p>R: 1 time/s</p><p>a: 2 time/s</p><p>d: 3 time/s</p><p>e: 7 time/s</p><p>g: 1 time/s</p><p>h: 2 time/s</p><p>i: 2 time/s</p><p>k: 1 time/s</p><p>n: 6 time/s</p><p>o: 5 time/s</p><p>r: 3 time/s</p><p>s: 2 time/s</p><p>t: 5 time/s</p><p>u: 3 time/s</p><p>v: 1 time/s</p><p>w: 1 time/s</p><p>y: 1 time/s</p>|
1. ## **Wardrobe**
You just bought a new wardrobe. The weird thing about it is that it came prepackaged with a big box of clothes (just like those refrigerators, which ship with free beer inside them)! So, you’ll need to find something to wear.
### **Input**
On the first line of the input, you will receive **n** –  the **number of lines** of clothes, which came prepackaged for the wardrobe.

On the next **n** lines, you will receive the clothes for each color in the format:

- “**{color} -> {item1},{item2},{item3}…**”

If a color is added a **second** time, **add** **all items** from it and **count** the **duplicates**.

**Finally**, you will receive the **color** and **item** of the clothing, that you need to look for.
### **Output**
Go through all the **colors** of the clothes and print them in the following format:

|<p>**{color}** clothes:</p><p>\* **{item1}** - **{count}**</p><p>\* **{item2}** - **{count}**</p><p>\* **{item3}** - **{count}**</p><p>…</p><p>\* **{itemN}** - **{count}**</p>|
| :- |

If the **color** lines up with the **clothing item**, print “**(found!)**” alongside the item. See the examples to better understand the output.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>4</p><p>Blue -> dress,jeans,hat</p><p>Gold -> dress,t-shirt,boxers</p><p>White -> briefs,tanktop</p><p>Blue -> gloves</p><p>Blue dress</p>|<p>Blue clothes:</p><p>\* dress - 1 (found!)</p><p>\* jeans - 1</p><p>\* hat - 1</p><p>\* gloves - 1</p><p>Gold clothes:</p><p>\* dress - 1</p><p>\* t-shirt - 1</p><p>\* boxers - 1</p><p>White clothes:</p><p>\* briefs - 1</p><p>\* tanktop - 1</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>4</p><p>Red -> hat</p><p>Red -> dress,t-shirt,boxers</p><p>White -> briefs,tanktop</p><p>Blue -> gloves</p><p>White tanktop</p>|<p>Red clothes:</p><p>\* hat - 1</p><p>\* dress - 1</p><p>\* t-shirt - 1</p><p>\* boxers - 1</p><p>White clothes:</p><p>\* briefs - 1</p><p>\* tanktop - 1 (found!)</p><p>Blue clothes:</p><p>\* gloves - 1</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>Blue -> shoes</p><p>Blue -> shoes,shoes,shoes</p><p>Blue -> shoes,shoes</p><p>Blue -> shoes</p><p>Blue -> shoes,shoes</p><p>Red tanktop</p>|<p>Blue clothes:</p><p>\* shoes - 9</p>|
1. ## **\*The V-Logger**
As you know vlogging (making short videos instead of written blogposts) is the new super trend among young people. You have always been very passionate about vloggers and their videos and now you decided to create a website, called "The V-Logger", so to rank the most followed vloggers. Good thing that you are also a programmer, so you can easily track what vloggers do. 

You need to implement functionality that allows **vloggers to register** in your website. Note that, every vlogger must have a **unique vloggername**, so to be recognizable by his followers.

**Vloggers** also like to **follow other vloggers**, so that they can see immediately when a new video is posted.

A vlogger **can follow** **as many other vloggers** **as he wants**, but he **cannot** follow **himself** or follow someone he is **already a follower** of.
### **Input**
The **input** will come as e sequence of strings, where each string will represent a **valid** command. The commands will be presented in the following format:

- "**{vloggername}**" **joined The V-Logger** – a vlogger got registered into your website.
  - Vloggernames **consist** **of only one word**.
  - If the **given** **vloggername is already taken ignore that command.**

- "**{vloggername} followed {vloggername}**" – The first vlogger followed the second vlogger.
  - If **any** of the **given vlogernames** **does not exist** in the log **ignore that command.**

- **"Statistics" -** Upon receiving this command you have to print a statistic about the registered vloggers in **"The** **V-Logger".**
### **Output**
- On the first line you have to print **the total amount of vloggers** using “The V-Logger” in format:

**"The V-Logger has a total of {registered vloggers} vloggers in its logs."**

- Then you have to find most famous vlogger (the** vlogger with the most followers). He should be printed along with **his followers**, in the following format:

` 	`"**1. {vlogger} : {followers} followers, {vloggers he is a follower of} following**

` 	 `\*  **{follower1}**

` `**\*  {follower2} ...** "

- If more than one vloggers have the same number of followers, you find **the one following less people**
- The **followers** should be printed in **lexicographical order**.
- If the vlogger has **no followers**, print only the **first line.**

- Last print **all other vloggers**, ordered by **number of followers (descending)** and **number of followings (ascending)** in the following format:

"**{No}. {vlogger} : {followers} followers, {vloggers he is a follower of} following"**

### **Constraints**
- There will be no invalid input.
- There will be no situation where two vloggers have equal amount of followers and equal amount of followings
- The subscribers will be strings.
- Allowed time/memory: **100ms/16MB**.
### **Examples**

|**Input**|**Output**|
| - | - |
|<p>EmilConrad joined The V-Logger</p><p>VenomTheDoctor joined The V-Logger</p><p>Saffrona joined The V-Logger</p><p>Saffrona **followed** EmilConrad</p><p>Saffrona **followed** VenomTheDoctor</p><p>EmilConrad **followed** VenomTheDoctor</p><p>VenomTheDoctor **followed** VenomTheDoctor</p><p>Saffrona **followed** EmilConrad</p><p>Statistics</p>|<p>The V-Logger has a total of 3 vloggers in its logs.</p><p>1\. VenomTheDoctor : 2 followers, 0 following</p><p>\*  EmilConrad</p><p>\*  Saffrona</p><p>2\. EmilConrad : 1 followers, 1 following</p><p>3\. Saffrona : 0 followers, 2 following                  </p>|
|<p>JennaMarbles joined The V-Logger</p><p>JennaMarbles followed Zoella</p><p>AmazingPhil joined The V-Logger</p><p>JennaMarbles followed AmazingPhil</p><p>Zoella joined The V-Logger</p><p>JennaMarbles followed Zoella</p><p>Zoella followed AmazingPhil</p><p>Christy followed Zoella</p><p>Zoella followed Christy</p><p>JacksGap joined The V-Logger</p><p>JacksGap followed JennaMarbles</p><p>PewDiePie joined The V-Logger</p><p>Zoella joined The V-Logger</p><p>Statistics</p>|<p>The V-Logger has a total of 5 vloggers in its logs.</p><p>1\. AmazingPhil : 2 followers, 0 following</p><p>\*  JennaMarbles</p><p>\*  Zoella</p><p>2\. Zoella : 1 followers, 1 following</p><p>3\. JennaMarbles : 1 followers, 2 following</p><p>4\. PewDiePie : 0 followers, 0 following</p><p>5\. JacksGap : 0 followers, 1 following</p>|

1. ## **\*Ranking**
Here comes the final and the most interesting part – the Final ranking of the candidate-interns. The final ranking is determined by the points of the interview tasks and from the exams in SoftUni. Here is your final task. You will receive some lines of input in the format **“{contest}:{password for contest}”** until you receive **“end of contests”**. Save that data because **you will need it later**. After that you will receive other type of inputs in format **“{contest}=>{password}=>{username}=>{points}”** until you receive **“end of submissions”**. Here is what you need to do. 

- Check if the **contest is valid (if you received it in the first type of input)**
- Check if the **password is correct for the given contest**
- Save the user with the contest they take part in **(a user can take part in many contests)** and the points the user has in the given contest. If you receive the **same contest and the same user update the points only if the new ones are more than the older ones.**

At the end you have to print the info for the user with the **most points** in the format **“Best candidate is {user} with total {total points} points.”**. After that print **all students ordered by their names**. **For each user print each contest with the points in descending order**. See the examples.
### **Input**
- strings in format **“{contest}:{password for contest}”** until the **“end of contests”** command. There will be no case with two equal contests
- strings in format **“{contest}=>{password}=>{username}=>{points}”** until the **“end of submissions”** command.
- **There will be no case with 2 or more users with same total points!**
### **Output**
- On the first line print the best user in format **“Best candidate is {user} with total {total points} points.”.** 
- Then print all students ordered as mentioned above in format:

**{user1 name}**

**#  {contest1} -> {points}**

**#  {contest2} -> {points}**

**{user2 name}**

**…**
### **Constraints**
- the strings may contain any ASCII character except from **(:, =, >)**
- the numbers will be in range **[0 - 10000]**
- second input is always valid
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>Part One Interview:success</p><p>Js Fundamentals:Pesho</p><p>C# Fundamentals:fundPass</p><p>Algorithms:fun</p><p>end of contests</p><p>C# Fundamentals=>fundPass=>Tanya=>350</p><p>Algorithms=>fun=>Tanya=>380</p><p>Part One Interview=>success=>Nikola=>120</p><p>Java Basics Exam=>pesho=>Petkan=>400</p><p>Part One Interview=>success=>Tanya=>220</p><p>OOP Advanced=>password123=>BaiIvan=>231</p><p>C# Fundamentals=>fundPass=>Tanya=>250</p><p>C# Fundamentals=>fundPass=>Nikola=>200</p><p>Js Fundamentals=>Pesho=>Tanya=>400</p><p>end of submissions</p>|<p>Best candidate is Tanya with total 1350 points.</p><p>Ranking: </p><p>Nikola</p><p>#  C# Fundamentals -> 200</p><p>#  Part One Interview -> 120</p><p>Tanya</p><p>#  Js Fundamentals -> 400</p><p>#  Algorithms -> 380</p><p>#  C# Fundamentals -> 350</p><p>#  Part One Interview -> 220</p>|
|<p><a name="_hlk505101421"></a>Java Advanced:funpass</p><p>Part Two Interview:success</p><p>Math Concept:asdasd</p><p>Java Web Basics:forrF</p><p>end of contests</p><p>Math Concept=>ispass=>Monika=>290</p><p>Java Advanced=>funpass=>Simona=>400</p><p>Part Two Interview=>success=>Drago=>120</p><p>Java Advanced=>funpass=>Petyr=>90</p><p>Java Web Basics=>forrF=>Simona=>280</p><p>Part Two Interview=>success=>Petyr=>0</p><p>Math Concept=>asdasd=>Drago=>250</p><p>Part Two Interview=>success=>Simona=>200</p><p>end of submissions</p>|<p>Best candidate is Simona with total 880 points.</p><p>Ranking: </p><p>Drago</p><p>#  Math Concept -> 250</p><p>#  Part Two Interview -> 120</p><p>Petyr</p><p>#  Java Advanced -> 90</p><p>#  Part Two Interview -> 0</p><p>Simona</p><p>#  Java Advanced -> 400</p><p>#  Java Web Basics -> 280</p><p>#  Part Two Interview -> 200</p>|





