using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightArea : MonoBehaviour
{
    public static LightArea instance;
    [SerializeField] private float _radius;
    public bool _canAttackPlayer;
    private void Start()
    {
        instance = this;
        _canAttackPlayer = false;
        SphereCollider sc = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        sc.isTrigger = true;
        sc.radius = _radius;
    }
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, _radius);
    }

    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _canAttackPlayer = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _canAttackPlayer = true;
        }
    }
}
