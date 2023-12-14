using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupEquip : MonoBehaviour
{
    public TMP_Text infoText;
    public Button YesBtn;

    public void PopupSetting(ItemSlot slot)
    {
        if(slot.inputData.isEquiped)
        {
            infoText.text = "������ �����Ͻðڽ��ϱ�?";
            YesBtn.onClick.RemoveAllListeners();
            YesBtn.onClick.AddListener(() => 
            { 
                slot.inputData.isEquiped = false;
                slot.ChangeEquip();
            });
            
        }
        else 
        {
            infoText.text = "���� �Ͻðڽ��ϱ�?";
            YesBtn.onClick.RemoveAllListeners();
            YesBtn.onClick.AddListener(() => 
            { 
                slot.inputData.isEquiped = true; 
                slot.ChangeEquip();
            });
        }
    }
  
}
