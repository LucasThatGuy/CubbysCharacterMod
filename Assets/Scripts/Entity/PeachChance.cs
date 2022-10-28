using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NSMB.Utils;
using UnityEngine.UI;

public class PeachChance : MonoBehaviour
{

    private Image image;
    public PlayerData data;
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(System.DateTime.Now.Second);
        image = GetComponent<Image>();
        if (Random.Range(0f,1f) < 0.5f)
        {
            image.sprite = data.loadingSmallSprite;
        }
    }
}
