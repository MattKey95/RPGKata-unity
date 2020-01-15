using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    public float speed = 0.1f;
    public Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var direction = ((Vector2)transform.position - target).normalized;
        transform.position = (Vector2)transform.position - (direction * speed);
    }
}
