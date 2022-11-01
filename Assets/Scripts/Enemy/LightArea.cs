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

    private void Start()
    {
        instance = this;
        _canAttackPlayer = false;
        _dia = _radius + _radius;
       // SphereCollider sc = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        
    }

    private void FixedUpdate()
    {
        float dir = Vector3.Distance(player.position, transform.position);
        if (dir <=_radius)
        {
            _canAttackPlayer = false;
        }
        else
        {
            _canAttackPlayer = true;
        }
    }
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, _radius);
    }

    

}
