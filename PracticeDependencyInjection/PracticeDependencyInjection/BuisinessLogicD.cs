using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDependencyInjection
{
    class BuisinessLogicD : IBuisinessLogicD
    {
        public IBuisinessLogicE BuisinessLogicE { get; private set; }
        public string Msg { get; private set; }

        public BuisinessLogicD(IBuisinessLogicE buisinessLogicE, string msg)
        {
            BuisinessLogicE = buisinessLogicE;
            Msg = msg;
        }

        public void Execute()
        {
            Console.WriteLine(Msg);
            BuisinessLogicE.Execute();
        }
    }
}
