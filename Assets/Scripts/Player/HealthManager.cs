using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager _HM;
   
    public static bool healthZero = false;
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
        if (healthBar.value > 0)
        {
            MainHealth._mg.lives = 5;
            healthZero = false;
            healthBar.value = Mathf.Lerp(healthBar.value, _health, reduceVelocity);
        }
        
        if (healthBar.value <= 0)
        {
            healthZero = true;
            MainHealth._mg.lives -= 1;
            PlayerPrefs.SetInt("LivesCount", MainHealth._mg.lives);
        }
      
    }
    public void TakeDamage(float damage)
    {
        _health -= damage;
        if (_health > 0)
        {
            _health -= damage;
            if (_health <= 0.0f)
            {
                int lifes = PlayerPrefs.GetInt("LivesCount");
                lifes -= 1;
                PlayerPrefs.SetInt("LivesCount", lifes);
            }
        }
    }
}
