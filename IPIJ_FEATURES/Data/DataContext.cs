using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_FEATURES
{
    #region Data
    class Person
    {
     
        public Person(string firstName, string surName, DateTime birthDate)
        {
            FirstName = firstName;
            SurName = surName;
            Birthdate = birthDate;
        }

        public Person(string firstName, string surName, DateTime birthData, int company)
        {
            FirstName = firstName;
            SurName = surName;
            Birthdate = birthData;
            CompanyId = company;
        }

        public string FirstName { get; set; }
        public string SurName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get { return TimeUtils.Years(Birthdate, DateTime.Now); } }

        public int CompanyId { get; set; }
        public override string ToString()
        {
            return FirstName + " " + SurName + " Age " + Age;
        }
    }

    class Company
    {
        public Company(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }

    static class DataFactory
    {
        public static List<Person> GetSamplePeople()
        {
            List<Person> list = new List<Person>();
            using (var stream = new StreamReader("../../PersonsData.csv"))
            {
                string line = stream.ReadLine();
                while (!stream.EndOfStream)
                {
                    string[] row = stream.ReadLine().Split(';');
                    int[] date = Array.ConvertAll(row[2].Split('/'), x => int.Parse(x));
                    DateTime birthData = new DateTime(date[0], date[1], date[2]);
                    Person tmp = new Person(row[0], row[1], birthData, int.Parse(row[3]));
                    list.Add(tmp);
                }
            }
            return list;
        }

        public static List<Company> GetSampleCompanies()
        {
            List<Company> list = new List<Company>();
            using (var stream = new StreamReader("../../Companies.csv"))
            {
                string line = stream.ReadLine();
                while (!stream.EndOfStream)
                {
                    string[] row = stream.ReadLine().Split(';');
                    Company tmp = new Company(int.Parse(row[0]), row[1]);
                    list.Add(tmp);
                }
            }
            return list;
        }
    }
    static class TimeUtils
    {
        public static int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
    }
    #endregion  
}
