using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_FEATURES
{
    delegate double SalaryCalculateMethod(double hours, double wage);

    class Salary
    {
        public SalaryCalculateMethod CalculateMethod;

        public Salary(double hours, double wage)
        {
            Hours = hours;
            Wage = wage;
        }

        double hours;
        public double Hours {
            get
            {
                return hours;
            }
            set
            {
                if (value > 0)
                {
                    hours = value;
                }
                else
                    throw new ArgumentException("Hours can't be negative");
            }
        } 

        // Simplified create property. It's not necessary to create background field
        // In old way it look
        //  private double wage;
        //  public double Wage
        //  {
        //      get { return wage; }
        //      set { wage = value; }
        //  }
        //--------------------------------------------------------------------------
        // Setter is private but it isn't necessary. 
        // In the same way we can make private get but it's rarely used 
        public double Wage { get; private set; } 

        public double CalculateSalary()
        {
            return CalculateMethod(Hours, Wage);
        }
    }


    class SpecialCalculation
    {
        public double Extra;

        public SpecialCalculation(double extra)
        {
            Extra = extra;
        }
        public double CalcWithExtra(double hours, double wage)
        {
            return hours * wage + Extra;
        }
    }


    static class DelegatesExample
    {
        static double ClassicSalary(double hours, double wage)
        {
            return hours * wage;
        }
        static double DoubledSalary(double hours, double wage)
        {
            return hours * 2 * wage;
        }

        public static void Run()
        {
            double result;
            Salary salary = new Salary(hours: 30.0, wage: 15.0); // Named parameters

            #region Static delegate

            salary.CalculateMethod = ClassicSalary;
            result = salary.CalculateSalary();
            Console.WriteLine("Classic Salary: " + result);

            salary.CalculateMethod = DoubledSalary;
            result = salary.CalculateSalary();
            Console.WriteLine("Doubled Salary: " + result);
            
            #endregion

            #region Object delegate

            SpecialCalculation extra = new SpecialCalculation(100);
            salary.CalculateMethod = extra.CalcWithExtra;
            result = salary.CalculateSalary();
            Console.WriteLine("Extra Salary: " + result);
            
            #endregion

            #region Anonymous delegate

            salary.CalculateMethod = delegate(double x, double y) { return x * y; };
            salary.CalculateMethod = (x,y) => x * y; // Lambda expression
            result = salary.CalculateSalary();
            Console.WriteLine("Anonymous Salary: " + result);

            #endregion

            #region ITSILESIA.IPIJ_FEATURES

            //List<Person> persons = DataFactory.GetSamplePersons();
            //Person honorato = persons.Find(x => x.FirstName == "Honorato");
            //Console.WriteLine("Find person: " + honorato);

            //string name = "Lyle";
            //Person somebody = persons.Find(x => x.FirstName == name);
            //Console.WriteLine("Find person: " + somebody);

            //int oldCount = persons.Count;
            //persons.RemoveAll(x => x.Age > 30);
            //int newCount = persons.Count;
            //Console.WriteLine("Old count was {0} and new count is {1}", oldCount, newCount);






            //ThreadStart thStart = () => ThreadAction.SomeAction(10, 400, "text");
            //Thread th = new Thread(thStart);
            #endregion

        } 
    }


}
