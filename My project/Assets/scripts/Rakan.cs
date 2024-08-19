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
            Debug.Log("마나가 부족합니다.");
            return;
        }
            mp -= 100;
        Debug.Log($"{name}이 매혹의 질주를 사용했다.");

    }
}
