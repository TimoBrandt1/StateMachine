using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    [SerializeField] private Transform leftCorner;
    [SerializeField] private Transform rightCorner;

    public Vector3 randomposition()
    {
        float randomX;
        float randomZ;
        Vector3 hoek1 = leftCorner.position;
        Vector3 hoek2 = rightCorner.position;
        if (hoek1.x < hoek2.x)
        {
            randomX = Random.Range(hoek1.x, hoek2.x);
        }
        else
        {
            randomX = Random.Range(hoek2.x, hoek1.x);
        }
        if (hoek1.y < hoek2.y)
        {
            randomZ = Random.Range(hoek1.z, hoek2.z);
        }
        else
        {
            randomZ = Random.Range(hoek2.z, hoek1.z);
        }

        return new Vector3(randomX, transform.position.y, randomZ);
    }
}
