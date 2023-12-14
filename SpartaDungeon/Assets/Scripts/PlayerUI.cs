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
        HpText.text = "ü�� : " + playerStats.Hp.ToString();
        AtkText.text = "���ݷ� : " + playerStats.Atk.ToString();
        DefText.text = " ���� : " + playerStats.Def.ToString();  
        CritText.text = " ũ��Ƽ�� Ȯ�� : " + playerStats.Crit.ToString();
        GoldText.text = " ���� ��� : " + playerStats.Gold.ToString();
        LevelText.text = " ����: " + playerStats.Level.ToString();
        NameText.text = " �г��� : " + playerStats.Name.ToString();
    }

    public void Update()
    {        
        UpdateUI();     
    }
}
