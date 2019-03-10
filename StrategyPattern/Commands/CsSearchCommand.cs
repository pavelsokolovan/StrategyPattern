using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CsSearchCommand: ICommand
    {
        public void Process(string param)
        {
            if (!Directory.Exists(param))
            {
                Console.WriteLine("directory {0} doesn't exist", param);
                return;
            }

            List<string> res = Directory.GetFiles(param, "*", SearchOption.AllDirectories).ToList();
            foreach (string n in res)
            {
                if (n.Substring(n.LastIndexOf(".") + 1) == "cs")
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
