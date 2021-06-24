using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class Context
    {
        private State _state;

        public State State
        {
            set
            {
                _state = value;
            }
        }

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        /// <summary>
        /// State 개체 변경
        /// </summary>
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context : Transition to {state.GetType().Name}");
            _state = state;
            _state.Context = this;
        }

        /// <summary>
        /// Context 동작의 일부를 현재 상태에 위임
        /// </summary>
        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
