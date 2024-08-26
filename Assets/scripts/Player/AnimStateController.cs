using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStateController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 | Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("isRuning", true);
        }
        else
        {
            animator.SetBool("isRuning", false);
        }
    }
}
