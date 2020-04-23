using System;
using System.Collections.Generic;
using System.Text;

namespace BatchSharp
{
    partial class Command
    {
        public static String[] line;
        public static bool NEW(String CommandName)
        {
            if (line[0]==CommandName)
            {
                return true;
            }
            return false;
        }
        public static void RUN()
        {
            echo();
        }
    }
}
