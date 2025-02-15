namespace DataStructure.Recursion
{
    public class Fibonacci
    {
        public Fibonacci() 
        {

        }

        public int FindFibonacciOfNumber(int n)
        {
            if (n <= 1)
                return n;

            return FindFibonacciOfNumber(n - 1) + FindFibonacciOfNumber(n - 2);
        }
    }
}
