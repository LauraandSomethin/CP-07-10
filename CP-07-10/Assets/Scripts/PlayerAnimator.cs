using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    private Animator animator;
    private PlayerControls playerControls;


    void Awake()
    {
        animator = GetComponent<Animator>();
        playerControls = GetComponent<PlayerControls>();
    }


    void Update()
    {

            animator.SetInteger("pJump", playerControls.JumpValue());
   

        animator.SetInteger("pMove", playerControls.MoveValueX() + playerControls.MoveValueY());

    }
}
