using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooClassLibrary
{
    public class BottledDrink : IDisposable
    {
        private string contents;
        public BottledDrink(string contents) 
        {
            this.contents = contents;
            Console.WriteLine($"Openned my bottle of {contents}");
        }
        public void Drink()
        {
            Console.WriteLine($"Drinking my {contents}");
        }
        public void Dispose()
        {
            Console.WriteLine($"Finished my bottle of {contents} and I have recycled it!");
        }
    }
}
