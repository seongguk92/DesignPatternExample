using System;

namespace MediatorPattern
{
    public class ListView : ModeListener
    {
        public void OnModeChange(CEnum.Mode mode)
        {
            string showMent = mode.Equals(CEnum.Mode.LIST) ? "Show" : "None";
            Console.WriteLine($"리스트 뷰 {showMent}");
        }
    }
}
