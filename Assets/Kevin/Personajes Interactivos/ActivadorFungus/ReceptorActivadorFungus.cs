using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ReceptorActivadorFungus : MonoBehaviour {

    public Flowchart flowchart;
    public string mensaje;

	// Use this for initialization
	void Start () {
        //Por si se nos ha olvidado desactivar el objeto.
        flowchart.gameObject.SetActive(false);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Me cago en puto Patxi");
            flowchart.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            flowchart.gameObject.SetActive(false);
        }
    }

    //Envía un mensaje a Fungus (como el nodo SendMessage) para que podamos capturarlo nosotros capturando ese mensaje en concreto.
    public void activaFungus(string mensaje)
    {
        Debug.Log("Entro al activador de Fungus");
        if (flowchart.gameObject.activeInHierarchy)
        {
            flowchart.SendFungusMessage(mensaje);
        }
    }
}
