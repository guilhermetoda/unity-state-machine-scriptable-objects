using PSM;
using UnityEngine;

[CreateAssetMenu(menuName ="PSM/Actions/Print", fileName = "Print_")]
public class Action_Print : IAction
{
    [SerializeField] private string _textToPrint;
    public override void Act(PlugglableStateMachine psm)
    {
        Debug.Log($"{psm.currentState.name} - {_textToPrint}");
    }
}