using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform playerSpawnPoint;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player.position = playerSpawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
