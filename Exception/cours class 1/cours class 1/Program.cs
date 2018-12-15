using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int b = 100;
            //    int a = b / 0;
            //    Console.WriteLine(a);
            //}
            //catch(DivideByZeroException exception)
            //{
            //    Console.WriteLine("ups something happend");
            //    Console.WriteLine(exception.Message);
            //}

            try
            {
                Person person = new Person(26);
                //Console.WriteLine(person.Age);

                //Person persone1 = new Person(-5);
                //Console.WriteLine(persone1.Age);

                //Person persone2 = new Person(2);
                //Console.WriteLine(persone2.Age);

                Person person3 = new Person(81);
                //Console.WriteLine(person3.Age);
            }
            catch(ArgumentException e) //uneori putem pune aici Exception in loc de ArgumentException, si cuprinde toate excpetiile
            {
                //Person persone2 = new Person(2);
                //this will show all the errors
                //Console.WriteLine(e);
                Console.WriteLine(e.Message + e.GetType());
                //throw;
                //Person persone2 = new Person(2);
            }
            catch(DressCodeException ex)
            {
                Console.WriteLine(ex.Message + ex.GetType());
            }








        }
    }
}
