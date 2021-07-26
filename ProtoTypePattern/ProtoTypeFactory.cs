using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTypePattern
{
    public class ProtoTypeFactory
    {
        private static List<ProtoType> protoTypes = new List<ProtoType>();
        public ProtoTypeFactory()
        {
            protoTypes.Add(new ConcreteProtoType1());
            protoTypes.Add(new ConcreteProtoType2());
        }

        public ProtoType Create<T>() where T : ProtoType
        {
            return protoTypes.Find(pt => pt is T).Clone();
        }
    }
}
