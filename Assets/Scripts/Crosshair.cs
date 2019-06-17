using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Texture2D crosshair;

    void OnGUI()
    {
            GUI.Label(new Rect(Screen.width / 2 - 45, Screen.height / 2 - 23, 100, 100), crosshair);
        
    }
}
