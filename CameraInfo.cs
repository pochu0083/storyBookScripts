using UnityEngine;
using System.Collections;

public class CameraInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ( tk2dCamera.inst.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		m_cameraPos = this.transform.position;
		
	}
	public Vector3 GetCameraPos(){
		return this.transform.position;	
	}
	public Vector3 m_cameraPos;

}
