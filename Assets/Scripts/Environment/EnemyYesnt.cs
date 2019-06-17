using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyYesnt : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip deathFx;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Destroy(enemy);
            AudioSource.PlayClipAtPoint(deathFx, transform.position, 2f);
        }
    }
}
