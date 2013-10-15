using UnityEngine;
using System.Collections;

public class FarScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float shiftZ = Input.GetAxis("Mouse ScrollWheel");
		if(shiftZ > 0.0f){
			shiftZ = 1.1f;
			this.transform.Translate (0.0f, 5.0f, 0.0f);
		}
		else if(shiftZ < 0.0f){
			shiftZ = 1.0f/1.1f;	
			this.transform.Translate (0.0f, -5.0f, 0.0f);
		}
		return;
	}
}
