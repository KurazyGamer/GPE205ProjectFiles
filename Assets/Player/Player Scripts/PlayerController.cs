using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class PlayerController : Controller
{
    public KeyCode MoveForwardKey;
    public KeyCode MoveBackwardKey;
    public KeyCode RotateClockwiseKey;
    public KeyCode RotateCounterClockwiseKey;
    public KeyCode ShootKey;

    // Start is called before the first frame update
    public override void Start()
    {
        if (GameManager.instance != null)
        {
            if (GameManager.instance.players != null)
            {
                GameManager.instance.players.Add(this);
            }
        }
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        // Process our Keyboard Inputs
        ProcessInputs();

        base.Update();
    }

    public void OnDestroy()
    {
        if (GameManager.instance != null)
        {
            if (GameManager.instance.players != null)
            {
                GameManager.instance.players.Remove(this);
            }
        }
    }

    public void ProcessInputs()
    {
        if (Input.GetKey(MoveForwardKey))
        {
            pawn.MoveForward();
        }
        if (Input.GetKey(MoveBackwardKey))
        {
            pawn.MoveBackward();
        }
        if (Input.GetKey(RotateClockwiseKey))
        {
            pawn.RotateClockwise();
        }
        if (Input.GetKey(RotateCounterClockwiseKey))
        {
            pawn.RotateCounterClockwise();
        }
        if (Input.GetKeyDown(ShootKey))
        {
            pawn.Shoot();
        }
    }
}
