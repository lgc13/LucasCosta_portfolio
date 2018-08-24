/* Assignment 8 for COP 3014. Created by Lucas Costa */
/*   "Cheesecake assignment"                         */

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>

using namespace std;

/* Prototypes */
string OpenAndCheckFile(ifstream &file); //passing in a copy (with &)
int CountLines(ifstream &file, string FileName);
int ReadInArray(ifstream &file, struct Roster * RosterArray, int LineRecords);
int HammingSort(struct Roster * RosterArray, int LineRecords);
void InfoSummary(struct Roster * RosterArray ,int LineRecords, int PieCounter, int CakeCounter);

struct Roster
  {
    string LName;
    string FName;
    char Cheesecake;
  };

int main(void)
{
  // PART 1     -Ask	the	user	for	the	name	of	the	input	file.You	must	make
  //	sure	it	is	a	valid	file	and	that	it can	be	opened.
  // If	not,	you	need	to	continually	ask	the	user	for	a	valid	file.
  ifstream file;

  string FileName = OpenAndCheckFile(file);  //run function, and set it = to FileName

  cout << FileName << endl;

  // Part 2. Open	the	file	and	read	the	contents	only	counting	the	number
  // of	records	in	the	file.
  int LineRecords = CountLines(file, FileName); //sets nr of lines to LineRecords

  //Part 3. Close file...Done in Step 2

  cout << LineRecords << endl;

  // Part 4. Dynamically	allocate an	array	to	store	the	data.	make	sure	that
  //	       you	only	allocate	enough storage	to	hold	exactly	the	number
  //         	of	records	needed.

  struct Roster * RosterArray = new struct Roster[LineRecords]; //a struct router
                                        //pointer named “records” is assigned a
                                        //new array of Rosters the size
                                        //of LineRecords

  // Part 5 Open	the	file	and	read	the	file	into	the	array.
  file.open(FileName);
  int PieCounter = ReadInArray(file, RosterArray, LineRecords);
  file.close();

  // Part 6: Sort	the	Array	on	Last	Name	in	ascending	order.
  file.open(FileName);
  int CakeCounter = HammingSort(RosterArray, LineRecords);
  file.close();

  //Part 7. Print	out	the	information	(to	standard	output)

  // Part 8: Print	out	at	the	end	of	the	summary	of	information	(i.e.	how many
  // people	said	that Cheesecake	is	a	Cake	and	how	many said	it	was	a	Pie).

  //Part 9. Also	print	out	the	number	of	participants.		Be	sure	that	the
  // number	of	people	who	said	Cheesecake	is	a	Cake	+	Cheesecake	is	Pie
  //	is	equal	to	the	total	number	participants.
  InfoSummary(RosterArray, LineRecords, PieCounter, CakeCounter);

return 0;
}

/* Function: OpenAndCheckFile                                              */
/*  Ask	the	user	for	the	name	of	the	input	file. Make                 */
/*	sure	it	is	a	valid	file	and	that	it can	be	opened.            */
/* If	not,	you	need	to	continually	ask	the	user	for	a	valid	file.     */
string OpenAndCheckFile(ifstream &file)  //
{
  string filename;
  cout << "Enter a valide filename please: ";
  cin >> filename;

  file.open(filename); //opens the file
  while(!file.is_open())  //continually check "while filename is not open, ask for another"
  {
    cout << "Invalid filename. Please put in another: ";
    cin >> filename;
    file.open(filename);
  }
  file.close(); //we now have a valid filename, so close it since we are aware it works

  return filename;
}

/* Function: CountLines                                                */
/*  Open	the	file	and	read	the	contents	only	counting	the	number */
/*  of	records	in	the	file.                                          */
/*	Once that is done, it closes the file                              */
/*                                                                     */
int CountLines(ifstream &file, string FileName)
{
  file.open(FileName);  //open the file

  int count = 0;
  string line;
  while(getline(file, line))  //while the file is open, go line by line until
                              //you reach the end of the file, getting lines
  {
    count++;
  }
  file.close();  //close the file

  return count;
}

/* Function: ReadInArray                                              */
/*  The file is already opened, so you read each part of the file      */
/*	directly into the array (first, last name and cheesecake type)            */
/*  Also, return a PieCounter which keeps track of how many people said P     */
int ReadInArray(ifstream &file, struct Roster * RosterArray, int LineRecords)
{
  string lname, fname;
  char cheese;
  int PieCounter = 0;

  for(int i = 0; i < LineRecords; i++)
    {
      file >> lname >> fname >> cheese; //sets fist word to lname, second to fname, third char to cheese
      RosterArray[i].LName = lname;    //read into array
      RosterArray[i].FName = fname;
      RosterArray[i].Cheesecake = cheese;

      if (RosterArray[i].Cheesecake == 'P')  //PieCounter checks how many people said P
        PieCounter++;
    }
  return PieCounter;
}

/* Function: HammingSort                                                     */
/*  This sorst all the lines of the file by the first word in each line     */
/*	once that is done, it rearranges the array                               */
/*  This function also has a CakeCounter                                    */
int HammingSort(struct Roster * RosterArray, int LineRecords) //sort all names in ascending order
{
  int CakeCounter = 0;

  for (int i = 0; i < LineRecords; i++)
  {
    if (RosterArray[i].Cheesecake == 'C')        //CakeCounter which is returned
      CakeCounter++;
  }

  for (int i = 0; i < LineRecords - 1; i++)           //HammingSort
  {
    if (RosterArray[i].LName > RosterArray[i + 1].LName)
    {
      struct Roster temp = RosterArray[i];
      RosterArray[i] = RosterArray[i + 1];
      RosterArray[i + 1] = temp;

      for (int k = i; k >= 1; k--)
      {
        if (RosterArray[k - 1].LName > RosterArray[k].LName)
        {
          struct Roster temp2 = RosterArray[k - 1];
          RosterArray[k - 1] = RosterArray[k];
          RosterArray[k] = temp2;
        }
      }
    }
  }
  return CakeCounter;
}

/* Function: InfoSummary                                                  */
/*  Prints out all the info requested                                     */
/*	Goes line by line printing l, f names and cheesecake type from array  */
/*  also prints out all the counts                                        */
void InfoSummary(struct Roster * RosterArray ,int LineRecords, int PieCounter, int CakeCounter)
{
  cout << "            The Cheesecake Report            " << endl;
  cout << "Last Name      First Name     Cake or Pie    " << endl;
  cout << "_________      __________     ___________    " << endl;

  for (int i = 0; i < LineRecords; i++)
  {
    cout << left << setw(15) << RosterArray[i].LName;
    cout << left << setw(15) << RosterArray[i].FName;
    cout << left << setw(15) << RosterArray[i].Cheesecake;
    cout << endl;
  }

  cout << "Number of records: " << LineRecords << endl;
  cout << "Number of people who believe cheesecake is pie: " << PieCounter << endl;
  cout << "Number of people who believe cheesecake is cake: " << CakeCounter << endl;
}
