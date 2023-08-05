using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private Slider _slider;
    private float _valueChangeSpeed = 10f;
    private Coroutine _changeSequence;

    void Start()
    {
        _slider = GetComponent<Slider>();
    }

    private IEnumerator ChangeHealth(float health)
    {
        var changeSpeed = new WaitForSeconds(0.001f);

        while (_slider.value != health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, health, _valueChangeSpeed * Time.deltaTime);
            yield return changeSpeed;
        }
    }

    public void PrepareRoutine(float health)
    {
        if (_changeSequence != null)
        {
            StopCoroutine(_changeSequence);
        }

        _changeSequence = StartCoroutine(ChangeHealth(health));
    }
}
