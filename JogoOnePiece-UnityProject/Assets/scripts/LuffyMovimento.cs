using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuffyMovimento : MonoBehaviour
{
    public LuffyController controller;
    public float runSpeed = 40f;
    public bool jump;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal") * runSpeed));
        animator.SetBool("isJumping", jump);

        if (Input.GetButton("Jump"))//tecla 'w'
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(Input.GetAxisRaw("Horizontal") * runSpeed * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}

