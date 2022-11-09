using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightArea : MonoBehaviour
{
    public static bool _canAttackPlayer;
    [SerializeField] private float _radius;
    [SerializeField] private Transform player;

    private void Start()
    {
        _canAttackPlayer = false;
        SphereCollider sc = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        sc.radius = _radius;
        sc.isTrigger = true;

    }


    private void OnTriggerStay(Collider other)
     {
         if (other.gameObject.tag=="Player")
         {
             _canAttackPlayer = false;
            
         }
     }
     private void OnTriggerExit(Collider other)
     {
         _canAttackPlayer = true;
        if (!EnemyGenrator._EM.IsGenerated)
        {
            EnemyGenrator._EM.GenerateEnemy();
        }
        
        
     }
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position+ new Vector3(0f,-2f,0f), _radius);
    }



}
