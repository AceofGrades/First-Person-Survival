using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
