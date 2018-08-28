<div align="center">
  <img src="img/lucas_banner.jpg" height='225'>

  <p>
    <a href="#monorepository-portfolio"><strong> Monorepository</strong></a> ·
    <a href="#about-lucas"><strong>About Lucas</strong></a> ·
    <a href="#projects-showcase"><strong>Projects</strong></a> ·
    <a href="#contact-info"><strong>Contact Info</strong></a>
  </p>

  <p>
    <a href="mailto:lucas.gomes.costa@gmail.com"><img src="/img/gmail_favicon.png" height="30px" width="30px"><strong> Email Me </strong></a> ·
    <a href="https://www.linkedin.com/in/lucas-gomes-costa/"><img src="/img/linkedin_favicon.png" height="30px" width="30px"><strong> LinkedIn </strong></a> ·
    <a href="https://lgc13.wordpress.com/"><img src="/img/wordpress_favicon.png" height="30px" width="30px"><strong>WordPress </strong></a>
  </p>

</div>


<hr>

### Monorepository Portfolio

Thanks for checking out my Github account! As of August 2018, I decided to revamp my entire portfolio onto a single centralized GitHub Monorepository! This allows me to:

1. Easily showcase (and remove from showcase) any of my projects, including their summaries, concepts, code snippets, code explanation, and screenshots.
2. Organize projects by subdividing their directories by the main technology/language used so that I can easily find it at a later time.

The goal is to make browsing through my project/directories fairly intuitive. Here's the layout that I created for this repo:

```sh

LucasCosta_portfolio
├── android_studio
│   └── project#
│   └── practice
├── c#
│   └── project#
│   └── practice
├── c++
│   └── project#
│   └── practice
├── java
│   └── project#
│   └── practice
├── python
│   └── project#
│   └── practice
└── web_dev
    └── project#
    └── practice

```

Each folder holds the biggest projects that I've done with that specific technology right inside its directory. There is also a 'practice' folder which has all other project/example exercises that I've done with said language.

---

### About Lucas

<div align="center">
  <h3>
    <img src="/img/brazil_favicon.png" height="30px" width="30px">
    Brazilian Born
    <img src="/img/us_favicon.png" height="35px" width="35px">
    American Raised
    <img src="/img/denmark_favicon.ico" height="30px" width="30px">
    Danish at Heart
  </h3>
</div>

I am enthusiastic, adaptive, responsible and hardworking. I strive at using my life and work experiences to plan ahead for any possible future challenges, as well as properly handling any current ongoing problems that I encounter. I enjoy investing time in learning and research, as new breakthroughs do not happen on their own.

As a Software engineer, I have used quite a lot of tools/technologies for an application's client side, server side, and infrastructure. For example:

- Infrastructure: Jenkins, IBM UrbanCode Deploy, Amazon Web Services (AWS), Weblogic, Websphere, JBoss, Apache Tomcat
- Web Frameworks: Spring MVC, Hibernate
- Development: Python, Java, C#, and C++, JSP, PHP
- Database: MySQL, Oracle
- Front end: AngularJS, jQuery, Javascript, HTML, Bootstrap, and CSS
- Others: Git, SVN, Bash, Unix, Jira

I have also worked as a computer technician, and I have a lot of experience with overall computer hardware, repairs, and upgrades.

Lastly, I am a very motivated individual who has held many leadership roles (such as a manager, assistant-manager, senior technician, and team leader) in previous jobs. I enjoy taking on responsibility and seeing progress all the way through.

---

### Projects Showcase

<!-- Project section -->
<h2><a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/java/RevatureTown_project">1- Revature Town</a></h2>

<!-- Project BIO -->
Revature Town is an entertainment based 'Single Page Application' which allows many people to play together online, at the same time. This app is very similar to other well known games: Werewolf or Mafia. In our version of the game, Hackers have infiltrated Town Revature and they are trying to fire all of the employees! By talking to people through a live chat, voting on users to 'fire', and working together with other roles such as a Trainer or HR, players can enjoy a live game - up until they get fired!

This app was made in roughly 2 weeks, by me and two other team members: David Foens and Jonathan Joseph.

This application displays some of my skills with:

- Amazon Web Services (AWS) full pipeline
- Spring MVC with Hibernate
- AngularJS views and controllers (single page app)
- REST API calls
- Live chat API import

<!-- Screenshots -->
<img src="RevatureTown_project/img/index.PNG" width= 60% length= 60%>
<img src="RevatureTown_project/img/about.PNG" width= 60% length= 80%>
<img src="RevatureTown_project/img/rules.PNG" width= 60% length= 80%>
<img src="RevatureTown_project/img/play2.PNG" width= 60% length= 80%>
<img src="RevatureTown_project/img/lobby_ready.PNG" width= 60% length= 60%>
<img src="RevatureTown_project/img/play_view2.PNG" width= 60% length= 60%>
<img src="RevatureTown_project/img/play_view5.PNG" width= 60% length= 60%>


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


```

<!-- comment -->


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

<!-- ......................E N D  O F  P R O J E C T........................ -->


---

### Contact Info

Do you like what you see? Here are some other pages where you can get some more info, and/or connect with me!

<a href="mailto:lucas.gomes.costa@gmail.com"><img src="/img/gmail_favicon.png" height="30px" width="30px"></a> Email: lucas.gomes.costa@gmail.com

<a href="https://www.linkedin.com/in/lucas-gomes-costa/"> <img src="/img/linkedin_favicon.png" height="30px" width="30px"></a> LinkedIn: <a href="https://www.linkedin.com/in/lucas-gomes-costa/">  https://www.linkedin.com/in/lucas-gomes-costa/ </a>

<a href="https://lgc13.wordpress.com/"><img src="/img/wordpress_favicon.png" height="30px" width="30px"></a> WordPress: <a href="https://lgc13.wordpress.com/">  https://lgc13.wordpress.com/ </a>

---
