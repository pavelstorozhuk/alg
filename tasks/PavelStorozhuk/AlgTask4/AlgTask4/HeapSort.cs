using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgTask4
{
    class HeapSort
    {
        private int N;
        public HeapSort(int number)
        {
            N = 0;
            _array= new int[number+1];

        }
        private readonly int[] _array;

        public void Push(int number)
        {
            _array[++N] = number;
            HeapUp(N);
        }

       
        public int Pop()
        {
            int result = _array[1];
            _array[1] = _array[N];
            --N;
            
            int p = 1;
            int max;
            while (p*2 <= N)
            {
                max = p*2;
                
                if ((p*2+1<=N) && (_array[p*2+1]>_array[p*2]) )
                {
                    max= p*2 + 1;
                }
                if (_array[p] < _array[max])
                {
                    int tmp = _array[p];
                    _array[p] = _array[max];
                    _array[max] = tmp;

                }
                p *= 2;


            }
            return result;
        }
        
        
        public void HeapUp(int digit)
        {
            while (digit > 1 && _array[digit/2] < _array[digit])
            {

                int temp = _array[digit];
                _array[digit] = _array[digit/2];
                _array[digit/2] = temp;
                digit = digit/2;
            }
        }

        public void Print()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }

        
    }
}
