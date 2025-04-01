using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))     //���콺 ��Ŭ��(0�� ��ư)�� ���� ��
        {
            Shootray();     //���� �߻� �Լ� ȣ��
        }
    }
    //���̰� �߻�Ǵ� �Լ�
    void Shootray()
    {
        Ray ray = new Ray(transform.position, transform.forward);        //�߻��� Ray�� ������, ���� ���� (���� ī�޶󿡼� ���콺 Ŀ�� �������� �߻�)
        RaycastHit hit;     //Ray�� ���� ����� ������ ������ �����

        if(Physics.Raycast(ray, out hit))       //Raycast�� ��ȯ���� Bool��, Ray�� �¾Ҵٸ� true �� ��ȯ
        {
            Destroy(hit.collider.gameObject);       //���� ������Ʈ�� ����
        }
    }
}
