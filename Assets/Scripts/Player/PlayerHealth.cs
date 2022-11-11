using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float damageToGive=0.1f;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Ghost"))
        {
            HealthManager._HM.TakeDamage(damageToGive );
        }
    }
 
}
