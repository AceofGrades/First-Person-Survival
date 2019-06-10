using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    // Reference Tag to detect collsions with
    public string hitTag;
    public UnityEvent onEnter;
    public AudioSource myFx;
    public AudioClip jumpFx;

    private void OnTriggerEnter(Collider other)
    {
        // If hitting hit tag
        if(other.gameObject.tag == "Player")
        {
            // Invokes (Run) the event!
            onEnter.Invoke();
            myFx.PlayOneShot(jumpFx);
            
        }

        if (other.gameObject.tag == "Enemy")
        {
            // Invokes (Run) the event!
            onEnter.Invoke();
            myFx.PlayOneShot(jumpFx);

        }
    }

}
