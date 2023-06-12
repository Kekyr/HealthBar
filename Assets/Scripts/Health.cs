using System;

[Serializable]
public class Health
{
    private float _maxHealthPoints;
    private float _healthPoints;

    public Health(float maxHealthPoints)
    {
        float defaultMaxHealthPoints = 100;

        if (maxHealthPoints <= 0)
            maxHealthPoints = defaultMaxHealthPoints;

        _maxHealthPoints = maxHealthPoints;
    }

    public float HealthPointsRatio => _healthPoints/_maxHealthPoints;

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
