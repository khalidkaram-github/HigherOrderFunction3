namespace HigherOrderFunction3
{
    internal class Program
    {
        //Example 3 Pipeline

        static Func<int, int> DoubleFunc = x => x * 2;
        static Func<int, int> SquareFunc = x => x * x;
        static Func<int, int> IncrementFunc = x => x + 1;

        static void Main()
        {

            Func<int, int> pipeline = x => IncrementFunc(SquareFunc(DoubleFunc(x)));

            var input = 3;

            var result = pipeline(input);

            Console.WriteLine($"The result of processing {input} is {result}");
        }

    }
}
