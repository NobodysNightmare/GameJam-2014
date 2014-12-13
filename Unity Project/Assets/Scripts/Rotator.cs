using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public Vector3 RotationOffset;
	public Vector3 RotationAxis;
	public float RotationSpeed;
	public float StartDelay;
	public float RestingTimeMs = 1000;

	private Vector3 initialPos;
	private float wait;

	// Use this for initialization
	void Start () {
		this.initialPos = this.transform.position;
		this.wait = this.StartDelay + this.RestingTimeMs;
	}
	
	// Update is called once per frame
	void Update () {		
		if (this.StartDelay > 0)
		{
			this.StartDelay -= Time.deltaTime * 1000;
			return;
		}		

		if (this.wait > 0)
		{
			this.wait -= Time.deltaTime * 1000;
		}

		this.transform.Rotate(this.RotationAxis * RotationSpeed);
	}
}
