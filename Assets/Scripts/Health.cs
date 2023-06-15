using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public event UnityAction<float> Changed;

    [SerializeField] private float _maxHealthPoints;

    private float _healthPoints;

    public float Ratio => _healthPoints / _maxHealthPoints;

    public void Increase(float amountOfHPs)
    {
        float newHPs = _healthPoints + amountOfHPs;
        _healthPoints = newHPs < _maxHealthPoints ? newHPs : _maxHealthPoints;
        Changed?.Invoke(Ratio);
    }

    public void Decrease(float amountOfHPs)
    {
        float newHPs = _healthPoints - amountOfHPs;
        _healthPoints = newHPs > 0 ? newHPs : 0;
        Changed?.Invoke(Ratio);
    }
}
