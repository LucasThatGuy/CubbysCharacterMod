using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NSMB.Utils;

public class Mario3Powerup : MonoBehaviour
{
    public Sprite NewSprite;
    public RuntimeAnimatorController NewAnimation;
    private SpriteRenderer spriteRenderer;
    public bool DisableAnimator = true, UseController = false;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.isMario3)
        {
            Animator anim = GetComponent<Animator>();
            if (UseController)
            {
                anim.runtimeAnimatorController = NewAnimation;
            }
            else
            {
                spriteRenderer = GetComponentInChildren<SpriteRenderer>();
                spriteRenderer.sprite = NewSprite;
            }
            
            if (DisableAnimator)
            {
                anim.enabled = false;
            }

        }
    }
}
