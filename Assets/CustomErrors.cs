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
            Funny.GetComponent<TMP_Text>().text = "You got BANNED Bozo";
        }
    }
}
