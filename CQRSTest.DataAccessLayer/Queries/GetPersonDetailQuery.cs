using CQRSTest.DataAccessLayer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSTest.DataAccessLayer.Queries
{
    public record GetPersonDetailQuery() : IRequest<List<Person>>;
}
