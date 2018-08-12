using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    GameObject triggeringNpc;
    bool triggering;
    bool keyPressed = false;

    public GameObject npcText;
    public GameObject text;
    public  BoxCollider colision;

    void Update()
    {
        if (triggering )
        {
            npcText.SetActive(true);


            if (Input.GetKeyDown(KeyCode.E) && keyPressed == false)
            {
                keyPressed = true;
                text.SetActive(true);
            }

            else if (Input.GetKeyDown(KeyCode.E) && keyPressed == true)
            {
                keyPressed = false;
                text.SetActive(false);
            }
        }
        else
        {
            npcText.SetActive(false);
            text.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = false;
            triggeringNpc = null;
        }
    }
}
