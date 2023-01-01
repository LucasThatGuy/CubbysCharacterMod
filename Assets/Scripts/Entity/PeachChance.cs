using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NSMB.Utils;
using UnityEngine.UI;

public class PeachChance : MonoBehaviour
{

    private Image image;
    public Sprite Imajin;
    public Sprite Lina;
    public Sprite Mama;
    public Sprite Papa;
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        image = GetComponent<Image>();
        int RandCheck = Mathf.FloorToInt(Random.Range(0f, 3.99f));
        if (RandCheck == 0)
        {
            image.sprite = Imajin;
        }
        if (RandCheck == 1)
        {
            image.sprite = Lina;
        }
        if (RandCheck == 2)
        {
            image.sprite = Mama;
        }
        if (RandCheck == 3)
        {
            image.sprite = Papa;
        }
    }
}
