using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthView : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _speed;

    private Coroutine _changeValue;
    private Slider _slider;
    private float _filled;

    public void OnHealthChanged(float newValue)
    {
        if (_changeValue != null)
            StopCoroutine(_changeValue);

        _changeValue = StartCoroutine(ChangeValue(newValue));
    }

    private IEnumerator ChangeValue(float newValue)
    {
        while (_filled != newValue)
        {
            _slider.value = Mathf.MoveTowards(_filled, newValue, _speed * Time.deltaTime);
            _filled = _slider.value;
            yield return null;
        }
    }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnHealthChanged;
    }
}