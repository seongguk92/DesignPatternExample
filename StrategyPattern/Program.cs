using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.Strategy = new AscSortStrategy();
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.Strategy = new DescSortStrategy();
            context.DoSomeBusinessLogic();
        }
    }
}
