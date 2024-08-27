using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource footSteps;
    void Update()
    {
        bool is_running = Input.GetAxis("Horizontal") != 0 | Input.GetAxis("Vertical") != 0;

        if (is_running)
            footSteps.enabled = true;
        else 
            footSteps.enabled = false;
    }
}
