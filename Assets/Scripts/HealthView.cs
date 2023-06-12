using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthView : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Health _health;
    private Slider _slider;

    private float _healthPoints;
    private float _newHealthPoints;

    public void Init(Health health)
    {
        _health = health;
        _healthPoints = _health.HealthPointsRatio;
        _slider.value = _healthPoints;
    }

    public void Increase(float amountOfHPs)
    {
        _health.Increase(amountOfHPs);
        _newHealthPoints = _health.HealthPointsRatio;
    }

    public void Decrease(float amountOfHPs)
    {
        _health.Decrease(amountOfHPs);
        _newHealthPoints = _health.HealthPointsRatio;
    }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (_healthPoints != _newHealthPoints)
        {
            _slider.value = Mathf.MoveTowards(_healthPoints, _newHealthPoints, _speed * Time.deltaTime);
            _healthPoints = _slider.value;
        }
    }
}
