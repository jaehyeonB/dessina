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
        if(Input.GetMouseButtonDown(0))     //마우스 좌클릭(0번 버튼)이 눌릴 때
        {
            Shootray();     //레이 발사 함수 호출
        }
    }
    //레이가 발사되는 함수
    void Shootray()
    {
        Ray ray = new Ray(transform.position, transform.forward);        //발사할 Ray의 시작점, 방향 지정 (메인 카메라에서 마우스 커서 방향으로 발사)
        RaycastHit hit;     //Ray를 맞은 대상의 정보를 저장할 저장소

        if(Physics.Raycast(ray, out hit))       //Raycast의 변환형은 Bool로, Ray를 맞았다면 true 로 변환
        {
            Destroy(hit.collider.gameObject);       //맞은 오브젝트를 제거
        }
    }
}
