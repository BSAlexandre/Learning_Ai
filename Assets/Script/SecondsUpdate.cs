using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float TimeStartOffset = 0;
    bool gotStartTime = false;
    public float spd = 1f;
    void Update()
    {
        if (!gotStartTime)
        {
            TimeStartOffset = Time.realtimeSinceStartup;
            gotStartTime = true;
        }

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Time.realtimeSinceStartup - TimeStartOffset * spd);

    }
}
