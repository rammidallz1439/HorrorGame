using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	

	[SerializeField]
	private Transform player;

	[SerializeField]
	private float xMin;

	[SerializeField]
	private float xMax;

	public Vector2 turn;
    public float sensitivity=2;

    private void Update()
	{

		turn.x = Input.GetAxisRaw("Mouse X") * sensitivity;
		turn.y = Input.GetAxisRaw("Mouse Y") * sensitivity;
		transform.localRotation = Quaternion.Euler(-turn.y,turn.x,0.0f);


		player.Rotate(0, turn.x, 0.0f, Space.World);
	}
}
