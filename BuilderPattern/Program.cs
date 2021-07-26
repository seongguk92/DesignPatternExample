using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanBuilder humanBuilder = new HumanBuilder();
            Human result = humanBuilder.SetMoney(1000)
                            .SetName("KimSeongGuk")
                            .SetWeight(73.3f)
                            .SetHeight(179.7f)
                            .SetIsCar(true)
                            .SetIsJob(true).Build();

            result.WriteHumanInfo();
        }
    }
}
