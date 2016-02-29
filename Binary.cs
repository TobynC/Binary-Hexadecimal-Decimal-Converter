using System.Collections.Generic;
using System.Text;

namespace DecimalConverter
{
    public class Binary
    {
        private readonly Stack<long> _stack;
        private long _value;
        private string _totalValue;

        public Binary(long value)
        {
            _value = value;
            _totalValue = null;
            _stack = new Stack<long>();
        }

        public void ConvertToBinary()
        {
            while (true)
            {
                if (_value == 1 || _value == 0)
                {
                    _stack.Push(_value);
                }
                else
                {
                    _stack.Push(_value%2);
                    _value = _value/2;
                    continue;
                }
                break;
            }

            GenerateConversion();
        }

        private void GenerateConversion()
        {
            var sb = new StringBuilder();
            var count = _stack.Count;

            for (var i = 0; i < count; i++)
            {
                sb.Append(_stack.Pop());
            }

            _totalValue = sb.ToString();
        }

        public string Print()
        {
            return _totalValue;
        }
    }
}
