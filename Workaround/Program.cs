using Business.Adapters;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Test";
            person1.LastName = "Test";
            person1.NationalIdentity = "123123";
            person1.DateOfBirthYear = 1993;

            Person person2 = new Person();
            person2.FirstName = "Test1";
            person2.LastName = "Test1";
            person2.NationalIdentity = "12311";
            person2.DateOfBirthYear = 1999;


            PttManager pttManager = new PttManager(new PersonManager(new MernisServiceAdapter()));
            pttManager.GiveMask(person1);

            PttManager pttManager1 = new PttManager(new ForeignerManager(new PersonCheckAdapter()));
            pttManager1.GiveMask(person2);

            Console.ReadLine();
        }

    }
}
