using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();

            originator.SetState("A");
            originator.Operate();

            Memento memento = originator.CreateMemento();

            originator.SetState("B");
            originator.Operate();

            originator.Restore(memento);
            originator.Operate();
        }
    }
}
