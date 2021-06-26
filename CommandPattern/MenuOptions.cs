using System;

namespace CommandPattern
{
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;

        public MenuOptions(ICommand _openCommand, ICommand _saveCommand, ICommand _closeCommand)
        {
            this.openCommand = _openCommand;
            this.saveCommand = _saveCommand;
            this.closeCommand = _closeCommand;
        }

        public void clickOpen()
        {
            openCommand.Execute();
        }
        public void clickSave()
        {
            saveCommand.Execute();
        }
        public void clickClose()
        {
            closeCommand.Execute();
        }
    }
}
