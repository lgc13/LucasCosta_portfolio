<img src="img/android_studio_logo.jpg" width = 30% length = 30% align = left><h1>Android Studio projects</h1>

This directory holds some projects and practice examples that I worked on through native Android Studio.

I created some android phone applications that utilized features such as radio buttons, images, and avatar emoticons.

# Projects:

Click on the title link to see more information about each specific project.

[1- My Business Card App](https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/MyBusinessCard_app_project)

Using Android Studio, I created a small 2 pages app which uses avatar emoticons, picture imports and radio buttons. Upon clicking the "Details" radio button, this link will display the second page which displays some plain text with some of my contact info.

![Screenshot](MyBusinessCard_app_project/img/my_app.png)
![Screenshot](MyBusinessCard_app_project/img/my_app2.png)

Explanation about code...

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

[2- Bruschetta Recipe App](https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/Recipe_app_project)

This was the first phone app that I made with Android Studio. I learned how to create a basic user interface using pictures, buttons, and different font texts.

![Screenshot](Recipe_app_project/img/user1.png)
![Screenshot](Recipe_app_project/img/user2.png)

# Practice:

Although these were my biggest projects with Android Studio, I have worked on quite a lot more smaller projects, practice problems and trivia questions. You can see these by clicking this link:

[Practice Directory](https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/practice)
