
# **Exercises: C# Basics – More Exercises**
Problems for exercises and homework for the [“Programming Fundamentals Extended” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).
1. ## **X**
Write a program, which **prints** an **X figure** with height **n**.

**N** will be an **odd number** in the range **[3…99]**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top">3</td><td colspan="1" valign="top"><p>x x</p><p>` `x</p><p>x x</p></td><td colspan="1" valign="top">5</td><td colspan="1" valign="top"><p>x   x</p><p>` `x x</p><p>`  `x</p><p>` `x x</p><p>x   x</p></td><td colspan="1" valign="top">11</td><td colspan="1" valign="top"><p>x         x</p><p>` `x       x</p><p>`  `x     x</p><p>`   `x   x</p><p>`    `x x</p><p>`     `x</p><p>`    `x x</p><p>`   `x   x</p><p>`  `x     x</p><p>` `x       x</p><p>x         x</p></td></tr>
</table>
1. ## **Vapor Store**
After the previous problem, you feel like taking a break, so you go on the **Vapor Store** to buy some video games. Write a program, which** helps you buy the games. The **valid games** are the following games in this table:

|**Name**|**Price**|
| :-: | :-: |
|<a name="ole_link1"></a><a name="ole_link2"></a>OutFall 4|$39.99|
|<a name="_hlk482714580"></a>CS: OG|$15.99|
|<a name="_hlk482714587"></a>Zplinter Zell|$19.99|
|<a name="_hlk482714591"></a>Honored 2|$59.99|
|<a name="_hlk482714595"></a>RoverWatch|$29.99|
|<a name="_hlk482714598"></a>RoverWatch Origins Edition|$39.99|

On the first line, you will receive your **current balance** – a **floating-point** number in the range **[0.00…5000.00]**.

Until you receive the command “**Game Time**”, you have to keep **buying games**. When a **game** is **bought**, the user’s **balance** decreases by the **price** of the game.

Additionally, the program should obey the following conditions:

- If a game the user is trying to buy is **not present** in the table above, print “**Not Found**” and **read the next line**.
- If at any point, the user has **$0** left, print “**Out of money!**” and **end the program**.
- Alternatively, if the user is trying to buy a game which they **can’t afford**, print “**Too Expensive**” and **read the next line**.

When you receive “<b>Game Time</b>”, <b>print</b> the user’s <b>remaining money</b> and <b>total spent on games</b>, <b>rounded</b> to the <b>2<sup>nd</sup> decimal place</b>.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>120</p><p>RoverWatch</p><p>Honored 2</p><p>Game Time</p>|<p>Bought RoverWatch</p><p>Bought Honored 2</p><p>Total spent: $89.98. Remaining: $30.02</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>19\.99</p><p>Reimen origin</p><p>RoverWatch</p><p>Zplinter Zell</p><p>Game Time</p>|<p>Not Found</p><p>Too Expensive</p><p>Bought Zplinter Zell</p><p>Out of money!</p>|


|**Input**|**Output**|
| :-: | :-: |
|<p>79\.99</p><p>OutFall 4</p><p>RoverWatch Origins Edition</p><p>Game Time</p>|<p>Bought OutFall 4</p><p>Bought RoverWatch Origins Edition</p><p>Total spent: $79.98. Remaining: $0.01</p>|
1. ## **Megapixels**
Write a program, which, given an **image resolution** (**width** and **height**), calculates its **megapixels**. **Megapixels** (short for **millions of pixels**) are calculated by **counting** all the **image** **pixels**, then **dividing** the result by **1000000**. 

The megapixels must **always** be rounded to the **first digit** after the **decimal point** (i.e. 0.786 MP è 0.8MP).
### **Input**
- **First Line** – the **width** of the image – integer in range **[1…20000]**
- **Second Line** – the **height** of the image – integer in range **[1…20000]**
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>1024</p><p>768</p></td><td colspan="1" valign="top">1024x768 => 0.8MP</td><td colspan="1" valign="top"><p>1920</p><p>1080</p></td><td colspan="1" valign="top">1920x1080 => 2.1MP</td><td colspan="1" valign="top"><p>5344</p><p>3006</p></td><td colspan="1" valign="top">5344x3006 => 16.1MP</td></tr>
</table>
### **Hints**
- To round a number, you can use the [Math.Round()](https://msdn.microsoft.com/en-us/library/75ks3aby\(v=vs.110\).aspx) method.
1. ## **Photo Gallery**
Write a program, which receives **image metadata** as input and prints information about the image, such as its **filename**, **date taken**, **size**, **resolution** and **aspect ratio**. Also, calculate the **orientation** of the image. The **3** orientations are: **portrait**, **landscape** and **square**.
### **Input**
- **First line** – the photo’s **number** – an **integer** in the range **[0…9999]**
- **Second, third, fourth line** – the **day**, **month** and **year** the photo was taken – **integers** forming **valid** dates in the range **[01/01/1990…31/12/2020]**
- **Fifth, sixth line** – the **hours** and **minutes** the photo was taken – **integers** in the range **[0…23]**
- **Seventh line** – the photo’s **size** in **bytes** – **integer** in the range **[0…999000000]**
- **Eighth, ninth line** – the photo’s **resolution** (**width** and **height**)** in **pixels** – **integers** in the range **[1…10000]**
### **Output**
- The **name** should be printed in the format “**DSC\_xxxx.jpg**”.
- The **date and time taken** should be printed in the format “**dd/mm/yyyy hh:mm**”.
- The **size** should be printed in standard **human-readable** format (i.e. 950 bytes = 950B, 500000 bytes = 500KB, 1500000 bytes = 1.5MB).
- The **resolution** should be printed in the following format: “**{width}x{height}**”.
- The **orientation** can be one of three valid values: **portrait**, **landscape** and **square**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>35</p><p>25</p><p>12</p><p>2003</p><p>12</p><p>3</p><p>1500000</p><p>5334</p><p>3006</p></td><td colspan="1" valign="top"><p>Name: DSC_0035.jpg</p><p>Date Taken: 25/12/2003 12:03</p><p>Size: 1.5MB</p><p>Resolution: 5334x3006 (landscape)</p></td><td colspan="1" valign="top"><p>533</p><p>20</p><p>3</p><p>1993</p><p>11</p><p>33</p><p>350000</p><p>768</p><p>1024</p></td><td colspan="1" valign="top"><p>Name: DSC_0533.jpg</p><p>Date Taken: 20/03/1993 11:33</p><p>Size: 350KB</p><p>Resolution: 768x1024 (portrait)</p></td></tr>
</table>


|**Input**|**Output**|
| :-: | :-: |
|<p>6552</p><p>12</p><p>11</p><p>2012</p><p>15</p><p>33</p><p>850</p><p>1000</p><p>1000</p>|<p>Name: DSC\_6552.jpg</p><p>Date Taken: 12/11/2012 15:33</p><p>Size: 850B</p><p>Resolution: 1000x1000 (square)</p>|
1. ## **BPM Counter**
Write a program, which receives **BPM** (beats per minute) and **number of beats** from the console and calculates how many **bars** (1 bar == 4 beats) the beats equal to, then calculates the **length** of the sequence in **minutes** and **seconds**.

The bars must **always** be rounded to the **first digit** after the **decimal point** (i.e. 1.75 bars è 1.8 bars).
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>60</p><p>60</p></td><td colspan="1" valign="top">15 bars - 1m 0s</td><td colspan="1" valign="top"><p>128</p><p>85</p></td><td colspan="1" valign="top">21\.2 bars - 0m 39s</td><td colspan="1" valign="top"><p>522</p><p>80</p></td><td colspan="1" valign="top">20 bars - 0m 9s</td></tr>
</table>
1. ## **DNA Sequences**
You are a molecular biologist, who’s on the verge of figuring out gene manipulation. But first you need to see what DNA sequences you’re working with, so you decide to write a program to do it for you.

Write a program, which prints all the possible **nucleic acid sequences** (**A**, **C**, **G** and **T**), in the **range** [**AAA…TTT**]. **Each** nucleic acid sequence is exactly **3 nucleotides (letters) long**. Print a **new line** every **4** sequences.

Each nucleotide has a corresponding numeric value – A è 1, C è 2, G è 3, T è 4.

For every sequence, take the **sum** of its elements (e.g. **ACAC** è 1 + 2 + 1 + 2 = 6) and if it’s **equal to or larger than** the **match sum**, print the sequence with an “**O**” before and after it, otherwise print “**X**” before and after it.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" valign="top"><b>Comments</b></th></tr>
<tr><td colspan="1" valign="top">5</td><td colspan="1" valign="top"><p>XAAAX XAACX OAAGO OAATO</p><p>XACAX OACCO OACGO OACTO</p><p>OAGAO OAGCO OAGGO OAGTO</p><p>OATAO OATCO OATGO OATTO</p><p>XCAAX OCACO OCAGO OCATO</p><p>OCCAO OCCCO OCCGO OCCTO</p><p>OCGAO OCGCO OCGGO OCGTO</p><p>OCTAO OCTCO OCTGO OCTTO</p><p>OGAAO OGACO OGAGO OGATO</p><p>OGCAO OGCCO OGCGO OGCTO</p><p>OGGAO OGGCO OGGGO OGGTO</p><p>OGTAO OGTCO OGTGO OGTTO</p><p>OTAAO OTACO OTAGO OTATO</p><p>OTCAO OTCCO OTCGO OTCTO</p><p>OTGAO OTGCO OTGGO OTGTO</p><p>OTTAO OTTCO OTTGO OTTTO</p></td><td colspan="1" valign="top">11</td><td colspan="1" valign="top"><p>XAAAX XAACX XAAGX XAATX</p><p>XACAX XACCX XACGX XACTX</p><p>XAGAX XAGCX XAGGX XAGTX</p><p>XATAX XATCX XATGX XATTX</p><p>XCAAX XCACX XCAGX XCATX</p><p>XCCAX XCCCX XCCGX XCCTX</p><p>XCGAX XCGCX XCGGX XCGTX</p><p>XCTAX XCTCX XCTGX XCTTX</p><p>XGAAX XGACX XGAGX XGATX</p><p>XGCAX XGCCX XGCGX XGCTX</p><p>XGGAX XGGCX XGGGX XGGTX</p><p>XGTAX XGTCX XGTGX OGTTO</p><p>XTAAX XTACX XTAGX XTATX</p><p>XTCAX XTCCX XTCGX XTCTX</p><p>XTGAX XTGCX XTGGX OTGTO</p><p>XTTAX XTTCX OTTGO OTTTO</p></td><td colspan="1" valign="top"><p>Combinations, where “sum >= 11”:</p><p>GTT è 3+4+4 è 11</p><p>TGT è 4+3+4 è 11</p><p>TTG è 4+4+3 è 11</p><p>TTT è 4+4+4 è 12</p></td></tr>
</table>


|**Input**|**Output**|**Comments**|
| :-: | :-: | :-: |
|10|<p>XAAAX XAACX XAAGX XAATX</p><p>XACAX XACCX XACGX XACTX</p><p>XAGAX XAGCX XAGGX XAGTX</p><p>XATAX XATCX XATGX XATTX</p><p>XCAAX XCACX XCAGX XCATX</p><p>XCCAX XCCCX XCCGX XCCTX</p><p>XCGAX XCGCX XCGGX XCGTX</p><p>XCTAX XCTCX XCTGX OCTTO</p><p>XGAAX XGACX XGAGX XGATX</p><p>XGCAX XGCCX XGCGX XGCTX</p><p>XGGAX XGGCX XGGGX OGGTO</p><p>XGTAX XGTCX OGTGO OGTTO</p><p>XTAAX XTACX XTAGX XTATX</p><p>XTCAX XTCCX XTCGX OTCTO</p><p>XTGAX XTGCX OTGGO OTGTO</p><p>XTTAX OTTCO OTTGO OTTTO</p>|<p>Combinations, where “sum >= 10”:</p><p>CTT è 2+4+4 è 10</p><p>GGT è 3+3+4 è 10</p><p>GTG è 3+4+3 è 10</p><p>GTT è 3+4+4 è 11</p><p>TCT è 4+2+4 è 10</p><p>TGG è 4+3+3 è 10</p><p>TGT è 4+3+4 è 11</p><p>TTC è 4+4+2 è 10</p><p>TTG è 4+4+3 è 11</p><p>TTT è 4+4+4 è 12</p>|
1. ## **Training Hall Equipment**
As the new intern in SoftUni, you’re tasked with **equipping** the **new training halls** with all the **necessary items** to lead quality technical trainings. You’ll be given a **budget** and a **list of items** to buy. The other intern will be tasked with plugging in everything and hopefully not getting anyone electrocuted in the process…
### **Input**
- On the first line, you will receive your **budget** – a floating-point value in the range **[0…1000000]**
- On the second line, you will receive the **number of items** you need to buy – an integer in the range **[0…10]**
- On the next **count\*3** lines, you will receive the **item data** as such:
  - The **item** **name** – **string**
  - The **item price** – **floating-point** value in the range **[0.50…1000.00]**
  - The **item count** – **integer** in the range **[0…1000]**
### **Output**
Every time an item is **added** to the cart, print “**Adding {count} {item} to cart.**” on the console. Make sure to **pluralize** item names (if the **item** **count** **isn’t 1**, add an **S** at the end of the item name). After all of the items have been added to the **cart**, you need to calculate the **subtotal** of the items and check if the **budget** will be **enough**. 

- If it’s enough, print “<b>Money left: ${moneyLeft}</b>”, <b>formatted</b> to the <b>2<sup>nd</sup> decimal point</b>.
- Otherwise, print “<b>Not enough. We need ${moneyNeeded} more.</b>”, <b>formatted</b> to the <b>2<sup>nd</sup> decimal point</b>.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>20000</p><p>4</p><p>projector</p><p>299\.99</p><p>2</p><p>hdmi cable</p><p>4\.99</p><p>1</p><p>chair</p><p>19\.99</p><p>180</p><p>desk</p><p>199\.99</p><p>60</p></td><td colspan="1" valign="top"><p>Adding 2 projectors to cart.</p><p>Adding 1 hdmi cable to cart.</p><p>Adding 180 chairs to cart.</p><p>Adding 60 desks to cart.</p><p>Subtotal: $16202.57</p><p>Money left: $3797.43</p></td><td colspan="1" valign="top"><p>700</p><p>3</p><p>projector</p><p>399\.99</p><p>1</p><p>hdmi cable</p><p>6\.99</p><p>3</p><p>chair</p><p>2\.99</p><p>80</p><p>desk</p><p>99\.99</p><p>25</p></td><td colspan="1" valign="top"><p>Adding 1 projector to cart.</p><p>Adding 3 hdmi cables to cart.</p><p>Adding 80 chairs to cart.</p><p>Subtotal: $660.16</p><p>Money left: $39.84</p></td></tr>
</table>


|**Input**|**Output**|
| :-: | :-: |
|<p>2000</p><p>4</p><p>whiteboard</p><p>150</p><p>1</p><p>marker</p><p>6\.99</p><p>10</p><p>chalk</p><p>0\.50</p><p>20</p><p>beanbag chair</p><p>119\.99</p><p>15</p>|<p>Adding 1 whiteboard to cart.</p><p>Adding 10 markers to cart.</p><p>Adding 20 chalks to cart.</p><p>Adding 15 beanbag chairs to cart.</p><p>Subtotal: $2029.75</p><p>Not enough. We need $29.75 more.</p>|
1. ## **\* SMS Typing**
Write a program, which emulates **typing an SMS**, following this guide:

|**1**|<p>**2**</p><p>abc</p>|<p>**3**</p><p>def</p>|
| :-: | :-: | :-: |
|<p>**4**</p><p>ghi</p>|<p>**5**</p><p>jkl</p>|<p>**6**</p><p>mno</p>|
|<p>**7**</p><p>pqrs</p>|<p>**8**</p><p>tuv</p>|<p>**9**</p><p>wxyz</p>|
||<p>**0**</p><p>space</p>||
Following the guide, **2** becomes “**a**”, **22** becomes “**b**” and so on.
### **Input**
- On the first line, you will receive **n** - the **number of characters** – **integer** in the range **[1…30]**
- On the next n lines, you will receive integers, representing the **text message characters**.
### **Output**
Print all the characters together, forming a **text message string**.
### **Examples**

<table><tr><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1" valign="top"><b>Input</b></th><th colspan="1" valign="top"><b>Output</b></th></tr>
<tr><td colspan="1" valign="top"><p>5</p><p>44</p><p>33</p><p>555</p><p>555</p><p>666</p></td><td colspan="1" valign="top">hello</td><td colspan="1" valign="top"><p>9</p><p>44</p><p>33</p><p>999</p><p>0</p><p>8</p><p>44</p><p>33</p><p>777</p><p>33</p></td><td colspan="1" valign="top">hey there</td><td colspan="1" valign="top"><p>7</p><p>6</p><p>33</p><p>33</p><p>8</p><p>0</p><p>6</p><p>33</p></td><td colspan="1" valign="top">meet me</td></tr>
</table>
### **Hints**
- A naïve approach would be to just put all the possible combinations of digits in a giant **switch** statement.
- A cleverer approach would be to come up with a **mathematical formula**, which **converts** a **number** to its **alphabet** representation:

|**Digit**|2|3|4|5|6|7|8|9|
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
|**Index**|0 1 2|3 4 5|6 7 8|9 11 12|13 14 15|16 17 18 19|20 21 22|23 24 25 26|
|**Letter**|a b c|d e f|g h i|j  k  l|m  n  o|p  q  r  s|t u v|w  x  y  z|

- Let’s take the number **222** (**c**) for example. Our algorithm would look like this:
  - Find the **number of digits** the number has “e.g. **222** è **3 digits**”
  - Find the **main digit** of the number “e.g.  **222** è **2**”
  - Find the **offset** of the number. To do that, you can use the formula: **(main digit - 2) \* 3**
  - If the main digit is **8 or 9**, we need to **add 1** to the **offset**, since the digits **7** and **9** have **4 letters each**
  - Finally, find the **letter index** (a è 0, c è 2, etc.). To do that, we can use the following formula: **(offset + digit length - 1)**.
  - After we’ve found the **letter index**, we can just add that to **the ASCII code** of the lowercase letter “**a**” (97)

