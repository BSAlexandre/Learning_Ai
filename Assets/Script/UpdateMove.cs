using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{
   public float spd = 0.01f;

    void Update()
    {
        this.transform.Translate(0, 0, spd);
    }
}
