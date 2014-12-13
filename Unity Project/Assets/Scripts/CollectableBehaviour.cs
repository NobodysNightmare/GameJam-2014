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

    // FIXME: dirty copy & paste from MoveBackAndForth

    private Vector3 StartOffset = new Vector3(0f, 0.1f, 0f);
    public Vector3 EndOffset = new Vector3(0f, -0.1f, 0f);
    private float Speed = 0.2f;

    private float t = 0;
    private bool f = false;
    private Vector3 StartPos;
    private float distance;

    // Use this for initialization
    void Start()
    {
        this.StartPos = this.transform.localPosition;
        this.distance = (this.EndOffset - this.StartOffset).magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.f)
        {
            t += this.Speed * Time.deltaTime;
            if (t >= this.distance)
            {
                this.f = !this.f;
            }
        }
        else
        {
            t -= this.Speed * Time.deltaTime;
            if (t <= 0)
            {
                this.f = !this.f;
            }
        }

        Vector3 dir = (this.EndOffset - this.StartOffset);
        dir.Normalize();

        this.transform.localPosition = this.StartPos - this.StartOffset + dir * this.t;
        this.transform.Rotate(Vector3.up * 0.5f);
    }
}
