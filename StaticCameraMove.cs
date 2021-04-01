using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCameraMove : MonoBehaviour
{
    private float speed;
    public Movement movement;
    void Start()
    {
        movement = GameObject.FindWithTag("Player").GetComponent<Movement>();

    }

    
    void Update()
    {
        speed = movement.speed;
        transform.position += Vector3.forward * Time.deltaTime * speed;

    }
}
