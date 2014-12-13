using UnityEngine;
using System.Collections;

public class MoveBackAndForth : MonoBehaviour {

	public Vector3 StartOffset;
	public Vector3 EndOffset;
	public float Speed = 1;
	public float RestingDurationMs = 250;
	public float DelayMs = 0;

	private float t = 0;
	private bool f = false;
	private Vector3 StartPos;
	private float distance;
	private float wait = 0; // seconds

	// Use this for initialization
	void Start () {
		this.StartPos = this.transform.position;
		this.distance = (this.EndOffset - this.StartOffset).magnitude;
		this.wait = this.DelayMs / 1000.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (wait <= 0)
		{
			if (this.f) {			
				t += this.Speed * Time.deltaTime;
				if (t >= this.distance) 
				{
					this.f = !this.f;
					this.wait = this.RestingDurationMs / 1000.0f;			
				}
			}
			else {
				t -= this.Speed * Time.deltaTime;
				if (t <= 0) 
				{
					this.f = !this.f;
					this.wait = this.RestingDurationMs / 1000.0f;
				}
			}
		}

		Vector3 dir = (this.EndOffset - this.StartOffset);		
		dir.Normalize();
		
		if (wait <= 0) this.transform.position = this.StartPos - this.StartOffset + dir * this.t;
		else wait -= Time.deltaTime;
	}
}
