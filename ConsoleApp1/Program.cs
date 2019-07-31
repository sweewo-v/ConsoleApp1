using System;
using Utils.Input;
using Utils.Output;
using static System.String;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            bool isWorking = true;
            IOutputter outputter = new ConsoleOutputter();
            IInputter inputter = new ConsoleInputter();
            ValueArray array = new ValueArray(outputter);

            while (isWorking)
            {
                try
                {
                    outputter.WriteLine(PreparedStrings.InputValue);
                    foreach (var value in Enum.GetValues(typeof(InputType)))
                    {
                        string str = Format(PreparedStrings.EnumToString, (int)value, value);
                        outputter.WriteLine(str);
                    }

                    string line = inputter.Read();
                    if (!Enum.TryParse(line, out InputType parsed))
                    {
                        outputter.WriteLine(PreparedStrings.WrongInput);
                        continue;
                    }

                    switch (parsed)
                    {
                        case InputType.WriteString:
                            array.AddValue(inputter.Read());
                            break;
                        case InputType.ShowResult:
                            array.ShowResult();
                            break;
                        case InputType.Exit:
                            isWorking = false;
                            break;
                        default:
                            outputter.WriteLine(PreparedStrings.WrongEnum);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    outputter.WriteLine(ex.Message);
                }
                finally
                {
                    outputter.WriteLine(PreparedStrings.EndOfBlock);
                }
            }
        }
    }
}
