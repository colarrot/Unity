using UnityEngine;
using UnityEngine.UI;
using System;
public class CurrentTime : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        // ���� �ð��� ����
        DateTime currentTime = DateTime.Now;

        // ��, ��, �ʸ� ����
        int hours = currentTime.Hour;
        int minutes = currentTime.Minute;
        int seconds = currentTime.Second;

        // �ؽ�Ʈ ������Ʈ
        timeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }
}

