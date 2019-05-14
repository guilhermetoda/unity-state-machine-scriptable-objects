using UnityEngine;

public class SetRefTransform : MonoBehaviour
{
    [SerializeField] private RefTransform _refTransform;

    private void OnEnable()
    {
        _refTransform.value = transform;
    }

    private void OnDisable()
    {
        _refTransform.value = null;    
    }
}
