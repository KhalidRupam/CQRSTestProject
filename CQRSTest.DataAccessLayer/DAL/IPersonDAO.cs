using CQRSTest.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSTest.DataAccessLayer.DAL
{
    public interface IPersonDAO
    {
        Task<List<Person>> GetPersonAsync();
        Task<List<Person>> AddPersonAsync(Person person);
    }
}
