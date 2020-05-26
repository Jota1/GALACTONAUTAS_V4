using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dome : MonoBehaviour
{
    private float time;
    private float segundos;

    public AI ai;

    public Slider lifeIndicatorSld;
    public float maxLife = 60f;

    public Text energiaDoDomoText;
    private int energiaDoDomo;

    private float life;

    private bool ForaDoDomo;

    // Start is called before the first frame update
    void Start()
    {
        energiaDoDomo = 22;
        energiaDoDomoText.text = energiaDoDomo + "%";
        lifeIndicatorSld.maxValue = maxLife;
        time = 1;
        segundos = time * 5;
    }

    // Update is called once per frame
    void Update()
    {

        if(ForaDoDomo)
        {
            life -= Time.timeScale;
            lifeIndicatorSld.value = life;
        }

       segundos -= Time.deltaTime;

        if (segundos <= 0 && Generators.currentEnergy > 0)
        {
            Generators.currentEnergy -= 1;
            UpdateInterface.instance.Update2();
            segundos = time * 60;
        }

        else if (segundos <= 0 && energiaDoDomo > 0)
        {
            energiaDoDomo -= 1;
            energiaDoDomoText.text = energiaDoDomo + "%";
            segundos = time * 5;
        }

        if(energiaDoDomo == 0)
        {
            gameObject.SetActive(false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        
        if(other.CompareTag("Player"))
        {
            ai.Avisinho();
            ForaDoDomo = true;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            ForaDoDomo = false;

        }
    }


}
