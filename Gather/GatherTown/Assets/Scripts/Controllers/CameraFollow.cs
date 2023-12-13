using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform 컴포넌트를 연결할 변수
    public Vector3 offset = new Vector3(0f, 0f, -5f); 

    void Update()
    {
        if (player != null)
        {
            // 플레이어의 현재 위치에 오프셋 값을 더하여 카메라 위치를 설정
            transform.position = player.position + offset;
        }
    }
}
