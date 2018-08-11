using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    bool Go;
    float tiempo;

	void Start () {
        Temporizador();
    }
	
	void Update () {
        Pulsar();
        if (Go)
        {
            tiempo += Time.deltaTime;
        }
    }

    void Temporizador ()
    {
        StartCoroutine(PreparadosListosYa());
    }

    public IEnumerator PreparadosListosYa()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("READY: " + Time.time);
        yield return new WaitForSeconds(2f);
        Debug.Log("STEADY: " + Time.time);
        yield return new WaitForSeconds(Random.Range(1f, 5f));
        Debug.Log("GO");
        Go = true;
    }

    void Pulsar()
    {
        if (!Go && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space) && tiempo >= 0.4f)
        {
            Debug.Log("Has perdido");
        }

        else if (Go && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space) && tiempo <= 0.4f)
        {
            Debug.Log("Has ganado");
        }
    }
}
