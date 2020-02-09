package com.example.lucas.myevent;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import java.text.NumberFormat;
import java.util.Locale;

public class MainActivity extends AppCompatActivity {

    //declare variable
    double costPerTicket = 0.0;
    int numberOfTickets = 0;
    double totalCost = 0.0;
    String groupChoice = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //begin code here..
        //show app icon in emulator
        getSupportActionBar().setDisplayShowHomeEnabled(true);
        getSupportActionBar().setLogo(R.mipmap.ic_launcher);
        getSupportActionBar().setDisplayUseLogoEnabled(true);

        //notes
        //notes 2
        //notes3
        //notes 4
        final EditText tickets = (EditText)findViewById(R.id.txtTickets);
        final Spinner group = (Spinner)findViewById(R.id.txtGroup);
        Button cost = (Button)findViewById(R.id.btnCost);
        cost.setOnClickListener(new View.OnClickListener() {
            final TextView result = ((TextView)findViewById(R.id.txtResult));
            @Override
            //notes
            //notes again
            public void onClick(View v){
                //notes
                groupChoice = group.getSelectedItem().toString();
                if(groupChoice.equals("Van Halen"))
                {
                    costPerTicket=59.99;
                }
                else if (groupChoice.equals("Led Zeppelin"))
                {
                    costPerTicket=49.99;
                }
                else
                {
                    costPerTicket=39.99;
                }
                //notes
                numberOfTickets = Integer.parseInt(tickets.getText().toString());
                totalCost = costPerTicket * numberOfTickets;
                NumberFormat nf = NumberFormat.getCurrencyInstance(Locale.US);
                result.setText("Cost for " + groupChoice + " is " + nf.format(totalCost));
            }
        });
    }
}
