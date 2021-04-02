using System;

namespace ConsequtiveNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConseqCalc calc = new(new int[] { 1, 3, 5, 5, 3, 3, 1 }, 3, 2);
            calc.ShiftIntsByN();
            calc.IsConsequtiveOrder();
            Console.Write(calc.IsValid());
        }
    }
}
