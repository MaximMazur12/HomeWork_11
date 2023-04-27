using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Ninject
{
    internal interface IDateTimeGenerator
    {
        string GetCurrentDateTime();
        string GetRandomDateTime();
    }
}
