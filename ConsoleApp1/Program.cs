using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            bool work = true;
            ValueArray array = new ValueArray();

            while (work)
            {
                try
                {
                    Console.WriteLine(PreparedStrings.InputValue);
                    foreach (var value in Enum.GetValues(typeof(InputType)))
                    {
                        Console.WriteLine(PreparedStrings.EnumToString, (int)value, value);
                    }

                    var line = Console.ReadLine();
                    if (!Enum.TryParse(line, out InputType parsed))
                    {
                        Console.WriteLine(PreparedStrings.WrongInput);
                        continue;
                    }

                    switch (parsed)
                    {
                        case InputType.WriteString:
                            array.AddValue(Console.ReadLine());
                            break;
                        case InputType.ShowResult:
                            array.ShowResult();
                            break;
                        case InputType.Exit:
                            work = false;
                            break;
                        default:
                            Console.WriteLine(PreparedStrings.WrongEnum);
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(PreparedStrings.EndOfBlock);
                }
            }
        }
    }






}
