using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoBox : MonoBehaviour
{
    public int Bullets;
    public Text ammoText;

    private void Start()
    {
        Bullets = 12;
        SetAmmoText();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        //if(other.gameObject.CompareTag("Ammo"))
        if (other.tag == "Ammo")
        {
            other.gameObject.SetActive(false);
            SetAmmoText();
        }
    }

    void SetAmmoText()
    {
        Weapon.UpdateBullets(6);
    }
}
