﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathCol : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Paal")
        {
            print("äaaaaaaaaaaaaaaa");
            Application.LoadLevel(0);

        }

    }
}