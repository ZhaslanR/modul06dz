using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class StaticMethod
    {
        public static string Method(Person person)
        {
            string statistic = string.Format("Имя : {0}\nФамилия : {1}\nВозраст : {2}" , person.name,person.surName,person.age);
            return statistic;
        }
    }
}
