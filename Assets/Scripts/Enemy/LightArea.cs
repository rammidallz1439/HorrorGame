using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightArea : MonoBehaviour
{
    public static LightArea instance;
    [SerializeField] private float _radius;
    [SerializeField] private float _Dia;

    private void Start()
    {
        instance = this;
        _Dia = _radius + _radius;
    }
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, _radius);
    }
}
