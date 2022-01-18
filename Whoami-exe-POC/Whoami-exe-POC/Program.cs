using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whoami_exe_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c \"whoami > C:\\\\Users\\Public\\POC.txt\"");
        }
    }
}
