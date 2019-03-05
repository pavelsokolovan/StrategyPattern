﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SearchCommand: ICommand
    {
        public void Process(string param)
        {
            Directory.GetFiles(param, "*", SearchOption.AllDirectories).ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}