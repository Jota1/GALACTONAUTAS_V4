using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dome : MonoBehaviour
{
    private float time;
    private float segundos;

    // Start is called before the first frame update
    void Start()
    {
        time = 1;
        segundos = time * 60;
    }

    // Update is called once per frame
    void Update()
    {
        segundos -= Time.deltaTime;

        if (segundos <= 0)
        {
            Generators.currentEnergy -= 1;
            UpdateInterface.instance.Update2();
            segundos = time * 60;
        }
    }
}
