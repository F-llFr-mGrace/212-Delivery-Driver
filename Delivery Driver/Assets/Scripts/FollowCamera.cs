using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] float distfromthing = 1;
    [SerializeField] float lerptime = 1;
    [SerializeField] private GameObject thingtofollow;
    Vector3 prevPos;
    Vector3 point;

    void Start()
    {
        prevPos = thingtofollow.transform.position;
        point = thingtofollow.transform.position;
    }
    void Update()
    {
        if (Vector3.Magnitude(thingtofollow.transform.position - prevPos) >= 0.001)
        {
            point = thingtofollow.transform.position + thingtofollow.transform.up * distfromthing;

        }

        else
        {
            point = thingtofollow.transform.position;
        }
        point.z = -5;
        transform.position = Vector3.Lerp(transform.position, point, lerptime);
        prevPos = thingtofollow.transform.position;
    }
}
