using UnityEngine;

public class NameTag : MonoBehaviour
{
    public Transform target; // ĳ������ Transform�� ������ ����

    void Update()
    {
        if (target != null)
        {
            // ĳ������ ��ġ�� �̸�ǥ�� ����ٴϵ��� ����
            transform.position = target.position + new Vector3(0f, 2f, 0f);
        }
    }
}
