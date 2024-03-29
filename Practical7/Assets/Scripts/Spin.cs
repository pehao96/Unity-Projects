using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	
	public float speed = 10f;
	public float VertMin = -45;
	public float VertMax = 45; 

	float xRotation = 0;

	public enum RotationAxis { MouseX, MouseY };

	public RotationAxis axes;

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		if (axes <= RotationAxis.MouseX) {
			transform.Rotate (0, Input.GetAxis ("Mouse X") * speed * Time.deltaTime, 0);
		} else {
			//transform.Rotate ( -Input.GetAxis("Mouse Y" ) * speed, 0, 0);
			xRotation -= Input.GetAxis ("Mouse Y") * speed * Time.deltaTime;
			xRotation = Mathf.Clamp (xRotation, VertMin, VertMax);
			transform.localEulerAngles = new Vector3 (xRotation, transform.localEulerAngles.y, 0);
		}
	}
}
