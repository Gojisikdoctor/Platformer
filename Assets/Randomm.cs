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
            // x,y ��ǥ���� ���� �ٸ� �������� �����ϰ� ���������� �������.
            float newX = Random.Range(-32, 23f), newY = Random.Range(-15f, 10f);

            // ������ ������Ʈ�� �ҷ��´�.
            GameObject ground = Instantiate(Ground);

            // �ҷ��� ������Ʈ�� �����ϰ� ������ ��ǥ������ ��ġ�� �ű��.
            ground.transform.position = new Vector2(newX, newY);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
