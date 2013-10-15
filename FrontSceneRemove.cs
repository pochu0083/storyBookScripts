using UnityEngine;
using System.Collections;

public class FrontSceneRemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
// Update is called once per frame
	void Update () {
		float parentZ = this.transform.parent ?
				this.transform.parent.transform.position.z : 0.0f;
		float shiftZ = this.transform.position.z - Camera.main.transform.position.z ;
		float curY = this.transform.position.y;
		if(shiftZ < 200.0f){
			float newY = -0.05f*Mathf.Pow (shiftZ-30.0f,2.0f);
			this.transform.Translate (0.0f, newY-curY, 0.0f);
		}

		return;
	}
}
