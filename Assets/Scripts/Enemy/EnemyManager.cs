using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackDist;

    Vector3 initialRotation;
   
    private void Start()
    {
        initialRotation = transform.eulerAngles;
    }
    private void FixedUpdate()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (LightArea.instance._canAttackPlayer)
        {
           
            transform.LookAt(target.position);
            transform.eulerAngles = new Vector3(initialRotation.x, transform.eulerAngles.y, initialRotation.z);
            Vector3 targetPos = target.position + Vector3.down;
            targetPos.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position,targetPos,attackSpeed*Time.fixedDeltaTime);
            Debug.DrawLine(transform.position, targetPos);
        }
      
    }
}
