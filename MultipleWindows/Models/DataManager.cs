using System.Collections.Generic;

namespace MultipleWindows.Models
{
    public class DataManager
    {
        public Person ImportantPerson { get; set; }
        public List<Person> ImportantPersons { get; set; }

        public DataManager()
        {
            ImportantPerson = new Person { FirstName = "Anders", LastName = "And" };
            ImportantPersons = new List<Person>()
            {
                new Person {FirstName = "Anders", LastName="And"},
                new Person {FirstName = "Mickey", LastName="Mouse"},
                new Person {FirstName = "Georg", LastName="Gearløs"},
                new Person {FirstName = "Fætter", LastName="Guf"},
                new Person {FirstName = "Minnie", LastName="Mouse"}
            };
        }
    }
}
