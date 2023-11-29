using UnityEngine;
using UnityEngine.UI;

public class JoinGame : MonoBehaviour
{
    public InputField nameInputField;
    public Button joinButton;

    void Start()
    {
        // Join 버튼 클릭 이벤트에 함수 연결
        joinButton.onClick.AddListener(OnJoinButtonClick);
    }

    void OnJoinButtonClick()
    {
        string playerName = nameInputField.text;

        // 이름이 조건에 맞는지 확인
        if (IsValidName(playerName))
        {
            // 이름을 저장하거나 다른 처리를 수행
            PlayerPrefs.SetString("PlayerName", playerName);

            // 맵으로 이동하는 로직 (SceneManager.LoadScene 등)
        }
        else
        {
            Debug.Log("이름은 2~10 글자여야 합니다.");
        }
    }

    bool IsValidName(string name)
    {
        return name.Length >= 2 && name.Length <= 10;
    }
}
