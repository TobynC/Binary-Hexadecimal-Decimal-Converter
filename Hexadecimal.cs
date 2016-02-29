using System;
using System.Linq;
using System.Text;

namespace DecimalConverter
{
    public class Hexidecimal
    {
        private readonly string _input;
        private string _hexOutput;

        public Hexidecimal(string input)
        {
            _input = input;
            _hexOutput = null;
        }

        public void Convert()
        {
            var inputArray = _input.ToCharArray();
            var sb = new StringBuilder();

            foreach (var binary in inputArray.Select(c => new Binary(ConvertValue(c))))
            {
                binary.ConvertToBinary();
                sb.Append(" ");
                for (var j = binary.Print().Length; j < 4; j++)
                {
                    sb.Append("0");
                }
                sb.Append(binary.Print());
            }

            _hexOutput = sb.ToString();
        }

        private static long ConvertValue(char c)
        {
            switch (c)
            {
                case 'A':
                case 'a':
                    return 10;
                case 'B':
                case 'b':
                    return 11;
                case 'C':
                case 'c':
                    return 12;
                case 'D':
                case 'd':
                    return 13;
                case 'E':
                case 'e':
                    return 14;
                case 'F':
                case 'f':
                    return 15;
                default:
                    try
                    {
                        return long.Parse(c.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        return -1;
                    }
            }
        }

        public string Print()
        {
            return _hexOutput;
        }
    }
}
