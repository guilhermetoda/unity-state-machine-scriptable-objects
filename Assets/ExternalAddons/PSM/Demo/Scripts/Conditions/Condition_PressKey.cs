using PSM;
using UnityEngine;

[CreateAssetMenu(menuName ="PSM/Conditions/PressKey", fileName = "PressKey_")]
public class Condition_PressKey : ICondition
{
    [SerializeField] private KeyCode _keyToPress;
    public override bool Evaluate(PlugglableStateMachine psm)
    {
        return Input.GetKeyDown(_keyToPress);
    }
}
