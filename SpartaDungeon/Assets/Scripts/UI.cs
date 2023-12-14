using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject statusScreen;
    public GameObject inventoryScreen;
    public GameObject playerScreen;

    public ItemSlot[] itemslots;

    public void SetInventory()
    {
        for (int i = 0; i < DataManager.instance.gameData.myItems.Length; i++) 
        {
            itemslots[i].Init(DataManager.instance.gameData.myItems[i]);
        }
    }

    void Start()
    {
        ShowMainScreen();     
    }

    public void ShowPlayerScreen()
    {
        playerScreen.SetActive(true);
    }
  
    public void ShowStatusScreen()
    {
        mainScreen.SetActive(false);
        playerScreen.SetActive(true);
        statusScreen.SetActive(true);
        inventoryScreen.SetActive(false);
       
      
    }

   
    public void ShowInventoryScreen()
    {
        mainScreen.SetActive(false);
        playerScreen.SetActive(true);
        statusScreen.SetActive(false);
        inventoryScreen.SetActive(true);
        
    }

   
    public void ShowMainScreen()
    {
        mainScreen.SetActive(true);
        playerScreen.SetActive(true);
        statusScreen.SetActive(false);
        inventoryScreen.SetActive(false);
    }
}
