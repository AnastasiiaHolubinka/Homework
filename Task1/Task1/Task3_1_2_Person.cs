using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Person
    {
        public string Name;
        public int Age;
        public int PhoneNumber;
        public int ID;
        public Person(string Name, int Age, int PhoneNumber, int ID)
        {
            this.Name = Name;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.ID = ID;
        }
    }
    class Persons
    {
        List<Person> Per = null;
        public Persons()
        {
            Per = new List<Person> { new Person("Sasha", 19, 0971608303, 0105),
                                   new Person("Natalya", 20, 0662574219, 0089),
                                   new Person("Roman", 25, 0735836459, 0111),
                                   new Person("Vasya", 62, 0685793156, 0015),
                                   new Person("Olena", 47, 0975933141, 0018)};
        }
        public void addTwo()
        {
            var temp = new List<Person> { new Person("Orest", 16, 0693464225, 0164),
                                          new Person("Vitalik", 23, 0936244567, 0015)};
            Per.AddRange(temp);
        }

        public string PrintOutNameAge()
        {
            string st = "";
            foreach (Person OnePerson in Per)
            {
                st += "Name: " + OnePerson.Name + " Age: " + OnePerson.Age + ";\n";
            }
            st = st.Remove(st.Length - 1, 1);
            return st;
        }
        public string PrintOutPhoneNumber()
        {
            string st = "";
            foreach (Person OnePerson in Per)
            {
                st += "Phone Number: +380" + OnePerson.PhoneNumber + ";\n";
            }
            st = st.Remove(st.Length - 1, 1);
            return st;
        }
    }
}

