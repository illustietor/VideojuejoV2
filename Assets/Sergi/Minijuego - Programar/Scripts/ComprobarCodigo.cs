using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarCodigo : MonoBehaviour {

    bool codigoCorrecto;

    public GameObject[] comprobaciones;
    int activos;
    int inactivos;


    bool ComprobarGamObjectsClaves()
    {
        activos = 0;
        inactivos = 0;

        for (int q = 0; q < comprobaciones.Length; q++)
        {
            if (comprobaciones[q].activeSelf)
            {
                Debug.Log("La clave " + comprobaciones[q] + " esta activa");
                activos++;
            }

            else
            {
                Debug.Log("La clave " + comprobaciones[q] + " esta inactiva");
                inactivos++;
            }

        }

        if (activos == comprobaciones.Length)
            return true;

        else
            return false;
    }

	// Use this for initialization
	void Start ()
    {
       codigoCorrecto = ComprobarGamObjectsClaves();
    }

}
