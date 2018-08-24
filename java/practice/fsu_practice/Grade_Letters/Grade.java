

public class Grade
{
   private double score;
   char letter;
     
   

public Grade()
{
   score = 0.0;
}

public void Grade(double a)
{
   score = a;
}

public double getScore()
{
   return score;
}

public void setScore(double b)
{
   score = b;
}

public char getLetterGrade()
{
  if (score >=0 && score <=60) {
  letter = 'F';
  return letter;
}
else  if (score >=61 && score <=70) {
   letter = 'D';
  return letter;}
else  if (score >=71 &&score<=80) {
 letter = 'C';
  return letter;}
else  if (score >=81 && score <=90) {
 letter = 'B';
  return letter;}
else  if (score >=91 && score <=100) {
 letter = 'A';
  return letter;}
else
{
   letter = 'X';
   return letter;
}
}


  }         








