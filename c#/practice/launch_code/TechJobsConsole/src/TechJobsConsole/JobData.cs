using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System;

namespace TechJobsConsole
{
    class JobData
    {
        static List<Dictionary<string, string>> AllJobs = new List<Dictionary<string, string>>();
        static bool IsDataLoaded = false;

        public static List<Dictionary<string, string>> FindAll()
        {
            LoadData();
            Console.WriteLine("--- AllJobs.Count: " + AllJobs.Count);
            return AllJobs;
        }

        /*
         * Returns a list of all values contained in a given column,
         * without duplicates.
         */
        public static List<string> FindAll(string column)
        {
            LoadData();

            List<string> values = new List<string>();
            Console.WriteLine("--- AllJobs.Count: " + AllJobs.Count);

            foreach (Dictionary<string, string> job in AllJobs)
            {
                string aValue = job[column]; // add the column choice (string) from AllJobs into aValue

                if (!values.Contains(aValue))
                {
                    values.Add(aValue);
                }
            }
            return values;
        }

        public static List<Dictionary<string, string>> FindByColumnAndValue(string column, string value)
        {
            // load data, if not already loaded
            LoadData();

            List<Dictionary<string, string>> jobs = new List<Dictionary<string, string>>();

            foreach (Dictionary<string, string> row in AllJobs)
            {
                string aValue = row[column];

                if (aValue.Contains(value))
                {
                    jobs.Add(row);
                }
            }

            return jobs;
        }

        public static List<Dictionary<string, string>> FindByValue(string input_val) {

            Console.WriteLine("I'm in FindByValue");
            Console.WriteLine(">>> input_val: " + input_val);

            LoadData();

            List<Dictionary<string, string>> jobs_dict = new List<Dictionary<string, string>>();

            foreach (Dictionary<string, string> row in AllJobs) { // iterate through AllJobs dictionary, line by line

                //if (row.ContainsValue(input_val)) { // this will not work as itll check if the entire Value is == to input_val
                //    jobs_dict.Add(row);
                //}
                foreach (string key in row.Keys) { // This goes through each key in the row.Keys

                    if (row[key].Contains(input_val)) {
                        Console.WriteLine(">>> The values contain the input value. Adding row to jobs_dict");
                        jobs_dict.Add(row);
                        break;
                    }
                }
            }

            return jobs_dict;
        }

        /*
         * Load and parse data from job_data.csv
         */
        private static void LoadData()
        {

            if (IsDataLoaded)
            {
                return;
            }

            List<string[]> rows = new List<string[]>(); // Create list which will hold a bunch of rows with the info from the CSV file

            using (StreamReader reader = File.OpenText("job_data.csv"))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    string[] rowArrray = CSVRowToStringArray(line);
                    if (rowArrray.Length > 0)
                    {
                        rows.Add(rowArrray);
                    }
                }
            }

            string[] headers = rows[0];
            rows.Remove(headers);

            // Parse each row array into a more friendly Dictionary
            foreach (string[] row in rows)
            {
                Dictionary<string, string> rowDict = new Dictionary<string, string>();

                //Console.WriteLine(">>> headers.Length: " + headers.Length);

                for (int i = 0; i < headers.Length; i++)
                {
                    //Console.WriteLine(" --- headers[i]: " + headers[i] + ", row[i]: " + row[i]);
                    rowDict.Add(headers[i], row[i]);
                }
                AllJobs.Add(rowDict);
            }

            IsDataLoaded = true;
        }

        /*
         * Parse a single line of a CSV file into a string array
         */
        private static string[] CSVRowToStringArray(string row, char fieldSeparator = ',', char stringSeparator = '\"')
        {
            bool isBetweenQuotes = false;
            StringBuilder valueBuilder = new StringBuilder();
            List<string> rowValues = new List<string>();

            // Loop through the row string one char at a time
            foreach (char c in row.ToCharArray())
            {
                if ((c == fieldSeparator && !isBetweenQuotes))
                {
                    rowValues.Add(valueBuilder.ToString());
                    valueBuilder.Clear();
                }
                else
                {
                    if (c == stringSeparator)
                    {
                        isBetweenQuotes = !isBetweenQuotes;
                    }
                    else
                    {
                        valueBuilder.Append(c);
                    }
                }
            }

            // Add the final value
            rowValues.Add(valueBuilder.ToString());
            valueBuilder.Clear();

            return rowValues.ToArray();
        }
    }
}
