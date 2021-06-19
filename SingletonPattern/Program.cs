using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.ForEach(Enumerable.Range(0, 10), idx =>
            {
                Singleton singleton = Singleton.GetInstance();
                singleton.Print();
            });
        }
    }
}
