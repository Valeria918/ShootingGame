using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moovement : MonoBehaviour
{
    [SerializeField] float speedMove;
    Rigidbody2D rb;
    Vector2 direction;
    float x = 0, y = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        x = 100f;
        direction = new Vector2(x, y);

        rb.transform.position = Vector2.MoveTowards(transform.position, direction, speedMove * Time.deltaTime);
       
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        x = Random.Range(-100, 100);
        y = Random.Range(-100, 100);

        speedMove = -speedMove;
    }
}
