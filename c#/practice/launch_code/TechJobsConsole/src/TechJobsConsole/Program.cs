using System;
using System.Collections.Generic;

namespace TechJobsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Dictionary vars to hold info for menu and data

            // Top-level menu options
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");

            // Column options
            Dictionary<string, string> columnChoices = new Dictionary<string, string>();
            columnChoices.Add("core competency", "Skill");
            columnChoices.Add("employer", "Employer");
            columnChoices.Add("location", "Location");
            columnChoices.Add("position type", "Position Type");
            columnChoices.Add("all", "All");

            Console.WriteLine("Welcome to LaunchCode's TechJobs App!");

            // Allow user to search/list until they manually quit with ctrl+c
            while (true)
            {

                string actionChoice = GetUserSelection("View Jobs", actionChoices);

                if (actionChoice.Equals("list"))
                {
                    string columnChoice = GetUserSelection("List", columnChoices);

                    if (columnChoice.Equals("all"))
                    {
                        PrintJobs(JobData.FindAll());
                    }
                    else
                    {
                        List<string> results = JobData.FindAll(columnChoice);

                        Console.WriteLine("\n*** All " + columnChoices[columnChoice] + " Values ***");
                        foreach (string item in results)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                else // choice is "search"
                {
                    // How does the user want to search (e.g. by skill or employer)
                    string columnChoice = GetUserSelection("Search", columnChoices);

                    // What is their search term?
                    Console.WriteLine("\nSearch term: ");
                    string searchTerm = Console.ReadLine();

                    List<Dictionary<string, string>> searchResults;

                    // Fetch results
                    if (columnChoice.Equals("all"))
                    {
                        searchResults = JobData.FindByValue(searchTerm); // Find all jobs by given input (searchTerm)

                        if (searchResults.Count > 0) {
                            PrintJobs(searchResults);
                        }
                        else if (searchResults.Count <= 0) {

                            Console.WriteLine("There are no jobs with the query you gave: " + searchTerm);
                        }
                        else {
                            Console.WriteLine("There was something wrong with searchResults");
                        }
                    }
                    else // If they search with any keyterms (searchTerm) other than "all"
                    {
                        searchResults = JobData.FindByColumnAndValue(columnChoice, searchTerm); // gets a list of all the results with searchTerm
                        PrintJobs(searchResults);
                    }
                }
            }
        }

        /*
         * Returns the key of the selected item from the choices Dictionary
         */
        private static string GetUserSelection(string choiceHeader, Dictionary<string, string> choices)
        {
            int choiceIdx;
            bool isValidChoice = false;
            string[] choiceKeys = new string[choices.Count];
            //Console.WriteLine("choices.Count is: " + choices.Count);

            int i = 0;
            foreach (KeyValuePair<string, string> choice in choices)
            {
                Console.WriteLine("choice.Key is: " + choice.Key);
                choiceKeys[i] = choice.Key;
                i++;
            }

            do
            {
                Console.WriteLine("\n" + choiceHeader + " by:");

                for (int j = 0; j < choiceKeys.Length; j++)
                {
                    Console.WriteLine(j + " - " + choices[choiceKeys[j]]);
                }

                string input = Console.ReadLine();
                choiceIdx = int.Parse(input);

                if (choiceIdx < 0 || choiceIdx >= choiceKeys.Length)
                {
                    Console.WriteLine("Invalid choices. Try again.");
                }
                else
                {
                    isValidChoice = true;
                }

            } while (!isValidChoice);

            return choiceKeys[choiceIdx];
        }

        private static void PrintJobs(List<Dictionary<string, string>> someJobs)
        {
            Console.WriteLine("This is Lucass's implementation of PrintJobs:");

            //List<Dictionary<string, string>> allJobsDict = new List<Dictionary<string, string>>();

            if (someJobs.Count > 0) // as long as theres at least one job
            {
                int count = 0;

                Console.WriteLine("\n*** All Values ***");
                foreach (Dictionary<string, string> allJobsDict in someJobs) // iterate through each Dictionary item in someJobs
                {
                    //string name_value = allJobsDict["name"];
                    //string employer_value = allJobsDict["employer"];
                    //string location_value = allJobsDict["location"];
                    //string position_type_value = allJobsDict["position type"];
                    //string core_competency_value = allJobsDict["core competency"];

                    //Console.WriteLine("*****");
                    //Console.WriteLine("position type: " + position_type_value);
                    //Console.WriteLine("name: " + name_value);
                    //Console.WriteLine("employer: " + employer_value);
                    //Console.WriteLine("location value: " + location_value);
                    //Console.WriteLine("core copetency: "+ core_competency_value);
                    //Console.WriteLine("*****\n");
                    //List<string> keyList = new List<string>(allJobsDict.Keys);


                    Console.WriteLine("*****"); // using nested for loops on the keys
                    foreach (string key in allJobsDict.Keys) // iterate on each Dictionary.Keys, printing our the KEY + VALUE (allJobsDict[key])
                    {

                        Console.WriteLine(key + ": " + allJobsDict[key]);
                    }
                    Console.WriteLine("*****\n");
                    count++;
                }
                Console.WriteLine("count: " + count); // Making sure this adds up to the right amount of dicts in the file
            }
            else if (someJobs.Count <= 0)
            {
                Console.WriteLine("There were no jobs found. Sorry :(");
            }
            else {
                Console.WriteLine("There was some issue with someJobs.");
            }

        }
    }
}
