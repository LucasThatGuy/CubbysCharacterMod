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
            Funny.GetComponent<TMP_Text>().text = "I think your internet sucks bro";
        }
        if (Funny.GetComponent<TMP_Text>().text == "Cannot resolve destination host - 0")
        {
            Funny.GetComponent<TMP_Text>().text = "Me trying to play the game with no internet connection be like";
        }
            if (Funny.GetComponent<TMP_Text>().text == "Exception")
        {
            Funny.GetComponent<TMP_Text>().text = "what in the fuck does this error mean dawg :skull:";
        }
    }
}
