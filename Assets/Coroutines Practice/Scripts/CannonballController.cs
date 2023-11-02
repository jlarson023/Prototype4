using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballController : MonoBehaviour
{
    public Rigidbody cannonballRb;
    public float launchForce;
    public float forwardForce;


    // Start is called before the first frame update
    void Start()
    {
        cannonballRb = GetComponent<Rigidbody>();
        cannonballRb.AddForce((Vector3.up * launchForce) + (Vector3.forward * forwardForce), ForceMode.Impulse);
    }
}
