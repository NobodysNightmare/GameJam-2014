using UnityEngine;
using System.Collections;

public class MoveBackAndForth : MonoBehaviour {

	public Vector3 StartOffset;
	public Vector3 EndOffset;
	public float Speed = 1;
	public float RestingDurationMs = 250;
	public float DelayMs = 0;

	private float travelledDistance = 0;
	private bool moveForward = false;
	private Vector3 StartPosition;
    private Vector3 EndPosition;
    private Vector3 travelDirection;
	private float distance;
	private float remainingWaitSeconds = 0; // seconds

	// Use this for initialization
	void Start () {
		this.StartPosition = this.transform.position + this.StartOffset;
        this.EndPosition = this.transform.position + this.EndOffset;
        this.distance = (this.EndPosition - this.StartPosition).magnitude;
        this.travelDirection = (this.EndPosition - this.StartPosition).normalized;
		this.remainingWaitSeconds = this.DelayMs / 1000.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (remainingWaitSeconds <= 0)
		{
			if (this.moveForward) {			
				travelledDistance += this.Speed * Time.deltaTime;
				if (travelledDistance >= this.distance) 
				{
					this.moveForward = !this.moveForward;
					this.remainingWaitSeconds = this.RestingDurationMs / 1000.0f;			
				}
			}
			else {
				travelledDistance -= this.Speed * Time.deltaTime;
				if (travelledDistance <= 0) 
				{
					this.moveForward = !this.moveForward;
					this.remainingWaitSeconds = this.RestingDurationMs / 1000.0f;
				}
			}

            this.transform.position = this.StartPosition + (this.travelDirection * this.travelledDistance);
		}
        else
        {
            remainingWaitSeconds -= Time.deltaTime;
        }
	}
}
