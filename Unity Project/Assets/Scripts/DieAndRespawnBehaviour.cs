using UnityEngine;
using System.Collections;

public class DieAndRespawnBehaviour : MonoBehaviour
{
    public float DeathHeight;

    public Vector3 RespawnLocation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.y < DeathHeight)
        {
            Debug.Log("Player died! Respawning...", this);
            this.transform.position = RespawnLocation;
        }
	}
}
