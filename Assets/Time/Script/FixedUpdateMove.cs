﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour
{
    public float spd = 0.01f;

    void FixedUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime * spd);
    }
}
