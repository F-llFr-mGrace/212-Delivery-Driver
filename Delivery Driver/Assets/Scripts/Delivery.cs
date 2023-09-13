using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Package"))
        {
            Debug.Log("Package pickup");
            hasPackage = true;
        }
        if (collision.CompareTag ("Customer") && hasPackage)
        {
            Debug.Log("Package dropoff");
            hasPackage = false;
        }
    }
}
