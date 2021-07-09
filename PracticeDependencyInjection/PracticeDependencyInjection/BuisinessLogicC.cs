using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDependencyInjection
{
    public class BuisinessLogicC : IBuisinessLogicC
    {
        public int GetRandomInt()
        {
            Console.WriteLine("C");

            Random random = new Random();
            return random.Next(0, 1);
        }
    }
}
