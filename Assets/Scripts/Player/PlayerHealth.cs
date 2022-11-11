using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float damageToGive=0.5f;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Ghost"))
        {
            HealthManager._HM.TakeDamage(damageToGive );
        }
    }
 
}
