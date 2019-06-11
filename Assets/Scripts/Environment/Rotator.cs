// =========================================
// Author: Jared
// Script: Rotator.cs
// Purpose: This script makes items rotate!
// Date created: 28/5/19
// =========================================
using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
    }
}
