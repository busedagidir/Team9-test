﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    float speed = 50.0f;
    
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
