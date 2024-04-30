using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBall : MonoBehaviour
{
    public Transform target;
    public float t; 
    public float speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }
}
