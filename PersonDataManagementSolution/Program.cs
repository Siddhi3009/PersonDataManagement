using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonInCity);
            CheckoingForTeenagerPerson(listPersonInCity);
            GetAverageAge(listPersonInCity);
            CheckForSpecificName(listPersonInCity);
            GetMoreThanSixty(listPersonInCity);
            RemoveSpecificName(listPersonInCity);
            CheckForSpecificName(listPersonInCity);
            Console.ReadKey();
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
        }
        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => e.Age < 60).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + "\t Age: " + person.Age);
            }
        }
        private static void CheckoingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("yes we have some teenagers in the list");
            }
            else
            {
                Console.WriteLine("No we donot have teenagers in the list");
            }
        }
        private static void GetAverageAge(List<Person> listPersonInCity)
        {
            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("Average Age: " + avgAge);
        }
        private static void CheckForSpecificName(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter name to be checked");
            string name = Console.ReadLine();
            if (listPersonInCity.Any(e => e.Name == name))
            {
                Console.WriteLine(name + " is present");
            }
            else
            {
                Console.WriteLine(name + " is not present");
            }
        }
        private static void GetMoreThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => e.Age > 60))
            {
                Console.WriteLine("Name: " + person.Name + "\t Age: " + person.Age);
            }
        }
        private static void RemoveSpecificName(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter name to be removed");
            string name = Console.ReadLine();
            Person toBeRemoved = listPersonInCity.Find(e => e.Name == name);
            listPersonInCity.Remove(toBeRemoved);
            Console.WriteLine(name + " is removed");
        }
    }
}
