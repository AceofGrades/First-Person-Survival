﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYesnt : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip pdeathFx;
    public GameObject player;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(player);
        }
    }
}