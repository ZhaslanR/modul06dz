using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace module06dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
      
            Console.ReadLine();
        }

        private static void Task2()
        {
            Console.WriteLine("Имя : {0}\nФамилия : {1}\nВозраст : {2}",Constant.name, Constant.surName, Constant.age);
        }

        private static void Task1()
        {
            Person person = new Person("Zhaslan", "Ryspekov", 17);
            Console.WriteLine(StaticMethod.Method(person));
        }
    }
}
