using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class ValueArray
    {
        public List<double> Values { get; } = new List<double>();

        public void AddValue(string line)
        {
            if (!double.TryParse(line, out double result))
            {
                return;
            }

            Values.Add(result);
        }

        public void ShowResult()
        {
            Console.WriteLine(PreparedStrings.ResultBegin);
            Values.ForEach(v => Console.Write($"{v} "));
            Console.WriteLine();

            Console.WriteLine(PreparedStrings.MinValueOutput, Values.Min(), Values.IndexOf(Values.Min()));
            Console.WriteLine(PreparedStrings.MinValueOutput, Values.Max(), Values.IndexOf(Values.Max()));
        }
    }
}
