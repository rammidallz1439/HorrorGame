using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager _HM;
    public float _health;
    public Slider healthBar;
    public float reduceVelocity;
    private void Start()
    {
        _HM = this;
        healthBar.value = 1f;
        _health = healthBar.value;
    }
    private void Update()
    {
        healthBar.value = Mathf.Lerp(healthBar.value,_health,reduceVelocity);
    }
    public void TakeDamage(float damage)
    {
        _health -= damage;
    }
}
