using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinGather : MonoBehaviour
{
    public InputField nameInputField;
    public Button joinButton;

    void Start()
    {
        // Join ��ư Ŭ�� �̺�Ʈ�� �Լ� ����
        joinButton.onClick.AddListener(OnJoinButtonClick);
    }

    void OnJoinButtonClick()
    {
        string playerName = nameInputField.text;

        // �̸��� ���ǿ� �´��� Ȯ��
        if (IsValidName(playerName))
        {
            // �̸��� �����ϰų� �ٸ� ó���� ����
            PlayerPrefs.SetString("PlayerName", playerName);
          
        }
        else
        {
            Debug.Log("�̸��� 2~10 ���ڷ� �����ּ���.");
        }
    }

    bool IsValidName(string name) //�̸� ���� ����
    {
        return name.Length >= 2 && name.Length <= 10;
    }
}
