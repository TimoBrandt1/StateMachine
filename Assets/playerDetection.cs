using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerDetection : MonoBehaviour
{
    public delegate void OnPlayerDetection(Transform player);
    public event Action<Transform> onPlayerDetection;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("huts");

            onPlayerDetection?.Invoke(collision.gameObject.transform);
        }
    }


}