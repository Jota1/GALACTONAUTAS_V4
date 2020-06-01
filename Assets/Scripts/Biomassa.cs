using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biomassa : MonoBehaviour
{

    private Inventory inventory;
    public Item item;
    public int amount;
    public static bool BioAlien;
    public GameObject fumaça;

    private float timer = 60;

    // Start is called before the first frame update
    void Start()
    {
        BioAlien = false;
        Generators.MaxCapacity += 10;
        UpdateInterface.instance.Update2();
        inventory = GameObject.Find("GameManager").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BioAlien)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {

                timer = 60;
                Generators.currentEnergy += 5;
                if(Generators.currentEnergy > Generators.MaxCapacity)
                {
                    Generators.currentEnergy = Generators.MaxCapacity;
                }
                UpdateInterface.instance.Update2();
            }
        }
    }

    public void GenerateEnergy()
    {
        if (HasMaterials(inventory) && Generators.currentEnergy < Generators.MaxCapacity)
        {
            
            RemoveMaterials(inventory);

            Generators.currentEnergy += 10;

            fumaça.SetActive(true);

            if(Generators.currentEnergy > Generators.MaxCapacity)
            {
                Generators.currentEnergy = Generators.MaxCapacity;
            }

            UpdateInterface.instance.Update2();
        }

    }

    public bool HasMaterials(ItemContainer itemContainer)
    {


        if (itemContainer.ItemCount(item.name) < 1)
        {
            Debug.LogWarning("You don't have the required materals.");
            return false;
       }

       return true;
    }

    public void RemoveMaterials(ItemContainer itemContainer)
    {

        for (int i = 0; i < amount; i++)
        {
            Inventory.instance.Remove(item);
        }
    }

}
