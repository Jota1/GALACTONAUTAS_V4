using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarTriggers : MonoBehaviour
{
    public AI ai;
    public GameObject[] triggers;
    public GameObject[] barreiraProJogador;
    public Collider[] collidersCercas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ai.GetnarrativaAtual() == 2 && !triggers[0].activeInHierarchy)
        {
            triggers[0].SetActive(true);
            barreiraProJogador[0].SetActive(false);
            barreiraProJogador[1].SetActive(false);


        }

        if(ai.GetnarrativaAtual() == 3)
        {
            barreiraProJogador[0].SetActive(true);
            barreiraProJogador[1].SetActive(true);

            for (int i = 0; i < collidersCercas.Length; i++)
            {
                collidersCercas[i].enabled = true;
            }
        }

        if (ai.GetnarrativaAtual() == 4 && !ai.GetFalaAtiva())
        {
            barreiraProJogador[0].SetActive(false);
            barreiraProJogador[1].SetActive(false);
            triggers[1].SetActive(true);

        }
    }
}
