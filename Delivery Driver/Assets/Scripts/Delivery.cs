using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Package"))
        {
            Debug.Log("Package pickup");
        }
        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Package dropoff");
        }
    }
}
