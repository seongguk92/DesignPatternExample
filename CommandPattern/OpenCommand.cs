using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class OpenCommand : ICommand
    {
        private Document document;

        public OpenCommand(Document doc)
        {
            this.document = doc;
        }

        public void Execute()
        {
            document.Open();
        }
    }
}
