using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpeed : MonoBehaviour
{
    [SerializeField][Range(0f, 100f)] private float _newSpeed;
    [SerializeField][Range(0f, 1f)] private float _newTimeDuration;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        if (Weapon.IsShootgun)
        {
            GameObject _shootgun = GameObject.FindGameObjectWithTag("Weapon");
            Shootgun _shootgunComponent = _shootgun.GetComponent<Shootgun>();
            _shootgunComponent.TimerDuration = _newTimeDuration;

        }
        else
        {
            Weapon.BulletSpeed = _newSpeed;
        }
    }
}
