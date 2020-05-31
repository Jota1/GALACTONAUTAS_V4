﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dome : MonoBehaviour
{
    private float time;
    private float segundos;

    public AI ai;

 

    public Text energiaDoDomoText;
    private int energiaDoDomo;





    private bool ForaDoDomo;

    // Start is called before the first frame update
    void Start()
    {
      
        energiaDoDomo = 51;
        energiaDoDomoText.text = energiaDoDomo + "%";
       
        time = 1;
        segundos = time * 5;
       
    }

    // Update is called once per frame
    void Update()
    {

       
       segundos -= Time.deltaTime;

         if (segundos <= 0 && energiaDoDomo > 0)
        {
            energiaDoDomo -= 1;
            energiaDoDomoText.text = energiaDoDomo + "%";
            segundos = time * 60;
        }

        if(energiaDoDomo == 0)
        {
            ForaDoDomo = true;
            gameObject.SetActive(false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        
        if(other.CompareTag("Player"))
        {
            print("dentrododomo");
            ai.Avisinho();
            ForaDoDomo = true;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            print("dentrododomo");
            ForaDoDomo = false;

        }
    }

    public bool GetForaDoDomo()
    {
        return ForaDoDomo;
    }

    public void SetEnergiaDoDomo()
    {
        energiaDoDomo = 100;
        energiaDoDomoText.text = energiaDoDomo + "%";
    }


}
