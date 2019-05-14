using UnityEngine;

namespace PSM
{
    [CreateAssetMenu(menuName = "PSM/State", fileName = "State_")]
    public class State : ScriptableObject
    {

        [SerializeField] private IAction[] _stateEnterActions;
        [SerializeField] private IAction[] _stateUpdateActions;
        [SerializeField] private IAction[] _stateExitActions;
        
        [Header("Transitions"), Space, Space]
        [Tooltip("All transitions are OR-ed")]
        [SerializeField] private Transition[] _transitions;

        public void OnStateEnter(PlugglableStateMachine psm) 
        {
            DoActions(_stateEnterActions, psm);
        }

        public void OnStateUpdate(PlugglableStateMachine psm) 
        {
            DoActions(_stateUpdateActions, psm);
            CheckTransitions(psm);
        }

        public void OnStateExit(PlugglableStateMachine psm) 
        {
            DoActions(_stateExitActions, psm);
        }

        private void DoActions(IAction[] _actions, PlugglableStateMachine psm) 
        {
            foreach (var item in _actions) 
            {
                item.Act(psm);
            }
        }

        private void CheckTransitions(PlugglableStateMachine psm) 
        {
            foreach (var item in _transitions) 
            {
                if (item.EvaluateConditions(psm))
                {
                    return;
                }
            }
        }
    }
}