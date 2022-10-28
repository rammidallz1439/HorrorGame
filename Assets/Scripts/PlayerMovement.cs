using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;

    public float speed;

    float horizontal;
    float vertical;
    Vector3 movement;

   public Animator anim;
    private float sensitivity=2;
    public GameObject _camera;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        MyInput();
        
        transform.Rotate(0, _camera.transform.rotation.x, 0.0f, Space.World);
    }
    void MyInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        movement = transform.forward * vertical + transform.right * horizontal;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.velocity = movement * speed;
        if (horizontal > 0f)
        {
            anim.SetInteger("State", 1);
        }
        else
        {
            anim.SetInteger("State", 0);
        }
    }
}
