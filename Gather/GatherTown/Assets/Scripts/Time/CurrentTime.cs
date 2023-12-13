using UnityEngine;
using UnityEngine.UI;
using System;
public class CurrentTime : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        // 현재 시간을 얻어옴
        DateTime currentTime = DateTime.Now;

        // 시, 분, 초를 추출
        int hours = currentTime.Hour;
        int minutes = currentTime.Minute;
        int seconds = currentTime.Second;

        // 텍스트 업데이트
        timeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }
}

