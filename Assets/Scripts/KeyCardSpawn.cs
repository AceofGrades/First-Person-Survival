using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardSpawn : MonoBehaviour
{
    public Transform[] cardSpawns;
    public Transform card;


    // Start is called before the first frame update
    void Start()
    {

        card.position = cardSpawns[Random.Range(0, cardSpawns.Length)].position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
