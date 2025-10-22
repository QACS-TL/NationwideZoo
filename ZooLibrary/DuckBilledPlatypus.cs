using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLibrary
{
    public class DuckBilledPlatypus: Animal
    {
        public int BeakCount { get; private set; } = 1;

        public override string Eat(string food)
        {
            return $"I'm a {this.GetType().Name} using my beak to eat {food}";
        }
    }
}
