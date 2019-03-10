using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CreateTxtCommand: ICommand
    {
        public void Process(string param)
        {
            if (!Directory.Exists(param))
            {
                Console.WriteLine("directory {0} doesn't exist", param);
                return;
            }

            File.Create(param + "\\test.txt");
        }
    }
}
