# Bruschetta Recipe App

<!-- Bruschetta Recipe app BIO -->
This was the first phone app that I made with Android Studio. I learned how to create a basic user interface using pictures, buttons, and different font texts.

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

* Screenshot of running application’s first user interface:

![First User interface Screenshot](img/user1.png)

* Screenshot of running application’s second user interface:

![Second User Interface Screenshot](img/user2.png)

<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/android_studio/" class="previous">&laquo; Back to Android Studio projects</a>
