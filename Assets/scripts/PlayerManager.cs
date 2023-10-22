using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    PhotonView PV;
    GameObject controller;
    void Awake()
    {
       PV = GetComponent<PhotonView>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PV.IsMine)
        {
            CreateController();
        }
        
    }

    // Update is called once per frame
    void CreateController()
    {
        Transform spawnpoint = SpawnManager.instance.GetSpawnpoint();
       controller = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefab", "PlayerController"), spawnpoint.position, spawnpoint.rotation,0, new object[] {PV.ViewID});
    }

    public void Die()
    {
        PhotonNetwork.Destroy(controller);
        CreateController();
    }
}
