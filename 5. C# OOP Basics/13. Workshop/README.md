
# **Workshop: Forum**
## **Overview**
In this workshop we shall create a functional **Forum** console application. You are given a source code which contains a solution with a single project in it **“Forum.App”**. This is the main project of your application and your business logic.
1. ## **Get Familiar with the Project**
### **Introduction**
In this part you should look around the project that you are kindly provided with. J
1. ### **StartUp**
The **StartUp.cs**’s  **Main** does nothing but instantiate **Engine** class and start it.
1. ### **Engine**
Things here are pretty straightforward too. The class holds a **forumViewer** of type **ForumViewer** and a **menuController** of type **MenuController** (whose methods you need to implement) and **IEnumerable<IController>** as fields.  The **Run** method holds a **while** loop that listens for user input.
1. ### **MenuState** 
An **enum** holding all the states of the menu. 
1. ### **MenuController**
This is the main logic of your menu, and it calls the controllers (you are about to implement) depending of the current state of the menu.
1. ### **InvalidCommandException**
Custom exception that inherits **Exception** class with an overridden message.
1. ### **UserInterface**
The folder contains a **ForumViewEngine** class and all the components it works with. The most significant ones are the **Views**. They store labels, buttons and logic for displaying the information given to them. That’s all you need to know for now, you’ll get familiar with the **ForumViewEngine** API in the process of creating the controllers.
1. ### **Controllers** 
You have a Contracts folder that holds the interfaces your controllers should implement, and a single controller called **MainController** which renders the main view and executes commands. The fun of implementing the other controllers is on you. Good luck!
1. ## **Create Object Models**
### **Introduction**
Before stepping into implementing we need to implement the models that hold the information for our entities: Category, User, Post, and Reply.
1. ### **Create Forum.Models Project**
Create a new project called “**Forum.Models**” and choose the “Class Library” for its output type. 

1. ### **Create Model Classes**
`         `Create the models with the following data: 

For each entity we need to create a class, holding properties show above. As you can see each entity holds information about itself (id, username, etc.) and collection of or a single id of the object that is related with. For example every category has Id, Name, and a collection of integers, representing the ids of the posts it contains. 
#### **Create Category Class**
First off we need to create a public class called **Category.cs**

Then we need to add the properties shown in the diagram above.

First create the property holding the id

Second, create the property holding the name of the category

Third, create the property holding **ICollection** of numbers representing post ids

Last, create a constructor that takes **int id**, **string name**, **IEnumerable<int>** posts as parameters and assigns them to the corresponding properties.

Note: We don’t need private fields behind the properties, because **we aren’t going to perform any validation** on this level.
#### **Finish the Model classes** 
Do the same to create the other three models using the information form the diagram shown above.
1. ## **Create Data Manager**
### **Introduction**
In this part we’re going to implement a [Data Mapper](https://en.wikipedia.org/wiki/Data_mapper_pattern) that reads a row from [.csv file](https://en.wikipedia.org/wiki/Comma-separated_values), converts it into a model and vice-versa. After that we’re going to create a class that holds the collections of all our entities and speaks with the Data Mapper.
1. ### **Create Forum.Data Project**
Create a project called “Forum.Data” and choose **Console App** so you can test your classes in it.

1. ### **Create a DataMapper class**
#### **Fields**
The first property we are going to initialize is **DATA\_PATH**. It will store the directory path were we will store our data (.csv files).

The second one is called **CONFIG\_PATH** and it stores the configuration file name. **DATA\_PATH** and **CONFIG\_PATH** are user concatenated to specify where the file should be.

The third constant is called **DEFAULT\_CONFIG** and it stores the content of the configuration file.

**"users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv"**


The last field is the object representation of the configuration file in you class and is called **config**. As you might have guessed it’s going to be a Dictionary<string, string> where the key represents the **entity collection group** and the value the name of the file it is stored.

#### **Helper Methods**
Next, we should start implementing the **helper methods**, in order to simplify the code and avoid repeating it in the methods, who take care of **parsing** and **reading/writing** entity data.

The first method we are going to implement is called **EnsureConfigFile(string configFilePath)**, his return type is **void** and as you can tell by its name, his job is to check whether a file form the path exists, and creating a new one with the string form **DEFAULT\_CONFIG** constant if it doesn’t. When you finish it will look something like this:

Next method is called **EnsureFile(string path)**, again his return type is void and the logic in it is pretty similar to the previous method only if the file doesn’t exist it creates an empty one. The code of course is similar too:

Note: Don’t forget to close the file.

Next in line is the **LoadConfig(string configFilePath)** method. Since it’s going to load the **config** its return type is **Dictinary<string, string>.** The logic is simple: Call the **EnsureConfigFile** method you have implemented with the given **configFilePath** as a parameter. After that you just need to read the data, split it with delimiter **'='** and convert it to **Dictionary<string, string>** where keys are names of the collection and values are **DEFAULT\_PATH** + names of the files:

Our mapper needs something that **reads all the lines** of the files. This is going to be the static **ReadLines** method, with **string array** as a return type and **string path**. Its job is simple, calls **EnsureFile** with the given path, reads all the lines from the file and returns them as an **array of strings**:

And finally something that **writes into files**, when our **data changes**. Since we’re just writing into the files, the return type of our method is going to be void, his name will be **WriteLines** and the arguments that it would take are **string** representing the **path**, and **string array** containing the **lines (entities)**. The only thing that it would do is to write all the data in the file with the given path. 

#### **Constructor**
The thing we need to initialize in the **constructor** is a **directory** for the **configuration file** and the object **config** that represents **configuration file**.

#### **Parsers**
Now we have to create methods that read the information and converts them to a list of models and corresponding ones that take list of models and writes the to the file in specific format. The entities that we are dealing with will be in the following formats:

**Category format: {Id};{Name};{postId1,postId2,postId3...}**

**User format: {Id};{Username};{Password};{postId1,postId2,postId3...}** 

**Post format: {Id};{Title};{Content};{CategoryId};{AuthorId};{replyId1,replyId2,replyId3...}**

**Reply format: {Id};{Content};{AuthorId};{PostId}**

Each line will contain information about a single entity. 

The fist method we are going to implement is **LoadCategories()** and its return type will be **List<Category>**. Again, the logic is not a big deal, you need to instantiate a **new List<Category>** and read the lines from the file using the **helper method** and the **path** in **config (config["categories"])**.

` `After that you have to **split** each line by delimiter **';'** so you can get the **id** (first argument), the **name** (second argument) of the category and the post **ids** (third argument split by **','**).

` `The next step is to **create** an instance of the **Category** **model** and add it to that list of yours. When you are done with **all the lines** just return the **list of categories**. After you finish it the **method** should look something like this:

Now we need a **method** which does **the exact opposite** of the one we just finished. Its name will be **SaveCategories**, it’s return type – void and it will take a **List<Category>** as argument. You need to instantiate a list again, but this time, it will contains **strings (lines).**

` `For each **model** in the list **create a string**, which follows the **format** shown above and add it to the list. 

At the end call the **WriteLines** method with the path from **config** and the **lines you’ve created**. When you finish it should look something like this:

Following those instructions and repeat that to create: **LoadUsers**, **SaveUsers**, **LoadPosts**, **SavePosts**, **LoadReplies**, **SaveReplies.**
1. ### **Create ForumData class**
This is going to be the holder of all of our data. It will have properties for all the entity groups: 

**Categories**:

**Users**:



**Posts**:

**Replies**:

The next step is defining a constructor that calls the corresponding **DataMapper** methods in order to initialize collections. It should look something like this:

Finally we need a method that saves the changes we made to our collections.

#### **Test Your Code**
Since you’ve created a **console application** at first you’ll have a **Program.cs** file with **Main method** in it, where you can test. You don’t have logic to read the user input, **therefore** you need to **add the information** in the files manually (**following the formats!**) in order to see if the methods you just wrote work in **the way you expect**. After you are done testing you can delete **Program.cs** file, right-click on the project (alt + enter) and set Output type to be “**Class Library”** and you are good to go**.**

In the next part, we will implement the controller logic and everything else.
# **Workshop: Forum – Part 2**
## **Overview**
In previous part we’ve implemented the “database”, now it’s time for **login** and **signup** functionality.
1. ## **Define Redirect to Menu**
In Menu controller class, in Execute command’s switch, all of the states that require special logic are listed as cases if the current state is none of those cases, it ends up in the default case: **RedirectToMenu** method, taking **MenuState** as argument. The logic you need to implement there is simple. Check if the incoming state is different from the current one, if it is, just push the **newState** into **controllerHistory**, call **RenderView** and return true. Otherwise, take no action and return false. It should look pretty much like this.

With this method our menu changes its current state and then call the **RenderCurrentView**. If you take a close look you will find that **RenderCurrentView** does nothing but asking the current controller for a view, setting it to be **CurrentView** and calling it’s own **forumViewer**’s **RenderView** method with the **CurrentView**.

Now that we have a method that wants stuff form our controllers, we shold step to **implementing controllers**.
1. ## **Implementing LogInController**
In the class **LogInController** all you have for now is the implementation of **IController** and **IReadUserController** interfaces and all of the methods throw **NotImplementedException**. 
### **Properties**
One of the properties that needs to be defined already exists and all you have to change is give it a **public** **getter** and a **private** **setter**. Like this:

Next, we should add a **private** **string Password**:

The last property that the controller needs for its functionality is the **private bool Error**:

Note that Password and Error are not part of the interface, that’s because they are needed only for **inner usage**.
### **Helpers**
After we made the properties we need, we are going to implement some other stuff that we need. In this case this is an **enum** (your favorite) which is **private**, **called Command** and holds the indices of the controller’s **commands**. It should look a lot like this:

The next helper method is **ResetLogin** and it speaks for itself. It sets **Error** to false, **Username** and **Password** to **string.Empty** so they are not null… Simple as that.

### **Constructor**
The constructor of this controller just calls the **ResetLogin** method we’ve just written, like so:

### **Implement Interface methods**
The first method we are going to implement is the **GetView** method that is called by **MainController**’s **RenderCurrentView**. As you can tell by its name the method **returns view** and the implementation is straightforward.

Note: Include the namespace in the **using**, so you can see the views.

Next in line are **ReadUsername** and **ReadPassword** and they are pretty much the same. They read a row for the corresponding property and call **ForumViewEngine**’s **HideCursor** method. 

Having the implementation of **ReadUsername**, write the logic of **ReadPassword**. By this time, you should be able to go to **LogIn** and the controller should **return a view** for the **ForumViewEngine** to **render**. Try it out.
### **ExecuteCommand**
This is the method, every controller has. It determines, which of the commands should execute and calling the corresponding method for it. It should contain switch case with all of the commands in the **Command** **enum**. The easiest way of implementing it is:

Define a switch statement:			 Cast the parameter to **Command**:



And then press enter twice. And… voilà!

The next step is to **delete the default case** because we are not going to need it. Then, you should replace all the **break** statements with **return "MenuState.SomeState"**, because the return type of the method is **MenuState**. First two cases (**ReadUsername** and **ReadPassword**) are going to return **MenuState.Login** in order for the user to **stay** on the same view. Login command case is going to return **MenuState.Error**, just for now. And finally **Command.Back** should return **MenuState.Back**. We are about to implement some logic in the cases in just a few moments, but before that check if your switch looks like this:

All that’s left to do is to **call the methods** we have already implemented that **execute the commands**. The **ReadUsername** command will call the **ReadUsername** method. I think you can guess what **ReadPassword** should call. Finally, the **back** command should **reset the login**. One last thing to do here for now is to throw an exception if the command doesn’t match any of the cases. (Ideally, you should implement your own custom exception, but the built-in **InvalidOperationException** works as well).

` `Finally, your method should look like this:

This is it for now, we will be back to finish that **TODO** later.
1. ## **Implementing SingnUpController**
The **SignUpCntroller** is pretty similar to the **LogInController** so let’s get right to it.
### **Fields**
The fields we are going to are two **private const string**s holding the **error messages** of the view. The f one is called **DETAILS\_ERROR** and looks like this: 

And the other one is called **USERNAME\_TAKEN\_ERROR**:

### **Properties**
The Username and Password properties are **exactly the same** as in the **LoginController**. The thing that is new is the private string **ErrorMessage** looking like this:

### **Helpers**
The first helper we will implement is the **Command** enum that every view has. This time, however, instead of a **LogIn** command it will have **SignUp** instead: 

This time we are going to define a second enum holding **SignUpStatus** which will tell our controller if signing up our user is successful and if not, **why**.

As you might have guess the **ResetLogin** method should look like this.

### **Implement Interface Methods**
**ReadUsername** and **ReadPassword** are the same as the ones in previous controller (surprise), **GetView** method looks like this: 

### **ExecuteCommand**
Since you are aware of the **witchcraft** from the previous part, I suppose you will be able to get to this state:

Again, everything is the same: Each command calls its corresponding method except the **SignUp** command. (We’ll get to that in seconds, really...) Final look before proceeding to the service:

1. ## **Implementing UserService**
In this part we will implement **UserService** class who will serve both controllers we’ve just implemented. According to Wikipedia service is something like *“… **software** functionality or a set of software functionalities (such as the retrieval of specified information or the execution of a set of operations) with a purpose that different **clients** can **reuse** for **different purposes**…*”. We’ll dive into that in the next course, but all you need to know for now is that the functionality of operating with the “database” **shouldn’t** take place in your **business logic**. That’s why you create services. J
### **Create Services folder**
In the main directory of the project create new folder called **Services**.

### **Create UserService**
In services directory create **public static class** called **UserService**

### **Implement TryLogInUser**
First of all, create a **public static TryLogInUser** method of type **bool** with **username** and **password** as parameters.

Then, check if the given username or password is null or empty and **return false** if any of them are.

After the check instantiate an object of type **ForumData** and check if there is any user with the same username and same password. Return the result.

The whole method should look like this:

### **Implement TrySignUpUser**
Since the possible endings of signing up a user are more than 2, we are going to user the **SignUpStatus** enumeration you’ve created earlier. (You remember it, right?) We are going to define **public static** method of type **SignUpStatus** taking username and password as parameters.

The validations you need to perform here are if the username and password are not **null or empty** and if they meet the requirements for **minimum length that is 3**. To do that define a bool variable that checks those two conditions for username:

And then repeat it for password:

After that if one of the defined variables is false return “**DetailsError**” **SingUpStatus**:

Next you need to instantiate object of type **ForumData** and in another variable determine if there is user with the username that is given as a parameter:

If such user doesn’t exists in the “database” you need to **generate** an id for the new user by taking the **last user id and incrementing it with one** or **setting it to one if there are no existing users**. Then you create a **User** model with the data you have, **add the user to the base**, **save changes** and return **Success** status. If the user exists return **UsernameTakenError** status.

The entire method should look like this:

1. ## **Finish the Implementation of User Controllers**
### **LoginController**
In **ExecuteCommand**‘s **LogIn** case define a Boolean called **loggedIn** (for example) and assign it with the result of **UserServise**’s **TryLogInUser** method with parameters **Username** and **Password** properties:

If logged in is true **return** **SuccessfulLogIn** state otherwise set **Error** property to true and keep the return of Error state.

### **SignUpController**
**SingUp** case here is pretty much the same. We call the **UserService** **TrySignUpUser** with **Username** and Password and assign the result in a variable:

Next we switch on **signUp** and return **SuccesfulLogIn** state in case of Success Status: 

Setting **ErrorMessage** to **DETAILS\_ERROR** constant in case of **DetailsError** status:

And **USERNAME\_TAKEN\_ERROR** in case of **UsernameTakenError** status:

All of it looks like this:

All that is left for us to do is implementing **LogInUser**, **LogOutUser**, **SuccessfulLogIn** and **LogOut** in **MenuController**.
### **LogInUser**
Here you just go through all of the controllers and calls the **UserLogIn** method if the controller implements **IUserRestrictedController** interface, like this:

### **LogOutUser**
This method is the same as **LogInUser** but calling **UserLogOut** instead.
### **SuccessfulLogIn**
All you have to do here is cast the **CurrentController** so you can get the username from it and set it to **MenuController**’s Username:

Next you call the **LogIn** method you’ve just implemented and the **RedirectToMenu** with the **Main** **MenuState** as a parameter.

### **LogOut**
The last piece of code you need to write in this method does the following:

Setting **Username** to an empty string. Call the **LogOutUser** method and then renders the current view, like so:

That’s it! If you have done everything right you should be able to signup users and login with them. See you in the next part where we will implement posts and replies functionality. J
# **Workshop: Forum – Part 3**
## **Overview**
In the previous two parts we’ve implemented the Data management and signup and login functionality. In this part comes the real fun. We will implement adding and displaying categories, posts and their replies.
1. ## **Creating View Models**
In almost every architecture with user interface **view models** are used in order to make displaying the information from the models ([DTO](https://en.wikipedia.org/wiki/Data_transfer_object)) easier. In general view models differ from the entities in the fact that they only store information that is significant for **view** to display and they can store logic of **formatting** that information. For example, the **PostViewModel** you’re about to implement, doesn’t care about its author or category id. It will keep strings with their names instead. Enough talking, let’s write some code and it will come to you.

Now first create a **ViewModels** folder in **UserInterface** directory. There we will store our view models


### **Post View Model**
In the **ViewModels** directory you’ve just created add a new public class called **PostViewModel**. First we need to add a private constant of type **int** called **LINE\_LENGTH**. We are going to need it for wrapping our text to fit the view layout.



We continue with the properties of our view model. You’ll be surprised that they look a lot like the **Post** model from your **Models** project. First one is an integer and we are going to name it **PostId**:



Next comes the title which is the same:

After that instead of integer that keeps the author id we will keep his name as string:

We do the same for the category name:

Next, we will define a property for our content, but instead of keeping it in a single string, we will create an **IList<string>**:

Now we have to make an **IList** of **ReplyViewModel**s in order to keep our replies, create the **ReplyViewModel** class in the same folder (we’ll be there in a bit) and come back to implement it:

The last thing for now is a text wrapper method we are going to call **GetLines**. It will be of type **IList<string>** and will take the content string as a parameter.

The implementation is simple. Fist we take our string and covert it to a nice comfy **array of characters**, like so:

Next, we are going to make ourselves a **List<string>** which we will return in the end:

Now the logic of the method is going to take place in a **for** loop statement, whose counter value will be assigned to zero, it’s condition will be that the value should be less than the content length (parameter) and the value will be incremented with **LINE\_LENGTH**’s value on each iteration. Then all you have to do is **calculate the characters** that has to be on the current row, concatenate them to a **single string** and add them to that list of yours you’ve created. I will appreciate if you try and do it yourself. In any case, there is an implementation coming right up.

This is how the loop should look like:

This way you can calculate the line that you are on:

This is hot the whole method should look like:

That’s it for now, we’ll be back later when we finish our services. Now let’s proceed to the **ReplyViewModel**.
### **Reply View Model**
Again, we start with the **LINE\_LENGTH** constant and is going to be the same as in Post View Model because we want our text to look consistent in our app. 

Next, we define a property which is a string and holds the Author’s username:



And a property that holds the content which will be of type… guess what… **IList<string>:**

Next, we will need a text wrapper that will take a string content and return **IList<string>** representing the lines. Sounds familiar? You can Copy and Paste it from the previous View model, and let’s hope you didn’t mess it all up the first time, right? J

That’s all we could do to our view models without the help of our services (remember?). We will be back to finish them in a bit.
1. ## **Proceed the Implementation of Service Layer**
In this part we’re going to finish the functionality of our service layer.
### **User Service**
We have created most of the stuff here in the previous part. The new thing that we need our **user service** to provide now is to fetch an existing user for us, and we are going to create two overloads of the same method. First one is going to search by **username** and the second by **id**.

First, we create a new public static method that returns a **User** and takes an **int** **id** as a parameter:

In the method instantiate an object of type **ForumData**, find in its users the one with the same **id** and **return** it. It should look something like this:

Having this, implement an **overload** to this method that takes **string username** as a parameter.
#### **Finish Reply View Model**
Just go back to **Reply View Model** and add a constructor that takes a **Reply** as an argument. First set the author name calling the **UserService**‘s corresponding method:

Then set the content lines using the method you write in **Part I.** of this document:

Finally add an empty constructor that takes no arguments.


### **Post Service**
Create a new **public static class** called **PostService**. For now, we are going to implement just two methods in order to finish the **PostViewModel** Implementation. Don’t worry, we’ll add more functionality with the post data later.

The first method we are going to implement will fetch us a category model found by **id**. It’s called **GetCategory** and takes an **id** as a parameter:

Since you saw how the **GetUser** method works, I am sure you can handle this.

And the second method is called **GetPostReplies** with parameter **postId** and return type **IList<ReplyViewModel>**. The task is simple you need to find the post by **id**, fetch it’s replies, instantiate a **ReplyViewModel** with each of them and return them as an **IList**. Easy.

First you create an object of good old **ForumData**.

Get the post with the given **id.**

Create an **IList<ReplyViewModel>** that you are going to fill.

In a **foreach** loop through current post’s replies **id**, find the post (in **ForumData**) with the same **id**, make **RepleyViewModelObject** with it and add it to the list you’ve just created. Finally, you should return the list. All of it looks like this.

#### **Finish Post View Model**
The thing we have to finish here are the constructors. Add one that takes no arguments and sets the Content to new **List of string**. There won’t be a screenshot, I **believe** in you.

The second constructor is going to take a **Post** model as an argument and it will:

Set view model’s post id and title:

Set the content lines with the result of get lines with **post.Content** as parameter:

Fetching the author name by **id** from **user service:**

Calling the method for getting the category form post service

Getting the replies by **id** from post service:

All of it:

Now that we’re ready with the view models and most of the Services we can dive into implementing controllers.
1. ## **Implementing Categories Controller**
Open the **CategoriesController** class, it should look like this:

### **Helpers** 
We are going to need an **enum** once again, but this time we’re going to set its integer values, because the count of the categories may vary:

### **Properties**
First remove **CurrentPage**’s **NotImplementedException** so it becomes like this:

You will need two **array** properties, one to keep all the category names:

And one for the ones on the current page:

Then there’s a property that calculates what the index of the last page is:

And two Boolean properties that determine whether your controller is on the **first page**:

Or the **last one**:

### **Methods**
The next method is called **ChangePage** and changes the **CurrentPage** depending on a **boolean** that is given to it as a parameter. This is the implementation:

For the next method we first will have to implement a service method in **PostService** whose job will be to fetch all the categories from **ForumData** and **return** their names as an array of strings. It’s called **GetAllGategoryNames** and the implementation is something like this:



Now we can return to our controller and continue with a method called **LoadCategories** and its task will be to call the service method we’ve just wrote, set the result to **AllCategoryNames** and then the set the **current ones**. The implementation goes like this:

The **GetView** method’s job is to call **LoadCategories** and **return new view**

### **Execute Command**
Once again, we’re in the method that decides which command should be implemented depending on the menu state. There is a slight difference however. If the **index** that we get as a parameter is **between 1 and 10** that means the cursor is on a **post** and its value should be set to 1 (take a look at the enum you’ve implemented). This is done by a simple if statement:

For the next step I again will rely on magic abilities and expect that crafting such statement won’t cost you any trouble.

All of the commands you need to invoke are **PreviousPage** and **NextPage**… And is actually just one method, right? So, in case of **NextPage** call the **ChangePage** method with no parameters since its parameter has a default value:

And PreviousPage calls it with false as a parameter:

The whole thing should look like this:

### **Constructor**
All the constructor does is setting **CurrentPage** to 0 and calling **LoadCategories** method:

1. ## **Implementing Category Controller**
Now, go to category controller and you should find something like this:

### **Helpers** 
The enum is exactly the same with the previous controller.
### **Properties**
First remove **CurrentPage**’s **NotImplementedException** so it becomes like this: 

Now there are somethings we need to have in our controller. One of them is array of string holding every **post’s title**:

For the next property you need to calculate the index of the last page of the posts so you can check if you are on the last page further in the implementation:

Next two are Boolean properties that check if you are on the first page or the last page and they are the same as in **CategoriesController**.

The last property will be public and holding the category id:

### **Methods**
The first method we are going to realize in this controller is the public void **SetCategory** method taking **int id** as an argument. Its job is simple: just sets the corresponding property with the value of the parameter it is given:

The next method is called **ChangePage** and changes the **CurrentPage** depending on a boolean that is given to it as a parameter. Sounds familiar?

For our next method we will need a post service we need to implement first. So, go to the **PostService** and implement a method of type **IEnumerable<Post>**, called **GetPostsByCategory** and takes **categoryId** as a parameter. All it should do is get the Category’s post ids and then filter the posts models with the given ids and return the result. Easy, right? Here is a screenshot just for sure:

Now that you have that service you can implement **GetPosts** method that takes all the posts and assigns them to the **PostTitles** property depending on the page that the controller is currently on. It should look something like this: 

Next in the line is **GetView** method who calls **GetPosts** method to be sure that current **PostsTitles** are the ones that the controller needs. Gets the **category** **name** from the service we’ve implemented and returns new **CategoryView** with the data:

### **Execute Command**
Identically with **ExecuteCommand** in the previous view, just change pages and return states show below:

### **Constructor**
Slightly different from categories controller **constructor** it sets current page to 0 and call **SetCategory** with parameter 0, like this:

### **Menu Controller’s Open Category**
The one last thing we need to implement before testing your categories and category controllers is the **OpenCategory** method in menu controller. It does very important job. It determines the **category** you want to open by the **index of the current object** and gives the **CategoryController** the category’s index. This is the implementation:

Now you can add manually some categories and test what you’ve done.
1. ## **Implementing Post Details Controller**
This controller returns a **PostDetailsView** and tells it whether you’re logged or not. Let get straight to implementation:
### **Helpers**
This time the controller’s executable commands are only two:

### **Properties**
First of all, get rid of **NotImplementedException** that **LoggedInUser** throws and make it normal automatic property.

After that add public **PostId** property, like so:

### **Methods**
**UserLogIn** method’s job is to set **LoggedInUser** property to true, like this:

Guess what **UserLogOut** does…

The next method you need to implement is the public void **SetPostId** method and you’ll never guess what it does:

Now to implement the **GetView** method we need a **PostViewModel** to give the view. That’s why we are going to implement ourselves a **service method** that does that. Go to **PostService** and create a **public static** method of type **PostViewModel** that takes **int id** as an argument, like this:

The logic is simple, find a post with the given **id**, create **PostViewModel** with it, and returns it:

Now we can implement the **GetView** method:

### **Execute Command**
Again, we have to implement the switch that returns different menu state depending on the index of the command. Since we’ve got only two commands in our **enum** we will have only two cases in our **switch**. The **AddReply** case should return **AddReplyPost** **MenuState**:

Next case is Back command and all it should do is reset **ForumViewEngine**’s Buffer and return the corresponding **MenuState**:

That’s all you have to do here. Just don’t forget to throw Exception if the index doesn’t match any case.
### **MenuController’s View Post method**
The method you are about to implement looks a lot like Open Category method. Its job is to get the **category id** form the **CurrentController**. Fetch all the posts with the current **category id**. Calculates **the index of the post you want to view and gets his index**. Fetches the post controller at index **Menu.ViewPost** (you remember they are integers, right?), and call the **RedirectToMenu** with **MenuState.ViewPost**:

By now, you should be able to view a post that you have inserted **manually**. Try it!	
1. ## **Implementing Add Post Controller**
By now we have working functionality of logging in, signing up, and viewing our categories and posts. Now we shall step into implementing the most important functionality of our forum, adding posts.
### **Fields** 
Take a look at the fields you are provided with by default, their names **speak** for themselves. 

You have to add two more fields that will hold the coordinates of the center of the console. You can get them from the **Position** class that is located in **UserInterface** folder. They should look like this:

### **Helpers**
Once again, we need to define the commands that our controller will have. They will be **AddTitle**, **AddCategory**, **Write**, and **Post**. Create the enum that is called **Command**:

### **Properties**
The properties that we need are a **PostViewModel** that we need to display the information from. Create it with private set, like this:



Next, we need a text area as a property where we will get our text from. You could take a look at the implementation of the **TextArea** and add some functionality if you want. Anyways, your property should look like this:

The final thing that we going to need is boolean propety called **Error:**

### **Methods**
Now, as I said earlier **TextArea** will be responsible for the content string, but the title and the category will be read like the **user data** in the previous document:

There, since you have the implementation of the **ReadFile** method use it to implement **ReadCategory**.

The next method is **IController**’s **GetView** and all it should do is set the **author** of the post and return new **AddpostView** giving it the **Post**, **TextArea** and **Error** as parameters:

The last method we need is **ResetPost** and its name pretty much speaks for itself:

### **Execute Command**
I believe you’ve done enough times already. Create a switch on the casted parameter:

Now, **AddTitle** and **AddCategory** should call the corresponding methods you’ve just wrote.

The Write command should call **TextArea**’s **Write** method and the set the post content to **TextArea**’s lines something like:

The last command is **Post** and in order to implement that case we will have to make ourselves a service method called **TrySavePost** and takes **PostViewModel** as argument. Go to **PostService** class and add the following methods:

First we need to create a method that ensures that we have the category for the post we are trying to add:

Note that this method doesn’t use its **own** **ForumData** but takes one as an argument.

Now we proceed to adding posts. Define a method that looks like this.

In it crate **validations** for the **category**, **title** and the **content** represented as Booleans:



And if any of the variables is **true** your method should return false:

After we validate our **ViewPostModel** we should instantiate new **ForumData** and call the **EnsureCategory** method we’ve just created:

After that we should generate a new **id** for the entity we’re about to create. You ca see how in the **EnsureCategory** method shown above.

Next we fetch our post author calling the **UserService** **GetUser** method with **PosViewMode.Author**:

The next two steps are getting the author id and concatenating **postView.Content** into a single string:

Finally create new Post model with the data you have and add it to forumData’s posts, the current author posts ids and current category posts ids and don’t forget to SaveChanges after you’re done:

All that is left to do is set postView.PostId to the curretn post id and return true in the end. All that should look like this:

Now we are ready to go back to **AddPostController**’s Execute command and add the following in Post command case:

### **Constructor**
Create and empty constructor that calls **this.ResetPost** method.
### **Menu Controller’s Add Post method**
The last thing we need to implement in order for our forum to create posts is implement **AddPost** method in **MenuController**. All it should do is fetch current post **id** set, give it to **PostDetails** Controller, resets the **AddPostController** and **Redirect** method, like this:

By now your forum should can add posts. Having all this implement **AddReplyController**. The service methods you will need are called **TryAddReply** (similar to **TryAddPost**). Good luck!


