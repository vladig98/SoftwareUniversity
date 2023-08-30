# Exercises: HTML5 and CSS

Problems for exercises and homework for the [“Software Technologies”
course @ SoftUni](https://softuni.bg/courses/software-technologies).

After following the steps for this exercise, you should have built the
base for our blog.

Note that this exercise uses bootstrap extensively, so every HTML code
you write will be instantly stylized and will look good off the shelf.
This is not the case when you write plain HTML without ready styles.

However, pay attention to the **\<tags\>** that we are using. Almost all
**\<tags\>** that we are going to write use a **class=""** attribute
(that is **\<tag class="some class"\>**). The **class=""** attribute
points to the corresponding selector in the **style.css** file. This is
exactly the same as when you are writing your own styles but in our
case, they are provided by the open source framework called
[bootstrap](https://en.wikipedia.org/wiki/Bootstrap_(front-end_framework)).

With this in mind, let's get to work.

# Initial Setup

## Create New Project

Open WebStorm and create new project from **File -\> New… -\> Project**

<img src="media/image1.png" style="width:3.52292in;height:3.25in"
alt="1" />

Now select **Empty Project** and choose a **destination folder** of your
project:

<img src="media/image2.png" style="width:6.94in;height:4.3in" alt="2" />

## Add Blog Home Page

Create new HTML file called **index.html** that will be our **home
page.**

<img src="media/image3.png" style="width:5.21291in;height:1.69167in"
alt="3" />

<img src="media/image4.png" style="width:2.55833in;height:1.45in"
alt="4" />

## Create a Directory for Styles

Create **new directory** in our project that will keep our **CSS files**
and name it **styles**:

<img src="media/image5.png" style="width:6.14524in;height:1.48333in" />

<img src="media/image6.png" style="width:3.95139in;height:1.32639in"
alt="C:\Users\Valio\AppData\Local\Microsoft\Windows\INetCache\Content.Word\45.png" />

## Create a Directory for Scripts

Create **new directory** in our project that will keep our **JS files**
and name it **scripts**:

<img src="media/image5.png" style="width:6.29167in;height:1.51868in" />

<img src="media/image7.png" style="width:4in;height:1.41667in" />

## Add CSS Files to the "styles" Folder

In the **resources folder** for this exercise, you can find some files
that you will need for the blog. Head there and find the file
"**style.css**". This file is a complete .css file that contains a
modified bootstrap theme, meaning that it is basically a plug and play
theme, **link your html files to it** and everything will be readily
styled.

Just copy "style.css" from the resources folder and paste it in the
WebStorm SoftUni Blog styles folder you just created:

<img src="media/image8.png" style="width:7.47866in;height:1.68852in" />

<img src="media/image9.png" style="width:5.44544in;height:2.625in" />

## Add Script Files to the "scripts" Folder

Head to the resources folder again, copy all **.js** files and paste
them in the "**scripts**" folder:

<img src="media/image10.png" style="width:7.51611in;height:1.57381in" />

<img src="media/image11.png" style="width:4.33333in;height:1.58333in" />

## Site Basic Structure

<img src="media/image12.png" style="width:1.83333in;height:2.24653in"
alt="7" />Now it’s time to start writing some code. Create the **basic
structure of a html** document:

- **\<!DOCTYPE\>** – this is an instruction to the web browser what
  version of HTML our page is written in. For HTML5 we should declare to
  be **\<!DOCTYPE html\>**

- **\<html\> –** this tag is the container of all other HTML elements in
  the document

- **\<head\>** - contains metadata like the title of the document,
  styles scripts, meta information and more.

- **\<body\>** - the actual content displayed in the browser

Here’s what it would look like in actual **HTML**:

## Link HTML and CSS Files

Now, we have the **HTML file** where the **structure of the blog** will
be, and the **CSS file** that will **make the blog look pretty**. But
the **HTML file** **does not know** that the **CSS file exists**. So,
let’s link them. You will need to link every page for the website to
this css file.

This can be done in the **\<head\>** part of the HTML file using a
**\<link\>** tag with **attributes**:

- **type** **text/css**

- **rel** **stylesheet**

- **href** **styles/styles.css**

<img src="media/image13.png" style="width:6.61883in;height:0.81356in" />

## Link HTML and jQuery Script Files

After we **linked the CSS file** we now have to **do the same for the
jQuery and Bootstrap script files**. Linking script files is slightly
different from linking a CSS file.

To add **jQuery** to our project, we can go to the **\<head\>** part of
the **HTML** file, and add a **\<script\>** tag with **attributes**:

- **src** **scripts/jquery-3.3.1.js**

<img src="media/image14.png" style="width:6.42973in;height:0.91099in" />

## Link HTML and Bootstrap Script Files

For **bootstrap**, go in the **\<head\>** part of the HTML file, and add
a **\<script\>\</script\>** tag with **attributes**:

- **src** **scripts/bootstrap.js**

<img src="media/image15.png" style="width:6.69907in;height:1.25191in" />

## jQuery Before Bootstrap

**Quick Note**: Make sure that jQuery link comes **before** the
**bootstrap** link, otherwise scripts **may not work properly**.

## Change Blog Title

Let’s give our page a more **appropriate title** that will be displayed
in the browser’s tab:

<img src="media/image16.png" style="width:6.84501in;height:1.56457in" />

<img src="media/image17.png" style="width:3.80208in;height:1.73414in"
alt="C:\Users\Valio\AppData\Local\Microsoft\Windows\INetCache\Content.Word\9.png" />

# Creating the Navbar

<img src="media/image18.png" style="width:7.31172in;height:0.78267in" />

## Create a Document Structure

Now we are going to start modifying the contents of the body element:

<img src="media/image19.png" style="width:6.42507in;height:2.8061in" />

The **page content is usually located** in the **body** tag. However,
just putting all the content in there is **not very appropriate**. So,
we will **wrap the content** in **semantic tags** which help us
**understand the role** of each part of the document.

We will start from the **\<header\>**, **\<main\>** and **\<footer\>**
elements. As you can probably guess, the **header** will hold the
**header** (or the **navbar**), the **main** will hold the **page
content** and the **footer** will contain… you guessed it, the
**footer**:

<img src="media/image20.png" style="width:1.5906in;height:2.10418in" />

## Create the Navbar

As our navbar will serve the role of a header, we will put it inside the
header tag. First, create a **\<div\>…\</div\>** tag with attribute
**class="navbar navbar-default navbar-fixed-top text-uppercase"**:

<img src="media/image21.png" style="width:7.24653in;height:1.20972in" />

The text inside the quotes means that this **\<div\>** will be a
**"navbar"** with the **"navbar-default"** theme. The
**"navbar-fixed-top"** class is there, so our navbar will **stay fixed**
at the **top** of the page and will have everything in it in
**uppercase** (**"text-uppercase"**). As you can probably guess,
**bootstrap** uses **css classes** for its syntax.

## Create a Container for The Navbar Elements

To make the **bootstrap responsive design work**, we need to use
**containers** for our elements. Basically, when the **window size**
changes, the **container** changes its **size**. **\<div\>…\</div\>**
container for **all navbar elements**. Let’s add a **container** inside
the navbar:

<img src="media/image22.png" style="width:7.24653in;height:1.64097in" />

If you start your project now (Default key combination:
**Ctrl+Shift+F10**) you can see the **navbar** on top of your page:

<img src="media/image23.png" style="width:7.02593in;height:2.60821in" />

## Create a Navbar Header Element

Now we need to **insert some content in the navbar**. Let’s start with
the header of the blog, which will also serve the role of a home button.

To create it, make a **\<div\>** with the class **"navbar-header"**
inside the container **\<div\>**. Then, inside of the navbar-header
**\<div\>**, create a link tag **\<a\>** with the text "**SoftUni
Blog**" and a **href="index.html"** and a class **"navbar-brand"**:

<img src="media/image24.png" style="width:6.1713in;height:1.2972in" />

The **href** basically means that this **link** will **point** to the
**index** page (the one we’re currently building).

You can check that the **title** with its link appears in the **header**
now:

<img src="media/image25.png" style="width:6.63007in;height:2.60256in" />

If you **click** the link it should redirect you to the **same page**.

## Create Navbar Buttons

Now we need to fill the rest of the navbar. On the home page, we will
have **two buttons** on the right side of the navbar - **Register** and
**Login**.

Let’s place them in the **container** we made earlier:
<img src="media/image26.png" style="width:2in;height:0.15278in"
alt="https://puu.sh/rV55L/56e789cbc8.png" />

We should place them in a separate **\<div\>**, which will have the
classes **"navbar-collapse collapse"**. In the **\<div\>**, we will
place an unordered list **\<ul\>** with the classes **"nav navbar-nav
navbar-right"** and two **\<li\>** elements - **Register** and
**Login**:

Each of the link texts will be inside a link tag **\<a\>**. Leave the
**href=""** attribute to **href="#"** for now, which will be a
**placeholder** for an actual link. It will just do nothing for now.

Let’s turn that into code:

<img src="media/image27.png" style="width:4.96759in;height:1.12374in"
alt="https://puu.sh/rV4R0/35846adeca.png" />

Test if the buttons appear in the navbar:

<img src="media/image28.png" style="width:6.94643in;height:0.9772in"
alt="C:\Users\Pesho\Documents\ShareX\Screenshots\2016-10\chrome_2016-10-25_16-56-17.png" />

## Create a Responsive Dropdown Menu

The responsive dropdown is why we included both **jQuery.js** and
**bootstrap.js** files, that is to make the navbar buttons collapse if
the window become too small.

For this we will add a **\<button\>** to the navbar-header **\<div\>**
we made earlier. Just after the home button, add a new **\<button\>**
attributes:

- **type="button"**

- **class="navbar-toggle"**

- **data-toggle="collapse"**

- **data-target=".navbar-collapse"**

<img src="media/image29.png" style="width:7.57159in;height:1.05211in" />

Now add three **\<span\>** with class **"icon-bar"**. The code should
look like this:

<img src="media/image30.png" style="width:7.2815in;height:1.48212in" />

And … we are ready with the navbar! **Test everything** to make sure it
looks and works as intended. Shrink the window to see if it "responds",
expand the menu, etc.:

<img src="media/image31.png" style="width:7.26862in;height:1.11806in" />

<img src="media/image32.png" style="width:3.90026in;height:1.95258in" />

# Creating the Main Content

<img src="media/image33.png" style="width:7.15831in;height:4.00285in" />

## Wrap the Content in The Main

We are now going to work in the **\<main\>** part:

<img src="media/image34.png" style="width:1.10714in;height:1.52289in" />

Again, we will need a **container** for the content there so we’ll
create one. We can use a **\<div\>** with class "**container
body-content**". Inside of it we will create a **\<div\>** with the
class "**row**", so our content is properly "**responsive**" (e.g.
bootstrap reasons):

<img src="media/image35.png" style="width:3.71724in;height:1.22283in" />

## Create a Wrapper for a Column

Working with columns inside a row will make sure that everything is
**displayed properly** when **resizing the window** (you don’t have to,
but you can quickly glance through
[this](http://www.helloerik.com/the-subtle-magic-behind-why-the-bootstrap-3-grid-works)
article). So, we will make a **\<div\>** with **class="col-md-6"**,
which basically means that we are creating a **column** that will have a
**width** of **6** (bootstrap works with a base width of **12**, as it
is easily divisible to an even number of columns like 2, 3, 4, 6 …
etc.). Our home page will show two columns with articles:

<img src="media/image36.png" style="width:3.80549in;height:1.34138in" />

Inside it will be a single article.

## Creating Structure for a Single Article

Inside the column, we have just created, we are going to create the
**template** which **every article** on the home page will use. For
this, we are going to use the semantic tag **\<article\>**, and inside
of it every article will have a **\<header\>**, **\<p\>**, author and
**\<footer\>**:

<img src="media/image37.png" style="width:2.91911in;height:2.88408in" />

## Creating Article Footer

Within the footer, we are going to have a button that links to the whole
article. Inside a **\<div\>** create a link **\<a\>** with the following
attributes:

- **class="btn btn-default btn-xs"**

- **href="#"**

Make the **\<div\>** **"pull-right"** and put text inside the button
**"Read more &raquo;"**:

<img src="media/image38.png" style="width:7.24653in;height:1.06875in" />

## Fill Article Content and Test

Fill the **\<header\>** with a sample header inside a **\<h2\>** tag and
some sample text:

<img src="media/image39.png" style="width:3.2719in;height:0.60422in" />

Then fill the **\<p\>** tag, the author and start your project. It
should look like this:
<img src="media/image40.png" style="width:7.24653in;height:4.96597in" />

# Creating the Footer

## Create the Footer

We are now working here:

<img src="media/image41.png" style="width:3.28704in;height:1.02967in" />

This will be easy. The footer of the page needs only a single paragraph
**\<p\>** and it will be placed in the **\<footer\>** tag inside a
**\<div class="container modal-footer"\>** in it, containing the
following text **"&copy; 2016 - Software University Foundation"**:

<img src="media/image42.png" style="width:4.54167in;height:0.95833in" />

And now you are done with the main page! If you want, you can multiply
the articles (copy and paste the whole
<img src="media/image43.png" style="width:1.84839in;height:0.16392in" />),
just to see how the blog will look once it has some content in it:

<img src="media/image33.png" style="width:7.15831in;height:4.00285in" />

<img src="media/image44.png" style="width:4.09375in;height:7.47917in" />

# Creating the Logged in View

## Initial Setup

We need a **variation of the home page** in which **the header is
slightly different**. It is logical, when you are not logged in the
site, to have a button for just that, and contrary, when you are logged
in, you need to have a **button** **for creating a new post** and a
**button for logging out**. This is what we are going to do now.

First you will need a different page, so create one:

<img src="media/image45.png" style="width:7.24653in;height:4.51528in" />

Call it "**indexlogged**":

<img src="media/image46.png" style="width:2.49306in;height:1.27014in" />

And just copy the whole HTML from the index.html page and paste it in
indexlogged.html, overriding all code that WebStorm generates:
<img src="media/image47.png" style="width:7.24653in;height:4.45972in" />

<img src="media/image48.png" style="width:7.24653in;height:3.44097in" />

Now you should have **two pages that are exactly the same** **except for
the name**. This is convenient, since everything is the same, except for
**two buttons**.

## Edit indexlogged.html

Now we need to **edit the new page** "**indexlogged.html**". You should
look for the navbar buttons in the header:

<img src="media/image49.png" style="width:7.00595in;height:3.03333in" />

We need to add **one more button** that will be called
"**Welcome(User)**". It will be placed before the other two. For now,
"**User**" is just a placeholder that will be replaced by the **actual
username** in the future. The button will be exactly like the other two,
a list item **\<li\>…\</li\>** with a link inside **\<a
href="#"\>…\<a\>** with text in it "**Welcome(User)**":

<img src="media/image50.png" style="width:4.19351in;height:1.40242in" />

Now just edit the text in the other two links: edit **"Register"**
**into** **"New Post"**, and **"Login"** **into** **"Logout"**:

<img src="media/image51.png" style="width:4.07559in;height:1.31389in" />

The new page's navbar should look like this now:

<img src="media/image52.png" style="width:7.24653in;height:0.97917in" />

# Creating the View Post Page

This is a page for viewing a single post. The "read more" button should
redirect to this page.

<img src="media/image53.png" style="width:7.24653in;height:3.49375in" />

## Initial Setup

This one is easy. You can just copy and paste the index.html or
indexlogged.html and just modify the code a little bit.

First create a new HTML file:

<img src="media/image54.png" style="width:4.67063in;height:2.0469in" />

Name it "**viewpost**":

<img src="media/image55.png" style="width:2.52658in;height:1.28792in" />

Then copy and paste the entire **index.html** into the new file,
**overwriting** everything in the new file:

<img src="media/image56.png" style="width:6.97917in;height:4.75565in" />

Now in **viewpost.html** leave **only** **one** article (that is the
content of a single **\<div class="col-md-6"\>**) and modify these:

- Make the class of the **\<div\>** wrapper **"col-md-12"**. This will
  **present** the article **on the whole page**.

- **Replace the text** in the button from "**Read more**" to "**back**":

<img src="media/image57.png" style="width:4.83831in;height:2.80486in" />

Of course, in the **\<header\>** and **\<p\>** elements you should have
your own article text, as well as in the "**author**" element.

So… that was it, you now have a view single post page:

<img src="media/image53.png" style="width:7.24653in;height:3.49375in" />

# Creating the New Post Page

## Initial Setup

If you are feeling adventurous, you can rewrite the navbar that we've
already made. But for the sake of saving space and time, we are going to
just copy and paste it.

First create a new **HTML** file:

<img src="media/image54.png" style="width:4.37847in;height:1.96726in" />

Name it "**createnewpost**":

<img src="media/image58.png" style="width:2.64189in;height:1.3467in" />

Again, **copy and paste** everything, this time from
**indexlogged.html** to **createnewpost.html**:
<img src="media/image59.png" style="width:7.23333in;height:3.87778in" />

Overwrite everything inside **createnewpost.html**:

<img src="media/image60.png" style="width:7.23333in;height:3.87778in" />

## Delete All Content, Except the Navbar

In the **createnewpost.html** you can just delete the segment storing
all posts, that is everything inside the **\<main\>** tag:

<img src="media/image61.png" style="width:0.97917in;height:1.02153in" />

## Creating the New Post Content

For a **new post to be created** we need **three text boxes** and a
**pair of buttons**. This should give you an idea of what the page will
look like:

<img src="media/image62.png" style="width:7.13354in;height:2.49286in" />

**First**, head to the **\<main\>** and insert a **\<div\>** with a
class **"container body-content span=8 offset=2"**. This will be the
**container for all elements**. **Span=8** means that it will occupy
**8** columns of **12** total (remember that bootstrap works with a
**12-column system**) and **offset=2** means that it will start **after
2 columns** on the left (so **2 on the left**, **8 in the middle** and
**2 on the right**, for total of **12**).

Here is the element:

<img src="media/image63.png" style="width:4.85277in;height:0.81191in" />

Inside of it, we need a **\<form\>** tag with class
**"form-horizontal"** and a nested **\<fieldset\>** tag:

<img src="media/image64.png" style="width:5.17566in;height:1.50235in" />

Now we can insert a **\<legend\>**, which is the "New Post" title in the
upper left corner:

<img src="media/image65.png" style="width:2.61046in;height:0.51093in" />

## Text Box Template

Now we **need a template for every text box**. Every text box needs a
**container**, a in it label and the actual text box.

We will start with the container. This will be a **\<div\>** with a
**class="form-group"** that will group a form element:

<img src="media/image66.png" style="width:2.61396in;height:1.14164in" />

Place the **\<label\>** in it with **class="col-sm-4 control-label"**
and text **"Post Title"**. The **"col-sm-4"** is part of **bootstrap**.
It means that when the window is small (**sm**), the column (**col**)
will have width **4** of **12**:

<img src="media/image67.png" style="width:5.56513in;height:0.56371in" />

So far you should see this:

<img src="media/image68.png" style="width:6.38631in;height:1.19543in" />

Now create one more **\<div\>** after the **\<label\>** with a
**class="col-sm-4"** and in it create an **\<input\>** with the
following attributes:

- **type="text"**

- **class="form-control"**

- **id="postTitle"**

- **placeholder="Post Title"**

<img src="media/image69.png" style="width:6.90515in;height:1.94027in" />

And now we have a text box:

<img src="media/image70.png" style="width:5.48389in;height:1.19911in" />

The left "**Post Title**" is the **\<label\>** and the "**Post Title**"
inside the text box is the **placeholder="Post Title"**.

## Multiply Text Boxes

You can now copy the code for a single text box (the whole **\<div
class="form-group"**) and paste it one more time:

<img src="media/image71.png" style="width:5.81469in;height:2.28482in" />

This should create one more text box with the same properties:

<img src="media/image72.png" style="width:5.62678in;height:1.3874in" />

You just need to **rename everything appropriately**. The label for the
second box would be "**Author**", the placeholder "**Author**" and the
id - "**postAuthor**":

<img src="media/image73.png" style="width:5.63581in;height:2.002in" />

## Content Text Box

Now the content box is a little bit different. For the **\<div\>**,
instead of **class="col-sm-4"**, you should have **class="col-sm-6"**
and **\<input\>** you need a **\<textarea\>** with the following
attributes:

- **class="form-control"**

- **rows="5"**

- **id="postContent"**

For text in the **\<label\>** put "**Content**":

<img src="media/image74.png" style="width:5.33962in;height:1.11019in" />

This will create the content text area:

<img src="media/image75.png" style="width:5.33607in;height:2.00758in" />

## Submit Buttons

The only thing left on this page is the submit and cancel buttons.

You need one more **\<div\>** with **class="form-group"**. Inside of it
place a **\<div\>** with **class="col-sm-4 col-sm-offset-4"**. And
inside of it place the **two buttons**:

<img src="media/image76.png" style="width:3.5287in;height:1.17904in" />

The first **\<button\>** will be of **type="reset"** and **class=" btn
btn-default"**:

<img src="media/image77.png" style="width:6.22187in;height:0.29514in" />

The second **\<button\>** will be of **type="submit"** and **class=" btn
btn-primary"**:

<img src="media/image78.png" style="width:6.0629in;height:0.32304in" />

We are done! We have a create new post page:

<img src="media/image79.png" style="width:5.19738in;height:2.09465in" />

# Register Page

We are going to build the following:

<img src="media/image80.png" style="width:5.66285in;height:2.2623in" />

By now you should know everything you need to create the page above. You
already have used every element that is present in this view so if you
feel confident, you can build it yourself. If not, continue reading.

## Initial Setup

If you couldn’t have guessed it… well yeah, we are going to copy-paste
again.

**Create a new page** "register.html":

<img src="media/image81.png" style="width:4.4587in;height:2.41392in" />

<img src="media/image82.png" style="width:2.7369in;height:1.39513in" />

Copy the code from **index.html** so you will have all you need right
from the start.

Then delete everything inside the **\<main\>** tag and start working
there:

<img src="media/image83.png" style="width:4.26786in;height:1.9492in" />

## Container for Content

In the **\<main\>**, insert a **\<div\>** with a class **"container
body-content span=8 offset=2"**. This will be the container for all
textbox elements:

<img src="media/image63.png" style="width:4.42271in;height:0.81191in" />

Inside of it, we need a **\<form\>** tag with class
**"form-horizontal"** and a nested **\<fieldset\>** tag:

<img src="media/image64.png" style="width:4.40652in;height:1.50235in" />

Now we can insert a **\<legend\>**, which will be the "**Register**"
title in the upper left corner:

<img src="media/image84.png" style="width:4.66713in;height:1.70313in" />

## Text Box Template

We need a template for every text box. Every text box needs a container,
and in it - a label and the actual text box.

We will start with the container. This will be a **\<div\>** with a
**class="form-group"** that will group a form element:

<img src="media/image85.png" style="width:3.61in;height:1.19319in" />

Place the **\<label\>** in it with **class="col-sm-4 control-label"**
and text **"Email"**:

<img src="media/image86.png" style="width:4.88852in;height:0.61604in" />

Now create one more **\<div\>** after the **\<label\>** with a
**class="col-sm-4"** and in it create an **\<input\>** with the
following attributes:

- **type="text"**

- **class="form-control"**

- **id="inputEmail"**

- **placeholder="Email"**

<img src="media/image87.png" style="width:6.61546in;height:1.80491in" />

And now we have a text box:

<img src="media/image88.png" style="width:6.49025in;height:1.3242in" />

## Multiply Text Boxes

You can now **copy the code for a single text box** (the whole **\<div
class="form-group"**) and paste it **three** more **times**:

<img src="media/image89.png" style="width:4.93333in;height:1.57004in" />

This should create **three more text boxes** with the same properties:

<img src="media/image90.png" style="width:5.73462in;height:2.02222in" />

You just need to **rename everything appropriately**:

- The **label** for the **second box** would be "**Full Name**", the
  **placeholder** "**Full Name**" and the **id** - "**inputFullName**"

- The **label** for the **third box** would be "Password", the
  **placeholder** "**Password**" and the **id** - "**inputPassword**"

- The **label** for the **fourth box** would be "Confirm Password", the
  **placeholder** "**Confirm** **Password**" and the **id** -
  "**inputConfirmPassword**"

<img src="media/image91.png" style="width:5.8236in;height:2.11637in" />

## Submit Buttons

The only thing left on this page is the **register** and **cancel
buttons**.

You need one more **\<div\>** with **class="form-group"**. Inside of it
place a **\<div\>** with **class="col-sm-4 col-sm-offset-4"**. And
inside of it place the two buttons:

<img src="media/image76.png" style="width:5.6437in;height:1.17904in" />

The first **\<button\>** will be of **type="reset"** and **class=" btn
btn-default"**:

<img src="media/image77.png" style="width:6.22187in;height:0.29514in" />

The second **\<button\>** will be of **type="submit"** and **class=" btn
btn-primary"**:

<img src="media/image92.png" style="width:6.00972in;height:0.31388in" />

We are done! We have a create the register page:

<img src="media/image80.png" style="width:5.62734in;height:2.26825in" />

# Login Page

This is the **final page** that you are going to create:

<img src="media/image93.png" style="width:5.67826in;height:1.73815in"
alt="C:\Users\Kalin\AppData\Local\Microsoft\Windows\INetCache\Content.Word\chrome_2017-07-10_16-24-20.png" />

As it is practically the **same as the register page** and is even
easier, this job will be solely for you to finish.

### Hints

- Use the Register page and just delete the two textboxes that you don’t
  need

- Rename the Register button to "**Login**"

#  Link Pages

If you want, you can play a little bit with the static web site you have
just created. You can **modify every link** in it to **point to another
page** and this will make your site feel real, even if it doesn’t yet
have the functionality to actually store user info and blog posts.

You can **modify the links** in the **\<a\>** tags. For example, in the
file index.html, you can set the **href=""** of the register button to
point to the register.html page and the **href=""** of the login button
to point to the **login.html** page:

<img src="media/image94.png" style="width:4.69385in;height:1.00984in" />

This way if you **click** on the **login** or **register** buttons you
will be **sent** to the corresponding page.

You can link the other pages as well or even create links in the
register and cancel buttons, but this is **yours to experiment with**.

### Hints

- Link "**SoftUni Blog**" button to direct to index.html

- Link "**Logout**" button to direct to index.html

- Link "**Read** **More**" button to direct to viewpost.html

- Link "**New Post**" button to direct to createnewpost.html

- Link "**Back**" button to direct to index.html

# Upload Project to GitHub Pages

Now that you’re pretty much done with the design of the page, all that’s
left to do is to upload it to **GitHub Pages**, so it can be publicly
available.

First off, this exercise assumes that you have a **GitHub** account. If
you don’t, you can make one [here](https://github.com/join).

Second, this exercise assumes you know how to use **GitHub** as a
**version control system**. You can brush up on how to use GitHub by
checking out the first exercise from the [Programming
Fundamentals](https://softuni.bg/courses/programming-fundamentals)
course.

**GitHub Pages** is a service within **GitHub**, which allows you to
host your own **static** web pages (hosted in a **GitHub repo**) **for
free** by using your **username** as a **URL** (such as
***myusername*.github.io**) and a repository of the same name
(***myusername*.github.io**). An example would be
<http://microsoft.github.io>, whose source code is located at
<https://github.com/Microsoft/microsoft.github.io/>.

## Create a GitHub repository

Once you register for a GitHub account, head on over to the **top**
right of the page and press the **+** button, followed by **New
Repository**:

<img src="media/image95.png" style="width:2.27419in;height:1.73946in" />

After you open this link, you’ll be redirected to the create repository
screen:

<img src="media/image96.png" style="width:7.24653in;height:2.17857in" />*Make
sure the name of the repo is **the same** as your username with
“**.github.io**” at the end (such as **softuni.github.io**). If you*
name *it anything else, it won’t get published!*

After you name the repo, press the green “Create Repository” button.

## Clone the Repository Locally

Using **TortoiseGit** or any other compatible git software, **clone**
the repository to your computer, so you can add files into it:

<table>
<colgroup>
<col style="width: 35%" />
<col style="width: 7%" />
<col style="width: 57%" />
</colgroup>
<thead>
<tr class="header">
<th><img src="media/image97.png"
style="width:1.79916in;height:2.99088in" /></th>
<th></th>
<th><img src="media/image98.png"
style="width:3.49576in;height:2.63569in" /></th>
</tr>
</thead>
<tbody>
</tbody>
</table>

Your cloned repository should look like this:

<img src="media/image99.png" style="width:1.99448in;height:1.07673in" />

## Copy the Blog Design into the Repo

Copy-Paste the content you have created so far into the repo:

<img src="media/image100.png"
style="width:3.76371in;height:1.67284in" />

## Commit Your Changes

Right click on an empty spot in your repo and choose “**Git Commit -\>
"master"…**”:

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 4%" />
<col style="width: 44%" />
</colgroup>
<thead>
<tr class="header">
<th><img src="media/image101.png"
style="width:3.7116in;height:2.43803in" /></th>
<th></th>
<th><img src="media/image102.png"
style="width:3.23594in;height:3.54112in" /></th>
</tr>
</thead>
<tbody>
</tbody>
</table>

## Open Your GitHub Page and Check It Out

Now that you’ve committed the changes successfully, if you open the
webpage “**yourusername.github.io**”, you should see your live page:

<img src="media/image103.png" style="width:5.95732in;height:3.1525in" />

# Congratulations!

**Congratulations**, you have **completed** the exercise for **HTML5**
and **CSS**! Note that **any changes** you make **and commit** to the
page will be **publicly viewable**.
