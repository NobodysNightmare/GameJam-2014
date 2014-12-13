using UnityEngine;
using System.Collections;

public class JumpPad : MonoBehaviour {
    public Vector3 JumpVector
    {
        get { return JumpDirection * JumpVelocity; }
    }

    public Vector3 JumpDirection = Vector3.up;

    public float JumpVelocity = 25f;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Someone is there!");
        var jumpee = collider.gameObject.GetComponent<CharacterMotor>();
        if (jumpee != null)
        {
            Debug.Log("Weeeeeeeeeeeee!");
            jumpee.SetVelocity(JumpVector);
        }
    }
}
