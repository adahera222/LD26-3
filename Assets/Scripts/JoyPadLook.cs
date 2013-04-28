using UnityEngine;
using System.Collections;

public class JoyPadLook : MonoBehaviour {
	public enum Axis {
		X=1,
		Y=2,
		Both=3
	}
	
	public Axis controlAxis = Axis.Both;
	
	public float XSensitivity = 1.5f;
	public float YSensitivity = 1.5f;
	
	public float XMin = -360;
	public float XMax = 360;

	public float YMin = -60;
	public float YMax = 60;
	
	float x = 0;
	float y = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((controlAxis & Axis.X) == Axis.X) {
			x = x + (Input.GetAxis("Horizontal2") * XSensitivity);
		}
		
		if((controlAxis & Axis.Y) == Axis.Y) {
			y = y + (Input.GetAxis("Vertical2") * YSensitivity);
		}
		
		x = Mathf.Clamp(x % 360, XMin, XMax);
		y = Mathf.Clamp(y % 360, YMin, YMax);
		
		transform.localEulerAngles = new Vector3(0, x, y);
	}
}
