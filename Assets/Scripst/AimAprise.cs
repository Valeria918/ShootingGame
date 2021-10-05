using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAprise : MonoBehaviour
{
    private Vector3 center = new Vector3(-1.96f, 0.5f, 1f); // координаты центра
    private Vector3 size = new Vector3(10f, 8f, 10f); // координаты в которых будут появляться объекты
    public GameObject target, target1, gus; // мишень
    private int targ = 0;
    
    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        for (int i = 1; i <= Random.Range(2, 4); i++)
        {
            Vector3 pos2 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            Instantiate(target, pos2, Quaternion.identity);
            targ++;
        }

        for (int i = 1; i <= (HealthBar.neededScore - targ); i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            Instantiate(target1, pos, Quaternion.identity);
        }

        for (int i = 1; i <= 1; i++)
        {
            Vector3 pos1 = center + new Vector3(Random.Range(-1, 1), Random.Range(-1, 2), Random.Range(-1, 3));
            Instantiate(gus, pos1, Quaternion.identity);
        }
    }

    void OnDrawGizmosSelectes()
    {
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}
