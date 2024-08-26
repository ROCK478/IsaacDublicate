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
        bool is_running_flag = Input.GetAxis("Horizontal") != 0 | Input.GetAxis("Vertical") != 0;
        animator.SetBool("isRuning", is_running_flag);
    }
}
