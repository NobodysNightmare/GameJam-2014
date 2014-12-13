using UnityEngine;
using System.Collections;

public class JumpPad : MonoBehaviour {
    public Vector3 JumpVector
    {
        get { return JumpDirection * JumpVelocity; }
    }

    public Vector3 JumpDirection = Vector3.up;

    public float JumpVelocity = 10f;
}
