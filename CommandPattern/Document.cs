using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Open");
        }

        public void Save()
        {
            Console.WriteLine("Document Save");
        }

        public void Close()
        {
            Console.WriteLine("Document Close");
        }
    }
}
