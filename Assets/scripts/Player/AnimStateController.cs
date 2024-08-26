using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStateController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        bool is_running = Input.GetAxis("Horizontal") != 0 | Input.GetAxis("Vertical") != 0;
        animator.SetBool("isRuning", is_running);
    }
}
