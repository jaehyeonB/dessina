using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaycastShooter : MonoBehaviour
{
    public ParticleSystem flashEffect;       //�߻� ����Ʈ ���� ����

    public int maganizeCapacity = 30;       //źâ�� ũ��
    private int currentAmmo;                //���� �Ѿ� ����

    public TextMeshProUGUI ammoUI;

    public Image reloadingUI;               //������UI
    public float reloadTime = 2f;           //������ 
    private float timer = 0;                //�ð� Ȯ�ο� Ÿ�̸�
    private bool isReloading = false;       //������ Ȯ�ο� bool ���� 

    public AudioSource audioSource;         //����� �ҽ�
    public AudioClip audioClip;             //����� Ŭ��
    void Start()
    {
        currentAmmo = maganizeCapacity;
        //ammoUI.text = currentAmmo + "/" + maganizeCapacity;
        ammoUI.text = $"{currentAmmo}/{maganizeCapacity}";

        reloadingUI.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && currentAmmo > 0 && isReloading == false)     //���콺 ��Ŭ��(0�� ��ư)�� ���� �� && ���� �Ѿ��� 0�� �ʰ��� ��
        {
            audioSource.PlayOneShot(audioClip);
            currentAmmo--;              //�Ѿ��� �Ѱ� �ʱ�ȭ �Ѵ�.
            flashEffect.Play();         //����Ʈ ���
            ammoUI.text = $"{currentAmmo}/{maganizeCapacity}";  //���� �Ѿ� ������ UI�� ǥ�� ( �Ѿ� �Һ� �� ǥ�� [�߿�] )
            Shootray();     //���� �߻� �Լ� ȣ��

        }

        if(Input.GetKeyDown(KeyCode.R))                     //RŰ�� ������
        {
            isReloading = true;                             //������ ������ ����
            reloadingUI.gameObject.SetActive(true);         //������ UI Ȱ��ȭ
        }

        if(currentAmmo == 0)
        {
            isReloading = true;
            reloadingUI.gameObject.SetActive(true);
        }

        if(isReloading == true)
        {
            Reloading();
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
    void Reloading()
    {
        timer += Time.deltaTime;

        reloadingUI.fillAmount = timer / reloadTime;            //������ UI�� fill ���� ���� ������� ������Ʈ

        if(timer >= reloadTime)                                 //������ �ð��� ������ ���
        {
            timer = 0;  
            isReloading = false;                                //�������� �Ϸ� ������ ǥ��
            currentAmmo = maganizeCapacity;                     //�Ѿ��� ä���ش�
            ammoUI.text = $"{currentAmmo}/{maganizeCapacity}";  //���� �Ѿ� ������ ǥ��
            reloadingUI.gameObject.SetActive(false);            //������ UI ������Ʈ�� ��Ȱ��ȭ
        }
    }
}
