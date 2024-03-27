using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TankMover : MoverClass
{
    private Rigidbody rb;

    // Start is called before the first frame update
    public override void Start()
    {
        // get the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    public override void Move(Vector3 direction, float speed)
    {
        Vector3 MoveVector = direction.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + MoveVector);
    }

    public override void Rotate(float turnspeed)
    {
        float RotationAmount = turnspeed * Time.deltaTime;
        transform.Rotate(0, RotationAmount, 0);
    }
}
