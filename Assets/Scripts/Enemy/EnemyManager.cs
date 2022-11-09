using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private GameObject target;
    [SerializeField] private float attackSpeed;
 

    Vector3 initialRotation;
   
    private void Start()
    {
        initialRotation = transform.eulerAngles;
        target = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {
        if (LightArea._canAttackPlayer)
        {
           
                transform.LookAt(target.transform.position);
                transform.eulerAngles = new Vector3(initialRotation.x, transform.eulerAngles.y, initialRotation.z);
                Vector3 targetPos = target.transform.position + Vector3.down;
                targetPos.y = transform.position.y;
                transform.position = Vector3.MoveTowards(transform.position, targetPos, attackSpeed * Time.fixedDeltaTime);
                Debug.DrawLine(transform.position, targetPos);
         
           
        }

        if (!LightArea._canAttackPlayer)
        {
            if (EnemyGenrator._EM.IsGenerated)
            {
                Destroy(this.gameObject, 0.2f);
                EnemyGenrator._EM.IsGenerated = false;
            }
        }
      
    }

  
}
