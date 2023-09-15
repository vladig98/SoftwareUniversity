
# **Exercises: Best Practices and Architecture**
This document defines the **exercise assignments** for the ["Databases Advanced – EF Core" course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).
# **Best Practices and Architecture**
1. ## **Photo Share System**
You are given a project [skeleton](http://svn.softuni.org/admin/svn/DB-Fundamentals/DB-Advanced-EntityFramework/Feb-2017/08.%20DB-Advanced-EntityFramework-Best%20Practices-and-Architecture/08.%20DB-Advanced-EntityFramework-Best-Practices-and-Architecture-PhotoShare-Skeleton.zip) of a **Photo Sharing System**. Take a look at it to get more familiar with that project.  The database is modeled by code first approach and the models are fine (in other words there is nothing to modify in **PhotoShare.Models** project).

But the other projects **PhotoShare.Client** and **PhotoShare.Service** are poorly written. Your task is to **improve the architecture of the project.** Seed some data in the database.

Then **implement the missing commands** by the hints given in each command class and **fix any bugs** in the already implemented code.
### **System functionality**
The photo share system contains the following commands:

- <a name="ole_link11"></a><a name="ole_link12"></a>**RegisterUser <username> <password> <repeat-password> <email>**
  Registers a new user.

|<a name="ole_link33"></a><a name="ole_link34"></a>**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|<a name="_hlk477455144"></a>Success |User [username] was registered successfully!|None|
|Passwords do not match|Passwords do not match!|ArgumentException|
|Username is taken|<a name="ole_link8"></a><a name="ole_link9"></a>Username [username] is already taken!|InvalidOperationException|

Any other validation is already implemented and it should stay as is.

- **AddTown <town Name> <country Name>**

Adds new  town. Town names must be unique.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success |<a name="ole_link10"></a><a name="ole_link13"></a>Town [town] was added successfully!|None|
|Town already exists|<a name="ole_link14"></a><a name="ole_link15"></a>Town [town] was already added!|ArgumentException|

Any other validation is already implemented and it should stay as is.

- **ModifyUser <username> <property> <new value>**
  Modifies current user. 

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success |<a name="ole_link21"></a><a name="ole_link22"></a>User [user] [property] is [value].|None|
|User does not exist|User [username] not found!|ArgumentException|
|<a name="_hlk477460816"></a>Property not found|Property [property] not supported!|ArgumentException|
|Value not valid for that property|<p>Value [value] not valid.</p><p>[DetailedMessage]</p>|ArgumentException|
**
`	`The above command may be executed in the following formats:

**ModifyUser <username> Password <NewPassword>**

- Password must contain at least one lowercase letter and digit. If not: 
  - Detailed Message - “**Invalid Password**”

**ModifyUser <username> BornTown <newBornTownName>**

- Town must exist in database. If not:
  - Detailed Message – “**Town [town] not found!**”

`      `**ModifyUser <username> CurrentTown <newCurrentTownName>**

- Town must exist in database. If not:
  - Detailed Message – “**Town [town] not found!**”

`	`Any other format different than from all the above formats is invalid.

- **DeleteUser <username>**
  Deletes a user.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|<a name="_hlk477464900"></a>Success |User [username] was deleted successfully!|None|
|<a name="_hlk477464562"></a>User does not exist|User [username] not found!|ArgumentException|
|User is already deleted|User [username] is already deleted!|InvalidOperationException|

- **AddTag <tag>**
  Adds a tag. Tag names should be unique.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success |Tag [tag] was added successfully!|None|
|Tag already exists|<a name="ole_link3"></a><a name="ole_link4"></a>Tag [tag] exists!|ArgumentException|

Tag validation is already implemented and should stay as is.

- **CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>**
  Adds an album. Album names should be unique.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success |<a name="ole_link17"></a><a name="ole_link18"></a>Album [Album] successfully created!|None|
|User does not exist|<a name="ole_link5"></a><a name="ole_link6"></a>User [username] not found!|ArgumentException|
|Album does exist|Album [album] exists!|ArgumentException|
|Background color does not exist|Color [color] not found!|ArgumentException|
|If any tag is not found in database|<a name="ole_link7"></a><a name="ole_link16"></a>Invalid tags!|ArgumentException|

- **AddTagTo <album> <tag>**
  Adds a tag.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success |<a name="ole_link19"></a><a name="ole_link20"></a>Tag [tag] added to [album]!|None|
|Album or tag does not exist|Either tag or album do not exist!|ArgumentException|

- **AddFriend <username1> <username2>**
  The first user adds the second one as a [friend](http://orig13.deviantart.net/006e/f/2013/297/c/6/lol_amumu_by_enzanblues456-d6rnrta.jpg). :)

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success |<a name="ole_link23"></a><a name="ole_link24"></a>Friend [username2] added to [username1]|None|
|Any of the users do not exist.|[user\*] not found!<br>*\*Pick the first not existing possible user*|ArgumentException|
|They are already friends|<a name="ole_link25"></a><a name="ole_link26"></a>[username2] is already a friend to [username1]|InvalidOperationException|

- **AcceptFriend <username1> <username2>**


|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success|[username1] accepted [username2] as a friend|None|
|Any of the users do not exist.|[user\*] not found!<br>*\*Pick the first not existing possible user*|ArgumentException|
|They are already friends|[username2] is already a friend to [username1]|InvalidOperationException|
|There is no such friend request|[username2] has not added [username1] as a friend|InvalidOperationException|

- **ListFriends <username>**
  List usernames of all friends for given user sorted alphabetically.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success|<p>Friends:</p><p>-[username1]</p><p>…</p><p>-[usernameN]</p>|None|
|User does not have any friends.|<a name="ole_link27"></a><a name="ole_link28"></a>No friends for this user. :(|None|
|User does not exist|User [user] not found!|ArgumentException|

- **ShareAlbum <albumId> <username> <permission>**
  Makes specified user to be part of given album.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success|<a name="ole_link29"></a><a name="ole_link30"></a><a name="ole_link31"></a>Username [user] added to album [album] ([permission])|None|
|Album does not exist|Album [albumId] not found!|ArgumentException|
|User does not exist|User [user] not found!|ArgumentException|
|Permission not valid|<a name="ole_link32"></a><a name="ole_link35"></a><a name="ole_link36"></a>Permission must be either “Owner” or “Viewer”!|ArgumentException|

- **UploadPicture <albumName> <pictureTitle> <pictureFilePath>**
  Creates picture and atteches it to specified album

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success|<a name="ole_link37"></a><a name="ole_link38"></a>Picture [picture] added to [album]!|None|
|Album does not exist|Album [Album] not found!|ArgumentException|

- **Exit**
  Exits application.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success|Good Bye!|None|

If command is **NOT** in format specified above (either command name is wrong or input arguments count) throw <a name="ole_link39"></a><a name="ole_link40"></a>**InvalidOperationException** with message: “<a name="ole_link41"></a><a name="ole_link42"></a>**Command <CommandName> not valid!**”.
### **Examples**

|**Input**|**Output**|
| :- | :- |
|<p>RegisterUser admin abc123 abc123 user@softuni.bg</p><p>ModifyUser admin BornTown Sofia</p><p>AddTown Sofia Bulgaria</p><p>ModifyUser admin BornTown Sofia</p><p>UploadPicture Nature Vitosha C://Pictures/Vitosha.png</p><p>CreateAlbum admin Nature Magenta nature</p><p>AddTag nature</p><p>CreateAlbum admin Nature Magenta nature</p><p>UploadPicture Nature Vitosha C://Pictures/Vitosha.png</p><p>Exit</p><p></p>|<p>User admin was registered successfully!</p><p><a name="ole_link43"></a><a name="ole_link44"></a>Value Sofia not valid!<br>Town Sofia not found!</p><p>Town Sofia was added successfully!</p><p>User admin BornTown is Sofia.</p><p>Album Nature not found!</p><p>Invalid tags!</p><p>Tag #nature was added successfully!</p><p>Album Nature successfully created!</p><p>Picture Vitosha added to Nature!</p><p>Good Bye!</p>|
|<p>RegisterUser peter pan123 pan123 peter@pan.com</p><p>RegisterUser peter aaa a123 pesho@pan.com</p><p>RegisterUser capt hook123 hook123 capitan@hook.com</p><p>AddFriend peterr capp</p><p>AddFriend peter capp</p><p>AddFriend peter capt</p><p>RegisterUser jack jack123 jack123 jack@j.com</p><p>AddFriend peter jack</p><p>AcceptFriend jack peter</p><p>AcceptFriend capt peter</p><p>PrintFriendsList peter </p><p>RegisterUser user</p><p>Exit</p>|<p>User peter was registered successfully!</p><p>Username peter is already taken!</p><p>User capt was registered successfully!</p><p>User peterr not found!</p><p>User capp not found!</p><p>Friend peter added to capt!</p><p>User jack was registered successfully!</p><p>Friend peter added to jack!</p><p>Friend jack accepted peter as friend</p><p>Friend capt accepted peter as friend</p><p>Friends</p><p>-capt</p><p>-jack</p><p>Command RegisterUser not valid!</p><p>Good Bye!</p>|
|<p>RegisterUser tomCat tom123 tom123 tom@t.com</p><p>RegisterUser jerry jerry123 jerry123 jerry@j.com</p><p>RegisterUser butch butch123 butch123 butch@b.com</p><p>AddTag #cartoon</p><p>CreateAlbum tomCat Tom&Jerry Blue cartoon</p><p>ShareAlbum 1 jerry Owner</p><p>AddTag #childhood</p><p>AddTagTo Tom&Jerry childhood</p><p>Exit</p>|<p>User tom was registered successfully!</p><p>User jerry was registered successfully!</p><p>User jerry was registered successfully!</p><p>Tag #cartoon was added successfully!</p><p>Album Tom&Jerry successfully created!</p><p>Username jerry added to album Tom&Jerry (Owner)</p><p>Tag #childhood was added successfully!</p><p>Tag #childhood added to Tom&Jerry!</p><p>Good Bye!</p>|
1. ## **Extend Photo Share System**
Extend the **Photo Share System** by implementing two more commands:

- **Login <username> <password>**
  Logs a user into the system and keep a reference to it until the “Logout” command is called.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success|User [username] successfully logged in!|None|
|Either user does not exist or password does not match|<a name="ole_link47"></a><a name="ole_link48"></a>Invalid username or password!|ArgumentException|
|User has logged in already|<a name="ole_link45"></a><a name="ole_link46"></a>You should logout first!|ArgumentException|

- **Logout**
  Logs out a user from the system.

|**Case**|**Message**|**Exception**|
| :-: | :-: | :-: |
|Success|<a name="ole_link54"></a><a name="ole_link55"></a><a name="ole_link56"></a>User [username] successfully logged out!|None|
|<a name="_hlk477519720"></a>There is no user logged in.|You should log in first in order to logout.|InvalidOperationException|

**Modify all commands accordingly**. 

Logged user can:

- Modify his own profile
- Add friends to himself
- Add tag
- Add town
- Create an album (only if he is owner of the album)
- Share an album (only if he is owner of the album)
- Upload picture (only if he is owner of the album that picture is uploaded to)
- Add tag to album (only if he is owner of the album)
- Delete user (can delete only himself/herself)
- List friends of any user
- Logout

Non-logged user can:

- List friends of any user
- Register
- Login

If any of these rules are violated print: “<a name="ole_link57"></a><a name="ole_link58"></a>**Invalid credentials!**” and throw **InvalidOperationException**.
### **Examples**

|**Input**|**Output**|
| :- | :- |
|<p>RegisterUser thor tor123 tor123 tor@t.com</p><p>Login thor tor1234</p><p>Login thor tor123</p><p>Login thor tor123</p><p>AddTag thunder</p><p>RegisterUser loki loki123 loki123 loki@l.com</p><p>Logout</p><p>RegisterUser loki loki123 loki123 loki@l.com</p><p>Login loki loki123</p><p>Exit</p><p></p><p></p>|<p>User thor was registered successfully!</p><p>Invalid username or password!<br>User thor successfully logged in!</p><p>Invalid Credentials!</p><p>Tag #thunder was added successfully!</p><p>Invalid Credentials!</p><p>User tor successfully logged out!</p><p>User loki was registered successfully!** <br>User loki successfully logged in!</p><p>Good Bye!</p>|
|<p>AddTown Asgard Asgard</p><p>RegisterUser loki loki123 loki123 loki@l.com</p><p>RegisterUser thor tor123 tor123 tor@t.com</p><p>Login thor tor123</p><p>AddTown Asgard Asgard</p><p>ModifyUser thor CurrentTown Asgard</p><p>ModifyUser loki CurrentTown Asgard</p><p>AcceptFriend thor loki</p><p>AcceptFriend loki thor</p><p>CreateAlbum thor TalesOfAsgard Black</p><p>CreateAlbum loki FalseGod Black</p><p>ShareAlbum 1 loki Viewer</p><p>UploadPicture TalesOfAsgard Thor D:\\images\thor.png</p><p>AddTag thunder</p><p>AddTagTo TalesOfAsgard thunder</p><p>PrintFriendsList thor</p><p>PrintFriendsList loki</p><p>DeleteUser thor</p><p>DeleteUser loki</p><p>Logout</p><p>RegisterUser odin odin123 odin123 odin@d.com</p><p>Login loki loki123</p><p>ShareAlbum 1 odin Owner</p><p>UploadPicture TalesOfAsgard Loki D:\\images\loki.png</p><p>AddTag #destruction</p><p>AddTagTo TalesOfAsgard #destruction</p><p>Exit</p>|<p>Invalid credentials!</p><p>User loki was registered successfully!</p><p>User thor was registered successfully!</p><p>User thor successfully logged in!</p><p>Town Asgard was added successfully!</p><p>User thor CurrentTown is Asgard.</p><p>Invalid credentials!</p><p>Friend loki added to thor!</p><p>Invalid credentials!</p><p>Album TalesOfAsgard successfully created!</p><p>Invalid credentials!</p><p>User loki added to album TalesOfAsgard(Viewer)</p><p>Picture Thor added to TalesOfAsgard!</p><p>Tag #thunder was added successfully!</p><p>Tag #thunder added to TalesOfAsgard!</p><p>Friends:</p><p>-loki</p><p>No friends for this user. :(</p><p>User thor was deleted successfully!</p><p>Invalid credentials!</p><p>User thor successfully logged out!</p><p>User odin was registered successfully!</p><p>User loki successfully logged in!</p><p>Invalid credentials!</p><p>Invalid credentials!</p><p>Tag #destruction was added successfully!</p><p>Invalid credentials!</p><p>Good Bye!</p>|
1. ## **\*Bus Tickets System**
Your task is to design a database for **Bus Tickets System** using the **code first** approach. The database should keep information about:

- **bus companies** - name, nationality, rating
- **tickets** - price, seat, customer, trip
- **customers** - first name, last name, date of birth, gender, home town
- **trips** - departure time, arrival time, status, origin bus station, destination bus station, bus company
- **bus stations** - name, town
- **towns** - name, country
- **reviews** - content, grade, bus station, customer, date and time of publishing
- **bank accounts** - account number, balance, customer

Each ticket is bought from a customer for a certain trip. A customer has only one home town. Every trip has an origin and a destination, a bus station and it is organized by only one bus company. A bus station is located in only one town and one town can have many bus stations in it. Reviews are written for a certain bus company and a bus company can have many reviews. One customer can write many reviews but a single review can be written only by one customer. Bank account can be owned by one customer and each customer can own only one bank account.

Gender can be only male, female or not specified. The status of the trip can be departed, arrived, delayed or cancelled. Grade of a review can any be a floating-point number in range [1, 10].

When database is up and running **seed** it with some **sample records in each table**.

Now let’s **make a command line application** that would **use that database and provide the following functionalities**:

- **print information for trips for a given bus station –**  Print a list of arrivals and departures buses for given bus station id in the format provided below
- **buy ticket –** Insert new ticket and reduce the balance from customers’ bank account. Consider managing all cases such as the customer does not have enough money in his/her bank account.
- **publish review –** insert new review from given user into the database
- **print reviews –** print a list of reviews for a given bus company in the format provided below

|**Command**|**Successful Output**|
| :- | :- |
|print-info {Bus Station ID}|<p>{Bus Station Name}, {Town}</p><p>Arrivals:</p><p>From {origin station} | Arrive at: {Arrival Time} | Status: {status}</p><p>Departures:</p><p>To {destination station} | Depart at: {Departure Time} | Status {status}</p>|
|buy-ticket {customer ID} {Trip ID} {Price} {Seat}|Customer {Full Name} bought ticket for trip {Trip ID} for {Price} on seat {Seat}|
|publish-review {Customer ID} {Grade} {Bus Company Name} {Content}|Customer {Full Name} published review for company {Company Name}|
|print-reviews {Bus Company ID}|<p>{Id} {Grade} {Date and Time}</p><p>{Customer Full Name}</p><p>{Content}</p>|

The application should **receive and execute unlimited number of commands** until the **“exit”** command is received.

Use all of the **best practices** you know to design and write your application.
### **Examples**

|**Input**|**Output**|
| :- | :- |
|<p>print-info 1</p><p>exit</p><p></p>|<p>Sofia Central Station, Sofia</p><p>Arrivals:</p><p>From: Burgas | Arrive at: 14:30 | Status: Departed</p><p>From: Svishtov | Arrive at: 07:30 | Status: Arrived</p><p>From: V.Tarnovo | Arrive at: 14:30 | Status: Departed</p><p>Departures:</p><p>To: Varna | Depart at: 14:40 | Status: Delayed</p><p>To: Plovdiv | Depart at: 15:30 | Status: Cancelled</p>|
|<p>buy-ticket 2 323 14.20 A4</p><p>buy-ticket 3 333 -12.00 B8</p><p>buy-ticket 9 874 6.90 A1</p><p>exit</p>|<p>Customer John Doe bought ticket for trip 323 for $14.20 on seat A4</p><p>Invalid price</p><p>Insufficient amount of money for customer Harry Potter with bank account number BGR33133235</p>|
|<p>publish-review 2 10 BusTrip2000 Excellent trip! Look forward to travel again.</p><p>publish-review 3 2 BusCompany2001 Awful and dirty bus. Cannot recommend it to anyone.</p><p>exit</p>|<p>John Doe’s review was succesfully published</p><p>Chuck Norris’ review was successfully published</p>|
|<p>publish-review 2 8.5 BusTrip2000 Would recommend it but the driver needs to stop smoking while driving.</p><p>print-reviews 1</p><p>exit</p>|<p>John Doe’s review was succesfully published</p><p>1 10 2016/11/15 10:46:18</p><p>John Doe</p><p>Excellent trip! Look forward to travel again.</p><p>2 8.5 2016/11/18 12:20:00</p><p>John Doe</p><p>Would recommend it but the driver needs to stop smoking while driving.</p>|
1. ## **\*\*Extend Bus Tickets System**
Implement one additional command **change-trip-status**. That command would change the status of a given trip

|**Command**|**Successful Output**|
| :- | :- |
|change-trip-status {Trip Id} {New Status}|<p>Trip from {Origin Bus Station Town} to {Destination Bus Station Town} on {Trip Departure Date and Time}</p><p>Status changed from {Old Status} to {New Status}</p>|

Add a **new table to the database** to keep information about **arrived trips** (actual arrival time, origin bus station, destination bus station, passengers count).

In case a **trip status is changed to Arrived, automatically add new record** in the **arrived trips table** with the required information.
### **Examples**

|**Input**|**Output**|
| :- | :- |
|<p>change-trip-status 2 Departed</p><p>change-trip-status 3 Cancelled</p><p>change-trip-status 134 Arrived</p><p>exit</p><p></p>|<p>Trip from Burgas to Sofia on 2016/11/15 10:45:00</p><p>Status changed from Cancelled to Departed</p><p>Trip from Sofia to Varna on 2016/11/15 10:00:00</p><p>Status changed from Delayed to Cancelled</p><p>Trip from Plovdiv to Varna on 2016/11/14 15:30:00</p><p>Status changed from Departed to Arrived</p><p>On 2016/11/14 22:32:43 - 34 passengers arrived at Varna from Plovdiv</p>|




