using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject hud;
    public GameObject pause;
    public GameObject player;

    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameOver.SetActive(true);
            player.SetActive(false);
            hud.SetActive(true);  
        }
    }
}