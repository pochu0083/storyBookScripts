using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		bound = new float[]{2.5f, -2.5f, 0.0f, -1.0f};
		curX = 0.0f;
		curY = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		float shiftX = Input.GetAxis ("Mouse X");
		float shiftY = Input.GetAxis ("Mouse Y");
			
		if(curX + shiftX < bound[0] && curX + shiftX > bound[1])
			curX += shiftX;
		else if(curX+shiftX > bound[0] || curX + shiftX < bound[1]){
			shiftX = shiftX < 0.0f? bound[1]-curX : bound[0]-curX;
			curX += shiftX;
			if(curX > bound[0]) curX = bound[0];
			if(curX < bound[1]) curX = bound[1];
		}
		if(curY + shiftY < bound[2] && curY + shiftY > bound[3])
			curY += shiftY;
		else if(curY+shiftY > bound[2] || curY + shiftY < bound[3]){
			shiftY = shiftY < 0.0f? bound[3]-curY : bound[2]-curY;
			curY += shiftY;
			if(curY > bound[2]) curY = bound[2];
			if(curY < bound[3]) curY = bound[3];
		}
		
		foreach(Transform child in transform){
			float curZ = child.transform.localPosition.z;
			if(curZ <= 3.0f)
				curZ = 3.0f;
			float multi = 3.0f*1024.0f/curZ;
			child.transform.Translate (shiftX * multi, shiftY*multi,0.0f);
		}
		return;
	}
	
	private float[] bound;
	private float curX;
	private float curY;
	
}
