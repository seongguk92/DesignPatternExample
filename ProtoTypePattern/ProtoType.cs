using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTypePattern
{
    public abstract class ProtoType
    {
        public abstract ProtoType Clone();
    }
}
