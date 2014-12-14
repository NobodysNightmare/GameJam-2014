using UnityEngine;
using System.Collections;

public class JumpPad : MonoBehaviour
{
    public Vector3 JumpDirection = Vector3.up;

    public float JumpVelocity = 25f;

    private Vector3 JumpVector
    {
        get { return this.transform.TransformDirection(JumpDirection) * JumpVelocity; }
    }

    void OnTriggerEnter(Collider collider)
    {
        var jumpee = collider.gameObject.GetComponent<CharacterMotor>();
        if (jumpee != null)
        {
            jumpee.SetVelocity(JumpVector);
        }
    }
}
