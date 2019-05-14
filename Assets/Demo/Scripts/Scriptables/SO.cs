using UnityEngine;

[CreateAssetMenu]
public class SO : ScriptableObject
{
    public string displayName;

    [SerializeField] private string _description;

    private int _someNumber;
}
