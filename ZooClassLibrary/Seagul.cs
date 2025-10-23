using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooClassLibrary
{
    public class Seagul : Animal, IFlyingAnimal, ISwimmer
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} the seagul is flying!");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} the seagul is paddling like crazy here!!!!");
        }
    }
}
