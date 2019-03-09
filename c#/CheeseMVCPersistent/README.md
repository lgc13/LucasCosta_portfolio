# Cheese Web App

<!-- Project BIO -->
This web application allows a user to do different actions with "cheese". A user can create a cheese type, create a cheese category which can have multiple cheese in it, and create a menu which can have multiple cheese and categories. This is a simple dynamic web application created while I taught at a organization called LaunchCode. The students and I both worked together on the creation of this dotnet app.

This application displays some of my skills with:

- Dotnet MVC web app with a Microsoft SqlServer database (through Docker)
- ViewModels being passed as parameters to the frontend
- Lambda expressions
- Utilization of DB migrator files
- Basic server-side validation
- Teaching and helping a group of beginner developers

<!-- Screenshots -->
<img src="/c%23/CheeseMVCPersistent/img/home.png" width= 60% length= 60%>
<img src="/c%23/CheeseMVCPersistent/img/addCheese.png" width= 60% length= 60%>
<img src="/c%23/CheeseMVCPersistent/img/categories.png" width= 60% length= 60%>
<img src="/c%23/CheeseMVCPersistent/img/addCategory.png" width= 60% length= 60%>
<img src="/c%23/CheeseMVCPersistent/img/menus.png" width= 60% length= 60%>
<img src="/c%23/CheeseMVCPersistent/img/addMenuItem.png" width= 60% length= 60%>

<!-- Code explanation -->
I use dbContext in order to persist any data the users puts in the front end, onto my SqlServer database. The use of lambdas comes in handy when retrieving and adding items from queries. I also make good use of models/ViewModels in order to properly create the objects that should be displayed on each view.

<!-- Code snippet -->
You can see that in this code snippet:

```c#
  if (ModelState.IsValid)
  {
      CheeseCategory newCheeseCategory =
              context.Categories.Single(c => c.ID == addCheeseViewModel.CategoryID);

      // Add the new cheese to my existing cheeses
      Cheese newCheese = new Cheese
      {
          Name = addCheeseViewModel.Name,
          Description = addCheeseViewModel.Description,
          Category = newCheeseCategory
      };

      context.Cheeses.Add(newCheese);
      context.SaveChanges();

      return Redirect("/Cheese");
  }
```

<!-- Adding a blank line -->
<br>

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c%23/" class="previous">&laquo; Back to C# projects</a>
