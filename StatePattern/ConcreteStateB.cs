using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateB handle1 요청");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB handle2 요청");
            Console.WriteLine("Context A상태로 변경");
            this._context.TransitionTo(new ConcreteStateA());
        }
    }
}
