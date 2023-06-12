using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthView : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Health _health;

    private Slider _slider;

    private float _filled;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (_filled != _health.Ratio)
        { 
            _slider.value = Mathf.MoveTowards(_filled, _health.Ratio, _speed * Time.deltaTime);
            _filled = _slider.value;
        }
    }
}
