using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Eerie : KillableEntity
{
    public float Amplitude = 0;
    public float Period = 1f;
    public float Speed = -5f;
    public float Timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            if (body.transform.position.y > 5)
            {
                Amplitude = 3f;
                Speed = 3f;
            }else
            {
                Amplitude = 0;
                Speed = -3.75f;
            }
            body.velocity = new Vector2(Speed, Mathf.Cos((Timer / Period) * Mathf.PI) * Amplitude);
            Timer += Time.deltaTime;
            body.transform.localScale = new Vector3(Mathf.Sign(Speed) * 3f, 3f, 3f);
        }
        else
        {
            body.velocity = new Vector2(body.velocity.x,body.velocity.y + 2.2f);
        }
    }
    public override void InteractWithPlayer(PlayerController player)
    {
        if (player.hitInvincibilityCounter <= 0)
        {
            player.photonView.RPC("Powerdown", RpcTarget.All, false);
        }
    }
}
