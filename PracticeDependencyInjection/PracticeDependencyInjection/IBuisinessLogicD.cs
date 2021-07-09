using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDependencyInjection
{
    interface IBuisinessLogicD
    {
        public IBuisinessLogicE BuisinessLogicE { get; }
        public string Msg { get; }

        public void Execute();
    }
}
