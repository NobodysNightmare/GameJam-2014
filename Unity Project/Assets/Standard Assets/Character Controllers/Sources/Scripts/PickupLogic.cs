using UnityEngine;
using System.Collections;

public class PickupLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        var collectable = collider.collider.gameObject;
        if (collectable.tag == "Collectable")
        {
            this.gameObject.GetComponent<PlayerVariables>().cactii++;
            Object.Destroy(collectable);
        }
    }
}
