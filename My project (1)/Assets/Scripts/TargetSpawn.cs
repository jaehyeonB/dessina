using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public GameObject targetPrefabs;        //���� ������Ʈ(������)

    public float generateTime = 3.0f;       //����� �ð�

    private float timer = 0;        //����� �ð� �����
    void Start()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime;         //timer �������� deltaTime�� ���� ���� �ð� ����

        if(timer < 0)       //timer�� 0���� �۰ų� ���� ��
        {
            timer = generateTime;       //timer�� ����� �ð��� �Է���

            float xPosition = Random.Range(-10f, 10f);      //-10 ~ 10 ������ ������ �Ǽ����� xPosition�� ����
            Vector3 newPosition = new Vector3(xPosition, 0, 0);     //������ ���Ӱ� ���� Position ��
            Instantiate(targetPrefabs, newPosition, Quaternion.identity);       //���� �������� newPosition ��ġ�� ������
        }
    }
}
