using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private PlayerControls playerControls;
    public void speed : 2f;
    private vektor2 movement;
    private rigidbody2D rb;
    private Animator myAnimator;
    private spriteRenderer mySpriteRender;

    public void awake(){
        base.awake();
        
    }
}
