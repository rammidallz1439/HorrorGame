using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] private Rigidbody _rb;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _anim;
    [SerializeField] private float speed = 6f;


    private void FixedUpdate()
    {

        //uses joystick when in android build
#if UNITY_STANDALONE ||PLATFORM_STANDALONE
        _joystick.gameObject.SetActive(true);
        _rb.velocity = new Vector3(_joystick.Vertical * speed, _rb.velocity.y,_joystick.Horizontal * speed);
        if (_joystick.Horizontal!=0||_joystick.Vertical!=0)
        {
            //transform.localRotation = Quaternion.LookRotation(_rb.velocity);
          
        }
#endif

        //uses KeyBoard when in windows build
#if PLATFORM_STANDALONE_WIN || UNITY_STANDALONE_WIN
        _joystick.gameObject.SetActive(false);

        float horizontal = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        transform.Translate(horizontal, 0f, vertical);
        if (horizontal!=0||vertical!=0)
        {
            _anim.SetInteger("State", 1);
        }
        else
        {
            _anim.SetInteger("State", 0);
        }
        
#endif
    }

 
}
