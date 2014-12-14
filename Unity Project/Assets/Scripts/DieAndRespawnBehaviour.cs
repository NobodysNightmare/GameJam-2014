using UnityEngine;
using System.Collections;

public class DieAndRespawnBehaviour : MonoBehaviour
{
    public float DeathHeight;

    private Vector3 respawnLocation;
    private Quaternion respawnRotation;

	// Use this for initialization
	void Start () {
        respawnLocation = this.transform.position;
        respawnRotation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.y < DeathHeight)
        {
            Debug.Log("Player died! Respawning...", this);
            this.transform.position = respawnLocation;
            this.transform.rotation = respawnRotation;
        }
	}
}
