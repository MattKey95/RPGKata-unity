using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public IHealth _health;
    public GameObject bullet;
    public float rotationSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        _health = new Health();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            _health.Heal(10);

        if (Input.GetKeyDown(KeyCode.Space))
            Fire();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, 0, rotationSpeed));

        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0, 0, -rotationSpeed));
    }

    private void Fire()
    {
        Instantiate(bullet, transform);
    }
}
