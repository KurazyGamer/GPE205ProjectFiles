using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PawnClass : MonoBehaviour
{
    public float MoveSpeed;
    public float TurnSpeed;
    public MoverClass mover;
    public GameObject Bullet;
    public Shooter shooter;
    public GameObject shellPrefab;
    public float fireForce;
    public float damageDone;
    public float shellLifespan;
    public float fireRate;

    // Start is called before the first frame update
    public virtual void Start()
    {
        mover = GetComponent<MoverClass>();
        shooter = GetComponent<Shooter>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void Shoot();
}
