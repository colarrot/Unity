using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemData_", menuName = "Data/ItemData", order = 1)]

public class ItemData : ScriptableObject
{
    public string itemName;
    public int price;
    public bool isEquiped;
    public Sprite image;
    /*
    public bool Equip { get; set; }     
    public string Name { get; }   
    public int Atk { get; }
    public int Def { get; }
    public int Hp { get; }

    public int Crit { get; }

    

    public Item(string name, int atk, int def, int hp, int crit, bool equip = false)
    {       
        Name = name;
        Atk = atk;
        Def = def;
        Hp = hp;
        Crit = crit;
        Equip = equip;
    }

    List<Item> items = new List<Item>(); 
  
    public void Start()
    {
        items = new List<Item>();

        items.Add(new Item("목검", 5, 0, 0, 5, false));
        items.Add(new Item("나무 방패", 0, 10, 0, 0, false));
    }

    public void OnButtonClick()
    {
        
    }

    public void EquipItem(Item items)
    {
        if (items.Equip == true)
        {
            PlayerStats.GetInst.Atk += items.Atk;
            PlayerStats.GetInst.Def += items.Def;
            PlayerStats.GetInst.Hp += items.Hp;
            PlayerStats.GetInst.Crit += items.Crit;
        }
        else
        {
            PlayerStats.GetInst.Atk -= items.Atk;
            PlayerStats.GetInst.Def -= items.Def;
            PlayerStats.GetInst.Hp -= items.Hp;
            PlayerStats.GetInst.Crit -= items.Crit;
        }
    }*/
    

}
