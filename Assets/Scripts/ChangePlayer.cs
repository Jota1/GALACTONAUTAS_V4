using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public static bool playerBool;
    public GameObject player;
    public GameObject car;
    public GameObject car2;
    public GameObject cam;

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
      
         FuelSystem.StartFuel = 100;
         UpdateInterface.instance.Update2();
         

       if(playerBool)
        {
            Debug.Log("hue");
           // Inventory.currentInventory = "Car";
           //inventoryUI.UpdateUIInventory();
            car.SetActive(true);
            car2.SetActive(false);
            cam.SetActive(true);
            player.SetActive(false);
            playerBool = false;
        }

       else
        {

            //Inventory.currentInventory = "Player";
            //InventoryUI.instance.UpdateUI();
            cam.SetActive(false);
            player.SetActive(true);
            car2.SetActive(true);
            car.SetActive(false);
            playerBool = true;
        }
    }

    public void Update()
    {
       // Debug.Log(FuelSystem.StartFuel);
       // if(!playerBool && FuelSystem.startFuel <= 0)
        //{
        //    ChangePlayerInteract();
       // }
    }
}
