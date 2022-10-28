using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MiniSpawner : MonoBehaviour
{
    public float initialShootTimer = 3;
    public float shootTimer = 3;

    // Update is called once per frame
    void Update()
    {
        if (!PhotonNetwork.IsMasterClient || GameManager.Instance.gameover)
            return;

        if ((shootTimer -= Time.deltaTime) <= 0)
        {
            shootTimer = initialShootTimer;
            PhotonNetwork.InstantiateRoomObject("Prefabs/Powerup/MiniMushroom", transform.position, Quaternion.identity, 0, new object[] { true });
        }
    }
}
