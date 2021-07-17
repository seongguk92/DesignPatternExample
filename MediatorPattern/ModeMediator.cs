using System;
using System.Collections;

namespace MediatorPattern
{
    public class ModeMediator
    {
        private ArrayList listeners = new ArrayList();

        public void AddListener(ModeListener listener)
        {
            listeners.Add(listener);
        }

        public void onModeChange(CEnum.Mode mode)
        {
            foreach (ModeListener listener in listeners)
            {
                listener.OnModeChange(mode);
            }
        }
    }
}
