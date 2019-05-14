using UnityEngine;

namespace PSM
{
    public class PlugglableStateMachine
    {   
        public GameObject ownerGO { get; private set; }
        public State currentState { get; private set; }
        public bool isActive { get; private set; }

        public PlugglableStateMachine(GameObject owner, State defaultState) 
        {
            ownerGO = owner;
            isActive = true;
            SetState(defaultState);
        }

        public void SetState(State newState)
        {
            if (!isActive) return;
            if (newState == null) return;
            currentState?.OnStateExit(this);
            currentState = newState;
            currentState?.OnStateEnter(this);
        }

        public void Update()
        {
            if (isActive && currentState != null) 
            {
                currentState.OnStateUpdate(this);
            }
            
        }
    }
}
