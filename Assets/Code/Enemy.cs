using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Health _health;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Spawned enemy");
        _health = new Health();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Something hit me");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player1>()._health.TakeDamage(10);
            Debug.Log("Player took damage");
            Object.Destroy(this);
        }

        if (collision.gameObject.name.Contains("bullet"))
        {
            _health.TakeDamage(10);
            Debug.Log("Enemy took damage");
            if (_health.IsDead)
            {
                Debug.Log("Enemy die!");
                Object.Destroy(this);
            }
        }

    }
}
