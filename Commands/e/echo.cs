﻿using System;

namespace BatchSharp
{
    partial class Command
    {
        public static void echo()
        {
            if (Command.NEW("echo")) {
                Console.WriteLine(String.Join(" ",ARGS()));
            }
        }
    }
}
