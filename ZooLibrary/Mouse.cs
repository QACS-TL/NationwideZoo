using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLibrary
{
    public class Mouse:Animal
    {
        public override string Eat(string food)
        {
            return $"I'm a {this.GetType().Name} nibbling on {food}";
        }
    }
}
