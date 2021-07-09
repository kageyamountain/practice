using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDependencyInjection
{
    public interface IBuisinessLogicB
    {
        public IBuisinessLogicC BuisinessLogicC { get; }
        public string Msg { get; }

        public void Execute();
    }
}
