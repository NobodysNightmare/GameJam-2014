using UnityEngine;
using System.Collections;

public class CollectableBehaviour : MonoBehaviour {

    private bool hasBeenTriggered = false;

    void OnTriggerEnter(Collider collider)
    {
        var player = collider.gameObject.GetComponent<PlayerVariables>();
        if (player != null && !hasBeenTriggered)
        {
            hasBeenTriggered = true;
            player.cactii++;
            Object.Destroy(this.gameObject);
        }
    }
}
