using System;

namespace MediatorPattern
{
    public class DataDownloader : ModeListener
    {
        public void OnModeChange(CEnum.Mode mode)
        {
            string showMent = mode.Equals(CEnum.Mode.GALLERY) ? "Show" : "None";
            Console.WriteLine($"갤러리 뷰 {showMent}");
        }
    }
}
