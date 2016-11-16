using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AlgTask3Final
{
    public class Justification
    {

        private  int _length = 20;
        private int[] marks;
        private Dictionary<String, int> _badness;
        private Dictionary<int, int> _justify;

        public String TextJustify(String input,int length)
        {
            _length = length;
            _badness = new Dictionary<String, int>();
            _justify = new Dictionary<int, int>();

            var text = input.Split(' ');
            marks = new int[text.Length];

            DP(text, 0);

            var sb = new StringBuilder();
            var k = 0;
            var i = marks[k];
            while (i < text.Length)
            {
                for (int j = k; j < i; j++)
                {
                    sb.Append(text[j] + " ");
                }
                sb.Remove(sb.Length - 1,1).Append("\n");
                k = i;
                i = marks[i];
            }
            for (int j = k; j < i; j++)
            {
                sb.Append(text[j] + " ");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        private int DP(String[] text, int start)
        {
            if (start == text.Length)
            {
                return 0;
            }
            if (_justify.ContainsKey(start))
            {
                return _justify[start];
            }
            int badness = Int32.MaxValue;
            int index = -1;
            for (int i = start; i < text.Length; i++)
            {
                int b = Badness(text, start, i, _length) + DP(text, i + 1);
                if (b < 0)
                {
                    b = int.MaxValue;
                }
                if (b < badness)
                {
                    badness = b;
                    index = i;
                }
            }
            marks[start] = index + 1;
            _justify.Add(start, badness);
            return badness;
        }

       

       
        private int Badness(string[] text, int wi, int wj, int maxWidth)
        {
            if (_badness.ContainsKey(wi + "," + wj))
            {
                return _badness[wi + "," + wj];
            }
            var length = Length(text, wi, wj);
            if (length > maxWidth)
            {
                _badness.Add(wi + "," + wj, int.MaxValue);
                return int.MaxValue;
            }
            _badness.Add(wi + "," + wj, (int) Math.Pow(maxWidth - length, 3));
            return (int) Math.Pow(maxWidth - length, 3);
        }

       
        private  int Length(String[] text, int wi, int wj)
        {
            int length = wj - wi;
            for (int i = wi; i <= wj; i++)
            {
                length += text[i].Length;
            }
            return length;
        }
    }
}


