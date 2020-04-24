using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace BatchSharp
{
    partial class Command
    {
        public static void call()
        {
            if (Command.NEW("call"))
            {
                Process p = new Process();
                p.StartInfo.FileName = Assembly.GetEntryAssembly().Location.Remove(Assembly.GetEntryAssembly().Location.Length - 14) + "BatchSharp.exe";
                p.StartInfo.Arguments = Directory.GetCurrentDirectory() + @"\" + String.Join(" ", ARGS());
                p.Start();
                p.WaitForExit();
            }
        }
    }
}
