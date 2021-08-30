using System;
using System.Threading;
using System.Threading.Tasks;

namespace Velog_SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
            {
                Process();
            });
            
            Resource.Instance.AddUnit("Marine");
            Resource.Instance.AddUnit("Firebat");
            Resource.Instance.AddUnit("Ghost");
            Resource.Instance.AddUnit("Medic");
        }
        
        private static void Process()
        {
            while (true)
            {
                Resource.Instance.Work();
                Thread.Sleep(1000);
            }
        }
    }
}
