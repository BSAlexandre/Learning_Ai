using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    public float spd = 0.01f;
    void LateUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime * spd);

    }
}
