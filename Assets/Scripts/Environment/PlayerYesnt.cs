using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerYesnt : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(3);
        }
        if (other.gameObject.tag == "Zomling")
        {
            SceneManager.LoadScene(5);
        }
    }
}
