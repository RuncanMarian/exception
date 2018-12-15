using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    public class Zoo
    {
        public List<Animal> Animals { get; set; }

        public Zoo()
        {
            Animals = new List<Animal>();
            InitZoo();
        }

        private void InitZoo()
        {
            Animals.Add(new Animal("Elephant", Gender. Male));
            Animals.Add(new Animal("Tiger", Gender.Female));
            Animals.Add(new Animal("Zebra", Gender.Male));
            Animals.Add(new Animal("Fox", Gender.Female));
        }

    }
}
