using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    abstract class State
    {
        protected Context _context;

        public Context Context
        {
            set
            {
                _context = value;
            }
        }

        public abstract void Handle1();
        public abstract void Handle2();
    }
}
