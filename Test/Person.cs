using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Person
    {
        public string name;
        public string surName;
        public int age;

        public Person(string name,string surName,int age)
        {
            this.name = name;
            this.surName = surName;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurName(string surName)
        {
            this.surName = surName;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurName()
        {
            return surName;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
