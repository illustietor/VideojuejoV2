using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class EnviarSenalFungus: MonoBehaviour {

    //Tecla para activar eventos.
    public KeyCode teclaInteraccion;

    //Distancia a la que podrás interactuar con el elemento.
    public float distanciaRaycast;

    //Mensaje que hay que enviar
    public string mensaje;

    //Impacto del Raycast
    private RaycastHit rayHit;
    Ray ray;

    private ReceptorActivadorFungus activadorFungus;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(teclaInteraccion))
        {
            Debug.Log("Activo el boton " + teclaInteraccion);
            //lanzamos un rayo y almacenamos la información del impacto en rayHit
            ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));


            if (Physics.Raycast(ray, out rayHit))
            {
                print("I'm looking at " + rayHit.transform.name);

                activadorFungus = rayHit.collider.gameObject.GetComponent<ReceptorActivadorFungus>();
            }
               

            if (activadorFungus != null)
            {
                Debug.Log("Intento activar Fungus");
                activadorFungus.activaFungus(mensaje);
            }

        }
	}
}
