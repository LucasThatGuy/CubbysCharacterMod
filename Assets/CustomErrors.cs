using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class CustomErrors : MonoBehaviour
{
    public GameObject Funny;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Funny.GetComponent<TMP_Text>().text == "User not authorized to join room.")
        {
            Funny.GetComponent<TMP_Text>().text = "You got BANNED Bozo :]";
        }
        if (Funny.GetComponent<TMP_Text>().text == "ClientTimeout")
        {
             Random.InitState(System.DateTime.Now.Millisecond);
            int Foony = Random.Range(0, 1);
            if(Foony == 0)
            {
                Funny.GetComponent<TMP_Text>().text = "I think your internet sucks bro";
            }
            else
            {
                Funny.GetComponent<TMP_Text>().text = "ATipodtouch0218 Pls Fix The Servers I think They Are Down Why Are They Down Why Pls Tell Me I Need To Know Why Cause I Wanna Play With My Friends At Our Sleepover ipod Pls My Mom Says That We Have 30 Mins Till Bed JUST FIX THE FUCKING SERVERS PLS!?";
            }
        }
        if (Funny.GetComponent<TMP_Text>().text == "Cannot resolve destination host - 0")
        {
            Funny.GetComponent<TMP_Text>().text = "Me trying to play the game with no internet connection be like";
        }
            if (Funny.GetComponent<TMP_Text>().text == "Exception")
        {
            Random.InitState(System.DateTime.Now.Millisecond);
            int Foony = Random.Range(0, 1);
            if(Foony == 0)
            {
                Funny.GetComponent<TMP_Text>().text = "Ok";
            }
            else
            {
                Funny.GetComponent<TMP_Text>().text = "Idk you figure it out";
            }
        }
            if (Funny.GetComponent<TMP_Text>().text == "DisconnectByDisconnectMessage")
        {
            Funny.GetComponent<TMP_Text>().text = "ThePooHacker sharted SO HARD! So you got an error whoops!";
        }
    }
}
