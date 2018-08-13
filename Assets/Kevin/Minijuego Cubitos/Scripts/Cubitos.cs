using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubitos : MonoBehaviour {
    public float speed = 10f;

    public GameObject player;
    public GameObject objetivo;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
    }

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<MeshRenderer>().material.color = new Color(0f, 255f, 0f);
        objetivo.GetComponent<MeshRenderer>().material.color = new Color(0f, 255f, 0f);

        StartCoroutine(Esperar());
        StopCoroutine(Esperar());
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0;
    }
}
