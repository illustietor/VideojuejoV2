using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {
    public int pulsacionesPorSegundo;
    public float tiempo;

    public bool facil = false;
    public bool medio = false;
    public bool dificil = false;

    public void PulsacionesPorSegundoJugador()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tiempo <= 10)
        {
            pulsacionesPorSegundo++;

            if (pulsacionesPorSegundo >= 65 && pulsacionesPorSegundo < 80 )
            {
                facil = true;
                if (facil == true)
                {
                    PlayerPrefs.SetInt("facil1", 1);
                }
            }

            if (pulsacionesPorSegundo >= 80 && pulsacionesPorSegundo < 90)
            {
                medio = true;
                if (medio == true)
                {
                    PlayerPrefs.SetInt("medio2", 2);
                    facil = false;
                    PlayerPrefs.DeleteKey("facil1");
                }
            }

            if (pulsacionesPorSegundo >= 90 && pulsacionesPorSegundo <= 100)
            {
                dificil = true;
                if (dificil == true)
                {
                    PlayerPrefs.SetInt("dificil3", 3);
                    medio = false;
                    facil = false;
                    PlayerPrefs.DeleteKey("facil1");
                    PlayerPrefs.DeleteKey("medio2");
                }
            }
        }
    }

    void TerminarTutorial()
    {
        if (tiempo >= 11 && pulsacionesPorSegundo >= 65)
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 0;
        }

        else if (tiempo >= 11 && pulsacionesPorSegundo < 65)
        {
            Debug.Log("Presiona R para reiniciar el tutorial");
            Time.timeScale = 0;

            if (Input.GetKeyDown(KeyCode.R))
            {
                

                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);

                Time.timeScale = 1;
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        tiempo += Time.deltaTime;

        PulsacionesPorSegundoJugador();
        TerminarTutorial();
    }
}
