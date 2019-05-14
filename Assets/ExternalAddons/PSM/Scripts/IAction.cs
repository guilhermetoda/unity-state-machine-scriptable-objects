using UnityEngine;

namespace PSM
{
    public abstract class IAction : ScriptableObject
    {
        public abstract void Act(PlugglableStateMachine psm);
    }
}