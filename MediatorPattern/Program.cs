using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ModeSwitch modeSwitch = new ModeSwitch();
            ModeMediator modeMediator = new ModeMediator();

            modeSwitch.SetModeMediator(modeMediator);
            modeMediator.AddListener(new ListView());
            modeMediator.AddListener(new GalleryView());
            modeMediator.AddListener(new DataDownloader());

            modeSwitch.ToggleMode();
            modeSwitch.ToggleMode();
        }
    }
}
