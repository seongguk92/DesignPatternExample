using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            ICommand openCommand = new OpenCommand(document);//ICommand를 상속받아 캡슐화 (기능별)
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);
            //기능 추가시 ICommand 상속 받아 Command 추가


            MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
            menu.clickOpen();
            menu.clickSave();
            menu.clickClose();
        }
    }
}
