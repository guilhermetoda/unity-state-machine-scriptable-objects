using PSM;
using UnityEngine;

[CreateAssetMenu(menuName ="PSM/Conditions/HoldKey", fileName = "HoldKey_")]
public class Condition_HoldKey : ICondition
{
    [SerializeField] private KeyCode _keyToHold;
    public override bool Evaluate(PlugglableStateMachine psm)
    {
        return Input.GetKey(_keyToHold);
    }
}
