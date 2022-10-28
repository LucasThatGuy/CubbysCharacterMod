using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPower : MonoBehaviour {
    
    public int marioX = -296, peachX = 296, minX = -410;
    public Vector3 movementSpeed;
    public MarioLoader mario;
    private Animator animator;
    private RectTransform rect;
    private bool goomba, goombaHit, mini;
    private float goombaTimer;
    void Start() {
        animator = GetComponent<Animator>();
        rect = GetComponent<RectTransform>();
        if (Random.Range(0f, 1f) < 0.5f)
        {
            goomba = true;
        }
    }

    void Update() {
        animator.SetBool("goomba", goomba);
        animator.SetBool("mini", mini);
        if ((goombaTimer -= Time.deltaTime) < 0)
            rect.localPosition += movementSpeed * Time.deltaTime;

        if (rect.localPosition.x <= marioX) {
            if (goomba) {
                if (!goombaHit) {
                    mario.scale--;
                    goombaHit = true;
                    mario.scaleTimer = 0f;
                    goombaTimer = 0.5f;
                }
                if (rect.localPosition.x <= minX)
                    Reset();
            } else {
                if (mini)
                {
                    mario.scale = Mathf.Max(mario.scale - 2, 0);
                    mario.scaleTimer = 0f;
                    Reset();
                } else
                {
                    mario.scale++;
                    mario.scaleTimer = 0f;
                    Reset();
                }
            }
        }
    }

    void Reset() {
        Random.InitState(System.DateTime.Now.Second + System.DateTime.Now.Minute);
        goombaHit = false;
        goomba = mario.scale > 1 && (mario.scale >= 3 || Random.value < 0.5f);
        mini = (mario.scale >= 1 && Random.Range(0f,1f) < 0.1117f);
        if(mini == true) {
            goomba = false;
        }
        if (mario.scale == 3 && Random.Range(0f, 1f) < 0.3f)
        {
            goomba = false;
            mini = false;
        }
        if (mario.scale == 4 && Random.Range(0f, 1f) < 0.2f)
        {
            goomba = false;
            mini = false;
        }
        rect.localPosition = new Vector2(320, rect.localPosition.y);
    } //peachX + 24f
}
