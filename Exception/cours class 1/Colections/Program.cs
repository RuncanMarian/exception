using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStringList = new List<string>();

            myStringList.Add("C#");
            myStringList.Add("Java");
            myStringList.Add("JavaScript");
            myStringList.Add("Python");

            foreach(string item in myStringList)
            {
                Console.WriteLine(item);
            }

            if (myStringList.Contains("Java"))
            {
                myStringList.Remove("Java");
            }

            foreach(string item in myStringList)
            {
                Console.WriteLine(item);
            }

            Zoo myZoo = new Zoo();
            

            foreach (var animal in myZoo.Animals)
            {
                Console.WriteLine($"This is a: {animal.Name}, and it's a {animal.Gender}");
            }

            Console.WriteLine("--------------stack");


            Stack<string> myStack = new Stack<string>();
            myStack.Push("C#");
            myStack.Push(".Net");
            myStack.Push("SQL");

            int count = myStack.Count();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myStack.Pop());
            }

            Console.WriteLine("---------------queues");

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("C#");
            myQueue.Enqueue(".Net");
            myQueue.Enqueue("SQL");

            int countQ = myQueue.Count();

            for (int i = 0; i < countQ; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.WriteLine("----------------Dictionary");

            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();

            dict.Add("Gigi", 30.32m);
            dict.Add("Ion", 23.23m);
            dict.Add("Mos Craciun",0m);

            foreach (var record in dict)
            {
                Console.WriteLine($"{record.Key}: {record.Value}");
            }

        }
    }
}
