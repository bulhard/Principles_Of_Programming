using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lesson_07_DataFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // CsvHelper.ReadFile("G:\temp\test.txt");

            
            List<Person> people = GenerateListOfPeople();

            //CsvHelper.WriteIntoFile(people, "G:\\temp\\test.txt");

            //CsvHelper.WriteIntoFile_1(people, "G:\\temp\\test1.txt");

            //var peopleR = CsvHelper.ReadFile("G:\\temp\\test.txt");

            // SerializeDataSet("G:\\temp\\test_xml.txt", people);

            JsonDemo(people);
        }

        private static void JsonDemo(List<Person> people)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.IgnoreNullValues = true;

            string jsonString = JsonSerializer.Serialize(people, options);

            List<Person> backList = JsonSerializer.Deserialize<List<Person>>(jsonString);

            Console.WriteLine(jsonString);
        }

        private static List<Person> GenerateListOfPeople()
        {
            List<Person> people = new List<Person>();

            for (int i = 1; i <= 10; i++)
            {
                people.Add(new Person { 
                    FirstName = $"FirstName {i}",
                    LastName = $"LastName {i}"
                });
            }

            return people;
        }

        private static void SerializeDataSet(string filename, List<Person> people)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Person>));

            TextWriter writer = new StreamWriter(filename);

            ser.Serialize(writer, people);

            writer.Close();
        }
    }
}
