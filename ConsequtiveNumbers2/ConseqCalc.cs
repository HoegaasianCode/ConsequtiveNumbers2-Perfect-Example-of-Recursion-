namespace ConsequtiveNumbers2
{
    public class ConseqCalc
    {
        private readonly int[] _numbers;
        private readonly int _n;
        private readonly int _tresholdCount;
        private int ConsequtiveCount { get; set; }
        private bool IsConsequtiveNumbers { get; set; }

        public ConseqCalc(int[] numbers, int n, int tresholdCount) //  { 1, 3, 5, 5, 3, 3 }, 3, 3);
        {
            _numbers = numbers;
            _n = n;
            _tresholdCount = tresholdCount;
            IsConsequtiveNumbers = false;
        }

        public void IsConsequtive()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                int number = _numbers[i];
                if (number != _n)
                {
                    ConsequtiveCount = 0; // reset count
                    continue; // finally... a purpose for 'continue' (skips 2nd check)
                }
                ConsequtiveCount++;
                if (ConsequtiveCount == _tresholdCount)
                {
                    IsConsequtiveNumbers = true;
                }
            }
        }

        public bool IsValid() => IsConsequtiveNumbers;
    }
}
