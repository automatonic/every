using Dichotomy;
using Dichotomy.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceManager.Initialize(
                name: "EveryService", 
                displayName: "Every",
                description: "Schedule stuff to run every...");

            var runner = new Runner(new WindowsService());
            runner.Run();
        }
    }
}
