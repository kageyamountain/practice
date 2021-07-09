using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDependencyInjection
{
    public class BuisinessLogicA : IBuisinessLogicA
    {
        public void Execute()
        {
            Console.WriteLine("A");
        }
    }
}
