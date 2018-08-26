# Pet Store Project

<!-- Project BIO -->
This application allows a user to handle a Pet Store web site. For example, the user can add "Pets" to the database. The user can also view, edit, and delete any of the current Pets in this same database on a different page. Some of these pages implement data validation on the user end(client side), while others have it on the back end(server side).

This application displays some of my skills with:

- Apache server application
- PHP development
- MySQL Database
- Client and Server Side validation (one uses Regular Expressions)
- Web Dev concepts (HTML, CSS, JS and Bootstrap)

<!-- Screenshots -->
<img src="images/pic1.png" width= 70% length= 70%>
<img src="images/pic2_all_pets.png" width= 70% length= 70%>

<!-- Code explanation -->
I use some Regular Expressions in order to create Client Side validation for the user input. This helps prevent possible bad data, and SQL injections going into the Database. I can also send messages to the browser letting them know exactly what the issue is when they are trying to input invalid data.

<!-- Code snippet -->
You can see that in this code snippet:

```php

fields: {
    name: {
        validators: {
            notEmpty: {
                message: 'Name is required'
            },
            stringLength: {
                min: 1,
                max: 30,
                message: 'Name must be less than 30 characters long'
            },
            regexp: {
              //alphanumeric, hyphens, underscores, and spaces
              //regexp: /^[a-zA-Z0-9\-_\s]+$/,
              //similar to: (though, \w supports other Unicode characters)
                regexp: /^[\w\-\s]+$/,
              message: 'Name can only contain letters, numbers, hyphens, and underscore'
            },
        },
    },

```

- Reminder to self:

In order for a PHP project to work locally on my computer, I need to put the project folder in the following directory:

/Applications/AMPPS/www

Then, start Apache Server using AMPPS

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/TECHNOLOGY/" class="previous">&laquo; Back to "TECHNOLOGY" projects</a>
