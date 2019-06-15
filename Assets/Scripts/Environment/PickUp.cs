using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public float speed;
    public AudioSource myFx;
    public AudioClip cardFx;
    public Text countText;
    public Text escapeText;
    public Time duration;

    private int Keycards;

    void Start()
    {
        Keycards = 0;
        SetCountText();
        escapeText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(cardFx, transform.position, 1f);
            Keycards = Keycards + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Keycards: " + Keycards.ToString();
        if(Keycards == 1)
        {
            escapeText.text = "You've found the keycard! Time to escape!";
            escapeText.CrossFadeAlpha(0, 10f, false);
        }
    }
    
}
