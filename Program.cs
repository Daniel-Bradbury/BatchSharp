using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace BatchSharp
{
    partial class Program
    {
        public static String sline;
        public static String[] line;
        static void Main(string[] args)
        { 
            StreamReader file = new StreamReader(args[0]);
            while ((sline = file.ReadLine()) != null)
            {
                line = sline.Split(" ");
                Command.line = line;
                Command.RUN();
            }
        }
    }
}