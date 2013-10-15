using UnityEngine;
using System.Collections;

public class cameraCtrlTemo : MonoBehaviour {
	public float maxYAngle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		var h = Input.GetAxis("Mouse X");
		var v = Input.GetAxis("Mouse Y");
		if(h > 0f && transform.rotation.eulerAngles.y > 180f - maxYAngle)
		{
			transform.Rotate(0f,maxYAngle * -0.1f,0f);	
		}else if(h < 0f && transform.rotation.eulerAngles.y < 180f + maxYAngle)
		{
			transform.Rotate(0f,maxYAngle * 0.1f,0f);
		}
	}
}
