using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VassicVariables : MonoBehaviour
{
    public int gold = 0;       //������
    public float Hp = 100.0f; //�Ǽ��� (�Ҽ����� �ִ� ����, ���� "f" �ʼ�)
    public string playerName = "ȫ�浿"; //���ڿ� (������ ����)
    private bool isAlive = true; //���� (��/������ ��Ÿ��) true/false

    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log("���ӽ���");       //����Ƽ ����׿� �޼����� ���
        if (gold > 50) //���� gold�� 50���� ũ�ٸ�
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�");    //�޽��� ���

        }
        else if (gold > 25)
        {
            Debug.Log("�Ϻ� �������� �����Ҽ� �ֽ��ϴ�"); //�޽��� ���
        }

        else
        {
            Debug.Log("���� �����մϴ�"); //�޽��� ���

        }
    
    
    
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Debug.Log("���� ������"); //����Ƽ ����׿� �޼����� ���
            gold = gold + 10;
        Debug.Log("���� ��� : " + gold);
    }
}
