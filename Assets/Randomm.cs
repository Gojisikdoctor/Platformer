using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Randomm : MonoBehaviour
{
    Transform transform;
    [SerializeField] GameObject Ground;

    private void Start()
    {
        StartCoroutine(a());
    }
    IEnumerator a()
    {
        for (int i = 0; i < 10; i++)
        {
            // x,y 좌표값을 각각 다른 범위에서 랜덤하게 정해지도록 만들었다.
            float newX = Random.Range(-32, 23f), newY = Random.Range(-15f, 10f);

            // 생성할 오브젝트를 불러온다.
            GameObject ground = Instantiate(Ground);

            // 불러온 오브젝트를 랜덤하게 생성한 좌표값으로 위치를 옮긴다.
            ground.transform.position = new Vector2(newX, newY);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
