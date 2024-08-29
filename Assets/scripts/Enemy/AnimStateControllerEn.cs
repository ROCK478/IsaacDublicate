using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStateControllerEn : MonoBehaviour
{
    Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ShootAnim()
    {
        animator.SetBool("isShooting", true);
    }
}
