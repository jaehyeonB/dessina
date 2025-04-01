using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public GameObject targetPrefabs;        //과녁 오브젝트(프리팹)

    public float generateTime = 3.0f;       //재생성 시간

    private float timer = 0;        //재생성 시간 저장용
    void Start()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime;         //timer 변수에서 deltaTime을 빼서 지난 시간 측정

        if(timer < 0)       //timer가 0보다 작거나 같을 때
        {
            timer = generateTime;       //timer에 재생성 시간을 입력함

            float xPosition = Random.Range(-10f, 10f);      //-10 ~ 10 사이의 랜덤한 실수값을 xPosition에 대입
            Vector3 newPosition = new Vector3(xPosition, 0, 0);     //과녁이 새롭게 생길 Position 값
            Instantiate(targetPrefabs, newPosition, Quaternion.identity);       //과녁 프리팹을 newPosition 위치에 생성함
        }
    }
}
