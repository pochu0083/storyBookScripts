using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {
	
	public float moverInertia;
	public float moverMaxSpeed;
	public float moverMaxDistance;
	// Use this for initialization
	void Start () {
		m_dmMover = new DragMover(moverInertia,moverMaxSpeed, moverMaxDistance);
	}
	
	// Update is called once per frame
	void Update () {
		float acc = 0.0f;
		if(Input.GetKey("d")){
			acc = 100.0f;
		}
		if(Input.GetKey("a")) {
			acc = -100.0f;
		}
		m_dmMover.Drag (this.transform, acc, Time.deltaTime);
	}
	
	private DragMover m_dmMover;
}
