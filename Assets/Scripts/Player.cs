using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class Player : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;
    private float _health = 100f;
    private float _valueChangeSpeed = 10f;

    private void Update()
    {
        _healthbar.value = Mathf.MoveTowards(_healthbar.value, _health, _valueChangeSpeed * Time.deltaTime);
    }

    public void RecieveDamage(float value)
    {
        _health -= value;
    }

    public void RecieveHealing(float value)
    {
        _health += value;
    }
}
