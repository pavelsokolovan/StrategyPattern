using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RemoveTxtCommand: Command, ICommand
    {
        public RemoveTxtCommand(ILog log) : base(log)
        {
        }

        public override void Process(string param)
        {
            Log.Debug("RemoveTxtCommand.Process() start.");

            if (!Directory.Exists(param))
            {
                Log.Debug("Directory {0} doesn't exist.");
                Console.WriteLine("directory {0} doesn't exist", param);
                return;
            }

            File.Delete(param + "\\test.txt");

            Log.Debug("RemoveTxtCommand.Process() end.");
        }
    }
}
