using PSM;
using UnityEngine;

[CreateAssetMenu(menuName ="PSM/Actions/PrintWarning", fileName = "Print_")]
public class Action_PrintWarning : IAction
{
    [SerializeField] private string _warningToPrint;
    public override void Act(PlugglableStateMachine psm)
    {
        Debug.Log($"{psm.currentState.name} - {_warningToPrint}");
    }
}