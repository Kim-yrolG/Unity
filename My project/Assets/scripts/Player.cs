using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*

클래스 class
개체에 대한 설계를 위해 만드는 설계 틀
    class 클래스명
     {
        필드(field) : 클래스 내부에서 만들어진 변수 개체의 속성을 표현하는 용도
        - 구조체와 비슷함

        메소드(method) : 클래스 내부에서 만들어진 함수, 개체의 동작, 기능을 표현하는 용도로 사용합니다.
     }
*/
[Serializable]  //유니티에서 클래스에 대한 정보를 인스펙터로부터 확인할 수 있게 하는 기능
public class Player
//monobehavier가 없기때문에 순수 class는 월드에 배치한 오브젝트에 직접 연결 할 수 없다.
{
    public int hp;
    public int max_hp;
    public string name;
    public Sprite image; //UI에서 이미지를 보여줄때 (2d이미지 파일)

    public void Dance()
    {
        Debug.Log($"{name}이 춤을 추고 있습니다.");
    }
    public void Heal()
    {
        if (hp >= max_hp)
        {
            Debug.Log("체력이 이미 가득차있습니다.");
            return; //void 함수에서 return 만 사용하면 함수의 종료를 의미합니다.
        }
        hp += 10;
        Debug.Log($"체력을 10 회복합니다. 현재 체력 {hp} / {max_hp}");
    }
}