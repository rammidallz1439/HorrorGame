using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightArea : MonoBehaviour
{
    public static LightArea instance;
    [SerializeField] private float _radius;
    [SerializeField] private Transform player;
    public bool _canAttackPlayer;
    public float _dia;
    public float dir;
    private void Start()
    {
        instance = this;
        _canAttackPlayer = false;
        _dia = _radius + _radius;
        SphereCollider sc = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        sc.radius = _radius;
        sc.isTrigger = true;

    }

   /* private void FixedUpdate()
    {
        dir = Vector3.Distance(transform.position, player.position);
        if (dir <= _radius)
        {
            _canAttackPlayer = true;
        }
        else if (dir >= _radius)
        {
            _canAttackPlayer = false;
        }
    }*/
    private void OnTriggerStay(Collider other)
     {
         if (other.gameObject.tag=="Player")
         {
             _canAttackPlayer = true;
         }
     }
     private void OnTriggerExit(Collider other)
     {
         _canAttackPlayer = false;
     }
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position+ new Vector3(0f,-2f,0f), _radius);
    }



}
