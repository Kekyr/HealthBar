using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealthPoints;
    [SerializeField] private HealthView _healthView;

    private void Awake()
    {
        _healthView.Init(new Health(_maxHealthPoints));
    }
}
