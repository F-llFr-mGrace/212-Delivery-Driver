using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyTime = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Package") && !hasPackage)
        {
            Debug.Log("Package pickup");
            hasPackage = true;
            Destroy(collision.gameObject, destroyTime);
        }
        if (collision.CompareTag ("Customer") && hasPackage)
        {
            Debug.Log("Package dropoff");
            hasPackage = false;
        }
    }
}
