using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Test t = new Test();
            //t.Start();
            t.StartCustomThreads();
        }
    }
}
