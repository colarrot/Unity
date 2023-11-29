using UnityEngine;

public class NameTag : MonoBehaviour
{
    public Transform target; // 캐릭터의 Transform을 연결할 변수

    void Update()
    {
        if (target != null)
        {
            // 캐릭터의 위치에 이름표를 따라다니도록 설정
            transform.position = target.position + new Vector3(0f, 2f, 0f);
        }
    }
}
