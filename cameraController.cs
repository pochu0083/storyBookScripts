using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		var h = Input.GetAxis("Mouse X");
		var v = Input.GetAxis("Mouse Y");
		if(h > 0f && transform.rotation.eulerAngles.y < 185f)
		{
			transform.Rotate(0f,0.5f,0f);	
		}else if(h < 0f && transform.rotation.eulerAngles.y > 175f)
		{
			transform.Rotate(0f,-0.5f,0f);	
		}
		
	}
}
