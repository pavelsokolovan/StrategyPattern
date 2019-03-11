using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SearchCommand: Command, ICommand
    {
        public SearchCommand(ILog log) : base(log)
        {
        }

        public override void Process(string param)
        {
            Log.Debug("SearchCommand.Process() start.");

            if (!Directory.Exists(param))
            {
                Log.Debug(String.Format("Directory '{0}' doesn't exist.", param));
                Console.WriteLine("Directory '{0}' doesn't exist.", param);
                Log.Debug("SearchCommand.Process() end.");
                return;
            }

            Directory.GetFiles(null, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(n => Console.WriteLine(n));

            Log.Debug("SearchCommand.Process() end.");
        }
    }
}
