using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHold : MonoBehaviour
{
    public bool hold;
    public Transform holdPoint;
    

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" & !hold)
        {
            gameObject.transform.position = holdPoint.position;
            gameObject.transform.SetParent(other.transform);
            hold = true;
        }
    }
}
