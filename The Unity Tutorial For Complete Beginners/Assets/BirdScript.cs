using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //public access to use in inspector
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    Vector3 currentRotation;
    Vector3 startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.eulerAngles; //rotation in degrees
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            myRigidbody.velocity = Vector2.up * flapStrength;

       // Vector3 currentRotation = transform.eulerAngles; //current rotation of the bird

        transform.eulerAngles = startRotation;
    }
}
