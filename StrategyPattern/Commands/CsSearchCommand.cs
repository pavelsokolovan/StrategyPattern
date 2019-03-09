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
            try
            {
                List<string> res = Directory.GetFiles(param, "*", SearchOption.AllDirectories).ToList();
                foreach (string n in res)
                {
                    if (n.Substring(n.LastIndexOf(".") + 1) == "cs")
                    {
                        Console.WriteLine(n);
                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
