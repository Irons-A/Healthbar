using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Healthbar _healthbar;
    private float _health = 100f;

    public void RecieveDamage(float value)
    {
        _health -= value;
        _healthbar.PrepareRoutine(_health);
    }

    public void RecieveHealing(float value)
    {
        _health += value;
        _healthbar.PrepareRoutine(_health);
    }
}
