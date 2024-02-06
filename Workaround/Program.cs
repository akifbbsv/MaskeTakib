

using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {


    static void Main(string[] args)
    {
            Person person1 = new Person();
            person1.FirstName = "Akif";
            person1.LastName = "Abbasov";
            person1.DateOfBirthYear = 1997;
            person1.NationalIdentity = 123;


            Person person2 = new Person();
            person2.FirstName = "Murat";
    

        PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
    }

}
    
}