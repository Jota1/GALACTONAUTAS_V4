using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarCoisas : MonoBehaviour
{
    public GameObject Bioefeito;
    public AI ai;

    // Start is called before the first frame update
  
    public void cancelarEfeito()
    {
        ai.SetFalaAtiva(true);
        Destroy(Bioefeito);
    }
}
