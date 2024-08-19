using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RakanUI : MonoBehaviour
{
    public Rakan rakan;
    public Image Rakan_image;
    public Slider Rakan_hp;
    public Text Rakan_name;
    public Slider Rakan_mp;
    public GameObject Rakan_UI;


    private void Start()
    {
        Rakan_image.sprite = rakan.image; //�̹����� .sprite�� �Է��� �ҷ����� ���� ���¸� ����������Ѵ�.
        Rakan_name.text = rakan.name;
        Rakan_hp.value = rakan.hp; //�����̴��� ���簪
        Rakan_mp.value = rakan.mp;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) // iŰ�� ������
        {
            if (Rakan_UI.activeSelf) //�÷��̾� ui�� �����ִٸ�
                Rakan_UI.SetActive(false); //���ּ���
            else
                Rakan_UI.SetActive(true); //���ּ���
        }
    }
    public void Ult()
    {
        rakan.ult();
        setValue(); //�ֽ�ȭ
    }
    public void setValue()
    {
        Rakan_mp.value = rakan.mp;
    }
}