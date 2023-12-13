using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform ������Ʈ�� ������ ����
    public Vector3 offset = new Vector3(0f, 0f, -5f); 

    void Update()
    {
        if (player != null)
        {
            // �÷��̾��� ���� ��ġ�� ������ ���� ���Ͽ� ī�޶� ��ġ�� ����
            transform.position = player.position + offset;
        }
    }
}
