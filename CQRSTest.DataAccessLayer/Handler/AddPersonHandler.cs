using CQRSTest.DataAccessLayer.Commands;
using CQRSTest.DataAccessLayer.DAL;
using CQRSTest.DataAccessLayer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSTest.DataAccessLayer.Handler
{
    public class AddPersonHandler : IRequestHandler<AddPersonCommand, List<Person>>
    {
        private readonly IPersonDAO _personDAO;

        public AddPersonHandler(IPersonDAO personDAO)
        {
            _personDAO = personDAO;
        }
        public async Task<List<Person>> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            return await _personDAO.AddPersonAsync(request.Person);
        }
    }
}
