using System;

namespace MediatorPattern
{
    public class ModeSwitch
    {
        private CEnum.Mode mode = CEnum.Mode.LIST;
        private ModeMediator modeMediator;
        public void SetModeMediator(ModeMediator modeMediator)
        {
            this.modeMediator = modeMediator;
        }

        public void ToggleMode()
        {
            mode = mode.Equals(CEnum.Mode.LIST) ? CEnum.Mode.GALLERY : CEnum.Mode.LIST;
            modeMediator.onModeChange(mode);
        }
    }
}
