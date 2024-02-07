using Business.Abstract;
using Business.Adapters;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        private IPersonCheckService _personCheckService;
        public ForeignerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfRealPerson(Person person)
        {
            return _personCheckService.CheckPerson(person);
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
