using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            //Context : Transition to ConcreteStateA
            //ConcreteStateA handle1 요청
            //Context B상태로 변경
            //Context: Transition to ConcreteStateB
            //ConcreteStateB handle2 요청
            //Context A상태로 변경
            //Context : Transition to ConcreteStateA
        }
    }
}
