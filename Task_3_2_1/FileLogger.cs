using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2_1
{
    class FileLogger: ILogger
    {
        public void Log(string message)
        {
            File.WriteAllText("log.txt",message);
        }
     
    }
}
