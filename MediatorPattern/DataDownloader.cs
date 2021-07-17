using System;

namespace MediatorPattern
{
    public class GalleryView : ModeListener
    {
        public void OnModeChange(CEnum.Mode mode)
        {
            string showMent = mode.Equals(CEnum.Mode.LIST) ? "리스트" : "갤러리";
            Console.WriteLine($"{showMent}뷰용 데이터 다운로드");
        }
    }
}
