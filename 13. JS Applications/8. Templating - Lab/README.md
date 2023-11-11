# **Lab: Templating**
Problems for in-class lab for the ["JavaScript Applications" course @ SoftUni](https://softuni.bg/courses/javascript-applications). 
1. ## **Contacts Book**
Create a simple page containing some cards with contacts. Each card should have a **name** and a **button "Details"**. Each time the button is pressed, you have to **toggle a div** containing more detailed information about the corresponding contact.

You will be provided with the **HTML, CSS** and a **JavaScript** file with all the contacts data. You have to create a **separate template** for the contact cards and display all of them on the main page. At the end, the page should look like this:



### **Hints**
First, let us create a **separate html file**, where we will put **our contact cards**:

- We **loop through all the contacts** and we **render the data** about each of them
- We attach a function called **showDetails()** as a click event handler to each [**Details**] button

The next step is to create the functionality for displaying all cards. Create a file - **renderContacts.js**

- Create a function that gets our **contactTemplate.html** file
- Pass the **contacts** variable to the context
- Create the **template**
- Get the **div** and fill it with the **compiled HTML**
- Create the **showDetails()** function which toggles the detailed info


