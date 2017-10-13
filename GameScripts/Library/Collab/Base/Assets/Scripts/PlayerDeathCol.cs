using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathCol : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Platform")
        {
            PlayerManager.instance.BirdDied();
        }
    }
}
