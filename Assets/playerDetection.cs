using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerDetection : MonoBehaviour
{
    public delegate void OnPlayerDetection(Transform player);
    public event Action<Transform> onPlayerDetection;
    // Start is called before the first frame update
    void Start()
    {

    }

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