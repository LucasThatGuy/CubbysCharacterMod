using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public int Incr = 0;
    public float Acceleration = -0.0001f;
    public float Speed = -0.0001f;
    public bool DoItAnyway = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Incr += 1;
        if(Incr >= 1200)
        {
            transform.position = new Vector3(transform.position.x + Speed, transform.position.y, 1);
            Speed += Acceleration;
        }
        if(transform.position.x >= 13)
        {
            DoItAnyway = true;
        }
        if(transform.position.x < 32 && DoItAnyway)
        {
            SpriteRenderer NewAlpha = GetComponent<SpriteRenderer>();
            NewAlpha.color = new Color(NewAlpha.color.r, NewAlpha.color.g, NewAlpha.color.b, NewAlpha.color.a - 0.015625f);
            if(NewAlpha.color.a <= 0f)
            {
                Destroy(this);
            }
        }
    }
}
