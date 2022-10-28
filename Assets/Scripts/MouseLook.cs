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

	public float  turnX;
	public float turnY;
    public float sensitivity=2;

    private void Update()
	{

		turnX += Input.GetAxis("Mouse X") * sensitivity;
		turnY += Input.GetAxis("Mouse Y") *-1* sensitivity;
		transform.localEulerAngles = new Vector3(turnY, turnX, 0.0f);


		//player.Rotate(0, turnX, 0.0f, Space.World);
	}
}
