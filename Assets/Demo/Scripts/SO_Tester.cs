using UnityEngine;

public class SO_Tester : MonoBehaviour
{
    [SerializeField] private SO _soObject;

    [ContextMenu("Print Scriptable Object")]
    private void PrintSO() 
    {
        print($"{_soObject.displayName} - {_soObject.name}");
    }    
}
