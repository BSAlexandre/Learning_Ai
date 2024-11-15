using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MyMoveShell : MonoBehaviour
{
    public float spd = 1f;
    public float upspd;

    void Start()
    {
        upspd = spd/2f;
    }

    void FixedUpdate()
    {
        this.transform.Translate(0, Time.deltaTime * upspd , Time.deltaTime * spd);
    }
}
