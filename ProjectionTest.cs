using UnityEngine;
using System.Collections;

public class ProjectionTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		m_vec3LocPos = new Vector3(this.transform.localPosition.x, 
									this.transform.localPosition.y, 
									this.transform.localPosition.z);
		//m_vec3LocPos = new Vector3(this.transform.localPosition);
		float parentX = this.transform.parent != null ? this.transform.parent.position.z : 0.0f;
		m_fOrginZ =  m_vec3LocPos.z - Camera.main.transform.position.z + parentX;
		//m_fOrginZ = 30.0f;
	}
	
	// Update is called once per frame
	void Update () {
			if(Camera.main != null){
				Vector3 CameraPos = Camera.main.transform.position;
				Vector3 _vec3Pos = new Vector3(0.0f, 0.0f, 0.0f);
				_vec3Pos += m_vec3LocPos;
				_vec3Pos.x -= CameraPos.x;
				_vec3Pos.y -= CameraPos.y;
				if(this.transform.parent != null)
					_vec3Pos += this.transform.parent.position;
				float worldZprime = _vec3Pos.z - CameraPos.z;
				if(worldZprime > 1.0f){
					float scaler = m_fOrginZ/worldZprime;
					float newX = (_vec3Pos.x-512.0f)*scaler+512.0f;
					float newY = (_vec3Pos.y-384.0f)*scaler+384.0f;
					float curX = this.transform.position.x-CameraPos.x;
					float curY = this.transform.position.y-CameraPos.y;
					this.transform.Translate (newX-curX, newY-curY, 0.0f);
					this.transform.localScale = new Vector3(scaler, scaler, 1.0f);
					}
			}
			else {
				Debug.Log ("No Camera");
			}
			
		return;
	}
	private float m_fOrginZ;
	private Vector3 m_vec3LocPos;
}
