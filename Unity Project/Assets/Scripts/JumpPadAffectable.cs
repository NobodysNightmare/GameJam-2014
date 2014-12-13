using UnityEngine;
using System.Collections;

public class JumpPadAffectable : MonoBehaviour
{
    private CharacterMotor myMotor;

    void Start()
    {
        myMotor = this.GetComponent<CharacterMotor>();

        if (myMotor == null)
        {
            Debug.LogError("Object without Character Motor tries to be JumpPadAffectable", this);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var jumpPad = hit.gameObject.GetComponent<JumpPad>();
        if (jumpPad != null)
        {
            Debug.Log("Weeeeeeeeeeeee!");
            this.myMotor.movement.velocity += jumpPad.JumpVector;
        }
    }
}
