using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using NSMB.Utils;

public class MarioStart : MonoBehaviour
{
    public GameObject ReadyText, MarioStartText;
    public PlayerData LoadingIcon;
    // Start is called before the first frame update
    void Start()
    {
        if(Utils.GetCharacterData() == LoadingIcon)
        {
            ReadyText.GetComponent<TMP_Text>().text = "";
            ReadyText.SetActive(false);
            MarioStartText.SetActive(true);
        }
        else
        {
            ReadyText.GetComponent<TMP_Text>().text = "Ready!";
            ReadyText.SetActive(true);
            MarioStartText.SetActive(false);
            MarioStartText.transform.localPosition = new Vector2(-9999, -9999);
        }
    }
}
