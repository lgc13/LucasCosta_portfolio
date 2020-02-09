package com.example.lucas.weightconverter2;

import android.support.v7.app.ActionBar;
import android.support.v7.app.ActionBarActivity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import java.text.DecimalFormat;

public class MainActivity extends AppCompatActivity {
    double conversionRate = 2.2;
    double weightEntered = 0.0;
    double convertedWeight = 0.0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        getSupportActionBar().setDisplayShowHomeEnabled(true);
        getSupportActionBar().setLogo(R.mipmap.ic_launcher);
        getSupportActionBar().setDisplayUseLogoEnabled(true);





        final EditText weight = (EditText) findViewById(R.id.txtWeight);
        final RadioButton lbToKilo = (RadioButton) findViewById(R.id.radLbToKilo);
        final RadioButton kiloToLb = (RadioButton) findViewById(R.id.radKiloToLb);
        final TextView result = (TextView) findViewById(R.id.txtResult);
        final Button convert = (Button) findViewById(R.id.btnConvert);

        convert.setOnClickListener(new View.OnClickListener() {
            @Override


            public void onClick(View view)  {
                weightEntered = Double.parseDouble(weight.getText().toString());
                DecimalFormat df = new DecimalFormat("#.#");
                if(lbToKilo.isChecked())
                {
                    if(weightEntered <= 500 && weightEntered > 0)
                    {
                        convertedWeight = weightEntered / conversionRate;
                        result.setText(df.format(convertedWeight) + " kilograms");
                    }
                    else
                    {
                        Toast.makeText(MainActivity.this, "Pounds must be <= 500 and > 0", Toast.LENGTH_LONG).show();
                    }
                }

                if(kiloToLb.isChecked()) {
                    if (weightEntered <= 225 && weightEntered > 0) {
                        convertedWeight = weightEntered * conversionRate;
                        result.setText(df.format(convertedWeight) + " pounds");
                    } else {
                        Toast.makeText(MainActivity.this, "Kilos must be <= 225 and > 0", Toast.LENGTH_LONG).show();
                    }
                }
            }
        });

    }
}
