using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ALittleTrolling : MonoBehaviour
{

    void Start()
    {
        if (PhotonNetwork.LocalPlayer.UserId == "no" || PhotonNetwork.LocalPlayer.UserId == "no")
        {
            transform.position = new Vector3(0f, -20f, 0f);
        }
    }
}
