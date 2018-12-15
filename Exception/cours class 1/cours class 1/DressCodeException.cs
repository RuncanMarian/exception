using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_class_1
{
    class DressCodeException : ApplicationException
    {
        

       private readonly string message = "You are not wearing an elf costume, and you are underage";

       public DressCodeException()
        {
            Console.WriteLine(message);
        }


    }

}
