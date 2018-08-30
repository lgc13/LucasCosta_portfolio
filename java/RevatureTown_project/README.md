# Revature Town project

<!-- Project BIO -->
Revature Town is a 'Single Page Application' game which allows many people to play together online, at the same time. This app is very similar to other well-known games: Werewolf or Mafia. In our version of the game, Hackers have infiltrated Town Revature and they are trying to fire all of the employees! By talking to people through a live chat, voting on users to 'fire', and working together with other roles such as a Trainer or HR, players can enjoy a live game - up until they get fired!

This app was made in roughly 2 weeks, by me and two other team members: David Foens and Jonathan Joseph.

This application displays some of my skills with:

- Amazon Web Services (AWS) full pipeline
- Spring MVC with Hibernate
- AngularJS views and controllers (single page app)
- REST API calls
- Live chat API import

<!-- Screenshots -->
<img src="img/index.PNG" width= 80% length= 80%>
<img src="img/about.PNG" width= 80% length= 80%>
<img src="img/rules.PNG" width= 80% length= 80%>
<img src="img/play2.PNG" width= 80% length= 80%>
<img src="img/lobby_ready.PNG" width= 80% length= 80%>
<img src="img/play_view2.PNG" width= 80% length= 80%>
<img src="img/play_view5.PNG" width= 80% length= 80%>


<!-- Code explanation -->
My team and I use Hibernate configurations in order to set up all the database configurations, controllers, and classes. We also put all of this on a live EC2 through AWS (no longer live) where we were able to deploy a full pipeline using Jenkins.

<!-- Code snippet -->
You can see that in this code snippet:

```xml

<!-- DB Configuration -->
<property name="hibernate.connection.driver_class">oracle.jdbc.OracleDriver</property>
<property name="hibernate.dialect">org.hibernate.dialect.Oracle10gDialect</property>
<property name="hibernate.connection.url">jdbc:oracle:thin:@project2.cvn2sbvqpuhu.us-east-2.rds.amazonaws.com:1521:orcl</property>


<!-- Mapping CLASSES with hibernate -->
<mapping class="com.revature.bean.Roles" />
<mapping class="com.revature.bean.Status" />
<mapping class="com.revature.bean.Users" />

```


<!-- Code explanation -->
AngularJS can be used to create single page applications. For this project, I use ngRoute and locationProvider to check the path. routeProvider can call upon a specific templateUrl  and controller depending on this path - afterwards, the browser will render this 'view' with any given information that we can get by making REST calls.

<!-- Code snippet -->
You can see that in this code snippet:

```js

var myApp = angular.module('myApp', ['ngRoute']);

//this will remove the URL prefix
myApp.config(['$locationProvider', function($locationProvider) {
	  $locationProvider.hashPrefix('');
	}]);


  myApp.config(function($routeProvider) {

  	$routeProvider

    .when('/', {
      templateUrl : 'pages/home.html',
      controller  : 'HomeController'
    })

    .when('/about', {
      templateUrl : 'pages/about.html',
      controller  : 'AboutController'
    })
  }
`
```

<!-- Code explanation -->
With Hibernate, we are able to easily query through our database and get any needed information. Using a session object, we can execute a hql query to return a list of users from the database which we can then pass on to other calls within our program.

<!-- Code snippet -->
You can see that in this code snippet:

```java

@Override
public List<Users> getUsers() {
  Session session = HibernateUtil.getSession();
  Query query;
  String hql;
  //Transaction tx;

  hql = "FROM com.revature.bean.Users";
  query = session.createQuery(hql);
  @SuppressWarnings("unchecked")
  List<Users> users = query.list(); //list executes the query and returns results
  session.close();
  return users;
}

```


<!-- Adding a blank line -->
<br>

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/java/" class="previous">&laquo; Back to Java projects</a>
