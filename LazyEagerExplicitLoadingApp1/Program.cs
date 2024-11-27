using LazyEagerExplicitLoadingApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyEagerExplicitLoadingApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lazy Loading by default in Entity Framework
            Console.WriteLine("---:Lazy Loading:---");
            using (var ctx = new CompanyDBModel())
            {

                var companies = ctx.Companies.Take(1).ToList<Company>();

                foreach (Company c in companies)
                {

                    Console.WriteLine("Company Name:" + c.CompanyName);

                    Console.WriteLine("Location:" + c.CompanyLocations.Count);

                }

            }
            #endregion

            Console.WriteLine("---:Eager Loading:---");
            #region Eager Loading
            using (var ctx = new CompanyDBModel())

            {

                ctx.Configuration.LazyLoadingEnabled = false;

                var companies = ctx.Companies.Take(1).ToList<Company>();

                foreach (Company c in companies)

                {

                    Console.WriteLine("Company Name:" + c.CompanyName);

                    Console.WriteLine("Location:" + c.CompanyLocations.Count);

                }

            }
            #endregion


            Console.ReadLine();
        }
    }
}
