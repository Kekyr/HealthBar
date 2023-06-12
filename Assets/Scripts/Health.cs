using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealthPoints;

    private float _healthPoints;

    public float Ratio => _healthPoints / _maxHealthPoints;

    public void Increase(float amountOfHPs)
    {
        float newHPs = _healthPoints + amountOfHPs;
        _healthPoints = newHPs < _maxHealthPoints ? newHPs : _maxHealthPoints;
    }

    public void Decrease(float amountOfHPs)
    {
        float newHPs = _healthPoints - amountOfHPs;
        _healthPoints = newHPs > 0 ? newHPs : 0;
    }
}
