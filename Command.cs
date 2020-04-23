using System;
using System.Linq;

namespace BatchSharp
{
    partial class Command
    {
        public static String[] line;
        public static bool NEW(String CommandName)
        {
            if (line[0].ToLower() == CommandName.ToLower())
            {
                return true;
            }
            return false;
        }
        public static String[] ARGS()
        {
            return line.Skip(1).ToArray();
        }
        public static void RUN()
        {
            echo();

        }
    }
}
