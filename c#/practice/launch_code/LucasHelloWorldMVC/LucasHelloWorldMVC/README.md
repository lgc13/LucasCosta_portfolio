# How to get a dotnet application set up

1. Create the project template

Through IDE: start a new MVC Web Application Project

Through terminal:
```
dotnet new mvc
```

2. Run the application

Through IDE: Just press 'Play'

Through terminal:
```
dotnet run
```

You might have to restore all packages before running:
```
dotnet restore
```


# Code Info

### Controllers folder

This holds any controllers, which can run on the browser by the first part of its name.

Ex: "LucasControler.cs" will be localhost:5001/Lucas

HomeController is the default and will run as "index" or Home (localhost:5001/ or localhost:5001/Home)

### Views folder

This folder has subfolders that tie to the controller by first name.

Ex: Views/Home has all the HomeController.cs views
Views/Lucas has all the LucasController.cs views

Views cannot be used by different controllers, unless its in the `Shared` folder.

You can -NOT- use the Layout file by adding this at the top of your cshtml file:
```
@{
    Layout = null;

}
```

### Passing data

You can pass data from the back end to front end using `ViewBag.object_name`

If its a POST method, use `[HttpPost]` on top of the method. Take in any arguments (name="") within the parameters of this method, from a form.
