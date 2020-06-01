using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDosEfeitos : MonoBehaviour
{
    public GameObject EfeitosChatos;
   
    public void CancelarEfeito()
    {
        Destroy(EfeitosChatos);
    }
}
