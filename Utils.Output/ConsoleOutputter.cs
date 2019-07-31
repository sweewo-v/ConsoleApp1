﻿using System;

namespace Utils.Output
{
    public class ConsoleOutputter : IOutputter
    {
        public void Write(string str)
        {
            Console.Write(str);
        }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
