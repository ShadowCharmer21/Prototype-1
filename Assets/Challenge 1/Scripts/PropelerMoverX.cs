﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelerMoverX : MonoBehaviour
{
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down * rotationSpeed);
    }
}
