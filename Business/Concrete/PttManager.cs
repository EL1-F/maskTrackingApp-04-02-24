using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckIfRealPerson(person))
            {
                Console.WriteLine(person.FirstName+" "+person.LastName+" Kişisine maske verildi.");
            }else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " Kişisine maske VERİLEMEDİ.");
            }
        }
    }
}
