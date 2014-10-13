using Dichotomy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every
{
    public class DichotomyService : IDichotomyService
    {
        public void Start()
        {
            Console.WriteLine("Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }
}
