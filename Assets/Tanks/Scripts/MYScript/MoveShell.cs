using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveShell : MonoBehaviour
{
    public float spd = 1f;
    public float upspd;

    void start()
    {
        upspd = spd/2f;
    }

    void FixedUpdate()
    {
        this.transform.Translate(0, Time.deltaTime * upspd , Time.deltaTime * spd);
    }
}
