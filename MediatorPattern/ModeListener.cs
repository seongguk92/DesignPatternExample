using System;

namespace MediatorPattern
{
    public interface ModeListener
    {
        public void OnModeChange(CEnum.Mode mode);
    }
}
