using NUnit.Framework.Internal.Commands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public Image player_Image;
    public Slider player_hp;
    public Text player_name;

    public GameObject player_UI;


    private void Start()
    {
        player_Image.sprite = player.image; //이미지의 .sprite를 입력해 불러오는 파일 형태를 지정해줘야한다.
        player_name.text = player.name;
        player_hp.maxValue = player.max_hp; //슬라이더 최대범위를 플레이어 최대체력
        player_hp.value = player.hp; //슬라이더의 현재값
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) // i키를 누르면
        {
            if (player_UI.activeSelf) //플레이어 ui가 켜져있다면
            player_UI.SetActive(false); //꺼주세요
            else
            player_UI.SetActive(true); //켜주세요
        }
    }

    //유니티 c#의 매서드 사용방법
    //1. 키보드 입력값에 따라 함수를 출력한다.
    //2. 유니티에 버튼등을 활용해 버튼누렀을때 메소드를 호출
    public void Action()
    {
        player.Dance();
    }
    public void Action2()
    {
        player.Heal();//플레이어 회복기능 사용

        setValue(); //최신화
    }
    public void setValue()
    {
        player_hp.value = player.hp;
    }
}
