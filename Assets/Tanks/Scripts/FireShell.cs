using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShell : MonoBehaviour {

    public GameObject bullet;
    public GameObject turret;
    public GameObject enemy;
    public Transform turretBase;

    private float speed = 15.0f;
    private float rotSpeed = 5.0f;
    //private float moveSpeed = 1.0f;

    //static float delayReset = 0.2f;
    //float delay = delayReset;

    void CreateBullet() {

        GameObject shell = Instantiate(bullet, turret.transform.position, turret.transform.rotation);
        shell.GetComponent<Rigidbody>().velocity = speed * turretBase.forward;
    }
    
    void Update()
    {
        Vector3 direction = (enemy.transform.position - this.transform.position).normalized;
        Quaternion lookRontation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookRontation, Time.deltaTime * rotSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateBullet();
        }

        
    }

    //Vector3 CalculateTrajectory() {

    //    Vector3 p = enemy.transform.position - this.transform.position;
    //    Vector3 v = enemy.transform.forward * enemy.GetComponent<Drive>().speed;
    //    float s = bullet.GetComponent<MoveShell>().speed;

    //    float a = Vector3.Dot(v, v) - s * s;
    //    float b = Vector3.Dot(p, v);
    //    float c = Vector3.Dot(p, p);
    //    float d = b * b - a * c;

    //    if (d < 0.1f) return Vector3.zero;

    //    float sqrt = Mathf.Sqrt(d);
    //    float t1 = (-b - sqrt) / c;
    //    float t2 = (-b + sqrt) / c;

    //    float t = 0.0f;
    //    if (t1 < 0.0f && t2 < 0.0f) return Vector3.zero;
    //    else if (t1 < 0.0f) t = t2;
    //    else if (t2 < 0.0f) t = t1;
    //    else {

    //        t = Mathf.Max(new float[] { t1, t2 });
    //    }
    //    return t * p + v;
    //}
}