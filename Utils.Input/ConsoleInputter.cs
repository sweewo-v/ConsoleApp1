using System;

namespace Utils.Input
{
    public class ConsoleInputter : IInputter
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
