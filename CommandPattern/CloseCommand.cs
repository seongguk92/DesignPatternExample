using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class CloseCommand : ICommand
    {
        private Document document;

        public CloseCommand(Document doc)
        {
            this.document = doc;
        }

        public void Execute()
        {
            document.Close();
        }
    }
}
