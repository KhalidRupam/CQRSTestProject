using CQRSTest.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSTest.DataAccessLayer.DAL
{
    public class PersonDAO : IPersonDAO
    {
        public List<Person> Persons { get; set; }
        public PersonDAO()
        {
            Persons = new List<Person>
            {
                new Person { Id = 1, FirstName = "John", LastName = "Doe" },
                new Person { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Person { Id = 3, FirstName = "Michael", LastName = "Johnson" }
            };
        }

        public async Task<List<Person>> GetPersonAsync()
        {
            return Persons;
        }
        public async Task<List<Person>> AddPersonAsync(Person person)
        {
            person.Id=Persons.Max(x => x.Id)+1;
            Persons.Add(person);
            return Persons;
        }
    }
}
