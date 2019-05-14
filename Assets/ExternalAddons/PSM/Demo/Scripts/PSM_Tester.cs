using PSM;
using UnityEngine;


public class PSM_Tester : MonoBehaviour
{
    [SerializeField] private State _defaultState;

    private PlugglableStateMachine _psm;
    
    private void Awake()
    {
        _psm = new PlugglableStateMachine(gameObject, _defaultState);
    }

    private void Update()
    {
        _psm.Update();
    }
}
