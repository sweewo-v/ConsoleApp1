using System.Collections.Generic;
using System.Linq;
using Utils.Output;
using static System.String;

namespace ConsoleApp1
{
    class ValueArray
    {
        public List<double> Values { get; } = new List<double>();

        private readonly IOutputter _outputter;

        public ValueArray(IOutputter outputter)
        {
            _outputter = outputter;
        }

        public void AddValue(string line)
        {
            Values.Add(Parse(line));
        }

        private double Parse(string str)
        {
            return double.Parse(str);
        }

        public void ShowResult()
        {
            _outputter.WriteLine(PreparedStrings.ResultBegin);
            Values.ForEach(v => _outputter.Write($"{v} "));
            _outputter.WriteLine(Empty);

            _outputter.WriteLine(Format(PreparedStrings.MinValueOutput, Values.Min(), Values.IndexOf(Values.Min())));
            _outputter.WriteLine(Format(PreparedStrings.MaxValueOutput, Values.Max(), Values.IndexOf(Values.Max())));
        }
    }
}
