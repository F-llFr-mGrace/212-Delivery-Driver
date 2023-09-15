using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyTime = 5;
    [SerializeField] Color32 hasPackageColor = new Color32 (255,255,255,255);
    [SerializeField] Color32 noPackageColor = new Color32(255,255,255,255);
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Package") && !hasPackage)
        {
            Debug.Log("Package pickup");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyTime);
        }
        if (collision.CompareTag ("Customer") && hasPackage)
        {
            Debug.Log("Package dropoff");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
