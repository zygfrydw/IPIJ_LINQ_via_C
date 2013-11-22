using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_FEATURES
{
    static class LinqExample
    {
        public static void Run()
        {
            var people = DataFactory.GetSamplePeople();
            var companies = DataFactory.GetSampleCompanies();

            var companiesWithPeople = from company in companies
                       join person in
                           (from p in people
                            where p.Age > 60
                            select p)
                       on company.ID equals person.CompanyId into gruped
                       select new { company.Name, employee = gruped };

            foreach (var company in companiesWithPeople)
            {
                Console.WriteLine(company.Name);
                foreach (var person in company.employee)
                    Console.WriteLine("\t" + person.FirstName + " " + person.SurName);
            }
        }
    }
}
