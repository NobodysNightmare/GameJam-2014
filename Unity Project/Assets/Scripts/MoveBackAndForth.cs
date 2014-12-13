using UnityEngine;
using System.Collections;

public class MoveBackAndForth : MonoBehaviour {

	public Vector3 StartOffset;
	public Vector3 EndOffset;
	public float Speed = 0.005f;

	private float t = 0;
	private bool f = false;
	private Vector3 StartPos;
	private float distance;

	// Use this for initialization
	void Start () {
		this.StartPos = this.transform.position;
		this.distance = (this.EndOffset - this.StartOffset).magnitude;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.f) {			
			t += this.Speed;
			if (t >= this.distance) this.f = !this.f;			
		}
		else {
			t -= this.Speed;
			if (t <= 0) this.f = !this.f;
		}

		Vector3 dir = (this.StartOffset - this.EndOffset);
		float length = dir.magnitude;
		dir.Normalize();

		this.transform.position = this.StartPos - this.StartOffset + dir * this.t;
	}
}
