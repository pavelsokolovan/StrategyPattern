using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CommandProcessor
    {
        private static Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>()
        {
            {"search", new SearchCommand()},
            {"cs_search", new CsSearchCommand()},
            {"create_txt", new CreateTxtCommand()},
            {"renove_txt", new RemoveTxtCommand()},
        };

        public static void ProcessCommand(string command, string param)
        {
            commands[command].Process(param);
        }
    }
}
