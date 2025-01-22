using CQRSTest.DataAccessLayer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSTest.DataAccessLayer.Commands
{
    public record AddPersonCommand(Person Person):IRequest<List<Person>>;
}
