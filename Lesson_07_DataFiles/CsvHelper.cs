using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Lesson_07_DataFiles
{
    public static class CsvHelper
    {
        public static List<Person> ReadFile(string fileName)
        {
            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader(fileName);
            List<Person> result = new List<Person>();

            using (reader)
            {
                // Read first line from the text file
                string line = reader.ReadLine();

                // Read the other lines from the text file
                while (line != null)
                {
                    var lineArr = line.Split(";");
                    result.Add(new Person
                    {
                        FirstName = lineArr[0],
                        LastName = lineArr[1]
                    }) ;
                    line = reader.ReadLine();
                }
            }

            return result;
        }

        public static void WriteIntoFile(List<Person> sourse, string fileName)
        {
            // Create a StreamWriter instance
            StreamWriter writer = new StreamWriter(fileName);

            // Ensure the writer will be closed when no longer used
            using (writer)
            {
                // Loop through the numbers from 1 to 20 and write them
                foreach(var item in sourse)
                {
                    writer.Write(item.FirstName);
                    writer.Write(";");
                    writer.Write(item.LastName);
                    writer.WriteLine();
                }
            }

        }

        public static void WriteIntoFile_1(List<Person> sourse, string fileName)
        {
            // Create a StreamWriter instance 
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(sourse);
                }
            }

        }
    }
}
