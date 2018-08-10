using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    Rigidbody miRigidBody;
    public float aceleracion = 5;

    private void Awake()
    {
        miRigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direccion = new Vector3(horizontal, 0, vertical);

        direccion.Normalize();

        miRigidBody.AddForce(direccion * aceleracion, ForceMode.Acceleration);
    }
}
