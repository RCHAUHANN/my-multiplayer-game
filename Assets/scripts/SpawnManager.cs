using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   public static SpawnManager instance;
    spawnPoint[] spawnpoints;

    private void Awake()
    {
        instance = this;
        spawnpoints = GetComponentsInChildren<spawnPoint>(); 
    }

    public Transform GetSpawnpoint()
    {
        return spawnpoints[Random.Range(0,spawnpoints.Length)].transform;
    }
    
}
