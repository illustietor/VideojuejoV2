using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Player : MonoBehaviour {
    public Flowchart flowchart;
    GameObject triggeringNpc;
    bool triggering;
    bool keyPressed = false;

    public GameObject npcText;
    public BoxCollider colision;

    void Update()
    {
        if (triggering )
        {
            npcText.SetActive(true);


            if (Input.GetKeyDown(KeyCode.E) && keyPressed == false)
            {
                keyPressed = true;
                flowchart.gameObject.SetActive(true);
            }

            else if (Input.GetKeyDown(KeyCode.E) && keyPressed == true)
            {
                keyPressed = false;
            }
        }
        else
        {
            npcText.SetActive(false);
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
