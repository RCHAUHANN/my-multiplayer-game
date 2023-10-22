using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class player : MonoBehaviourPunCallbacks

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (photonView.IsMine)
        {
            float x =Input.GetAxis("Horizontal")* 10f * Time.deltaTime;
            float z = Input.GetAxis("Vertical") * 10f * Time.deltaTime;
            transform.Translate(x,0,z);
        }
        
    }
}
