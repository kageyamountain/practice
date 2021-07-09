using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDependencyInjection
{
    public class BuisinessLogicB : IBuisinessLogicB
    {
        public IBuisinessLogicC BuisinessLogicC { get; private set; }
        public string Msg { get; private set; }

        public BuisinessLogicB(IBuisinessLogicC buisinessLogicC)
        {
            BuisinessLogicC = buisinessLogicC;
        }

        public void Execute()
        {
            Console.WriteLine("B");
            
            int result = BuisinessLogicC.GetRandomInt();
            Msg = result == 0 ? "0です" : "1です";
            Console.WriteLine(Msg);
        }
    }
}
