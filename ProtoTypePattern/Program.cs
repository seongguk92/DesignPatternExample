using System;

namespace ProtoTypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProtoTypeFactory protoTypeFactory = new ProtoTypeFactory();
            var concretePtrotoType1 = protoTypeFactory.Create<ConcreteProtoType1>();
            var concretePtrotoType2 = protoTypeFactory.Create<ConcreteProtoType2>();
        }
    }
}
