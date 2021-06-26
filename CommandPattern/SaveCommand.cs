using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class SaveCommand : ICommand
    {
        private Document document;

        public SaveCommand(Document doc)
        {
            this.document = doc;
        }

        public void Execute()
        {
            document.Save();
        }
    }
}
