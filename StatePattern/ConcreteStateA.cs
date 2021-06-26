using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 2가지 동작 구현
    /// </summary>
    class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handle1 요청");
            Console.WriteLine("Context B상태로 변경");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handle2 요청");
        }
    }
}
