using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    public float speed;
    public float destroyTime;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBall", destroyTime);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); //движ относ сист кординат
    }

    void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.tag == "Walls") //если столкнется с объектом под тегом 
		{
            Invoke("DestroyBall", 0);
        }
    }

	void DestroyBall()
    {
        Destroy(gameObject);
    }
}
