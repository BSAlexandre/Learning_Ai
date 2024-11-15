using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float speed = 0f;
    float yspeed = 0f;
    float mass = 50;
    float force = 2;
    float drag = 5;
    float gravity = -8.8f;
    float gAccel;
    public float acceleration;

    public GameObject explosion;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    
    void Start()
    {
        acceleration = force / mass;
        speed += acceleration * 1;
        gAccel = gravity / mass; 
    }
    void Update()
    {
        speed *= (1- Time.deltaTime * drag);
        yspeed += gAccel * Time.deltaTime;
        this.transform.Translate(0, yspeed, speed);
    }
}
