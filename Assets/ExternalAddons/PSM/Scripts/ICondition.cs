using UnityEngine;

namespace PSM
{
    public abstract class ICondition : ScriptableObject
    {
        public abstract bool Evaluate(PlugglableStateMachine psm);
    }
    
}
