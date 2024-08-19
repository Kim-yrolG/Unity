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
        Rakan_image.sprite = rakan.image; //이미지의 .sprite를 입력해 불러오는 파일 형태를 지정해줘야한다.
        Rakan_name.text = rakan.name;
        Rakan_hp.value = rakan.hp; //슬라이더의 현재값
        Rakan_mp.value = rakan.mp;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) // i키를 누르면
        {
            if (Rakan_UI.activeSelf) //플레이어 ui가 켜져있다면
                Rakan_UI.SetActive(false); //꺼주세요
            else
                Rakan_UI.SetActive(true); //켜주세요
        }
    }
    public void Ult()
    {
        rakan.ult();
        setValue(); //최신화
    }
    public void setValue()
    {
        Rakan_mp.value = rakan.mp;
    }
}