﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    private int vie = 5;
    public GameObject coeur1;
    public GameObject coeur2;
    public GameObject coeur3;
    public GameObject coeur4;
    public GameObject coeur5;

    private GameObject[] tabCoeur;

    // Start is called before the first frame update
    void Start()
    {
        tabCoeur = new GameObject[] { coeur1, coeur2, coeur3, coeur4, coeur5 };

    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Il reste " + vie + "pv");
            lostxLife(1);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Il reste " + vie + "pv");
            gainxLife(1);
        }
    }

    void lostxLife(int x)
    {
        vie -= 1;
        if (vie < 0) { vie = 0; }
        afficherVie();
    }

    void gainxLife(int x)
    {
        vie += x;
        if (vie > 5) { vie = 5; }
        afficherVie();

    }

    void viderCoeurs()
    {
        foreach (GameObject coeur in tabCoeur)
        {
            coeur.SetActive(false);
        }
    }

    void afficherVie()
    {
        viderCoeurs();
        for(int i=0; i<vie; i++)
        {
            tabCoeur[i].SetActive(true);

        }
    }
}