using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackDist;

 
    private void FixedUpdate()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist <= attackDist)
        {
            transform.LookAt(target.position);

            transform.position = Vector3.MoveTowards(transform.position,target.position,attackSpeed*Time.fixedDeltaTime);
        }
    }
}
