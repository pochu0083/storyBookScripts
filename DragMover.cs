using UnityEngine;
using System.Collections;

public class DragMover
{
	public DragMover (float inertia, float maxSpeed, float maxDistance)	{
		m_fInertia = inertia;
		m_fMaxSpeed = maxSpeed;
		m_fMaxDistance = maxDistance;
		m_fCurDistance = 0.0f;
		m_fCurSpeed = 0.0f;
	}
	
	public void Drag(Transform trans, float acc, float dTime){
		if(acc*m_fCurDistance > 0.0f && Mathf.Abs(m_fCurDistance) > Mathf.Abs ( m_fMaxDistance) ){
				acc = 0.0f;
		}
			if( Mathf.Abs(m_fCurSpeed) >= 0.0001f){
				float useInertia = m_fCurSpeed > 0.0f ? m_fInertia : -m_fInertia;
				m_fCurSpeed -= useInertia * dTime;
			}

			
			m_fCurSpeed += dTime*acc;
			if(Mathf.Abs(m_fCurSpeed) >= m_fMaxSpeed){
				m_fCurSpeed = m_fCurSpeed > 0.0f ? m_fMaxSpeed : -m_fMaxSpeed;
			}
			float diffDis = dTime * m_fCurSpeed;
			m_fCurDistance += diffDis;
			trans.Translate(diffDis, 0.0f, 0.0f);
		
		return;
	}
	
	private float m_fInertia;
	private float m_fMaxSpeed;
	private float m_fMaxDistance;
	private float m_fCurDistance;
	private float m_fCurSpeed;
}


