using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "UserData_", menuName = "Data/UserData", order = 0)]

public class PlayerStats : ScriptableObject
{

    public PlayerStats playerStats;

    public Text HpText;
    public Text AtkText;
    public Text DefText;
    public Text CritText;
    public Text GoldText;
    public Text LevelText;
    public Text NameText;

    public int BaseHp = 50;
    public int BaseAtk = 20;
    public int BaseDef = 10;
    public int BaseCrit = 15;
    public int BaseGold = 10000;
    public int BaseLevel = 10;
    public string BaseName = "�亥�Ӹ����";
    
    public string Name { get; set; }
    public int Hp { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }

    public int Crit { get; set; }
    public int Gold { get; set; }

    public int Level { get; set; }

    public void PlayerData(string name, int hp, int atk, int def, int crit, int gold, int level)
    {
        Name = name;
        Hp = hp;
        Atk = atk;
        Def = def;
        Crit = crit;
        Gold = gold;
        Level = level;
    }
    private static PlayerStats instance;
    public static PlayerStats GetInst
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerStats();
            }
            return instance;
        }
    }

    public void Start()
    {
        StartStats();
    }
  

    public void StartStats()
    {
        HpText.text = ($"ü�� :  {BaseHp} + {PlayerStats.GetInst.Hp}");
        AtkText.text = ($"���ݷ� :  {BaseAtk} + {PlayerStats.GetInst.Atk}");
        DefText.text = ($" ���� :  {BaseDef} + {PlayerStats.GetInst.Def}");
        CritText.text = ($" ũ��Ƽ�� Ȯ�� :  {BaseCrit} + {PlayerStats.GetInst.Crit}");
        GoldText.text = ($" ���� ��� :  {BaseGold}");
        LevelText.text = ($" ����:  {BaseLevel} ");
        NameText.text = ($" �г��� :  {BaseName} ");
    }
}
