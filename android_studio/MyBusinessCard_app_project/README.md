# My Business Card App

<!-- My Business Card app BIO -->
Using Android Studio, I created a small 2 pages app which is displayed on a Nexus 5 API. It uses avatar emoticons, picture imports and radio buttons. Upon clicking the "Details" radio button, this link will display the second page which displays some plain text with some of my contact info.

<!-- Code explanation -->
The majority of the hard work comes from extending the android support library AppCompatActivity. With this, I'm able to call upon methods for each specific thing that I'm trying to accomplish, like the setOnClickListener for my button. You can see some of the code here:

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

* Screenshot of the application's home page:

![Home Page](img/my_app.png)

* Second page view:

![Second Page](img/my_app2.png)

<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/" class="previous">&laquo; Back to Android Studio projects</a>
