
# **Calculator: Java and Spring**
This document defines a complete walkthrough of creating a **Calculator** application with the [Spring](http://spring.io/) Framework, from setting up the framework to implementing the fully functional application.
1. # **Setting Up JDK and IntelliJ Idea Configuration**
Before we start, you need to download the [Java Development Kit](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html), also known as **JDK**. Download the "**Java SE Development Kit 8u141**". After downloading it, install it **without changing the installation directory**. The default configuration will install it in the "**Program Files\Java**" folder if you’re running **Windows**.
1. ## **Set Up JDK**
If you are using the skeleton and see something like this:

You should set-up the SDK. Click on "**Setup SDK**". You should see this screen:

Click on "**Configure**" and see if you receive this screen:

Click on the **green plus sign** in the top left corner of the window and choose **JDK**:

Then **locate your JDK**, it should be in the "**Program Files**" **folder** if you're using **windows**:

After you click "**OK**", you should see this screen:

That’s everything, your **JDK is now configured**.
1. # **Base Project Overview**
1. ## **Open the Project**
When you open the [project](http://softuni.bg/downloads/svn/soft-tech/May-2017/Software-Technologies-July-2017/09.%20Software-Technologies-Java-Syntax-and-Basic-Web/09.%20Software-Technologies-Java-Syntax-Basic-Web-Calculator-Skeleton.zip) you might see the following window in the lower right corner of IntelliJ IDEA:

Click on "**Enable Auto-Import**". It is **really important** and if you miss this step, the **project might not work** as **you would expect**.

In our [project](http://softuni.bg/downloads/svn/soft-tech/May-2017/Software-Technologies-July-2017/09.%20Software-Technologies-Java-Syntax-and-Basic-Web/09.%20Software-Technologies-Java-Syntax-Basic-Web-Calculator-Skeleton.zip), there is only one folder we're interested in. That would be the “**src**” folder. That folder will **contain all the files** we are **going to create**. Let's take a look:

We can see several folders here. Let look at them one by one and see what they are for:

1. **src** –** Contains all the **source** files of our applications, including **templates**, **models** (entities) and **controllers**.
1. **src/main/resources/static** – Everything that’s in our **static folder** (files, images, stylesheets, JavaScript scripts, etc.) will be **accessible** by **every user**.
1. **src/main/java/{packageName}/… –** we’ll store all our **back-end logic** (controllers, entities, etc.) here (in separate folders, of course).
1. **src/main/resources/templates** – we’ll store our **view templates** here. We’ll be using the template engine **Thymeleaf**.
1. ## **Run the Project**
Now that we’ve opened the project, let’s try running it, so we can see what we’re working with. Go to the **top right** corner of **IntelliJ Idea**, where you’ll find a **Run** button, which looks like a **green play button** (be patient – the first build may take a while due to resolving dependencies):

That’s how we’ll run our Spring app. Go ahead and click the **play** **button**. If everything goes according to plan, we should see this message in the console:

Now we can open the page (at **localhost:8080**) and see what we have:


It doesn’t look like much, but at least we have the basic layout down! Let’s get to work on implementing some functionality!
1. # **Implementing Functionality**
1. ## **Create Calculator View**
Before we start adding functionality, it would be nice to have an idea of what we’re working against, so let’s go ahead and **create** a **form**, which the **user** will use for **calculations**:

Go into the **src/main/resources/templates/views/** folder and open the **calculatorForm.html** file:

It’s empty?! How does the header and footer seen above get displayed then? The answer is, we use a global **layout** file (**base-layout.html**), so we don’t have to copy-paste our page layout into every single view in our project (which could have **tens** or **hundreds** of views). All the **actual base design HTML** is inside **base-layout.html**. We won’t be touching that, so let’s go to the **calculatorForm.html** file and add our form:

|<**form class="form-inline" th:action="@{/}" method="POST"**><br>`    `<**fieldset**><br>`        `<**div class="form-group"**><br>`            `<**div class="col-sm-1 "**><br>`                `<**input type="text" class="form-control" id="leftOperand" placeholder="Left Operand"<br>`                       `name="leftOperand" th:value="${leftOperand}"**/><br>`            `</**div**><br>`        `</**div**><br><br>`        `<**div class="form-group"**><br>`            `<**div class="col-sm-4 "**><br>`                `<**select class="form-control" name="operator"**><br>`                    `<**option value="+" th:selected="${operator.equals('+')}"**>+</**option**><br>`                    `<**option value="-" th:selected="${operator.equals('-')}"**>-</**option**><br>`                    `<**option value="\*" th:selected="${operator.equals('\*')}"**>\*</**option**><br>`                    `<**option value="/" th:selected="${operator.equals('/')}"**>/</**option**><br>`                `</**select**><br>`            `</**div**><br>`        `</**div**><br><br>`        `<**div class="form-group"**><br>`            `<**div class="col-sm-4 "**><br>`                `<**input type="text" class="form-control" id="rightOperand" placeholder="Right Operand"<br>`                       `name="rightOperand" th:value="${rightOperand}"**/><br>`            `</**div**><br>`        `</**div**><br><br>`        `<**div class="form-group"**><br>`            `<**div class="col-sm-2 "**><br>`                `<**p**>=</**p**><br>`            `</**div**><br>`        `</**div**><br><br>`        `<**div class="form-group"**><br>`            `<**div class="col-sm-4 "**><br>`                `<**input type="text" class="form-control" id="result" placeholder="Result"<br>`                       `name="result" th:value="${result}"**/><br>`            `</**div**><br>`        `</**div**><br><br>`        `<**div class="form-group"**><br>`            `<**button type="submit" class="btn btn-primary"**>Calculate</**button**><br>`        `</**div**><br>`    `</**fieldset**><br></**form**>|
| :- |

Just like with the JavaScript blog, we will **save the state** of the operands and operator for ease of use, so the **Thymeleaf syntax** you see here does just that. The **th:selected=""** template is a bit more special: it **automatically** **selects** the operator from the dropdown list, **based on** the last used operator. We’ll see how that’s implemented a bit later. For now, let’s navigate to our web app at <http://localhost:8080> and see how we’re doing:

Still nothing?! The reason our form doesn’t display is because we’re not sending the **form view** to the user. To add the form to our project, we need to do two things: The first thing is to add this line of code in **base-layout.html**:

This line of code expects to be fed a **template** to display around the header and footer. So, we’re going to do just that. Go into the **HomeController.java** file and check out what the **index** action does:

All this action does is listen on the “**/**” (site root) route, and display the **base-layout** view. But before it displays it, it **adds an attribute** to the model. The **model** is the **data** that’s fed to the **view**, so it can perform various functions (such as displaying the calculator’s operands, operator, etc.). We’re going to give the **view** one more **attribute**. Remember that **${view}** template the **base-layout** expects? Let’s **add** it here **before** returning the base layout view:

We’ve given it the view, so let’s get **restart** our Spring application and see how we’re doing:

Looking good! Except it doesn’t do anything. First, let’s get down to making the thing, which will hold our data: the **model**.
1. ## **Create Calculator Model**
It’s time to design our main model – the **Calculator**. It will contain the following properties:

1. **leftOperand**
1. **operator**
1. **rightOperand**

Let’s create our mode. Since we’re **not** using a database in this exercise, we’re just going to define the calculator as a **simple Java class**.

Go into the **entity** folder and create a new Java class, called “**Calculator.java**”:

Now, let’s define what our class will have:

1. Create **fields**, which will be used internally in the class:
1. **Define** the calculator **properties**:

|<br>|à||
| :-: | :-: | :-: |
1. Create a **constructor** for **instantiating** the calculator:
1. Create **getters** and **setters** for the** Calculator’s **fields** (you can make them with **[Alt + Insert]**)
1. Create a **method** for **calculating** the result from the **properties**:

   Inside this method, we’ll write the logic, which is needed for calculating the result from the operands and operator. Let’s create the logic, needed for that.
1. Write the calculation logic:
 

Our calculator logic is neatly nested inside the **Calculator** class. Now all that’s left is to connect it to the rest of our little web application.

For our final trick, we’ll create our own controller action, which will **process** what the user sent us and **return** a **view** with the **result** from the calculation.
1. ## **Implement the Controller Action**
Now that we’ve created the **view**, which will **hold our data** and allow the **user** to **interact** with our web application, it’s time to implement the driving force behind the whole app – **the controller action**. 

As it turns out, we already have a **home controller** set up, and an action, set up on the “**/**” route, otherwise we wouldn’t even be able to see our calculator. You can find the **home controller** in the “**controller**” folder. Let’s see what it looks like:

Not much going on here… Let’s break it down:

- **@GetMapping("/")** è the piece of code, which binds a URL Route to a method, so it can **execute the action** when our user **calls** the specified **route** (right now, that’s “**/**”).
- **public String index(Model model)** è This is the actual **controller action**. It’s a method, which **holds the** **logic**, which will be **executed**, when it’s **called**. 
  It has one parameter: **model** – it holds the data, which will be passed to the **view** for processing. Remember – all we’re doing here is returning different **HTML**, based on the logic we’ve implemented in our app.
- **model.addAttribute(String, String)** è this piece of code takes **2 parameters** – the **first** states the **name** of the **attribute** we’re going to **send** to the **view**. The **second** one – the **actual data**.
- **return "base-layout"** è This function **renders** a **layout** in the **response** (in essence, takes whatever’s inside of “**templates/base-layout.html**”, runs it through the **Thymeleaf** templating engine, and returns it to the user.

So, using that newfound knowledge, let’s try to create our own **action**.

First, we’ll start off by declaring what kind of **HTTP method** this method will be handling (either GET or POST). In our case, since we’re processing **form data** sent to the “**/**” URL, we’ll set it to **@PostMapping("/")**:

After that, let’s declare our method. We’ll use a couple of new types here – **RequestParam**. That’s just a fancy way of getting the form data:

All this method should do at this point is just return the **base-layout** template with the **form attribute** inside of it:

Let’s see what a debug session would show us if we were to debug this method:

||
| :- |
||
||
The **leftOperand**, **operator**, and **rightOperand** variables come in the form of **strings**. So, before we feed them to our **calculator** class, we need to **parse** them as numeric variables, using **try-catch** blocks:

This will ensure, that if the user tries to send us **invalid data**, it’ll be set to **zero** instead.

Next, we need to create an **instance** of our calculator model, which we’ll use for storing the data inside:

We can set its data, using its constructor, which we defined in step 4. Now that we’ve gotten the data, it’s time to calculate the result from what we currently have. Remember that **calculateResult()** function we wrote a while ago? Now is the time to use it:

After that, all we have left is to **send the result to the** **view**. Apart from the result, we also need to send the **leftOperand**, **rightOperand** and **operator**, so we can **save the state** of our calculator through requests. We can do that, using the **model.addAttribute** function:


This way, we specify what we’re going to **send** to **the view**. So, when we send over the **result value** and the previous state of the calculator to the view, we can **fill** the **form fields** with our data. This happens here:

We use the data from the controller in the **views/calculatorForm.html** view to set the **values** of the form inputs to whatever we want. In this case, we set the **operands**, and select the last used **operator**.
1. # **Test the Application**
All our hard work should finally pay off now, right? If you’ve followed all the steps properly, and have read all the explanatory text, hopefully we should have a functioning calculator!



