using CQRSTest.DataAccessLayer.DAL;
using CQRSTest.DataAccessLayer.Models;
using CQRSTest.DataAccessLayer.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSTest.DataAccessLayer.Handler
{
    public class GetPersonDetailHandler : IRequestHandler<GetPersonDetailQuery, List<Person>>
    {
        private readonly IPersonDAO _personDAO;

        public GetPersonDetailHandler(IPersonDAO personDAO)
        {
            _personDAO = personDAO;
        }
        public async Task<List<Person>> Handle(GetPersonDetailQuery request, CancellationToken cancellationToken)
        {
            return await _personDAO.GetPersonAsync();
        }
    }
}
