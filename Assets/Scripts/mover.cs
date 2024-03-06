using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        transform.position = transform.position + (new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
