using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Rakan
{
    public int hp;
    public int mp;
    public string name;
    public Sprite image;



    public void ult()
    {
        if (mp < 100)
        {
            Debug.Log("������ �����մϴ�.");
            return;
        }
            mp -= 100;
        Debug.Log($"{name}�� ��Ȥ�� ���ָ� ����ߴ�.");

    }
}
