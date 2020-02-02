using FIDS.ATR.SCRIPT.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FIDS.ATR.SCRIPT.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> files = new List<string>{
                @"C:\Users\NameOfUser\Source\Workspaces\Path\Main\Web.IntegrationExample\Web.config"
            };
            //bool endOfInput = false;
            //do
            //{
            //    var file = System.Console.ReadLine();

            //    if (file != "0")
            //    {
            //        files.Add(file);
            //    }
            //    else
            //    {
            //        endOfInput = true;
            //    }
            //} while (!endOfInput);


            IvanCustomCore.IvansRunCustom(files.ToArray()).Wait();
        }
    }
}
