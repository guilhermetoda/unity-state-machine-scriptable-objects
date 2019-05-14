using UnityEngine;

namespace PSM
{
    [System.Serializable]
    public class Transition
    {
        [Tooltip("All Conditions are AND-ed")]
        [SerializeField] private ICondition[] _conditions;

        [SerializeField] private State _transitionToState;

        public bool EvaluateConditions(PlugglableStateMachine psm) 
        {
            for (int i = 0; i < _conditions.Length; i++) 
            {
                if (_conditions[i].Evaluate(psm) == false) return false;
            }
            psm.SetState(_transitionToState);
            return true;
        }
    }

}