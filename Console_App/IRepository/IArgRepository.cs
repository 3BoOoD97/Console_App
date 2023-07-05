using Console_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.IRepository
{
    interface IArgRepository
    {
        void AdArg(string result);

        // IEnumerable<T> was chosen here because only iterating over the elements is needed here
        IEnumerable<Arg> getArgs();

    }
}
