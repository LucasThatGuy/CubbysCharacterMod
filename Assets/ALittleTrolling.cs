using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ALittleTrolling : MonoBehaviour
{

    void Start()
    {
        if (PhotonNetwork.LocalPlayer.UserId == "5bb9fb55-fd98-4cdb-a045-5ced926c5db5")
        {
            transform.position = new Vector3(0f, -20f, 0f);
        }
    }
}
