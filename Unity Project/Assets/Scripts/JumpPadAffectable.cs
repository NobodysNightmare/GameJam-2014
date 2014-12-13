using UnityEngine;
using System.Collections;

public class JumpPadAffectable : MonoBehaviour
{
    private CharacterMotor myMotor;
    private CharacterController myController;

    void Start()
    {
        myMotor = this.GetComponent<CharacterMotor>();
        myController = this.GetComponent<CharacterController>();

        if (myMotor == null || myController == null)
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
            this.myMotor.SetVelocity(jumpPad.JumpVector);
        }
    }
}
