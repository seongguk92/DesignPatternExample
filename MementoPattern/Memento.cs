using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Memento
    {
        private string _state;

        public string state
        {
            get
            {
                return _state;
            }
        }

        public Memento(string state)
        {
            _state = state;
        }
    }
}
