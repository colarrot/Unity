using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text HpText;
    public Text AtkText;
    public Text DefText;
    public Text CritText;
    public Text GoldText;
    public Text LevelText;
    public Text NameText;

    public PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        

        UpdateUI();
    }

    // Update is called once per frame
    void UpdateUI()
    {
        HpText.text = "체력 : " + playerStats.Hp.ToString();
        AtkText.text = "공격력 : " + playerStats.Atk.ToString();
        DefText.text = " 방어력 : " + playerStats.Def.ToString();  
        CritText.text = " 크리티컬 확률 : " + playerStats.Crit.ToString();
        GoldText.text = " 보유 골드 : " + playerStats.Gold.ToString();
        LevelText.text = " 레벨: " + playerStats.Level.ToString();
        NameText.text = " 닉네임 : " + playerStats.Name.ToString();
    }

    public void Update()
    {        
        UpdateUI();     
    }
}
