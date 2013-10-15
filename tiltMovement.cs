using UnityEngine;
using System.Collections;

public class tiltMovement : MonoBehaviour {
	public float maxYAngle;
	public float maxXAngle;
	public float angleYNow;
	public float angleYOld;
	public float angleXNow;
	public float angleXOld;
	public float speed;
	// Use this for initialization
	void Awake () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		var h = Input.acceleration.x;
		var v = Input.acceleration.y;
		//var h = Input.GetAxis("Mouse X");
		//var v = Input.GetAxis("Mouse Y");
		if(h > 0f && angleYNow < maxYAngle)
		{
			angleYNow += h*speed;
			var pos = transform.position;
			moveMent();

		}else if(h < 0f && angleYNow > -maxYAngle)
		{
			angleYNow += h*speed;
			moveMent();
		}
		if(v > 0f && angleXNow < maxXAngle)
		{
			angleXNow += v*speed;
			var pos = transform.position;
			moveMent();

		}else if(v < 0f && angleXNow > -maxXAngle)
		{
			angleXNow += v*speed;
			moveMent();
		}
	}
	void moveMent()
	{
		foreach(Transform child in transform)
		{
			float curX = child.transform.position.x;
			float curY = child.transform.position.y;
			float curZ = child.transform.position.z;
			float dAngleY = Mathf.Tan (angleYNow * Mathf.PI/180) - Mathf.Tan (angleYOld * Mathf.PI/180);
			float dAngleX = Mathf.Tan (angleXNow * Mathf.PI/180) - Mathf.Tan (angleXOld * Mathf.PI/180);
			var newPos = new Vector3(curZ * dAngleY + curX, curZ * dAngleX + curY, curZ);
			child.transform.Translate(curZ * dAngleY, curZ * dAngleX, 0f);
		}
		angleYOld = angleYNow;
		angleXOld = angleXNow;
	}
}
