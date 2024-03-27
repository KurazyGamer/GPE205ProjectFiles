using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject PlayerControllerPrefab;
    public GameObject TankPawnPrefab;
    public Transform PlayerSpawnTransform;
    public List<PlayerController> players;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        GameObject NewPlayerObj = Instantiate(PlayerControllerPrefab, PlayerSpawnTransform.position, PlayerSpawnTransform.rotation) as GameObject;
        GameObject NewPawnObj = Instantiate(TankPawnPrefab, PlayerSpawnTransform.position, PlayerSpawnTransform.rotation) as GameObject;
        Controller newController = NewPlayerObj.GetComponent<Controller>();
        PawnClass newPawn = NewPawnObj.GetComponent<PawnClass>();

        newController.pawn = newPawn;
    }
}
