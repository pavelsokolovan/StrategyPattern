using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface ILog
    {
        void Debug(string text);
        void Error(string text);
    }
}
