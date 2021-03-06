﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public void Obstaculos()
    {
        {
            myRigidbody = GetComponent<Rigidbody>();
            myRigidbody.AddForce(Vector3.left * 5, ForceMode.VelocityChange);
        }
    }

    void Start()
    {
        Obstaculos();
    }

    private void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Mini_Saltar player = other.GetComponent<Mini_Saltar>();
        
        if (player)
        {
            Time.timeScale = 0;
            Debug.Log("Has perdido");
        }
    }
}
