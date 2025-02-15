namespace DataStructure.Recursion
{
    public class Factorial
    {
        public Factorial()
        {

        }

        public int FactorialOfNumber(int n)
        {
            if (n==0) 
                return 1;

            return n  * FactorialOfNumber(n - 1);
        }

    }
}
