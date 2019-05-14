using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/Variables/Float", fileName = "Float_")]
public class RefFloat : ScriptableObject
{
    [SerializeField] private float _value;

    public event Action<float> Listeners = delegate {};

    public float value
    {
        get => _value;
        set 
        {
            if (value != _value) 
            {
                Listeners(_value);
            }
        }
    }
}
