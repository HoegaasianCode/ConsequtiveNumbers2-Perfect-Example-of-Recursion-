using System;

namespace ConsequtiveNumbers2
{
    class Program
    {
        // https://edabit.com/challenge/ywHrStmf93Thm3x3B
        // SOLVED
        
        static void Main(string[] args)
        {
            ConseqCalc calc = new(new int[] { 1, 2, 3, 4, 5 }, 1, 1);
            calc.IsConsequtive();
            Console.Write(calc.IsValid());
        }
    }
}
