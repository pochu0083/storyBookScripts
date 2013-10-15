using UnityEngine;
using System.Collections;

public class clickToNextPage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonUp("Fire1"))
		{
			var level = Application.loadedLevel;
			if(level != 5)
			{
				Application.LoadLevel(level + 1);
			}else
			{
				Application.LoadLevel(0);
			}
		}
	}
}
