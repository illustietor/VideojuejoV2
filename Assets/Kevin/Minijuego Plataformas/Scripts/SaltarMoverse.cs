using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltarMoverse : MonoBehaviour
{
    public float velocidad = 10f;

    bool enSuelo = false;

    public Transform checkSuelo;

    float radioSuelo = 0.2f;

    public float fuerzaSalto = 700f;

    public LayerMask Suelo;

    void FixedUpdate()
    {
        float movimiento = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(movimiento * velocidad, GetComponent<Rigidbody2D>().velocity.y);

        enSuelo = Physics2D.OverlapCircle(checkSuelo.position, radioSuelo, Suelo);
    }

    void Update()
    {
        if(enSuelo && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzaSalto));
        }
    }
}