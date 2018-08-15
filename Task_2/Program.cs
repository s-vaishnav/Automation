using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;


            Console.WriteLine("Enter the Directory where operation sholud be performed(eg:- c or d ..");
            // string C = Console.ReadLine();
            // String str;
            // String query = "% SystemDrive %";
            // str = Environment.ExpandEnvironmentVariables(query);
            // string path1 =  C + ":";
            // string path2 = "\\Users\\User\\source\repos\\Task_1_Copy\\Task_1_Copy\bin\\Debug";
            var actualPath = Environment.ExpandEnvironmentVariables(@"%SystemDrive%\Users\User\source\repos\Task_1_Copy\Task_1_Copy\bin\Debug");
            process.StartInfo.WorkingDirectory = actualPath;
            process.Start();
            process.StandardInput.WriteLine("Task_1_Copy.exe");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();



        }
    }
}
