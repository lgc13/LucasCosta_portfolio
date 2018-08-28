<!-- Technology logo picture and title -->
<img src="img/android_studio_logo.jpg" width= 30% length= 30% align="right">
<h1>Android Studio projects</h1>

<!-- Technology welcome message -->
This directory holds some projects and practice examples that I worked on with native Android Studio.

I created some android phone applications that utilizes features such as radio buttons, images, and avatar emoticons.


<h6>Click the title links if you want to see more details about a particular project.</h6>

<h2><a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/MyBusinessCard_app_project">
1- My Business Card App </a></h2>

<!-- My Business Card app BIO -->
Using Android Studio, I created a small 2 page app which is displayed on a Nexus 5 API. It uses avatar emoticons, picture imports and radio buttons. Upon clicking the "Details" radio button, this link will display the second page which contains some plain text with some of my contact info.

![First page](MyBusinessCard_app_project/img/my_app.png)
![Second page](MyBusinessCard_app_project/img/my_app2.png)

<!-- Code explanation -->
The majority of the hard work comes from extending the android support library AppCompatActivity. With this, I'm able to call upon methods for each specific task that I'm trying to accomplish, for example, the setOnClickListener for my button. You can see some of the code here:

<!-- Code snippet -->
```java
protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_my_business_card);
    getSupportActionBar().setDisplayShowHomeEnabled(true);
    getSupportActionBar().setLogo(R.mipmap.ic_launcher);
    getSupportActionBar().setDisplayUseLogoEnabled(true);
    Button button = (Button) findViewById(R.id.button);
    button.setOnClickListener(new View.OnClickListener(){
        @Override
        public void onClick(View v){
            startActivity(new Intent(MyBusinessCard.this, Details.class));
        }
    });
}
```

<h2><a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/Recipe_app_project">2- Bruschetta Recipe App</a></h2>

<!-- Bruschetta Recipe app BIO -->
This was the first phone app that I made with Android Studio. I learned how to create a basic user interface using pictures, buttons, and different font texts.

![Screenshot](Recipe_app_project/img/user1.png)
![Screenshot](Recipe_app_project/img/user2.png)

<!-- Code explanation -->
Similar as to how I completed my Business Card App, I extended AppCompatActivity in this Recipe app which allowed me to bring in many native features of Android Studio. Making apps has never been so easy!

```java
protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);
    Button button = (Button) findViewById(R.id.btnRecipe);
    button.setOnClickListener(new View.OnClickListener(){
        @Override
        public void onClick(View v){
            startActivity(new Intent(MainActivity.this, Recipe.class));
        }
    });
}
```

# Practice:

Although these were my biggest projects with Android Studio, I have worked on a lot of other smaller projects, practice problems and trivia questions. You can see these by clicking this link:

[Practice Directory](https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/practice)

<!-- Contact info -->
# Let's Connect! Don't be shy...

Do you like what you see? Here are some other pages where you can get some more info, and/or connect with me!

<a href="mailto:lucas.gomes.costa@gmail.com"><img src="/img/gmail_favicon.png" height="30px" width="30px"></a> Email: lucas.gomes.costa@gmail.com

<a href="https://www.linkedin.com/in/lucas-gomes-costa/"> <img src="/img/linkedin_favicon.png" height="30px" width="30px"></a> LinkedIn: <a href="https://www.linkedin.com/in/lucas-gomes-costa/">  https://www.linkedin.com/in/lucas-gomes-costa/ </a>

<a href="https://lgc13.wordpress.com/"><img src="/img/wordpress_favicon.png" height="30px" width="30px"></a> Wordpress: <a href="https://lgc13.wordpress.com/">  https://lgc13.wordpress.com/ </a>

<br>

<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/" class="previous">&laquo; Back to LucasCosta_portfolio</a>
