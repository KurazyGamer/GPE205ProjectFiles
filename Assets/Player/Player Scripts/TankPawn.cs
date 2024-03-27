using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : PawnClass
{
    private float nextShootTime;

    // Start is called before the first frame update
    public override void Start()
    {
        
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Start();
    }

    public override void MoveForward()
    {
        mover.Move(transform.forward, MoveSpeed);
    }

    public override void MoveBackward()
    {
        mover.Move(transform.forward, -MoveSpeed);
    }

    public override void RotateClockwise()
    {
        mover.Rotate(TurnSpeed);
    }

    public override void RotateCounterClockwise()
    {
        mover.Rotate(-TurnSpeed);
    }

    public override void Shoot()
    {
        
        if (Time.time >= nextShootTime)
        {
            shooter.Shoot(shellPrefab, fireForce, damageDone, shellLifespan);
            nextShootTime = Time.time + fireRate;
        }
        
    }
}
