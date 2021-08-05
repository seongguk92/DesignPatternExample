using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            _state = state;
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void Restore(Memento memento)
        {
            _state = memento.state;
        }

        public void Operate()
        {
            Console.WriteLine($"Operatin Originator as {_state} State");
        }
    }
}
