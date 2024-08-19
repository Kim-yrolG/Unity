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
        player_Image.sprite = player.image; //�̹����� .sprite�� �Է��� �ҷ����� ���� ���¸� ����������Ѵ�.
        player_name.text = player.name;
        player_hp.maxValue = player.max_hp; //�����̴� �ִ������ �÷��̾� �ִ�ü��
        player_hp.value = player.hp; //�����̴��� ���簪
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) // iŰ�� ������
        {
            if (player_UI.activeSelf) //�÷��̾� ui�� �����ִٸ�
            player_UI.SetActive(false); //���ּ���
            else
            player_UI.SetActive(true); //���ּ���
        }
    }

    //����Ƽ c#�� �ż��� �����
    //1. Ű���� �Է°��� ���� �Լ��� ����Ѵ�.
    //2. ����Ƽ�� ��ư���� Ȱ���� ��ư�������� �޼ҵ带 ȣ��
    public void Action()
    {
        player.Dance();
    }
    public void Action2()
    {
        player.Heal();//�÷��̾� ȸ����� ���

        setValue(); //�ֽ�ȭ
    }
    public void setValue()
    {
        player_hp.value = player.hp;
    }
}
