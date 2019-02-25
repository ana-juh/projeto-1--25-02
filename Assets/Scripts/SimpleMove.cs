﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;
    
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float So = transform.position.x;
        float newX = So + SpeedFactor * Time.deltaTime;
       transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
