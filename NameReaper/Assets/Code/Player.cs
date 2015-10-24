using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Player : ObjectInformation
{
    public float moveSpeed = 3;
    

	// Use this for initialization
	void Start ()
    {
        
    }

    void FixedUpdate()
    {
        // Cache the inputs.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(h * moveSpeed, v * moveSpeed);
    }

    // Update is called once per frame
    void Update ()
    {
	    
	}
}