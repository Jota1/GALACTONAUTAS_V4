using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public static bool playerBool;
    public GameObject player;
    public GameObject car;
    public GameObject car2;

    InventoryUI inventoryUI;
    Inventory inventory;

    private void Start()
    {
        playerBool = true;
        inventory = Inventory.instance;
        inventoryUI = InventoryUI.instance;
        inventory.onItemChangedCallback += inventoryUI.UpdateUI;
    }

    public void ChangePlayerInteract()
    {
       if(FuelSystem.StartFuel <= 0)
        {
            if(Generators.currentEnergy >= 5)
            {
                Generators.currentEnergy -= 5;
                FuelSystem.StartFuel = 100;
                UpdateInterface.instance.Update2();
            }
        }

       if(playerBool)
        {
            Debug.Log("hue");
           // Inventory.currentInventory = "Car";
           //inventoryUI.UpdateUIInventory();
            car.SetActive(true);
            car2.SetActive(false);
            player.SetActive(false);
            playerBool = false;
        }

       else
        {
        
            //Inventory.currentInventory = "Player";
            //InventoryUI.instance.UpdateUI();
            player.SetActive(true);
            car2.SetActive(true);
            car.SetActive(false);
            playerBool = true;
        }
    }

    public void Update()
    {
        Debug.Log(FuelSystem.StartFuel);
       // if(!playerBool && FuelSystem.startFuel <= 0)
        //{
        //    ChangePlayerInteract();
       // }
    }
}
