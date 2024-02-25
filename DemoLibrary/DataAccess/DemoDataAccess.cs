using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Vikash", LastName = "Gaurav" });
            people.Add(new PersonModel { Id = 2, FirstName = "Viaansh", LastName = "Ojha" });
            people.Add(new PersonModel { Id = 3, FirstName = "Naisha", LastName = "Gaurav" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new PersonModel() { LastName = lastName, FirstName = firstName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}
