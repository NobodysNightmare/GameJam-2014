using UnityEngine;
using System.Collections;

public class CollectableBehaviour : MonoBehaviour {

    private bool hasBeenTriggered = false;

    void OnTriggerEnter(Collider collider)
    {
        var player = collider.gameObject.GetComponent<Player>();
        if (player != null && !hasBeenTriggered)
        {
            hasBeenTriggered = true;
            player.cactiiCollected++;
            Object.Destroy(this.gameObject);
        }
    }
}
