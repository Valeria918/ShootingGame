 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    
    public GameObject bullet;
    public Transform shotDir;

    private float timeShot;
    private float startTime = 0.5f;

    public AudioSource ShootSound;
    public AudioClip impact;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition); //положение мышки
        // ”гол между объектами
        float angle = Vector2.Angle(Vector2.up, position - transform.position);
        // ћгновенное вращение
        transform.eulerAngles = new Vector3(0f, 0f, transform.position.x < position.x ? -angle : angle);

        if (timeShot <= 0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, shotDir.position, transform.rotation);
                ShootSound.PlayOneShot(impact, 0.7f);
                timeShot = startTime;
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
}
