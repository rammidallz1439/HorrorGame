using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	

	[SerializeField]
	private Transform myCamera;

	[SerializeField]
	private float xMin;

	[SerializeField]
	private float xMax;

	private Vector3 _eulerAngles;
	public float sensitivity;

	private void Update()
	{

		float mouseX = Input.GetAxis("Mouse X") * sensitivity;
		float mouseY = Input.GetAxis("Mouse Y") * sensitivity;


		_eulerAngles.x = Mathf.Clamp(_eulerAngles.x, xMin, xMax);

		myCamera.localEulerAngles = _eulerAngles;

		transform.Rotate(0.0f, mouseX, 0.0f, Space.World);
	}
}
