using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsequtiveNumbers2
{
    public class ConseqCalc
    {
        private readonly int[] _numbers;
        private readonly int _n;
        private readonly int _tresholdCount;
        private List<int> ShiftedInts { get; set; }
        private int ConsequtiveCount { get; set; }
        private bool IsConsequtive { get; set; }

        public ConseqCalc(int[] numbers, int n, int tresholdCount) //  { 1, 3, 5, 5, 3, 3, 3 }, 3, 3);
        {
            _numbers = numbers;
            _n = n;
            _tresholdCount = tresholdCount;
            ShiftedInts = new();
            ConsequtiveCount = 1;
            IsConsequtive = false;
        }

        public void IsConsequtiveOrder()
        {
            for(int i = 0; i < _numbers.Length; i++)
            {
                int number = _numbers[i];
                int shiftedInt = ShiftedInts[i];
                if (number == shiftedInt && number == _n)
                {
                    ConsequtiveCount++;
                    ShiftIntsByN();
                }
                if (ConsequtiveCount == _tresholdCount)
                {
                    IsConsequtive = true;
                    break;
                }
            }
        }

        public void ShiftIntsByN()
        {
            List<int> shiftedInts = new();
            for(int i = ConsequtiveCount; i < _numbers.Length; i++)
            {
                int number = _numbers[i];
                shiftedInts.Add(number);
            }
            ShiftedInts = shiftedInts;
        }

        public bool IsValid() => IsConsequtive;
    }
}
