using UnityEngine;
using UnityEngine.UI;

public class JoinGame : MonoBehaviour
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

            // ������ �̵��ϴ� ���� (SceneManager.LoadScene ��)
        }
        else
        {
            Debug.Log("�̸��� 2~10 ���ڿ��� �մϴ�.");
        }
    }

    bool IsValidName(string name)
    {
        return name.Length >= 2 && name.Length <= 10;
    }
}
